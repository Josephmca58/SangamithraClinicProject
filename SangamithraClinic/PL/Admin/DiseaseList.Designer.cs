namespace SangamithraClinic.PL.Admin
{
    partial class DiseaseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiseaseList));
            this.pnlPatientList = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbDiseaseList = new System.Windows.Forms.GroupBox();
            this.dgDiseases = new System.Windows.Forms.DataGridView();
            this.gbDiseases = new System.Windows.Forms.GroupBox();
            this.lblDiseaseID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.cbDoctorName = new System.Windows.Forms.ComboBox();
            this.lblDiseaseName = new System.Windows.Forms.Label();
            this.txtDiseaseName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPatientList.SuspendLayout();
            this.gbDiseaseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiseases)).BeginInit();
            this.gbDiseases.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPatientList
            // 
            this.pnlPatientList.BackColor = System.Drawing.Color.LightBlue;
            this.pnlPatientList.Controls.Add(this.btnBack);
            this.pnlPatientList.Controls.Add(this.gbDiseaseList);
            this.pnlPatientList.Controls.Add(this.gbDiseases);
            this.pnlPatientList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPatientList.Location = new System.Drawing.Point(0, 0);
            this.pnlPatientList.Name = "pnlPatientList";
            this.pnlPatientList.Size = new System.Drawing.Size(1002, 534);
            this.pnlPatientList.TabIndex = 102;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(862, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 162;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbDiseaseList
            // 
            this.gbDiseaseList.Controls.Add(this.dgDiseases);
            this.gbDiseaseList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiseaseList.Location = new System.Drawing.Point(35, 278);
            this.gbDiseaseList.Name = "gbDiseaseList";
            this.gbDiseaseList.Size = new System.Drawing.Size(961, 229);
            this.gbDiseaseList.TabIndex = 160;
            this.gbDiseaseList.TabStop = false;
            this.gbDiseaseList.Text = "Diseases List";
            // 
            // dgDiseases
            // 
            this.dgDiseases.AllowUserToResizeColumns = false;
            this.dgDiseases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDiseases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgDiseases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiseases.Location = new System.Drawing.Point(6, 19);
            this.dgDiseases.Name = "dgDiseases";
            this.dgDiseases.Size = new System.Drawing.Size(949, 190);
            this.dgDiseases.TabIndex = 0;
            this.dgDiseases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDiseases_CellContentClick);
            // 
            // gbDiseases
            // 
            this.gbDiseases.Controls.Add(this.lblDiseaseID);
            this.gbDiseases.Controls.Add(this.btnSave);
            this.gbDiseases.Controls.Add(this.lblDoctorName);
            this.gbDiseases.Controls.Add(this.cbDoctorName);
            this.gbDiseases.Controls.Add(this.lblDiseaseName);
            this.gbDiseases.Controls.Add(this.txtDiseaseName);
            this.gbDiseases.Controls.Add(this.btnSearch);
            this.gbDiseases.Controls.Add(this.btnCancel);
            this.gbDiseases.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiseases.Location = new System.Drawing.Point(33, 40);
            this.gbDiseases.Name = "gbDiseases";
            this.gbDiseases.Size = new System.Drawing.Size(936, 229);
            this.gbDiseases.TabIndex = 150;
            this.gbDiseases.TabStop = false;
            this.gbDiseases.Text = "Diseases";
            // 
            // lblDiseaseID
            // 
            this.lblDiseaseID.AutoSize = true;
            this.lblDiseaseID.Location = new System.Drawing.Point(598, 70);
            this.lblDiseaseID.Name = "lblDiseaseID";
            this.lblDiseaseID.Size = new System.Drawing.Size(0, 16);
            this.lblDiseaseID.TabIndex = 40;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(53, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 39);
            this.btnSave.TabIndex = 39;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(37, 42);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(88, 16);
            this.lblDoctorName.TabIndex = 35;
            this.lblDoctorName.Text = "Doctor Name";
            // 
            // cbDoctorName
            // 
            this.cbDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctorName.FormattingEnabled = true;
            this.cbDoctorName.ItemHeight = 16;
            this.cbDoctorName.Location = new System.Drawing.Point(156, 42);
            this.cbDoctorName.Name = "cbDoctorName";
            this.cbDoctorName.Size = new System.Drawing.Size(191, 24);
            this.cbDoctorName.TabIndex = 36;
            // 
            // lblDiseaseName
            // 
            this.lblDiseaseName.AutoSize = true;
            this.lblDiseaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiseaseName.Location = new System.Drawing.Point(37, 98);
            this.lblDiseaseName.Name = "lblDiseaseName";
            this.lblDiseaseName.Size = new System.Drawing.Size(99, 16);
            this.lblDiseaseName.TabIndex = 37;
            this.lblDiseaseName.Text = "Disease Name";
            // 
            // txtDiseaseName
            // 
            this.txtDiseaseName.Location = new System.Drawing.Point(156, 98);
            this.txtDiseaseName.Name = "txtDiseaseName";
            this.txtDiseaseName.Size = new System.Drawing.Size(191, 22);
            this.txtDiseaseName.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(372, 148);
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
            this.btnCancel.Location = new System.Drawing.Point(211, 148);
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
            this.panel1.TabIndex = 202;
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
            // DiseaseList
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
            this.Name = "DiseaseList";
            this.Text = "Disease List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DiseaseList_Load);
            this.pnlPatientList.ResumeLayout(false);
            this.gbDiseaseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDiseases)).EndInit();
            this.gbDiseases.ResumeLayout(false);
            this.gbDiseases.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPatientList;
        private System.Windows.Forms.GroupBox gbDiseaseList;
        private System.Windows.Forms.DataGridView dgDiseases;
        private System.Windows.Forms.GroupBox gbDiseases;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.ComboBox cbDoctorName;
        private System.Windows.Forms.Label lblDiseaseName;
        private System.Windows.Forms.TextBox txtDiseaseName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDiseaseID;
    }
}