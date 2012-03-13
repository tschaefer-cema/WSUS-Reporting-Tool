namespace WSUS_Status_Check_GUI
{
    partial class DetailUpdates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailUpdates));
            this.results = new System.Windows.Forms.DataGridView();
            this.Updatename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SB = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Erscheinungsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produktfamilie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Updatename,
            this.SB,
            this.Erscheinungsdatum,
            this.Status,
            this.Produktfamilie,
            this.Kategorie});
            this.results.Location = new System.Drawing.Point(0, 0);
            this.results.Margin = new System.Windows.Forms.Padding(0);
            this.results.MultiSelect = false;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.RowHeadersVisible = false;
            this.results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.results.Size = new System.Drawing.Size(958, 487);
            this.results.TabIndex = 12;
            this.results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.results_CellContentClick);
            // 
            // Updatename
            // 
            this.Updatename.HeaderText = "Updatename";
            this.Updatename.Name = "Updatename";
            this.Updatename.ReadOnly = true;
            // 
            // SB
            // 
            this.SB.HeaderText = "Security Bulletin";
            this.SB.Name = "SB";
            this.SB.ReadOnly = true;
            this.SB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Erscheinungsdatum
            // 
            this.Erscheinungsdatum.HeaderText = "Erscheinungsdatum";
            this.Erscheinungsdatum.Name = "Erscheinungsdatum";
            this.Erscheinungsdatum.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Produktfamilie
            // 
            this.Produktfamilie.HeaderText = "Produktfamilie";
            this.Produktfamilie.Name = "Produktfamilie";
            this.Produktfamilie.ReadOnly = true;
            // 
            // Kategorie
            // 
            this.Kategorie.HeaderText = "Kategorie";
            this.Kategorie.Name = "Kategorie";
            this.Kategorie.ReadOnly = true;
            // 
            // DetailUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 487);
            this.Controls.Add(this.results);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailUpdates";
            this.Text = "Details zu";
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Updatename;
        private System.Windows.Forms.DataGridViewLinkColumn SB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Erscheinungsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produktfamilie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorie;
    }
}