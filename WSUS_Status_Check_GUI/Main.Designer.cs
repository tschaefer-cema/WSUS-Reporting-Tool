namespace WSUS_Status_Check_GUI
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusErmittelnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.cbxWsusServer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groups = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxFailed = new System.Windows.Forms.CheckBox();
            this.cbxInstalled = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.resultsClients = new System.Windows.Forms.DataGridView();
            this.FullDomainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastReportStatusTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WSUSGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OSDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.resultsUpdates = new System.Windows.Forms.DataGridView();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fortschritt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SB = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.updateguid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlClients = new System.Windows.Forms.Panel();
            this.pnlUpdates = new System.Windows.Forms.Panel();
            this.lblView = new System.Windows.Forms.Label();
            this.gbxClientFilter = new System.Windows.Forms.GroupBox();
            this.lblClientFilter = new System.Windows.Forms.Label();
            this.txtClientFilter = new System.Windows.Forms.TextBox();
            this.gbxUpdateFilter = new System.Windows.Forms.GroupBox();
            this.lblUpdateFilter = new System.Windows.Forms.Label();
            this.txtUpdateFilter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GetClients = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsUpdates)).BeginInit();
            this.pnlClients.SuspendLayout();
            this.pnlUpdates.SuspendLayout();
            this.gbxClientFilter.SuspendLayout();
            this.gbxUpdateFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.ansichtToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusErmittelnToolStripMenuItem,
            this.excelExportToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            this.dateiToolStripMenuItem.DropDownOpening += new System.EventHandler(this.dateiToolStripMenuItem_DropDownOpening);
            // 
            // statusErmittelnToolStripMenuItem
            // 
            this.statusErmittelnToolStripMenuItem.Name = "statusErmittelnToolStripMenuItem";
            this.statusErmittelnToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.statusErmittelnToolStripMenuItem.Text = "Status ermitteln";
            this.statusErmittelnToolStripMenuItem.Click += new System.EventHandler(this.statusErmittelnToolStripMenuItem_Click);
            // 
            // excelExportToolStripMenuItem
            // 
            this.excelExportToolStripMenuItem.Name = "excelExportToolStripMenuItem";
            this.excelExportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.excelExportToolStripMenuItem.Text = "Excel Export...";
            this.excelExportToolStripMenuItem.Click += new System.EventHandler(this.excelExportToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.updatesToolStripMenuItem});
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.updatesToolStripMenuItem.Text = "Updates";
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeToolStripMenuItem,
            this.überToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.cbxWsusServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groups);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 76);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allgemein";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Updatestatus bis";
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(101, 45);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(98, 20);
            this.dateTo.TabIndex = 15;
            this.dateTo.Value = new System.DateTime(2012, 2, 2, 16, 58, 18, 0);
            // 
            // cbxWsusServer
            // 
            this.cbxWsusServer.FormattingEnabled = true;
            this.cbxWsusServer.Location = new System.Drawing.Point(307, 45);
            this.cbxWsusServer.Name = "cbxWsusServer";
            this.cbxWsusServer.Size = new System.Drawing.Size(200, 21);
            this.cbxWsusServer.Sorted = true;
            this.cbxWsusServer.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "WSUS Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "WSUS Gruppe";
            // 
            // groups
            // 
            this.groups.FormattingEnabled = true;
            this.groups.Location = new System.Drawing.Point(307, 18);
            this.groups.Name = "groups";
            this.groups.Size = new System.Drawing.Size(200, 21);
            this.groups.Sorted = true;
            this.groups.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxFailed);
            this.groupBox2.Controls.Add(this.cbxInstalled);
            this.groupBox2.Location = new System.Drawing.Point(412, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 76);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Updatedetails für";
            this.groupBox2.Visible = false;
            // 
            // cbxFailed
            // 
            this.cbxFailed.AutoSize = true;
            this.cbxFailed.Checked = true;
            this.cbxFailed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFailed.Location = new System.Drawing.Point(10, 48);
            this.cbxFailed.Name = "cbxFailed";
            this.cbxFailed.Size = new System.Drawing.Size(70, 17);
            this.cbxFailed.TabIndex = 21;
            this.cbxFailed.Text = "fehlerhaft";
            this.cbxFailed.UseVisualStyleBackColor = true;
            // 
            // cbxInstalled
            // 
            this.cbxInstalled.AutoSize = true;
            this.cbxInstalled.Checked = true;
            this.cbxInstalled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxInstalled.Location = new System.Drawing.Point(10, 21);
            this.cbxInstalled.Name = "cbxInstalled";
            this.cbxInstalled.Size = new System.Drawing.Size(66, 17);
            this.cbxInstalled.TabIndex = 18;
            this.cbxInstalled.Text = "installiert";
            this.cbxInstalled.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Updatestatus von";
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(101, 19);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(98, 20);
            this.dateFrom.TabIndex = 3;
            // 
            // resultsClients
            // 
            this.resultsClients.AllowUserToAddRows = false;
            this.resultsClients.AllowUserToDeleteRows = false;
            this.resultsClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.resultsClients.BackgroundColor = System.Drawing.SystemColors.Control;
            this.resultsClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resultsClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resultsClients.ColumnHeadersHeight = 20;
            this.resultsClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.resultsClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullDomainName,
            this.UpdateProgress,
            this.ComputerRole,
            this.LastReportStatusTime,
            this.WSUSGroup,
            this.OSDescription,
            this.detailView});
            this.resultsClients.Location = new System.Drawing.Point(0, 0);
            this.resultsClients.Margin = new System.Windows.Forms.Padding(0);
            this.resultsClients.MultiSelect = false;
            this.resultsClients.Name = "resultsClients";
            this.resultsClients.ReadOnly = true;
            this.resultsClients.RowHeadersVisible = false;
            this.resultsClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsClients.Size = new System.Drawing.Size(866, 332);
            this.resultsClients.TabIndex = 23;
            this.resultsClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsClients_CellContentClick);
            // 
            // FullDomainName
            // 
            this.FullDomainName.HeaderText = "Computername";
            this.FullDomainName.Name = "FullDomainName";
            this.FullDomainName.ReadOnly = true;
            // 
            // UpdateProgress
            // 
            this.UpdateProgress.HeaderText = "Fortschritt (%)";
            this.UpdateProgress.Name = "UpdateProgress";
            this.UpdateProgress.ReadOnly = true;
            // 
            // ComputerRole
            // 
            this.ComputerRole.HeaderText = "Typ";
            this.ComputerRole.Name = "ComputerRole";
            this.ComputerRole.ReadOnly = true;
            // 
            // LastReportStatusTime
            // 
            this.LastReportStatusTime.HeaderText = "letzter Bericht";
            this.LastReportStatusTime.Name = "LastReportStatusTime";
            this.LastReportStatusTime.ReadOnly = true;
            // 
            // WSUSGroup
            // 
            this.WSUSGroup.HeaderText = "WSUS Gruppe";
            this.WSUSGroup.Name = "WSUSGroup";
            this.WSUSGroup.ReadOnly = true;
            // 
            // OSDescription
            // 
            this.OSDescription.HeaderText = "OS";
            this.OSDescription.Name = "OSDescription";
            this.OSDescription.ReadOnly = true;
            // 
            // detailView
            // 
            this.detailView.HeaderText = "Details";
            this.detailView.Name = "detailView";
            this.detailView.ReadOnly = true;
            // 
            // resultsUpdates
            // 
            this.resultsUpdates.AllowUserToAddRows = false;
            this.resultsUpdates.AllowUserToDeleteRows = false;
            this.resultsUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsUpdates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsUpdates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.resultsUpdates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.resultsUpdates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsUpdates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resultsUpdates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resultsUpdates.ColumnHeadersHeight = 20;
            this.resultsUpdates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.resultsUpdates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bezeichnung,
            this.Fortschritt,
            this.SB,
            this.Details,
            this.updateguid});
            this.resultsUpdates.Location = new System.Drawing.Point(0, 0);
            this.resultsUpdates.Margin = new System.Windows.Forms.Padding(0);
            this.resultsUpdates.MultiSelect = false;
            this.resultsUpdates.Name = "resultsUpdates";
            this.resultsUpdates.ReadOnly = true;
            this.resultsUpdates.RowHeadersVisible = false;
            this.resultsUpdates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsUpdates.Size = new System.Drawing.Size(866, 332);
            this.resultsUpdates.TabIndex = 24;
            this.resultsUpdates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsUpdates_CellContentClick);
            // 
            // Bezeichnung
            // 
            this.Bezeichnung.FillWeight = 500F;
            this.Bezeichnung.HeaderText = "Update";
            this.Bezeichnung.Name = "Bezeichnung";
            this.Bezeichnung.ReadOnly = true;
            // 
            // Fortschritt
            // 
            this.Fortschritt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fortschritt.FillWeight = 65F;
            this.Fortschritt.HeaderText = "Fortschritt (%)";
            this.Fortschritt.Name = "Fortschritt";
            this.Fortschritt.ReadOnly = true;
            // 
            // SB
            // 
            this.SB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SB.FillWeight = 65F;
            this.SB.HeaderText = "Security Bulletin";
            this.SB.Name = "SB";
            this.SB.ReadOnly = true;
            this.SB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Details.FillWeight = 65F;
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // updateguid
            // 
            this.updateguid.HeaderText = "UpdateGuid";
            this.updateguid.MinimumWidth = 2;
            this.updateguid.Name = "updateguid";
            this.updateguid.ReadOnly = true;
            this.updateguid.Visible = false;
            // 
            // pnlClients
            // 
            this.pnlClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClients.Controls.Add(this.resultsClients);
            this.pnlClients.Location = new System.Drawing.Point(0, 109);
            this.pnlClients.Margin = new System.Windows.Forms.Padding(0);
            this.pnlClients.Name = "pnlClients";
            this.pnlClients.Size = new System.Drawing.Size(869, 334);
            this.pnlClients.TabIndex = 25;
            // 
            // pnlUpdates
            // 
            this.pnlUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpdates.Controls.Add(this.resultsUpdates);
            this.pnlUpdates.Location = new System.Drawing.Point(0, 109);
            this.pnlUpdates.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUpdates.Name = "pnlUpdates";
            this.pnlUpdates.Size = new System.Drawing.Size(869, 334);
            this.pnlUpdates.TabIndex = 26;
            // 
            // lblView
            // 
            this.lblView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblView.BackColor = System.Drawing.Color.Transparent;
            this.lblView.Location = new System.Drawing.Point(804, 0);
            this.lblView.Name = "lblView";
            this.lblView.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.lblView.Size = new System.Drawing.Size(65, 24);
            this.lblView.TabIndex = 28;
            this.lblView.Text = "label3";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblView.Click += new System.EventHandler(this.lblView_Click);
            // 
            // gbxClientFilter
            // 
            this.gbxClientFilter.Controls.Add(this.lblClientFilter);
            this.gbxClientFilter.Controls.Add(this.txtClientFilter);
            this.gbxClientFilter.Location = new System.Drawing.Point(534, 27);
            this.gbxClientFilter.Name = "gbxClientFilter";
            this.gbxClientFilter.Size = new System.Drawing.Size(173, 76);
            this.gbxClientFilter.TabIndex = 29;
            this.gbxClientFilter.TabStop = false;
            this.gbxClientFilter.Text = "Filter";
            // 
            // lblClientFilter
            // 
            this.lblClientFilter.AutoSize = true;
            this.lblClientFilter.Location = new System.Drawing.Point(7, 21);
            this.lblClientFilter.Name = "lblClientFilter";
            this.lblClientFilter.Size = new System.Drawing.Size(126, 13);
            this.lblClientFilter.TabIndex = 1;
            this.lblClientFilter.Text = "Rechnername beinhaltet:";
            // 
            // txtClientFilter
            // 
            this.txtClientFilter.Location = new System.Drawing.Point(7, 45);
            this.txtClientFilter.Name = "txtClientFilter";
            this.txtClientFilter.Size = new System.Drawing.Size(160, 20);
            this.txtClientFilter.TabIndex = 0;
            this.txtClientFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClientFilter_KeyDown);
            // 
            // gbxUpdateFilter
            // 
            this.gbxUpdateFilter.Controls.Add(this.lblUpdateFilter);
            this.gbxUpdateFilter.Controls.Add(this.txtUpdateFilter);
            this.gbxUpdateFilter.Location = new System.Drawing.Point(534, 27);
            this.gbxUpdateFilter.Name = "gbxUpdateFilter";
            this.gbxUpdateFilter.Size = new System.Drawing.Size(173, 76);
            this.gbxUpdateFilter.TabIndex = 30;
            this.gbxUpdateFilter.TabStop = false;
            this.gbxUpdateFilter.Text = "Filter";
            // 
            // lblUpdateFilter
            // 
            this.lblUpdateFilter.AutoSize = true;
            this.lblUpdateFilter.Location = new System.Drawing.Point(7, 21);
            this.lblUpdateFilter.Name = "lblUpdateFilter";
            this.lblUpdateFilter.Size = new System.Drawing.Size(120, 13);
            this.lblUpdateFilter.TabIndex = 1;
            this.lblUpdateFilter.Text = "Updatename beinhaltet:";
            // 
            // txtUpdateFilter
            // 
            this.txtUpdateFilter.Location = new System.Drawing.Point(7, 45);
            this.txtUpdateFilter.Name = "txtUpdateFilter";
            this.txtUpdateFilter.Size = new System.Drawing.Size(160, 20);
            this.txtUpdateFilter.TabIndex = 0;
            this.txtUpdateFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUpdateFilter_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::WSUS_Status_Check_GUI.Properties.Resources.excel32x32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(795, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 70);
            this.button1.TabIndex = 27;
            this.button1.Text = "Excel Export";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetClients
            // 
            this.GetClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetClients.Image = global::WSUS_Status_Check_GUI.Properties.Resources.chart_search1;
            this.GetClients.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GetClients.Location = new System.Drawing.Point(721, 33);
            this.GetClients.Name = "GetClients";
            this.GetClients.Size = new System.Drawing.Size(62, 70);
            this.GetClients.TabIndex = 20;
            this.GetClients.Text = "Status ermitteln\r\n";
            this.GetClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GetClients.UseVisualStyleBackColor = true;
            this.GetClients.Click += new System.EventHandler(this.GetClients_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(704, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Aktuelle Ansicht:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.lblView_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbxUpdateFilter);
            this.Controls.Add(this.gbxClientFilter);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlUpdates);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GetClients);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(885, 480);
            this.Name = "Main";
            this.Text = "WSUS Client Update Status";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsUpdates)).EndInit();
            this.pnlClients.ResumeLayout(false);
            this.pnlUpdates.ResumeLayout(false);
            this.gbxClientFilter.ResumeLayout(false);
            this.gbxClientFilter.PerformLayout();
            this.gbxUpdateFilter.ResumeLayout(false);
            this.gbxUpdateFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusErmittelnToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.ComboBox cbxWsusServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox groups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxFailed;
        private System.Windows.Forms.CheckBox cbxInstalled;
        private System.Windows.Forms.Button GetClients;
        private System.Windows.Forms.DataGridView resultsClients;
        private System.Windows.Forms.DataGridView resultsUpdates;
        private System.Windows.Forms.Panel pnlClients;
        private System.Windows.Forms.Panel pnlUpdates;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullDomainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastReportStatusTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WSUSGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn OSDescription;
        private System.Windows.Forms.DataGridViewButtonColumn detailView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.GroupBox gbxClientFilter;
        private System.Windows.Forms.GroupBox gbxUpdateFilter;
        private System.Windows.Forms.Label lblUpdateFilter;
        private System.Windows.Forms.TextBox txtUpdateFilter;
        private System.Windows.Forms.Label lblClientFilter;
        private System.Windows.Forms.TextBox txtClientFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fortschritt;
        private System.Windows.Forms.DataGridViewLinkColumn SB;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateguid;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

