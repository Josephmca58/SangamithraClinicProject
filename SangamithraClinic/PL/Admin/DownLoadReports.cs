using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SangamithraClinic.BAL;
using SangamithraClinic.Common;

namespace SangamithraClinic.PL.Admin
{
    public partial class DownLoadReports : Form
    {
        BALDoctorPatientList objDoctorPatientList = null;
        DoctorNames objDoctorNames = null;
        DataTable dtDoctorPatientList = null;
        int columnIndex;
        string strPatientName = string.Empty, strPhoneNumber = string.Empty, strGender, strAge;
        Guid _guidPID;
        DataSet dsDoctorPatientList = null;
        string LoginText = string.Empty;
        public DownLoadReports()
        {
            InitializeComponent();
        }
        public DownLoadReports(string strText)
        {
            LoginText = strText;
            InitializeComponent();
        }

        private void DownLoadReports_Load(object sender, EventArgs e)
        {
            BALHRPatientList objHRPatientList = new BALHRPatientList();
            DateTime dt1 = DateTime.Now;
            lblCurrentDate.Text = string.Format("{0:dd-MMM-yyyy}", dt1);
            dtpRegistrationDate.Text = string.Format("{0:dd-MMM-yyyy}", dt1);
            lblTotalPatientsCount.Text = objHRPatientList.BindTotalPatientCount(dtpRegistrationDate.Text);
            lblRepeatedPatientsCount.Text = objHRPatientList.BindRepeatedPatientCount();
            objDoctorPatientList = new BALDoctorPatientList();
            BindDocotrsList();
            DateTime dt = Convert.ToDateTime(dtpRegistrationDate.Text);
            objDoctorPatientList.DoctorName = Convert.ToString(cbDoctorName.SelectedValue) == "0" ? string.Empty : Convert.ToString(cbDoctorName.Text);
            objDoctorPatientList.Name = txtName.Text;
            objDoctorPatientList.RegistrationDate = dt.ToShortDateString();
            objDoctorPatientList.Phonenumber = Convert.ToString(txtPhoneNumber.Text);
            BindingPatientDetails(objDoctorPatientList);
            for (int i = 0; i < dgHRPatientList.Rows.Count; i++)
            {
                DataGridViewRow row1 = dgHRPatientList.Rows[i];
                System.Drawing.Font font = new System.Drawing.Font("Times New Roman", 9.0f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                row1.Cells[13].Style.Font = font;
            }
        }
        private void BindDocotrsList()
        {
            try
            {
                objDoctorNames = new DoctorNames();
                cbDoctorName.DataSource = objDoctorNames.liDoctorNames();
                cbDoctorName.DisplayMember = "DoctorName";
                cbDoctorName.ValueMember = "DoctorId";
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }
        private void BindingPatientDetails(BALDoctorPatientList objDoctorPatientListParameters)
        {

            dtDoctorPatientList = new DataTable();
            DataTable dtDummy = new DataTable();
            dsDoctorPatientList = new DataSet();
            objDoctorPatientList = new BALDoctorPatientList();
            try
            {
                dsDoctorPatientList = objDoctorPatientList.GeHRPatientList(objDoctorPatientListParameters);
                dtDoctorPatientList = dsDoctorPatientList.Tables[0];
                dtDummy = dsDoctorPatientList.Tables[1];
                dummyGrid.DataSource = dtDummy.DefaultView;
                dummyGrid.Visible = false;
                dtDoctorPatientList.Columns.Add("Download Report");
                for (int i = 0; i < dtDoctorPatientList.Rows.Count; i++)
                {
                    dtDoctorPatientList.Rows[i]["Download Report"] = "Download";
                }
                dgHRPatientList.DataSource = dtDoctorPatientList.DefaultView;
                dgHRPatientList.AutoGenerateColumns = false;
                dgHRPatientList.ReadOnly = true;
                dgHRPatientList.AllowUserToAddRows = false;
                dgHRPatientList.Columns[0].Visible = false;
                dgHRPatientList.Columns[13].Visible = false;
            }

            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void dgHRPatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strText = string.Empty;
                string strBp = string.Empty;
                string strSugar = string.Empty;
                string strFever = string.Empty;
                string strWeight = string.Empty;
                string strHeight = string.Empty;
                string strRegistratioDate = string.Empty;
                //ObjGeneralCheckup = new BALGeneralCheckup();
                string strDoctorName = Convert.ToString(cbDoctorName.SelectedValue) == "0" ? "Sudhakar" : Convert.ToString(cbDoctorName.Text);
                columnIndex = e.ColumnIndex;
                strPatientName = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Patient Name"].Value);
                strPhoneNumber = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Phone Number"].Value);
                DateTime dt = Convert.ToDateTime(dtpRegistrationDate.Text);
                strRegistratioDate = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Registration Date"].Value);
                _guidPID = Guid.Parse(dgHRPatientList.Rows[e.RowIndex].Cells["PID"].Value.ToString());
                strAge = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Age"].Value);
                strGender = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["SEX"].Value);
                strBp = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Blood Pressure"].Value);
                strSugar = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Sugar"].Value) == "1" ? "Yes" : "NO";
                strFever = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Fever"].Value);
                strWeight = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Weight"].Value);
                strHeight = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Height"].Value);
                strText = dgHRPatientList.Rows[e.RowIndex].Cells[14].Value.ToString().Replace(" ", "");

                if (columnIndex == 14 && strText.ToLower() == "download")
                {
                    //if (strBp != string.Empty && strWeight != string.Empty)
                    //{
                        TestDetails obj = new TestDetails("download", dt, strPatientName, strPhoneNumber, _guidPID, strDoctorName, strAge, strGender, strBp, strSugar, strFever, strWeight, strHeight);
                        obj.txtRegistrationDate.Text = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Registration Date"].Value);
                        //this.Close();
                        obj.Show();
                    //}
                    //else
                    //    MessageBox.Show("Patient is not attend the general checkup");

                }
                //else if (columnIndex == 13 && strText.ToLower() == "completed")
                //{
                //    MessageBox.Show("Test details of this patient is inserted successfully! choose another patient");
                //}
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (LoginText.ToLower() == "sw")
            {
                StaffWelcome objSW = new StaffWelcome();
                this.Close();
                objSW.Show();
            }
            else
            {
                DoctorWelcome objDW = new DoctorWelcome();
                this.Close();
                objDW.Show();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                objDoctorPatientList = new BALDoctorPatientList();
                objDoctorPatientList.DoctorName = Convert.ToString(cbDoctorName.SelectedValue) == "0" ? string.Empty : Convert.ToString(cbDoctorName.Text);
                objDoctorPatientList.Name = txtName.Text;
                objDoctorPatientList.Phonenumber = txtPhoneNumber.Text;
                DateTime dt = Convert.ToDateTime(dtpRegistrationDate.Text);
                objDoctorPatientList.RegistrationDate = dt.ToShortDateString();
                BindingPatientDetails(objDoctorPatientList);
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }
    }
}
