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
using SangamithraClinic.Constants;

namespace SangamithraClinic.PL.Admin
{
    public partial class DoctorPatientList : Form
    {
        BALDoctorPatientList objDoctorPatientList = null;
        BALGeneralCheckup ObjGeneralCheckup = null;
        DoctorNames objDoctorNames = null;
        DataTable dtDoctorPatientList = null;
        int columnIndex;
        string strPatientName = string.Empty, strPhoneNumber = string.Empty, strGender, strAge,_strStaffID;
        Guid _guidPID;
        DataSet dsDoctorPatientList = null;
        public DoctorPatientList()
        {
            InitializeComponent();
        }

        private void DoctorPatientList_Load(object sender, EventArgs e)
        {
            BALHRPatientList objHRPatientList = new BALHRPatientList();
            DateTime dt1 = DateTime.Now;
            lblCurrentDate.Text = string.Format("{0:dd-MMM-yyyy}", dt1);
            dtpRegistrationDate.Text = string.Format("{0:dd-MMM-yyyy}", dt1);
            lblTotalPatientsCount.Text = objHRPatientList.BindTotalPatientCount(dtpRegistrationDate.Text);
            lblRepeatedPatientsCount.Text = objHRPatientList.BindRepeatedPatientCount();
            try
            {
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
                    if (dummyGrid.Rows.Count > 0)
                    {
                        DataGridViewRow row2 = dummyGrid.Rows[i];
                        for (int j = 0; j < dummyGrid.Rows.Count; j++)
                        {
                            if (Convert.ToString(row1.Cells["PID"].Value) == Convert.ToString(row2.Cells["PId"].Value))
                            {
                                //row1.DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                            }
                            else
                            {

                                System.Drawing.Font font = new System.Drawing.Font("Times New Roman", 9.0f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                                row1.Cells[13].Style.Font = font;
                            }
                        }
                    }
                    else
                    {
                        System.Drawing.Font font = new System.Drawing.Font("Times New Roman", 9.0f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                        row1.Cells[13].Style.Font = font;
                    }

                }
                //DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                //Editlink.HeaderText = "Edit";
                //Editlink.UseColumnTextForLinkValue = true;
                //Editlink.DataPropertyName = "lnkColumnEdit";
                //Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                //Editlink.Text = "TestItems";
                //dgHRPatientList.Columns.Add(Editlink);
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
            //this.reportViewer1.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorWelcome objDoctorWelcome = new DoctorWelcome();
            this.Close();
            objDoctorWelcome.Show();
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
                //dtDoctorPatientList = objDoctorPatientList.GeHRPatientList(objDoctorPatientListParameters);
                dsDoctorPatientList = objDoctorPatientList.GeHRPatientList(objDoctorPatientListParameters);
                dtDoctorPatientList = dsDoctorPatientList.Tables[0];
                dtDummy = dsDoctorPatientList.Tables[1];
                //dummyGrid = new DataGridView();
                dummyGrid.DataSource = dtDummy.DefaultView;
                dummyGrid.Visible = false;
                dtDoctorPatientList.Columns.Add("Add Test Details");
                for (int i = 0; i < dtDoctorPatientList.Rows.Count; i++)
                {
                    if (dtDummy.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtDummy.Rows)
                        {
                            if (dr["PID"].ToString().Contains(Convert.ToString(dtDoctorPatientList.Rows[i]["PID"])))
                            {
                                dtDoctorPatientList.Rows[i]["Add Test Details"] = "Completed";
                                break;
                            }
                            else
                            {
                                dtDoctorPatientList.Rows[i]["Add Test Details"] = "Add Test Details";
                            }
                        }

                    }
                    else
                    {
                        dtDoctorPatientList.Rows[i]["Add Test Details"] = "Add Test Details";
                    }

                }
                dgHRPatientList.DataSource = dtDoctorPatientList.DefaultView;
                dgHRPatientList.AutoGenerateColumns = false;
                dgHRPatientList.ReadOnly = true;
                dgHRPatientList.AllowUserToAddRows = false;
                dgHRPatientList.Columns[0].Visible = false;
                dgHRPatientList.Columns[8].Visible = false;
                dgHRPatientList.Columns[13].Visible = false;
            }

            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbDoctorName.SelectedValue = "0";
            txtName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
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
                ObjGeneralCheckup = new BALGeneralCheckup();
                string strDoctorName = Convert.ToString(cbDoctorName.SelectedValue) == "0" ? "Sudhakar" : Convert.ToString(cbDoctorName.Text);
                columnIndex = e.ColumnIndex;
                strPatientName = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Patient Name"].Value);
                strPhoneNumber = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Phone Number"].Value);
                _guidPID = Guid.Parse(dgHRPatientList.Rows[e.RowIndex].Cells["PID"].Value.ToString());
                strAge = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Age"].Value);
                strGender = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["SEX"].Value);
                strBp = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Blood Pressure"].Value);
                strSugar = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Sugar"].Value) == "1" ? "Yes" : "NO";
                strFever = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Fever"].Value);
                strWeight = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Weight"].Value);
                strHeight = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Height"].Value);
                strText = dgHRPatientList.Rows[e.RowIndex].Cells[14].Value.ToString().Replace(" ", "");
                if (columnIndex == 14 && strText.ToLower() == "addtestdetails")
                {
                    TestDetails obj = new TestDetails(string.Empty, DateTime.Now, strPatientName, strPhoneNumber, _guidPID, strDoctorName, strAge, strGender, strBp, strSugar, strFever, strWeight, strHeight);
                    obj.txtRegistrationDate.Text = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Registration Date"].Value);
                    this.Close();
                    obj.Show();
                    //if (strBp != string.Empty && strWeight != string.Empty)
                    //{
                    //    TestDetails obj = new TestDetails(string.Empty, DateTime.Now, strPatientName, strPhoneNumber, _guidPID, strDoctorName, strAge, strGender, strBp, strSugar, strFever, strWeight, strHeight);
                    //    obj.txtRegistrationDate.Text = Convert.ToString(dgHRPatientList.Rows[e.RowIndex].Cells["Registration Date"].Value);
                    //    obj.Show();
                    //}
                    //else
                    //    MessageBox.Show("Patient is not attend the general checkup");

                }
                else if (columnIndex == 14 && strText.ToLower() == "completed")
                {
                    MessageBox.Show("Test details of the patient were already inserted! choose another patient", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
