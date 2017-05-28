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
    public partial class StaffRegistration : Form
    {
        public string StaffID = string.Empty;
        string strRowID;
        string strOperationName;
        int columnIndex;
        public StaffRegistration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int staffRegistrationResult;
            BALStaffRegistration objStaffRegistration = new BALStaffRegistration();
            try
            {
                #region(CRUD Operation)
                if (txtUserName.Text != string.Empty && txtStaffName.Text != string.Empty && txtPhoneNumber.Text != string.Empty && txtPassword.Text != string.Empty && txtConfirmPassword.Text != string.Empty && int.Parse(cbGender.SelectedValue.ToString()) != 0 && Convert.ToString(cbUserType.SelectedValue)!=string.Empty)
                {

                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {


                        if (strOperationName == "Edit")
                        {
                            objStaffRegistration.StaffID = lblStaffId.Text;
                            objStaffRegistration.UserList = Convert.ToString(cbUserType.SelectedValue);
                            objStaffRegistration.UserName = txtUserName.Text;
                            objStaffRegistration.StaffName = txtStaffName.Text;
                            objStaffRegistration.Password = txtPassword.Text;
                            objStaffRegistration.Gender = Convert.ToString(cbGender.SelectedValue);
                            objStaffRegistration.PhoneNumber = Convert.ToInt64(txtPhoneNumber.Text);
                            staffRegistrationResult = objStaffRegistration.Update(objStaffRegistration);
                            if (staffRegistrationResult == 1)
                            {
                                DataSet ds = new DataSet();
                                ds = objStaffRegistration.GetStaffDetails();
                                dgStaffList.DataSource = ds.Tables[0];
                                ClearFields();
                                MessageBox.Show(ConstatntMessages.strUpdateSuccess, "Alert");
                                MessageBox.Show("Staff Registration" + ConstatntMessages.strUpdateSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            objStaffRegistration.StaffID = lblStaffId.Text;
                            objStaffRegistration.UserList = Convert.ToString(cbUserType.SelectedValue);
                            objStaffRegistration.UserName = txtUserName.Text;
                            objStaffRegistration.StaffName = txtStaffName.Text;
                            objStaffRegistration.Password = txtPassword.Text;
                            objStaffRegistration.Gender = Convert.ToString(cbGender.SelectedValue);
                            objStaffRegistration.PhoneNumber = Convert.ToInt64(txtPhoneNumber.Text);
                            staffRegistrationResult = objStaffRegistration.Insert(objStaffRegistration);
                            if (staffRegistrationResult == 1)
                            {
                                DataSet ds = new DataSet();
                                ds = objStaffRegistration.GetStaffDetails();
                                dgStaffList.DataSource = ds.Tables[0];
                                dgStaffList.ReadOnly = true;
                                //dgStaffList.Columns[0].Visible = false;
                                ClearFields();
                                MessageBox.Show("Staff Registration" + ConstatntMessages.strSaveSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and Confirm Password are not same", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("All fields are Mandatory","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                #endregion
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void BindGridview()
        {
            DataSet ds = new DataSet();
            BALStaffRegistration objStaffRegistration = new BALStaffRegistration();
            try
            {
                ds = objStaffRegistration.GetStaffDetails();
                dgStaffList.DataSource = ds.Tables[0];
                dgStaffList.ReadOnly = true;
                dgStaffList.Columns[0].Visible = false;
                dgStaffList.AutoGenerateColumns = false;
                dgStaffList.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }

        }

        private void GetStaffID()
        {
            BALStaffRegistration objStaffRegistration = new BALStaffRegistration();
            StaffID = objStaffRegistration.GetStaffID();

            if (!string.IsNullOrEmpty(StaffID))
            {
                int n = int.Parse(StaffID);
                n++;
                objStaffRegistration.StaffID = "SF" + Convert.ToString(n);
                lblStaffId.Text = "SF" + Convert.ToString(n);
            }
            else
            {
                objStaffRegistration.StaffID = "SF1";
                lblStaffId.Text = "SF1";
            }


        }
        private void BindDropdowns()
        {
            try
            {
                //binding gender list..
                cbGender.DataSource = StaticMethods.GenderList();
                cbGender.DisplayMember = "Name";
                cbGender.ValueMember = "Id";

                //binding usertype list
                cbUserType.DataSource = StaticMethods.UserList();
                cbUserType.DisplayMember = "UserName";
                cbUserType.ValueMember = "UserId";
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void GetUserDetailsByID(string strRowID)
        {
            BALStaffRegistration objStaffRegistration = new BALStaffRegistration();
            try
            {
                DataTable dt = new DataTable();
                dt = objStaffRegistration.GetStaffDetailsByID(strRowID);
                lblStaffId.Text = dt.Rows[0]["StaffID"].ToString();
                txtUserName.Text = dt.Rows[0]["UserName"].ToString();
                txtStaffName.Text = dt.Rows[0]["StaffName"].ToString();
                txtPassword.Text = dt.Rows[0]["Pwd"].ToString();
                txtPhoneNumber.Text = dt.Rows[0]["Phone Number"].ToString();
                cbUserType.SelectedIndex = cbUserType.FindString(dt.Rows[0]["UserType"].ToString());
                cbGender.SelectedIndex = cbGender.FindString(dt.Rows[0]["Gender"].ToString());
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void dgStaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                strRowID = dgStaffList.Rows[e.RowIndex].Cells["StaffID"].Value.ToString();
                BALStaffRegistration objStaffRegistration = new BALStaffRegistration();
                columnIndex = e.ColumnIndex;
                if (columnIndex == 6)
                {
                    strOperationName = dgStaffList.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
                    GetUserDetailsByID(strRowID);

                }
                else if (columnIndex == 7)
                {
                    strOperationName = dgStaffList.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
                    int staffRegistrationResult;
                    staffRegistrationResult = objStaffRegistration.Delete(strRowID);
                    if (staffRegistrationResult == 1)
                    {
                        DataSet ds = new DataSet();
                        ds = objStaffRegistration.GetStaffDetails();
                        dgStaffList.DataSource = ds.Tables[0];
                        dgStaffList.ReadOnly = true;
                        dgStaffList.Columns[0].Visible = false;
                        ClearFields();
                        MessageBox.Show(ConstatntMessages.strDeleteSuccess, "Alert");

                    }

                }
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            try
            {
                txtUserName.Text = string.Empty;
                txtStaffName.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtConfirmPassword.Text = string.Empty;
                cbGender.SelectedValue = 0;
                cbUserType.SelectedValue = "0";
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void StaffRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                //lblDate.Text = String.Format("{0:dd-MMM-yyyy}", dt);
                BindDropdowns();
                GetStaffID();
                BindGridview();
                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkColumnEdit";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                dgStaffList.Columns.Add(Editlink);

                DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                Deletelink.UseColumnTextForLinkValue = true;
                Deletelink.HeaderText = "Delete";
                Deletelink.DataPropertyName = "lnkColumnDelete";
                Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                Deletelink.Text = "Delete";
                dgStaffList.Columns.Add(Deletelink);
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Close();
            objLogin.Show();
        }
    }
}
