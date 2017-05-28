namespace SangamithraClinic.PL.Admin
{
    partial class TestList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestList));
            this.pnlPatientList = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbTestList = new System.Windows.Forms.GroupBox();
            this.dgTestItems = new System.Windows.Forms.DataGridView();
            this.gbTestItems = new System.Windows.Forms.GroupBox();
            this.lblInvestigationID = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.cbDoctorName = new System.Windows.Forms.ComboBox();
            this.lblDiseaseName = new System.Windows.Forms.Label();
            this.cbDiseaseName = new System.Windows.Forms.ComboBox();
            this.lblTestName = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPatientList.SuspendLayout();
            this.gbTestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestItems)).BeginInit();
            this.gbTestItems.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatientList
            // 
            this.pnlPatientList.BackColor = System.Drawing.Color.LightBlue;
            this.pnlPatientList.Controls.Add(this.btnBack);
            this.pnlPatientList.Controls.Add(this.gbTestList);
            this.pnlPatientList.Controls.Add(this.gbTestItems);
            this.pnlPatientList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPatientList.Location = new System.Drawing.Point(0, 0);
            this.pnlPatientList.Name = "pnlPatientList";
            this.pnlPatientList.Size = new System.Drawing.Size(1002, 534);
            this.pnlPatientList.TabIndex = 103;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(861, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 162;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbTestList
            // 
            this.gbTestList.Controls.Add(this.dgTestItems);
            this.gbTestList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTestList.Location = new System.Drawing.Point(25, 278);
            this.gbTestList.Name = "gbTestList";
            this.gbTestList.Size = new System.Drawing.Size(961, 229);
            this.gbTestList.TabIndex = 160;
            this.gbTestList.TabStop = false;
            this.gbTestList.Text = "Test List";
            // 
            // dgTestItems
            // 
            this.dgTestItems.AllowUserToResizeColumns = false;
            this.dgTestItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTestItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgTestItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTestItems.Location = new System.Drawing.Point(6, 19);
            this.dgTestItems.Name = "dgTestItems";
            this.dgTestItems.Size = new System.Drawing.Size(949, 190);
            this.dgTestItems.TabIndex = 0;
            this.dgTestItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTestItems_CellClick);
            // 
            // gbTestItems
            // 
            this.gbTestItems.Controls.Add(this.lblInvestigationID);
            this.gbTestItems.Controls.Add(this.lblDoctorName);
            this.gbTestItems.Controls.Add(this.cbDoctorName);
            this.gbTestItems.Controls.Add(this.lblDiseaseName);
            this.gbTestItems.Controls.Add(this.cbDiseaseName);
            this.gbTestItems.Controls.Add(this.lblTestName);
            this.gbTestItems.Controls.Add(this.txtTestName);
            this.gbTestItems.Controls.Add(this.btnSave);
            this.gbTestItems.Controls.Add(this.btnSearch);
            this.gbTestItems.Controls.Add(this.btnCancel);
            this.gbTestItems.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTestItems.Location = new System.Drawing.Point(26, 40);
            this.gbTestItems.Name = "gbTestItems";
            this.gbTestItems.Size = new System.Drawing.Size(936, 229);
            this.gbTestItems.TabIndex = 150;
            this.gbTestItems.TabStop = false;
            this.gbTestItems.Text = "Test Items";
            // 
            // lblInvestigationID
            // 
            this.lblInvestigationID.AutoSize = true;
            this.lblInvestigationID.Location = new System.Drawing.Point(508, 36);
            this.lblInvestigationID.Name = "lblInvestigationID";
            this.lblInvestigationID.Size = new System.Drawing.Size(0, 16);
            this.lblInvestigationID.TabIndex = 49;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(54, 26);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(88, 16);
            this.lblDoctorName.TabIndex = 47;
            this.lblDoctorName.Text = "Doctor Name";
            // 
            // cbDoctorName
            // 
            this.cbDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctorName.FormattingEnabled = true;
            this.cbDoctorName.ItemHeight = 16;
            this.cbDoctorName.Location = new System.Drawing.Point(184, 26);
            this.cbDoctorName.Name = "cbDoctorName";
            this.cbDoctorName.Size = new System.Drawing.Size(191, 24);
            this.cbDoctorName.TabIndex = 48;
            this.cbDoctorName.SelectionChangeCommitted += new System.EventHandler(this.cbDoctorName_SelectionChangeCommitted);
            // 
            // lblDiseaseName
            // 
            this.lblDiseaseName.AutoSize = true;
            this.lblDiseaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseaseName.Location = new System.Drawing.Point(54, 72);
            this.lblDiseaseName.Name = "lblDiseaseName";
            this.lblDiseaseName.Size = new System.Drawing.Size(99, 16);
            this.lblDiseaseName.TabIndex = 43;
            this.lblDiseaseName.Text = "Disease Name";
            // 
            // cbDiseaseName
            // 
            this.cbDiseaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiseaseName.FormattingEnabled = true;
            this.cbDiseaseName.ItemHeight = 16;
            this.cbDiseaseName.Location = new System.Drawing.Point(184, 72);
            this.cbDiseaseName.Name = "cbDiseaseName";
            this.cbDiseaseName.Size = new System.Drawing.Size(191, 24);
            this.cbDiseaseName.TabIndex = 44;
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(54, 124);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(75, 16);
            this.lblTestName.TabIndex = 45;
            this.lblTestName.Text = "Test Name";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(184, 124);
            this.txtTestName.MaxLength = 100;
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(191, 22);
            this.txtTestName.TabIndex = 46;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(53, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 39);
            this.btnSave.TabIndex = 39;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(372, 172);
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
            this.btnCancel.Location = new System.Drawing.Point(211, 172);
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(1002, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 534);
            this.panel1.TabIndex = 203;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doctor Name : Dr. Sudhakar";
            // 
            // TestList
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
            this.Name = "TestList";
            this.Text = "Test List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestList_Load);
            this.pnlPatientList.ResumeLayout(false);
            this.gbTestList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTestItems)).EndInit();
            this.gbTestItems.ResumeLayout(false);
            this.gbTestItems.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPatientList;
        private System.Windows.Forms.GroupBox gbTestList;
        private System.Windows.Forms.DataGridView dgTestItems;
        private System.Windows.Forms.GroupBox gbTestItems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.ComboBox cbDoctorName;
        private System.Windows.Forms.Label lblDiseaseName;
        private System.Windows.Forms.ComboBox cbDiseaseName;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblInvestigationID;
    }
}