namespace SangamithraClinic.PL.Reports
{
    partial class DiseasesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiseasesReport));
            this.gbDiseasesPatients = new System.Windows.Forms.GroupBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbDiseasesPatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDiseasesPatients
            // 
            this.gbDiseasesPatients.Controls.Add(this.cbYear);
            this.gbDiseasesPatients.Controls.Add(this.lblYear);
            this.gbDiseasesPatients.Controls.Add(this.reportViewer1);
            this.gbDiseasesPatients.Controls.Add(this.btnBack);
            this.gbDiseasesPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDiseasesPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiseasesPatients.Location = new System.Drawing.Point(0, 0);
            this.gbDiseasesPatients.Name = "gbDiseasesPatients";
            this.gbDiseasesPatients.Size = new System.Drawing.Size(1241, 500);
            this.gbDiseasesPatients.TabIndex = 1;
            this.gbDiseasesPatients.TabStop = false;
            this.gbDiseasesPatients.Text = "Disease Patients Count";
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(86, 19);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(212, 24);
            this.cbYear.TabIndex = 166;
            this.cbYear.SelectionChangeCommitted += new System.EventHandler(this.cbYear_SelectionChangeCommitted);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(20, 22);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(49, 16);
            this.lblYear.TabIndex = 165;
            this.lblYear.Text = "Year :";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SangamithraClinic.PL.Rdlc.DiseasePatients.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1195, 424);
            this.reportViewer1.TabIndex = 164;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(1135, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 163;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DiseasesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1241, 500);
            this.Controls.Add(this.gbDiseasesPatients);
            this.Name = "DiseasesReport";
            this.Text = "Patient Diseases";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DiseasesReport_Load);
            this.gbDiseasesPatients.ResumeLayout(false);
            this.gbDiseasesPatients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDiseasesPatients;
        private System.Windows.Forms.Button btnBack;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblYear;

    }
}