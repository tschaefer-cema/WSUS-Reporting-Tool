using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections;

namespace WSUS_Status_Check_GUI
{
    public partial class DetailUpdates : Form
    {             
        public DetailUpdates()
        {
            InitializeComponent();
            results.AutoGenerateColumns = false;
        }

        public DetailUpdates(string title, DataTable updtData)
        {
            InitializeComponent();
            results.AutoGenerateColumns = false;
            this.Text = title;

            foreach (DataRow row in updtData.Rows)
            {
                int currentRow = results.Rows.Add(row["Updatename"], row["SB"], row["Erscheinungsdatum"], row["Status"], row["Produktfamilie"], row["Kategorie"]);
                                
                if (row["Status"].ToString() == "Unknown")
                {
                    results.Rows[currentRow].DefaultCellStyle.BackColor = Color.Yellow;
                }

                if (row["Status"].ToString() == "Installed")
                {
                    results.Rows[currentRow].DefaultCellStyle.BackColor = Color.YellowGreen;
                }

                if (row["Status"].ToString() == "NotInstalled")
                {
                    results.Rows[currentRow].DefaultCellStyle.BackColor = Color.Red;
                }

                if (row["Status"].ToString() == "Failed")
                {
                    results.Rows[currentRow].DefaultCellStyle.BackColor = Color.Red;
                }               
            }
        }


        private void results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsANonHeaderLinkCell(e))
            {
                if (e.RowIndex >= 0)
                {                    
                        System.Diagnostics.Process.Start("http://technet.microsoft.com/en-us/security/bulletin/" + results.Rows[e.RowIndex].Cells[1].Value.ToString());
                 }
            }
        }


        private bool IsANonHeaderLinkCell(DataGridViewCellEventArgs cellEvent)
        {
            if (results.Columns[cellEvent.ColumnIndex] is
                DataGridViewLinkColumn &&
                cellEvent.RowIndex != -1)
            { return true; }
            else { return (false); }
        }


    }
}
