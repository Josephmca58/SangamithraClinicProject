namespace SangamithraClinic.PL.Admin
{
    partial class DoctorPatientList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPatientList));
            this.pnlPatientList = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgHRPatientList = new System.Windows.Forms.DataGridView();
            this.gbPatientDetails = new System.Windows.Forms.GroupBox();
            this.dummyGrid = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbDoctorName = new System.Windows.Forms.ComboBox();
            this.lblDiseaseName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblRepeatedPatientsCount = new System.Windows.Forms.Label();
            this.lblRepeatedPatients = new System.Windows.Forms.Label();
            this.lblTotalPatientsCount = new System.Windows.Forms.Label();
            this.lblTotalPatients = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.pnlPatientList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHRPatientList)).BeginInit();
            this.gbPatientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dummyGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatientList
            // 
            this.pnlPatientList.BackColor = System.Drawing.Color.LightBlue;
            this.pnlPatientList.Controls.Add(this.btnBack);
            this.pnlPatientList.Controls.Add(this.groupBox1);
            this.pnlPatientList.Controls.Add(this.gbPatientDetails);
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
            this.btnBack.Location = new System.Drawing.Point(875, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 162;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgHRPatientList);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 229);
            this.groupBox1.TabIndex = 160;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient List";
            // 
            // dgHRPatientList
            // 
            this.dgHRPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHRPatientList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgHRPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHRPatientList.Location = new System.Drawing.Point(6, 19);
            this.dgHRPatientList.Name = "dgHRPatientList";
            this.dgHRPatientList.Size = new System.Drawing.Size(949, 190);
            this.dgHRPatientList.TabIndex = 0;
            this.dgHRPatientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHRPatientList_CellClick);
            // 
            // gbPatientDetails
            // 
            this.gbPatientDetails.Controls.Add(this.dummyGrid);
            this.gbPatientDetails.Controls.Add(this.btnSearch);
            this.gbPatientDetails.Controls.Add(this.btnCancel);
            this.gbPatientDetails.Controls.Add(this.txtPhoneNumber);
            this.gbPatientDetails.Controls.Add(this.lbEmail);
            this.gbPatientDetails.Controls.Add(this.dtpRegistrationDate);
            this.gbPatientDetails.Controls.Add(this.lblRegistrationDate);
            this.gbPatientDetails.Controls.Add(this.txtName);
            this.gbPatientDetails.Controls.Add(this.lblName);
            this.gbPatientDetails.Controls.Add(this.cbDoctorName);
            this.gbPatientDetails.Controls.Add(this.lblDiseaseName);
            this.gbPatientDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientDetails.Location = new System.Drawing.Point(40, 38);
            this.gbPatientDetails.Name = "gbPatientDetails";
            this.gbPatientDetails.Size = new System.Drawing.Size(935, 230);
            this.gbPatientDetails.TabIndex = 150;
            this.gbPatientDetails.TabStop = false;
            this.gbPatientDetails.Text = "Patient Details";
            // 
            // dummyGrid
            // 
            this.dummyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dummyGrid.Location = new System.Drawing.Point(414, 41);
            this.dummyGrid.Name = "dummyGrid";
            this.dummyGrid.Size = new System.Drawing.Size(318, 82);
            this.dummyGrid.TabIndex = 202;
            this.dummyGrid.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(423, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 39);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(594, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(162, 159);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(191, 22);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(43, 159);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(98, 16);
            this.lbEmail.TabIndex = 85;
            this.lbEmail.Text = "Phone Number";
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegistrationDate.Location = new System.Drawing.Point(162, 119);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(191, 22);
            this.dtpRegistrationDate.TabIndex = 3;
            this.dtpRegistrationDate.Value = new System.DateTime(2016, 7, 17, 0, 0, 0, 0);
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDate.Location = new System.Drawing.Point(43, 120);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(109, 16);
            this.lblRegistrationDate.TabIndex = 83;
            this.lblRegistrationDate.Text = "RegistrationDate";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(43, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 81;
            this.lblName.Text = "Name";
            // 
            // cbDoctorName
            // 
            this.cbDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctorName.FormattingEnabled = true;
            this.cbDoctorName.ItemHeight = 16;
            this.cbDoctorName.Location = new System.Drawing.Point(162, 41);
            this.cbDoctorName.Name = "cbDoctorName";
            this.cbDoctorName.Size = new System.Drawing.Size(191, 24);
            this.cbDoctorName.TabIndex = 1;
            // 
            // lblDiseaseName
            // 
            this.lblDiseaseName.AutoSize = true;
            this.lblDiseaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseaseName.Location = new System.Drawing.Point(43, 42);
            this.lblDiseaseName.Name = "lblDiseaseName";
            this.lblDiseaseName.Size = new System.Drawing.Size(88, 16);
            this.lblDiseaseName.TabIndex = 79;
            this.lblDiseaseName.Text = "Doctor Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lblCurrentDate);
            this.panel1.Controls.Add(this.lblRepeatedPatientsCount);
            this.panel1.Controls.Add(this.lblRepeatedPatients);
            this.panel1.Controls.Add(this.lblTotalPatientsCount);
            this.panel1.Controls.Add(this.lblTotalPatients);
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
            // lblRepeatedPatientsCount
            // 
            this.lblRepeatedPatientsCount.AutoSize = true;
            this.lblRepeatedPatientsCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatedPatientsCount.Location = new System.Drawing.Point(160, 140);
            this.lblRepeatedPatientsCount.Name = "lblRepeatedPatientsCount";
            this.lblRepeatedPatientsCount.Size = new System.Drawing.Size(0, 16);
            this.lblRepeatedPatientsCount.TabIndex = 5;
            // 
            // lblRepeatedPatients
            // 
            this.lblRepeatedPatients.AutoSize = true;
            this.lblRepeatedPatients.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatedPatients.Location = new System.Drawing.Point(21, 140);
            this.lblRepeatedPatients.Name = "lblRepeatedPatients";
            this.lblRepeatedPatients.Size = new System.Drawing.Size(132, 16);
            this.lblRepeatedPatients.TabIndex = 4;
            this.lblRepeatedPatients.Text = "Repeated Patients :";
            // 
            // lblTotalPatientsCount
            // 
            this.lblTotalPatientsCount.AutoSize = true;
            this.lblTotalPatientsCount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatientsCount.Location = new System.Drawing.Point(124, 110);
            this.lblTotalPatientsCount.Name = "lblTotalPatientsCount";
            this.lblTotalPatientsCount.Size = new System.Drawing.Size(0, 16);
            this.lblTotalPatientsCount.TabIndex = 3;
            // 
            // lblTotalPatients
            // 
            this.lblTotalPatients.AutoSize = true;
            this.lblTotalPatients.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatients.Location = new System.Drawing.Point(18, 110);
            this.lblTotalPatients.Name = "lblTotalPatients";
            this.lblTotalPatients.Size = new System.Drawing.Size(102, 16);
            this.lblTotalPatients.TabIndex = 2;
            this.lblTotalPatients.Text = "Total Patients :";
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
            // DoctorPatientList
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
            this.Name = "DoctorPatientList";
            this.Text = "Patient List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DoctorPatientList_Load);
            this.pnlPatientList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHRPatientList)).EndInit();
            this.gbPatientDetails.ResumeLayout(false);
            this.gbPatientDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dummyGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPatientList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgHRPatientList;
        private System.Windows.Forms.GroupBox gbPatientDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbDoctorName;
        private System.Windows.Forms.Label lblDiseaseName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblRepeatedPatientsCount;
        private System.Windows.Forms.Label lblRepeatedPatients;
        private System.Windows.Forms.Label lblTotalPatients;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.DataGridView dummyGrid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalPatientsCount;
    }
}