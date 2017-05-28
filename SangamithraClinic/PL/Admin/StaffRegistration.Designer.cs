namespace SangamithraClinic.PL.Admin
{
    partial class StaffRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffRegistration));
            this.pnlPatientList = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbStaffList = new System.Windows.Forms.GroupBox();
            this.dgStaffList = new System.Windows.Forms.DataGridView();
            this.gbStaffRegistration = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.pnlPatientList.SuspendLayout();
            this.gbStaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaffList)).BeginInit();
            this.gbStaffRegistration.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatientList
            // 
            this.pnlPatientList.BackColor = System.Drawing.Color.LightBlue;
            this.pnlPatientList.Controls.Add(this.btnBack);
            this.pnlPatientList.Controls.Add(this.gbStaffList);
            this.pnlPatientList.Controls.Add(this.gbStaffRegistration);
            this.pnlPatientList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPatientList.Location = new System.Drawing.Point(0, 0);
            this.pnlPatientList.Name = "pnlPatientList";
            this.pnlPatientList.Size = new System.Drawing.Size(1002, 538);
            this.pnlPatientList.TabIndex = 102;
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
            // gbStaffList
            // 
            this.gbStaffList.Controls.Add(this.dgStaffList);
            this.gbStaffList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStaffList.Location = new System.Drawing.Point(35, 278);
            this.gbStaffList.Name = "gbStaffList";
            this.gbStaffList.Size = new System.Drawing.Size(961, 229);
            this.gbStaffList.TabIndex = 160;
            this.gbStaffList.TabStop = false;
            this.gbStaffList.Text = "Staff List";
            // 
            // dgStaffList
            // 
            this.dgStaffList.AllowUserToResizeColumns = false;
            this.dgStaffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStaffList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStaffList.Location = new System.Drawing.Point(6, 19);
            this.dgStaffList.Name = "dgStaffList";
            this.dgStaffList.Size = new System.Drawing.Size(949, 190);
            this.dgStaffList.TabIndex = 0;
            this.dgStaffList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStaffList_CellClick);
            // 
            // gbStaffRegistration
            // 
            this.gbStaffRegistration.Controls.Add(this.btnSave);
            this.gbStaffRegistration.Controls.Add(this.btnCancel);
            this.gbStaffRegistration.Controls.Add(this.lblStaffId);
            this.gbStaffRegistration.Controls.Add(this.txtPhoneNumber);
            this.gbStaffRegistration.Controls.Add(this.lblPhoneNumber);
            this.gbStaffRegistration.Controls.Add(this.cbGender);
            this.gbStaffRegistration.Controls.Add(this.lblGender);
            this.gbStaffRegistration.Controls.Add(this.txtConfirmPassword);
            this.gbStaffRegistration.Controls.Add(this.lblConfirmPassword);
            this.gbStaffRegistration.Controls.Add(this.txtPassword);
            this.gbStaffRegistration.Controls.Add(this.lblPassword);
            this.gbStaffRegistration.Controls.Add(this.txtStaffName);
            this.gbStaffRegistration.Controls.Add(this.lblStaffName);
            this.gbStaffRegistration.Controls.Add(this.txtUserName);
            this.gbStaffRegistration.Controls.Add(this.lblUserName);
            this.gbStaffRegistration.Controls.Add(this.cbUserType);
            this.gbStaffRegistration.Controls.Add(this.lblUserType);
            this.gbStaffRegistration.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStaffRegistration.Location = new System.Drawing.Point(40, 38);
            this.gbStaffRegistration.Name = "gbStaffRegistration";
            this.gbStaffRegistration.Size = new System.Drawing.Size(935, 230);
            this.gbStaffRegistration.TabIndex = 150;
            this.gbStaffRegistration.TabStop = false;
            this.gbStaffRegistration.Text = "Staff Registration";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(363, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 39);
            this.btnSave.TabIndex = 47;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(521, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 39);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(738, 45);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(0, 16);
            this.lblStaffId.TabIndex = 45;
            this.lblStaffId.Visible = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(516, 131);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(191, 22);
            this.txtPhoneNumber.TabIndex = 42;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(360, 131);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(98, 16);
            this.lblPhoneNumber.TabIndex = 41;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.ItemHeight = 16;
            this.cbGender.Location = new System.Drawing.Point(516, 84);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(191, 24);
            this.cbGender.TabIndex = 40;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(360, 89);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 16);
            this.lblGender.TabIndex = 39;
            this.lblGender.Text = "Gender";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(516, 39);
            this.txtConfirmPassword.MaxLength = 10;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(191, 22);
            this.txtConfirmPassword.TabIndex = 38;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(360, 39);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(116, 16);
            this.lblConfirmPassword.TabIndex = 37;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 170);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(191, 22);
            this.txtPassword.TabIndex = 36;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(27, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 35;
            this.lblPassword.Text = "Password";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(140, 127);
            this.txtStaffName.MaxLength = 30;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(191, 22);
            this.txtStaffName.TabIndex = 34;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(27, 127);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(74, 16);
            this.lblStaffName.TabIndex = 33;
            this.lblStaffName.Text = "Staff Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(140, 85);
            this.txtUserName.MaxLength = 30;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(191, 22);
            this.txtUserName.TabIndex = 32;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(27, 85);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 16);
            this.lblUserName.TabIndex = 31;
            this.lblUserName.Text = "User Name";
            // 
            // cbUserType
            // 
            this.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.ItemHeight = 16;
            this.cbUserType.Location = new System.Drawing.Point(140, 34);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(191, 24);
            this.cbUserType.TabIndex = 30;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(27, 34);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(72, 16);
            this.lblUserType.TabIndex = 29;
            this.lblUserType.Text = "User Type\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lblTodayDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(1002, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 538);
            this.panel1.TabIndex = 202;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.Location = new System.Drawing.Point(479, 261);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(45, 16);
            this.lblTodayDate.TabIndex = 7;
            this.lblTodayDate.Text = "Date :";
            // 
            // StaffRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1257, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPatientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffRegistration";
            this.Text = "Staff Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffRegistration_Load);
            this.pnlPatientList.ResumeLayout(false);
            this.gbStaffList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStaffList)).EndInit();
            this.gbStaffRegistration.ResumeLayout(false);
            this.gbStaffRegistration.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPatientList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbStaffList;
        private System.Windows.Forms.DataGridView dgStaffList;
        private System.Windows.Forms.GroupBox gbStaffRegistration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTodayDate;
    }
}