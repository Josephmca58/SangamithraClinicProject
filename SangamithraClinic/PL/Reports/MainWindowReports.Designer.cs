namespace SangamithraClinic.PL
{
    partial class MainWindowReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowReports));
            this.gbTotalEmployees = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRDShow = new System.Windows.Forms.Label();
            this.lblRD = new System.Windows.Forms.Label();
            this.gbRepeatedPatientsMonthWise = new System.Windows.Forms.GroupBox();
            this.lblRPShow = new System.Windows.Forms.Label();
            this.lblRP = new System.Windows.Forms.Label();
            this.gbTotalPatientsMonthWise = new System.Windows.Forms.GroupBox();
            this.lblTpShow = new System.Windows.Forms.Label();
            this.lblShortDescriptionTP = new System.Windows.Forms.Label();
            this.lblReportName = new System.Windows.Forms.Label();
            this.gbTotalEmployees.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbRepeatedPatientsMonthWise.SuspendLayout();
            this.gbTotalPatientsMonthWise.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTotalEmployees
            // 
            this.gbTotalEmployees.Controls.Add(this.btnBack);
            this.gbTotalEmployees.Controls.Add(this.groupBox3);
            this.gbTotalEmployees.Controls.Add(this.gbRepeatedPatientsMonthWise);
            this.gbTotalEmployees.Controls.Add(this.gbTotalPatientsMonthWise);
            this.gbTotalEmployees.Controls.Add(this.lblReportName);
            this.gbTotalEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTotalEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotalEmployees.Location = new System.Drawing.Point(0, 0);
            this.gbTotalEmployees.Name = "gbTotalEmployees";
            this.gbTotalEmployees.Size = new System.Drawing.Size(1257, 538);
            this.gbTotalEmployees.TabIndex = 0;
            this.gbTotalEmployees.TabStop = false;
            this.gbTotalEmployees.Text = "Reports";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(1151, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 164;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRDShow);
            this.groupBox3.Controls.Add(this.lblRD);
            this.groupBox3.Location = new System.Drawing.Point(12, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1154, 148);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repeated Disease Month Wise";
            // 
            // lblRDShow
            // 
            this.lblRDShow.AutoSize = true;
            this.lblRDShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRDShow.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDShow.Location = new System.Drawing.Point(1092, 116);
            this.lblRDShow.Name = "lblRDShow";
            this.lblRDShow.Size = new System.Drawing.Size(50, 18);
            this.lblRDShow.TabIndex = 3;
            this.lblRDShow.Text = "Show";
            this.lblRDShow.Click += new System.EventHandler(this.lblRDShow_Click);
            // 
            // lblRD
            // 
            this.lblRD.AutoSize = true;
            this.lblRD.Location = new System.Drawing.Point(16, 44);
            this.lblRD.Name = "lblRD";
            this.lblRD.Size = new System.Drawing.Size(508, 16);
            this.lblRD.TabIndex = 2;
            this.lblRD.Text = "This report depicts the number of patients visited in a year disease-wise.";
            // 
            // gbRepeatedPatientsMonthWise
            // 
            this.gbRepeatedPatientsMonthWise.Controls.Add(this.lblRPShow);
            this.gbRepeatedPatientsMonthWise.Controls.Add(this.lblRP);
            this.gbRepeatedPatientsMonthWise.Location = new System.Drawing.Point(12, 217);
            this.gbRepeatedPatientsMonthWise.Name = "gbRepeatedPatientsMonthWise";
            this.gbRepeatedPatientsMonthWise.Size = new System.Drawing.Size(1154, 131);
            this.gbRepeatedPatientsMonthWise.TabIndex = 3;
            this.gbRepeatedPatientsMonthWise.TabStop = false;
            this.gbRepeatedPatientsMonthWise.Text = "Repeated Patients Month Wise";
            // 
            // lblRPShow
            // 
            this.lblRPShow.AutoSize = true;
            this.lblRPShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRPShow.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPShow.Location = new System.Drawing.Point(1092, 101);
            this.lblRPShow.Name = "lblRPShow";
            this.lblRPShow.Size = new System.Drawing.Size(50, 18);
            this.lblRPShow.TabIndex = 2;
            this.lblRPShow.Text = "Show";
            this.lblRPShow.Click += new System.EventHandler(this.lblRPShow_Click);
            // 
            // lblRP
            // 
            this.lblRP.AutoSize = true;
            this.lblRP.Location = new System.Drawing.Point(16, 39);
            this.lblRP.Name = "lblRP";
            this.lblRP.Size = new System.Drawing.Size(503, 16);
            this.lblRP.TabIndex = 1;
            this.lblRP.Text = "This report depicts the number patients those who visited multiple times.";
            // 
            // gbTotalPatientsMonthWise
            // 
            this.gbTotalPatientsMonthWise.Controls.Add(this.lblTpShow);
            this.gbTotalPatientsMonthWise.Controls.Add(this.lblShortDescriptionTP);
            this.gbTotalPatientsMonthWise.Location = new System.Drawing.Point(12, 77);
            this.gbTotalPatientsMonthWise.Name = "gbTotalPatientsMonthWise";
            this.gbTotalPatientsMonthWise.Size = new System.Drawing.Size(1158, 117);
            this.gbTotalPatientsMonthWise.TabIndex = 2;
            this.gbTotalPatientsMonthWise.TabStop = false;
            this.gbTotalPatientsMonthWise.Text = "Total Patients Month Wise";
            // 
            // lblTpShow
            // 
            this.lblTpShow.AutoSize = true;
            this.lblTpShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTpShow.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpShow.Location = new System.Drawing.Point(1092, 83);
            this.lblTpShow.Name = "lblTpShow";
            this.lblTpShow.Size = new System.Drawing.Size(50, 18);
            this.lblTpShow.TabIndex = 1;
            this.lblTpShow.Text = "Show";
            this.lblTpShow.Click += new System.EventHandler(this.lblTpShow_Click);
            // 
            // lblShortDescriptionTP
            // 
            this.lblShortDescriptionTP.AutoSize = true;
            this.lblShortDescriptionTP.Location = new System.Drawing.Point(5, 31);
            this.lblShortDescriptionTP.Name = "lblShortDescriptionTP";
            this.lblShortDescriptionTP.Size = new System.Drawing.Size(1149, 32);
            this.lblShortDescriptionTP.TabIndex = 0;
            this.lblShortDescriptionTP.Text = "This report displays the number patients visited in a month in a graphical format" +
    " for a selected year. This report also displays the amount collected in each mon" +
    "th for a\r\nselected year";
            // 
            // lblReportName
            // 
            this.lblReportName.AutoSize = true;
            this.lblReportName.Location = new System.Drawing.Point(6, 29);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(120, 16);
            this.lblReportName.TabIndex = 0;
            this.lblReportName.Text = "Report Names : ";
            // 
            // MainWindowReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1257, 538);
            this.Controls.Add(this.gbTotalEmployees);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindowReports";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reports_Load);
            this.gbTotalEmployees.ResumeLayout(false);
            this.gbTotalEmployees.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbRepeatedPatientsMonthWise.ResumeLayout(false);
            this.gbRepeatedPatientsMonthWise.PerformLayout();
            this.gbTotalPatientsMonthWise.ResumeLayout(false);
            this.gbTotalPatientsMonthWise.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTotalEmployees;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbRepeatedPatientsMonthWise;
        private System.Windows.Forms.GroupBox gbTotalPatientsMonthWise;
        private System.Windows.Forms.Label lblShortDescriptionTP;
        private System.Windows.Forms.Label lblRP;
        private System.Windows.Forms.Label lblRD;
        private System.Windows.Forms.Label lblTpShow;
        private System.Windows.Forms.Label lblRDShow;
        private System.Windows.Forms.Label lblRPShow;
        private System.Windows.Forms.Button btnBack;
    }
}