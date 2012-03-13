using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.UpdateServices.Administration;
using System.IO;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Xml;

namespace WSUS_Status_Check_GUI
{
    

    public partial class Main : Form
    {
        enum View {Client, Update};

        View currentView = View.Client;
        int updateDays = 31;
        ComputerTargetGroupCollection wsusGroups;
        string mainWSUS = "";

        public Main()
        {
            InitializeComponent();

            readConfig();

            init();

            hideUpdates();
            showClients();
            pnlClients.Left = 0;
            pnlClients.Top = 109;
            pnlUpdates.Left = 0;
            pnlUpdates.Top = 109; 
            
        }

        private void readConfig()
        {
            string strFilename = Application.StartupPath + "\\config.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(strFilename);

            XmlNode wsusmaster = doc.SelectSingleNode("/WSUS/Master");
            if (wsusmaster != null)
            {
                mainWSUS = wsusmaster.Attributes["Computername"].InnerText;
            }
        }

        private void disableGUI()
        {
            this.Enabled = false;
            dateFrom.Enabled = false;
            dateTo.Enabled = false;
            groups.Enabled = false;
            cbxWsusServer.Enabled = false;
            resultsClients.Enabled = false;
        }

        private void enableGUI()
        {
            this.Enabled = true;
            dateFrom.Enabled = true;
            dateTo.Enabled = true;
            groups.Enabled = true;
            cbxWsusServer.Enabled = true;
            resultsClients.Enabled = true;
        }

