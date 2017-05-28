namespace SangamithraClinic.PL.Reports
{
    partial class RPReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rptvRepeatedPatients = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rptvRepeatedPatients);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1241, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repeated Patients";
            // 
            // rptvRepeatedPatients
            // 
            this.rptvRepeatedPatients.LocalReport.ReportEmbeddedResource = "SangamithraClinic.PL.Rdlc.RepeatedPatients.rdlc";
            this.rptvRepeatedPatients.Location = new System.Drawing.Point(32, 103);
            this.rptvRepeatedPatients.Name = "rptvRepeatedPatients";
            this.rptvRepeatedPatients.Size = new System.Drawing.Size(1197, 385);
            this.rptvRepeatedPatients.TabIndex = 164;
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
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(95, 37);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(212, 24);
            this.cbYear.TabIndex = 1;
            this.cbYear.SelectionChangeCommitted += new System.EventHandler(this.cbYear_SelectionChangeCommitted);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(29, 40);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(49, 16);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year :";
            // 
            // RPReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1241, 500);
            this.Controls.Add(this.groupBox1);
            this.Name = "RPReport";
            this.Text = "RPReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RPReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rptvRepeatedPatients;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblYear;
    }
}