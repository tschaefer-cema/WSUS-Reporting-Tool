namespace WSUS_Status_Check_GUI
{
    partial class DetailClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailClients));
            this.results = new System.Windows.Forms.DataGridView();
            this.Computername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastreport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.AllowUserToAddRows = false;
            this.results.AllowUserToDeleteRows = false;
            this.results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.results.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.results.BackgroundColor = System.Drawing.SystemColors.Control;
            this.results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.results.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.results.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.results.ColumnHeadersHeight = 20;
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Computername,
            this.OS,
            this.lastreport,
            this.UpdateStatus});
            this.results.Location = new System.Drawing.Point(0, 0);
            this.results.Margin = new System.Windows.Forms.Padding(0);
            this.results.MultiSelect = false;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.RowHeadersVisible = false;
            this.results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.results.Size = new System.Drawing.Size(829, 376);
            this.results.TabIndex = 13;
            // 
            // Computername
            // 
            this.Computername.HeaderText = "Computername";
            this.Computername.Name = "Computername";
            this.Computername.ReadOnly = true;
            // 
            // OS
            // 
            this.OS.HeaderText = "OS";
            this.OS.Name = "OS";
            this.OS.ReadOnly = true;
            // 
            // lastreport
            // 
            this.lastreport.HeaderText = "letzter Statusbericht";
            this.lastreport.Name = "lastreport";
            this.lastreport.ReadOnly = true;
            // 
            // UpdateStatus
            // 
            this.UpdateStatus.HeaderText = "Updatestatus";
            this.UpdateStatus.Name = "UpdateStatus";
            this.UpdateStatus.ReadOnly = true;
            // 
            // DetailClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 378);
            this.Controls.Add(this.results);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailClients";
            this.Text = "DetailClients";
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Computername;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastreport;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateStatus;
    }
}