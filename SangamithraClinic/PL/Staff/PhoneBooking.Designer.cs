namespace SangamithraClinic.PL.Staff
{
    partial class PhoneBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneBooking));
            this.pnlPatientRegistration = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbPatientRegistration = new System.Windows.Forms.GroupBox();
            this.btnGeneratePhno = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbDoctorName = new System.Windows.Forms.ComboBox();
            this.lblDiseaseName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.pnlPatientRegistration.SuspendLayout();
            this.gbPatientRegistration.SuspendLayout();
            this.pnlInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatientRegistration
            // 
            this.pnlPatientRegistration.AllowDrop = true;
            this.pnlPatientRegistration.BackColor = System.Drawing.Color.LightBlue;
            this.pnlPatientRegistration.Controls.Add(this.btnBack);
            this.pnlPatientRegistration.Controls.Add(this.gbPatientRegistration);
            this.pnlPatientRegistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPatientRegistration.Location = new System.Drawing.Point(0, 0);
            this.pnlPatientRegistration.Name = "pnlPatientRegistration";
            this.pnlPatientRegistration.Size = new System.Drawing.Size(1002, 534);
            this.pnlPatientRegistration.TabIndex = 101;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(863, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 202;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbPatientRegistration
            // 
            this.gbPatientRegistration.Controls.Add(this.btnGeneratePhno);
            this.gbPatientRegistration.Controls.Add(this.txtAmount);
            this.gbPatientRegistration.Controls.Add(this.lblAmount);
            this.gbPatientRegistration.Controls.Add(this.cbGender);
            this.gbPatientRegistration.Controls.Add(this.cbMaritalStatus);
            this.gbPatientRegistration.Controls.Add(this.txtPhoneNumber);
            this.gbPatientRegistration.Controls.Add(this.lbEmail);
            this.gbPatientRegistration.Controls.Add(this.dtpRegistrationDate);
            this.gbPatientRegistration.Controls.Add(this.lblRegistrationDate);
            this.gbPatientRegistration.Controls.Add(this.lblGender);
            this.gbPatientRegistration.Controls.Add(this.lblMaritalStatus);
            this.gbPatientRegistration.Controls.Add(this.txtAge);
            this.gbPatientRegistration.Controls.Add(this.lblAge);
            this.gbPatientRegistration.Controls.Add(this.txtName);
            this.gbPatientRegistration.Controls.Add(this.lblName);
            this.gbPatientRegistration.Controls.Add(this.cbDoctorName);
            this.gbPatientRegistration.Controls.Add(this.lblDiseaseName);
            this.gbPatientRegistration.Controls.Add(this.btnCancel);
            this.gbPatientRegistration.Controls.Add(this.btnSave);
            this.gbPatientRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPatientRegistration.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientRegistration.Location = new System.Drawing.Point(21, 42);
            this.gbPatientRegistration.Name = "gbPatientRegistration";
            this.gbPatientRegistration.Size = new System.Drawing.Size(957, 480);
            this.gbPatientRegistration.TabIndex = 150;
            this.gbPatientRegistration.TabStop = false;
            this.gbPatientRegistration.Text = "Patient Registration";
            // 
            // btnGeneratePhno
            // 
            this.btnGeneratePhno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePhno.Location = new System.Drawing.Point(418, 291);
            this.btnGeneratePhno.Name = "btnGeneratePhno";
            this.btnGeneratePhno.Size = new System.Drawing.Size(120, 23);
            this.btnGeneratePhno.TabIndex = 202;
            this.btnGeneratePhno.Text = "Phone Number";
            this.btnGeneratePhno.UseVisualStyleBackColor = true;
            this.btnGeneratePhno.Click += new System.EventHandler(this.btnGeneratePhno_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(199, 330);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(191, 22);
            this.txtAmount.TabIndex = 101;
            this.txtAmount.Text = "0";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(43, 337);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 16);
            this.lblAmount.TabIndex = 100;
            this.lblAmount.Text = "Amount";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.ItemHeight = 16;
            this.cbGender.Location = new System.Drawing.Point(199, 199);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(191, 24);
            this.cbGender.TabIndex = 99;
            // 
            // cbMaritalStatus
            // 
            this.cbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaritalStatus.FormattingEnabled = true;
            this.cbMaritalStatus.ItemHeight = 16;
            this.cbMaritalStatus.Location = new System.Drawing.Point(199, 160);
            this.cbMaritalStatus.Name = "cbMaritalStatus";
            this.cbMaritalStatus.Size = new System.Drawing.Size(191, 24);
            this.cbMaritalStatus.TabIndex = 98;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(199, 290);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(191, 22);
            this.txtPhoneNumber.TabIndex = 97;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(43, 294);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(98, 16);
            this.lbEmail.TabIndex = 96;
            this.lbEmail.Text = "Phone Number";
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegistrationDate.Location = new System.Drawing.Point(199, 246);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(191, 22);
            this.dtpRegistrationDate.TabIndex = 95;
            this.dtpRegistrationDate.Value = new System.DateTime(2015, 6, 26, 0, 0, 0, 0);
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDate.Location = new System.Drawing.Point(43, 246);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(109, 16);
            this.lblRegistrationDate.TabIndex = 94;
            this.lblRegistrationDate.Text = "RegistrationDate";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(43, 204);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 16);
            this.lblGender.TabIndex = 93;
            this.lblGender.Text = "Gender";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatus.Location = new System.Drawing.Point(43, 165);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(88, 16);
            this.lblMaritalStatus.TabIndex = 92;
            this.lblMaritalStatus.Text = "Marital Status";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(199, 126);
            this.txtAge.MaxLength = 3;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(191, 22);
            this.txtAge.TabIndex = 91;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(43, 130);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 16);
            this.lblAge.TabIndex = 90;
            this.lblAge.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(199, 91);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 89;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(43, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 88;
            this.lblName.Text = "Name";
            // 
            // cbDoctorName
            // 
            this.cbDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctorName.FormattingEnabled = true;
            this.cbDoctorName.ItemHeight = 16;
            this.cbDoctorName.Location = new System.Drawing.Point(199, 49);
            this.cbDoctorName.Name = "cbDoctorName";
            this.cbDoctorName.Size = new System.Drawing.Size(191, 24);
            this.cbDoctorName.TabIndex = 87;
            // 
            // lblDiseaseName
            // 
            this.lblDiseaseName.AutoSize = true;
            this.lblDiseaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseaseName.Location = new System.Drawing.Point(43, 49);
            this.lblDiseaseName.Name = "lblDiseaseName";
            this.lblDiseaseName.Size = new System.Drawing.Size(88, 16);
            this.lblDiseaseName.TabIndex = 86;
            this.lblDiseaseName.Text = "Doctor Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(199, 409);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 39);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(46, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 39);
            this.btnSave.TabIndex = 13;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlInformation
            // 
            this.pnlInformation.AllowDrop = true;
            this.pnlInformation.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlInformation.Controls.Add(this.lblDate);
            this.pnlInformation.Controls.Add(this.lblTodayDate);
            this.pnlInformation.Controls.Add(this.lblDoctorName);
            this.pnlInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInformation.Location = new System.Drawing.Point(1002, 0);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(1002, 534);
            this.pnlInformation.TabIndex = 201;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(65, 53);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 16);
            this.lblDate.TabIndex = 2;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.Location = new System.Drawing.Point(13, 53);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(45, 16);
            this.lblTodayDate.TabIndex = 1;
            this.lblTodayDate.Text = "Date :";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(10, 13);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(155, 16);
            this.lblDoctorName.TabIndex = 0;
            this.lblDoctorName.Text = "Doctor Name : Dr. Sudhakar";
            // 
            // PhoneBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1253, 534);
            this.Controls.Add(this.pnlInformation);
            this.Controls.Add(this.pnlPatientRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhoneBooking";
            this.Text = "Patient Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhoneBooking_Load);
            this.pnlPatientRegistration.ResumeLayout(false);
            this.gbPatientRegistration.ResumeLayout(false);
            this.gbPatientRegistration.PerformLayout();
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPatientRegistration;
        private System.Windows.Forms.GroupBox gbPatientRegistration;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbMaritalStatus;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbDoctorName;
        private System.Windows.Forms.Label lblDiseaseName;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGeneratePhno;
    }
}