        private void init()
        {
            resultsUpdates.Columns["SB"].DefaultCellStyle.Format = "-";
            resultsUpdates.Columns["Fortschritt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            resultsUpdates.Columns["SB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;


            //resultsClients.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

            resultsClients.Columns["UpdateProgress"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter; 

            disableGUI();

            dateFrom.Value = DateTime.Now.Date.Subtract(new TimeSpan(updateDays, 0, 0, 0));
            dateTo.Value = DateTime.Now;
            getGroups();
            getDownstreamServers();

            enableGUI();
        }

    
        private IUpdateServer getUpdateServer(string servername)
        {
            //Verbindung mit dem lokalen Server aufbauen
            IUpdateServer UpdateServer = null;
            
            try
            {
                UpdateServer = AdminProxy.GetUpdateServer(servername, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Environment.Exit(0);
                //statuslbl.Text = "Verbindungsfehler:" + ex.Message;
            }

            return UpdateServer;
        }

        private void getGroups()
        {
            IUpdateServer UpdateServer = getUpdateServer(mainWSUS);
                        
            wsusGroups = UpdateServer.GetComputerTargetGroups();

            foreach (IComputerTargetGroup wsusgroup in wsusGroups)
            {
                groups.Items.Add(new WSUSGroup(wsusgroup));
            }          
        }



        private void getDownstreamServers()
        {
            IUpdateServer UpdateServer = getUpdateServer(mainWSUS);
                        
            DownstreamServerCollection servers = new DownstreamServerCollection();
            servers = UpdateServer.GetChildServers();

            foreach (IDownstreamServer server in servers)
            {
                cbxWsusServer.Items.Add(server.FullDomainName);
            }

            cbxWsusServer.Items.Add(mainWSUS);            
        }

        private void getClientStatus()
        {
            if (cbxWsusServer.Text == "")
            {
                MessageBox.Show("Bitte wählen Sie einen WSUS Server aus.", "Kein WSUS Server ausgewählt.");
            }
            else
            {
                if (groups.Text == "")
                {
                    MessageBox.Show("Bitte wählen Sie eine WSUS Gruppe aus.", "Keine WSUS Gruppe ausgewählt.");
                }
                else
                {
                    disableGUI();
                    
                    IUpdateServer UpdateServer = getUpdateServer(cbxWsusServer.SelectedItem.ToString());

                    //Zu suchende Updates definieren
                    UpdateScope updtScope = new UpdateScope();
                    updtScope.FromCreationDate = dateFrom.Value;
                    updtScope.ToCreationDate = dateTo.Value.Date;
                    //updtScope.ExcludedInstallationStates = UpdateInstallationStates.NotApplicable;
                    //updtScope.IncludedInstallationStates = UpdateInstallationStates.Installed | UpdateInstallationStates.InstalledPendingReboot | UpdateInstallationStates.Failed | UpdateInstallationStates.NotInstalled | UpdateInstallationStates.Unknown | UpdateInstallationStates.Downloaded;
                    updtScope.ApprovedStates = ApprovedStates.HasStaleUpdateApprovals | ApprovedStates.LatestRevisionApproved | ApprovedStates.NotApproved;
                    

                    ComputerTargetScope searchRange = new ComputerTargetScope();
                    searchRange.ComputerTargetGroups.Add(((WSUSGroup)groups.SelectedItem).getWSUSGroup());
                    searchRange.IncludeDownstreamComputerTargets = true;
                    searchRange.NameIncludes = txtClientFilter.Text;
                                                  
                    ComputerTargetCollection myClients = UpdateServer.GetComputerTargets(searchRange);
                   
                    foreach (IComputerTarget client in myClients)
                    {   
                        int countInstalledUpdates = 0;
                        int countAllUpdates = 0;

                        IUpdateSummary updtsum = client.GetUpdateInstallationSummary(updtScope);
                        countInstalledUpdates = updtsum.InstalledCount;
                        countAllUpdates = updtsum.InstalledCount + updtsum.UnknownCount + updtsum.NotInstalledCount + updtsum.FailedCount;
                                                                      

                        //ermittle zugewiesene wsus gruppe des clients
                        string clientWsusGroup = "";

                        foreach (IComputerTargetGroup gp in client.GetComputerTargetGroups())
                        {
                            clientWsusGroup += gp.Name + " / ";
                        }
                        clientWsusGroup = clientWsusGroup.Remove((clientWsusGroup.Length - 3));

                        double state = 0.0;

                        if (countAllUpdates > 0 | countInstalledUpdates > 0)
                        {
                            state = ((100.0 / (double)countAllUpdates) * (double)countInstalledUpdates);
                        }

                        resultsClients.Rows.Add(client.FullDomainName.ToString(), Math.Round(state, 2), client.ComputerRole, client.LastReportedStatusTime.ToString("yyy/MM/dd - HH:mm"), clientWsusGroup, client.OSDescription + ", " + client.OSArchitecture, "Updatedetails", "Detailansicht");
                    }
                                        
                    enableGUI();
                }
            }

            resultsClients.Visible = true;
        }

        private void results_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //wechsle in Detailansicht
            if (e.RowIndex >= 0)
            {
                MessageBox.Show(resultsClients.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }


        private bool IsANonHeaderButtonCell(DataGridViewCellEventArgs cellEvent)
        {
            if (resultsClients.Columns[cellEvent.ColumnIndex] is
                DataGridViewButtonColumn &&
                cellEvent.RowIndex != -1)
            { return true; }
            else { return (false); }
        }



        private void resultsClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsANonHeaderButtonCell(e))
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == resultsClients.ColumnCount - 1)
                    {
                        if (cbxWsusServer.Text != "")
                        {
                            disableGUI();

                            //hole alle Updateinformationen für den Client und zeige das Fenster an.
                            string client = resultsClients.Rows[e.RowIndex].Cells[0].Value.ToString();
                            string title = "Details zu " + client;
                            DataTable data = getUpdatesPerClient(cbxWsusServer.SelectedItem.ToString(), client);

                            if (data.Rows.Count >= 1)
                            {
                                DetailUpdates FrmDetailView = new DetailUpdates(title, data);
                                FrmDetailView.Show();
                            }
                            else
                            {
                                MessageBox.Show("Es konnten keine Updateinformationen mit den angegebenen Kriterien ermittelt werden.","Keine Einträge vorhanden");
                            }

                            enableGUI();
                        }
                        else
                        {
                            MessageBox.Show("Bitte wählen Sie einen WSUS Server aus.", "Kein WSUS Server ausgewählt.");
                        }
                    }
                }
            }
        }


