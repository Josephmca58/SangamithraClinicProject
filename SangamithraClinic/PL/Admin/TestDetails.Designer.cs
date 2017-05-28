namespace SangamithraClinic.PL.Admin
{
    partial class TestDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestDetails));
            this.pnlPatientList = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbTestDetails = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtRegistrationDate = new System.Windows.Forms.TextBox();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.txtFileUpload = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDiseaseName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.pnlPatientList.SuspendLayout();
            this.gbTestDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatientList
            // 
            this.pnlPatientList.BackColor = System.Drawing.Color.LightBlue;
            this.pnlPatientList.Controls.Add(this.btnBack);
            this.pnlPatientList.Controls.Add(this.gbTestDetails);
            this.pnlPatientList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPatientList.Location = new System.Drawing.Point(0, 0);
            this.pnlPatientList.Name = "pnlPatientList";
            this.pnlPatientList.Size = new System.Drawing.Size(1002, 534);
            this.pnlPatientList.TabIndex = 101;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(861, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 162;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbTestDetails
            // 
            this.gbTestDetails.Controls.Add(this.btnSave);
            this.gbTestDetails.Controls.Add(this.btnUpload);
            this.gbTestDetails.Controls.Add(this.txtRegistrationDate);
            this.gbTestDetails.Controls.Add(this.lblRegDate);
            this.gbTestDetails.Controls.Add(this.txtFileUpload);
            this.gbTestDetails.Controls.Add(this.label2);
            this.gbTestDetails.Controls.Add(this.label3);
            this.gbTestDetails.Controls.Add(this.cbDiseaseName);
            this.gbTestDetails.Controls.Add(this.btnCancel);
            this.gbTestDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTestDetails.Location = new System.Drawing.Point(26, 36);
            this.gbTestDetails.Name = "gbTestDetails";
            this.gbTestDetails.Size = new System.Drawing.Size(935, 460);
            this.gbTestDetails.TabIndex = 150;
            this.gbTestDetails.TabStop = false;
            this.gbTestDetails.Text = "Test Details";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(41, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 39);
            this.btnSave.TabIndex = 79;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.Location = new System.Drawing.Point(424, 151);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(138, 39);
            this.btnUpload.TabIndex = 77;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Enabled = false;
            this.txtRegistrationDate.Location = new System.Drawing.Point(209, 79);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.Size = new System.Drawing.Size(191, 22);
            this.txtRegistrationDate.TabIndex = 76;
            // 
            // lblRegDate
            // 
            this.lblRegDate.AutoSize = true;
            this.lblRegDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegDate.Location = new System.Drawing.Point(24, 84);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(112, 16);
            this.lblRegDate.TabIndex = 75;
            this.lblRegDate.Text = "Registration Date";
            // 
            // txtFileUpload
            // 
            this.txtFileUpload.Location = new System.Drawing.Point(208, 159);
            this.txtFileUpload.Name = "txtFileUpload";
            this.txtFileUpload.Size = new System.Drawing.Size(191, 22);
            this.txtFileUpload.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Upload Test Items Sheet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Disease Name";
            // 
            // cbDiseaseName
            // 
            this.cbDiseaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiseaseName.FormattingEnabled = true;
            this.cbDiseaseName.ItemHeight = 16;
            this.cbDiseaseName.Location = new System.Drawing.Point(208, 116);
            this.cbDiseaseName.Name = "cbDiseaseName";
            this.cbDiseaseName.Size = new System.Drawing.Size(191, 24);
            this.cbDiseaseName.TabIndex = 71;
            this.cbDiseaseName.SelectionChangeCommitted += new System.EventHandler(this.cbDiseaseName_SelectionChangeCommitted);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(193, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lblCurrentDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblDoctorName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(1002, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 534);
            this.panel1.TabIndex = 201;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(67, 72);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentDate.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(15, 71);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(12, 30);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(184, 16);
            this.lblDoctorName.TabIndex = 0;
            this.lblDoctorName.Text = "Doctor Name : Dr. Sudhakar";
            // 
            // TestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1253, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPatientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestDetails";
            this.Text = "Test Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestDetails_Load);
            this.pnlPatientList.ResumeLayout(false);
            this.gbTestDetails.ResumeLayout(false);
            this.gbTestDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPatientList;
        private System.Windows.Forms.GroupBox gbTestDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Button btnUpload;
        public System.Windows.Forms.TextBox txtRegistrationDate;
        private System.Windows.Forms.Label lblRegDate;
        private System.Windows.Forms.TextBox txtFileUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDiseaseName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
    }
}