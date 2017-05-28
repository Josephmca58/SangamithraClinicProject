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

namespace SangamithraClinic.PL.Staff
{
    public partial class PatientList : Form
    {
        DoctorNames objDoctorNames = null;
        BALHRPatientList objHRPatientList = null;
        DataTable dtHRPatientList = null;
        int columnIndex;
        Guid PID, GeneralCheckupPID;
        bool GeneralCheckupResult;
        string PatientName = string.Empty, strText = string.Empty;
        public PatientList()
        {
            InitializeComponent();
        }
        public PatientList(bool blGeneralCheckupStatus, Guid guidGeneralCheckupPID)
        {
            this.GeneralCheckupResult = blGeneralCheckupStatus;
            GeneralCheckupPID = guidGeneralCheckupPID;
            InitializeComponent();
        }

        private void PatientList_Load(object sender, EventArgs e)
        {
            objHRPatientList = new BALHRPatientList();
            DateTime dt1 = DateTime.Now;
            lblCurrentDate.Text = string.Format("{0:dd-MMM-yyyy}", dt1);
            dtpRegistrationDate.Text = string.Format("{0:dd-MMM-yyyy}", dt1);
            lblTotalPatientsCount.Text = objHRPatientList.BindTotalPatientCount(dtpRegistrationDate.Text);
            lblRepeatedPatientsCount.Text = objHRPatientList.BindRepeatedPatientCount();
            try
            {
                objHRPatientList = new BALHRPatientList();
                BindDocotrsList();   //Binding doctor names to dropdwon list.
                DateTime dt = Convert.ToDateTime(dtpRegistrationDate.Text);
                objHRPatientList.DoctorName = Convert.ToString(cbDoctorName.SelectedValue) == "0" ? string.Empty : Convert.ToString(cbDoctorName.SelectedText);
                objHRPatientList.Name = txtName.Text;
                objHRPatientList.RegistrationDate = dt.ToShortDateString();
                objHRPatientList.Phonenumber = Convert.ToString(txtPhoneNumber.Text);
                BindingPatientDetails(objHRPatientList);
                for (int i = 0; i < dgHRPatientList.Rows.Count; i++)
                {
                    DataGridViewRow row = dgHRPatientList.Rows[i];
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["InsertStatus"].Value)) && Convert.ToString(row.Cells["InsertStatus"].Value) == "True")
                    {
                        //row.DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {

                        row.Cells[10].Style.Font = new System.Drawing.Font("Times New Roman", 9.0f, FontStyle.Bold | FontStyle.Underline);
                        //System.Drawing.Font font = new System.Drawing.Font("Times New Roman", 9.0f, FontStyle.Bold | FontStyle.Underline);
                        //row.Cells[10].Style.Font = font;
                    }

                }
                GeneralCheckup obj = new GeneralCheckup();
                obj.Close();
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }
        private void BindingPatientDetails(BALHRPatientList objHRPatientListParameters)
        {

            dtHRPatientList = new DataTable();
            objHRPatientList = new BALHRPatientList();
            try
            {
                dtHRPatientList = objHRPatientList.GeHRPatientList(objHRPatientListParameters);
                dtHRPatientList.Columns.Add("General Checkup Details");
                for (int i = 0; i < dtHRPatientList.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(dtHRPatientList.Rows[i]["InsertStatus"])) && (Convert.ToString(dtHRPatientList.Rows[i]["InsertStatus"]) == "True"))
                    {
                        dtHRPatientList.Rows[i]["General Checkup Details"] = "Visited";
                    }
                    else
                    {

                        dtHRPatientList.Rows[i]["General Checkup Details"] = "GeneralCheckup";
                    }
                }
                dgHRPatientList.DataSource = dtHRPatientList.DefaultView;
                dgHRPatientList.AutoGenerateColumns = false;
                dgHRPatientList.ReadOnly = true;
                dgHRPatientList.AllowUserToAddRows = false;
                dgHRPatientList.Columns[0].Visible = false;
                dgHRPatientList.Columns[8].Visible = false;
                dgHRPatientList.Columns[9].Visible = false;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
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
       

        private void btnCancel_Click(object sender, EventArgs e)
        {


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StaffWelcome objStaffWel = new StaffWelcome();
            this.Close(); ;
            objStaffWel.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                objHRPatientList = new BALHRPatientList();
                BindDocotrsList();   //Binding doctor names to dropdwon list.
                DateTime dt = Convert.ToDateTime(dtpRegistrationDate.Text);
                objHRPatientList.DoctorName = Convert.ToString(cbDoctorName.SelectedValue) == "0" ? string.Empty : Convert.ToString(cbDoctorName.Text);
                objHRPatientList.Name = txtName.Text;
                objHRPatientList.RegistrationDate = dt.ToShortDateString();
                objHRPatientList.Phonenumber = Convert.ToString(txtPhoneNumber.Text);
                BindingPatientDetails(objHRPatientList);
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
                columnIndex = e.ColumnIndex;
                PID = new Guid(dgHRPatientList.Rows[e.RowIndex].Cells["PID"].Value.ToString());
                PatientName = dgHRPatientList.Rows[e.RowIndex].Cells["Patient Name"].Value.ToString();
                strText = dgHRPatientList.Rows[e.RowIndex].Cells[10].Value.ToString();
                if (columnIndex == 10 && strText.ToLower() == "generalcheckup")
                {
                    GeneralCheckup objGeneralCheckup = new GeneralCheckup(PID, PatientName);
                    this.Close();
                    objGeneralCheckup.Show();
                }
                if (columnIndex == 10 && strText.ToLower() == "visited")
                {
                    MessageBox.Show("General checkup details were inserted successfly! Patient can visit the Doctor", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }
    }
}