        private DataTable getUpdatesPerClient(string wsusServer, string client)
        {
            DataTable data = new DataTable();
            data = new DataTable();

            data.Columns.Add("Updatename");
            data.Columns.Add("Erscheinungsdatum");
            data.Columns.Add("Status");
            data.Columns.Add("Produktfamilie");
            data.Columns.Add("Kategorie");
            data.Columns.Add("id");
            data.Columns.Add("SB");
            
            IUpdateServer UpdateServer = getUpdateServer(wsusServer);
            
            //get ComputerTarget
            IComputerTarget computer = UpdateServer.GetComputerTargetByName(client);
            
            //define Updatescope
            UpdateScope updtScopeClientUpdates = new UpdateScope();
            updtScopeClientUpdates.FromCreationDate = dateFrom.Value;
            updtScopeClientUpdates.ToCreationDate = dateTo.Value.Date;
            updtScopeClientUpdates.ExcludedInstallationStates = UpdateInstallationStates.NotApplicable;
            updtScopeClientUpdates.IncludedInstallationStates = UpdateInstallationStates.Installed | UpdateInstallationStates.InstalledPendingReboot | UpdateInstallationStates.Failed | UpdateInstallationStates.NotInstalled | UpdateInstallationStates.Unknown | UpdateInstallationStates.Downloaded;
         
            if (cbxInstalled.Checked)
            {
                if (cbxFailed.Checked)
                {
                    updtScopeClientUpdates.IncludedInstallationStates = UpdateInstallationStates.Installed | UpdateInstallationStates.InstalledPendingReboot | UpdateInstallationStates.Failed | UpdateInstallationStates.NotInstalled | UpdateInstallationStates.Unknown | UpdateInstallationStates.Downloaded;
                } else {
                    updtScopeClientUpdates.IncludedInstallationStates = UpdateInstallationStates.Installed | UpdateInstallationStates.InstalledPendingReboot;
                }
            } else {
                if (cbxFailed.Checked)
                {
                    updtScopeClientUpdates.IncludedInstallationStates = UpdateInstallationStates.Failed | UpdateInstallationStates.NotInstalled | UpdateInstallationStates.Unknown | UpdateInstallationStates.Downloaded;
                }
            }

           
            
            //get all updates
            UpdateInstallationInfoCollection installStatus = computer.GetUpdateInstallationInfoPerUpdate(updtScopeClientUpdates);

            // loop through the updates in the install info collection and output the 
            // name of the update and it's install state on this computer
            
            foreach (IUpdateInstallationInfo updateStatus in installStatus)
            {
                Boolean addRow = false;
                IUpdate update = updateStatus.GetUpdate();

                //if (update.Approve(UpdateApprovalAction.Install))
                string prodTitle = "";
                string famTitle = "";
                
                foreach (string title in update.ProductTitles)
                {
                    prodTitle += title + ", ";
                }
                prodTitle = prodTitle.Remove((prodTitle.Length - 2));

                foreach (string title in update.ProductFamilyTitles)
                {
                    famTitle += title + ", ";
                }
                famTitle = famTitle.Remove((famTitle.Length - 2));


                //if (cbxInstallPending.Checked)
                //{
                //    if (updateStatus.UpdateInstallationState == UpdateInstallationState.InstalledPendingReboot)
                //    {
                //        addRow = true;
                //    }
                //}

                if (cbxInstalled.Checked)
                {
                    if (updateStatus.UpdateInstallationState == UpdateInstallationState.Installed ||
                        updateStatus.UpdateInstallationState == UpdateInstallationState.InstalledPendingReboot)
                    {
                        addRow = true;
                    }
                }

                //if (cbxNotInstalled.Checked)
                //{
                //    if (updateStatus.UpdateInstallationState == UpdateInstallationState.NotInstalled || 
                //        updateStatus.UpdateInstallationState == UpdateInstallationState.Downloaded ||
                //        updateStatus.UpdateInstallationState == UpdateInstallationState.Unknown)
                //    {
                //        addRow = true;
                //    }
                //}

                if (cbxFailed.Checked)
                {
                    if (updateStatus.UpdateInstallationState == UpdateInstallationState.Failed ||
                        updateStatus.UpdateInstallationState == UpdateInstallationState.NotInstalled ||
                        updateStatus.UpdateInstallationState == UpdateInstallationState.Downloaded ||
                        updateStatus.UpdateInstallationState == UpdateInstallationState.Unknown)
                    {
                        addRow = true;
                    }
                }
                
                if (addRow)
                {


                    string secbul = String.Empty;

                    if (update.SecurityBulletins.Count > 0)
                    {
                        foreach (string str in update.SecurityBulletins)
                        {
                            secbul += str + ";";
                        }

                        secbul = secbul.Remove(secbul.Length - 1);
                    }

                    data.Rows.Add(update.Title, update.CreationDate.ToString("yyy/MM/dd - HH:mm"), updateStatus.UpdateInstallationState.ToString(),
                        //prodTitle, 
                    famTitle,
                    update.UpdateClassificationTitle, update.Id.UpdateId.ToString(), secbul);

                }
            }
            return data;
        }




        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }


        private void exportToExcel(string path, View view)
        {
            if (view == View.Client)
            {
                Excel.Application excelApp = new Excel.ApplicationClass();
                Excel.Workbook newWorkbook = excelApp.Workbooks.Open(Application.StartupPath + "\\wsus_vorlage_client.xlsx");
                Excel.Worksheet excelSheet = (Excel.Worksheet)newWorkbook.Worksheets[1];

                excelSheet.Cells[5, 4] = "Zeitraum: " + dateFrom.Value.ToShortDateString() + " bis " + dateTo.Value.ToShortDateString();

                int i = 10;
                int j = 1;

                foreach (DataGridViewRow row in resultsClients.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex <= 5)
                        {
                            excelSheet.Cells[i, j++] = cell.Value.ToString();
                        }
                    }
                    i++;
                    j = 1;
                }

                excelSheet.Columns.AutoFit();

                newWorkbook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault);
                newWorkbook.Close();
                excelApp.Quit();
            }
            else if (view == View.Update)
            {
                Excel.Application excelApp = new Excel.ApplicationClass();
                Excel.Workbook newWorkbook = excelApp.Workbooks.Open(Application.StartupPath + "\\wsus_vorlage_update.xlsx");
                Excel.Worksheet excelSheet = (Excel.Worksheet)newWorkbook.Worksheets[1];

                excelSheet.Cells[5, 1] = "Zeitraum: " + dateFrom.Value.ToShortDateString() + " bis " + dateTo.Value.ToShortDateString();
                excelSheet.Cells[7, 1] = "WSUS Client Gruppe: " + groups.Text;

                int i = 10;
                int j = 1;

                foreach (DataGridViewRow row in resultsUpdates.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex <= 2)
                        {
                            excelSheet.Cells[i, j++] = cell.Value.ToString();
                        }
                    }
                    i++;
                    j = 1;
                }

                excelSheet.Columns.AutoFit();

                newWorkbook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault);
                newWorkbook.Close();
                excelApp.Quit();
            }
        }

        private void excelExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = string.Empty;

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel-Arbeitsmappe (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFile.AddExtension = true;
            saveFile.DefaultExt = ".xlsx";
            saveFile.FileName = "WSUS " + currentView.ToString() + " Status Report " + DateTime.Now.ToString("yyyy-MM-dd");
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                path = saveFile.FileName;
                exportToExcel(path, currentView);
            }
        }
                
        private void statusErmittelnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultsClients.Rows.Clear();
            getClientStatus();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.ShowDialog();
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideClients();
            showUpdates();
        }     
      
        private void hideClients()
        {
            pnlClients.Hide();
        }

        private void hideUpdates()
        {
            pnlUpdates.Hide();
        }

        private void showClients()
        {
            lblView.Text = "Clients";
            gbxClientFilter.Visible = true;
            gbxUpdateFilter.Visible = false;
            pnlClients.Show();
            currentView = View.Client;
        }

        private void showUpdates()
        {
            lblView.Text = "Updates";
            gbxClientFilter.Visible = false;
            gbxUpdateFilter.Visible = true;
            pnlUpdates.Show();
            currentView = View.Update;
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideUpdates();
            showClients();
        }

        private void GetClients_Click_1(object sender, EventArgs e)
        {
            if (currentView == View.Client)
            {
                resultsClients.Rows.Clear();
                getClientStatus();
            }
            else if (currentView == View.Update)
            {                
                resultsUpdates.Rows.Clear();
                getUpdateStatus();
            }
            
        }


        private void getUpdateStatus()
        {
            if (cbxWsusServer.Text == "")
            {
                MessageBox.Show("Bitte wählen Sie einen WSUS Server aus.", "Kein WSUS Server ausgewählt.");
            }
            else
            {
                if (groups.Text == "")
                {
                    MessageBox.Show("Bitte wählen Sie eine WSUS Gruppe aus.", "Keine WSUS Gruppe ausgewählt.");
                }
                else
                {
                    disableGUI();
                    
                    IUpdateServer UpdateServer = getUpdateServer(cbxWsusServer.SelectedItem.ToString());

                    //Zu suchende Updates definieren
                    UpdateScope updtScope = new UpdateScope();
                    updtScope.FromCreationDate = dateFrom.Value.Date;
                    updtScope.ToCreationDate = dateTo.Value.Date;
                    //updtScope.UpdateSources = UpdateSources.All;
                    //updtScope.UpdateApprovalActions = UpdateApprovalActions.All;
                    updtScope.ApprovedStates = ApprovedStates.HasStaleUpdateApprovals | ApprovedStates.LatestRevisionApproved | ApprovedStates.NotApproved;
                    updtScope.TextIncludes = txtUpdateFilter.Text;
                    //updtScope.ApprovedComputerTargetGroups.Add(((WSUSGroup)groups.SelectedItem).getWSUSGroup());

                    UpdateCollection UpdatesCol = new UpdateCollection();
                    UpdateSummaryCollection SumCol = new UpdateSummaryCollection();
                                       
                    
                    try
                    {
                        UpdatesCol = UpdateServer.GetUpdates(updtScope);

                        foreach (IUpdate updt in UpdatesCol)
                        {
                            IUpdateSummary updtsum = updt.GetSummaryForComputerTargetGroup(((WSUSGroup)groups.SelectedItem).getWSUSGroup());

                            double countUpdates = 0.0;
                            countUpdates = (100.0 / (updtsum.InstalledCount + updtsum.FailedCount + updtsum.NotInstalledCount + updtsum.UnknownCount + updtsum.NotApplicableCount)) * (updtsum.InstalledCount + updtsum.NotApplicableCount);


                            string secbul = String.Empty;

                            if (updt.SecurityBulletins.Count > 0)
                            {
                                foreach (string str in updt.SecurityBulletins)
                                {
                                    secbul += str + ";";
                                }

                                secbul = secbul.Remove(secbul.Length - 1);
                            }

                            resultsUpdates.Rows.Add(updt.Title, Math.Round(countUpdates, 2), secbul, "Details", updt.Id.UpdateId.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Es trat folgender Fehler auf: " + ex);
                    }

                    
                    enableGUI();
                    resultsUpdates.Visible = true;
                    pnlUpdates.Visible = true;

                }
            }            
        }

        private void dateiToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            //if (resultsClients.RowCount > 0)
            //{
            //    excelExportToolStripMenuItem.Enabled = true;
            //}
            //else
            //{
            //    excelExportToolStripMenuItem.Enabled = false;
            //}
        }

        private void resultsUpdates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsANonHeaderLinkCell(e))
            {
                if (e.RowIndex >= 0)
                {
                    System.Diagnostics.Process.Start("http://technet.microsoft.com/en-us/security/bulletin/" + resultsUpdates.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
            }
                         
            if (IsANonHeaderButtonCellUpdates(e))
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == resultsUpdates.ColumnCount - 2)
                    {
                        if (cbxWsusServer.Text != "")
                        {
                            disableGUI();

                            //hole alle Updateinformationen für den Client und zeige das Fenster an.
                            string update = resultsUpdates.Rows[e.RowIndex].Cells[0].Value.ToString();
                            string title = "Details zu " + update;

                            UpdateRevisionId updateID = new UpdateRevisionId(new Guid(resultsUpdates.Rows[e.RowIndex].Cells[resultsUpdates.ColumnCount - 1].Value.ToString()));
                            DataTable data = getClientsPerUpdate(cbxWsusServer.SelectedItem.ToString(), updateID);

                            if (data.Rows.Count >= 1)
                            {
                                DetailClients FrmDetailViewClient = new DetailClients(title, data);
                                FrmDetailViewClient.Show();
                            }
                            else
                            {
                                MessageBox.Show("Es konnten keine Clientinformationen mit den angegebenen Kriterien ermittelt werden.","Keine Einträge vorhanden");
                            }

                            enableGUI();
                        }
                        else
                        {
                            MessageBox.Show("Bitte wählen Sie einen WSUS Server aus.", "Kein WSUS Server ausgewählt.");
                        }
                    }
                }
            }
        
        }
        
        private bool IsANonHeaderLinkCell(DataGridViewCellEventArgs cellEvent)
        {
            if (resultsUpdates.Columns[cellEvent.ColumnIndex] is
                DataGridViewLinkColumn &&
                cellEvent.RowIndex != -1)
            { return true; }
            else { return (false); }
        }

        private bool IsANonHeaderButtonCellUpdates(DataGridViewCellEventArgs cellEvent)
        {
            if (resultsUpdates.Columns[cellEvent.ColumnIndex] is
                DataGridViewButtonColumn &&
                cellEvent.RowIndex != -1)
            { return true; }
            else { return (false); }
        }

        private DataTable getClientsPerUpdate(string wsusServer, UpdateRevisionId updateID)
        {
            DataTable data = new DataTable();
            data = new DataTable();

            data.Columns.Add("Computername");
            data.Columns.Add("OS");
            data.Columns.Add("lastReport");
            data.Columns.Add("UpdateStatus");

            IUpdateServer UpdateServer = getUpdateServer(wsusServer);

            ComputerTargetScope compTargetScope = new ComputerTargetScope();
            compTargetScope.ComputerTargetGroups.Add(((WSUSGroup)groups.SelectedItem).getWSUSGroup());
            compTargetScope.IncludeDownstreamComputerTargets = true;
            compTargetScope.IncludeSubgroups = true;
            
            //get Update
            IUpdate update = UpdateServer.GetUpdate(updateID);
            UpdateInstallationInfoCollection updtCol = update.GetUpdateInstallationInfoPerComputerTarget(compTargetScope);

            foreach (IUpdateInstallationInfo clientStatus in updtCol)
            {
                Boolean addRow = true;

                IComputerTarget compTarget = UpdateServer.GetComputerTarget(clientStatus.ComputerTargetId);

                if (addRow)
                {
                    data.Rows.Add(compTarget.FullDomainName, compTarget.OSDescription + ", " + compTarget.OSArchitecture, compTarget.LastReportedStatusTime.ToString("yyy/MM/dd - HH:mm"), clientStatus.UpdateInstallationState.ToString());
                }
            }

            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = string.Empty;

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel-Arbeitsmappe (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFile.AddExtension = true;
            saveFile.DefaultExt = ".xlsx";
            saveFile.FileName = "WSUS " + currentView.ToString() + " Status Report " + DateTime.Now.ToString("yyyy-MM-dd");
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                path = saveFile.FileName;
                exportToExcel(path, currentView);
            }
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help inf = new Help();
            inf.ShowDialog();
        }

        private void lblView_Click(object sender, EventArgs e)
        {
            if (currentView == View.Client)
            {
                hideClients();
                showUpdates();
            }
            else
            {
                hideUpdates();
                showClients();
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUpdateFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                resultsUpdates.Rows.Clear();
                getUpdateStatus();
            }
        }

        private void txtClientFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                resultsClients.Rows.Clear();
                getClientStatus();
            }
        } 
    }
}