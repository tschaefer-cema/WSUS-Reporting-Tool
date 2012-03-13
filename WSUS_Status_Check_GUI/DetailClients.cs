using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WSUS_Status_Check_GUI
{
    public partial class DetailClients : Form
    {
        public DetailClients()
        {
            InitializeComponent();
        }

        public DetailClients(string title, DataTable clientData)
        {
            InitializeComponent();
            results.AutoGenerateColumns = false;
            this.Text = title;

            foreach (DataRow row in clientData.Rows)
            {
                int currentRow = results.Rows.Add(row["Computername"], row["OS"], row["lastReport"], row["UpdateStatus"]);

                if (row["UpdateStatus"].ToString() == "Unknown")
                {
                    results.Rows[currentRow].DefaultCellStyle.BackColor = Color.Yellow;
                }

                if (row["UpdateStatus"].ToString() == "Installed")
                {
                    results.Rows[currentRow].DefaultCellStyle.BackColor = Color.YellowGreen;
                }

                if (row["UpdateStatus"].ToString() == "NotInstalled")
                {
                    results.Rows[currentRow].DefaultCellStyle.BackColor = Color.Red;
                }

                if (row["UpdateStatus"].ToString() == "Failed")
                {
                    results.Rows[currentRow].DefaultCellStyle.BackColor = Color.Red;
                }

                if (row["UpdateStatus"].ToString() == "NotApplicable")
                {
                    results.Rows[currentRow].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }
    }
}
