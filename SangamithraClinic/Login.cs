using SangamithraClinic.Constants;
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
using SangamithraClinic.Constants;
using SangamithraClinic.Common;
using System.Data;
using SangamithraClinic.PL.Admin;
namespace SangamithraClinic
{
    public partial class Login : Form
    {
        BALLogin objBALLogin = null;
        string strUserName = string.Empty;
        DataTable dtUserList = null;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                objBALLogin = new BALLogin();
                dtUserList = new DataTable();
                //assigning text values to Properties.
                if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
                {
                    objBALLogin.UserName = txtUsername.Text;
                    objBALLogin.Password = txtPassword.Text;
                    dtUserList = objBALLogin.UserType(objBALLogin);

                    //Following Condition is used to check the Dr.Sudhakar.
                    if (dtUserList != null && dtUserList.Rows[0]["StaffID"].ToString() == "SF1" && dtUserList.Rows[0]["UserID"].ToString() == "US01")
                    {
                        DoctorWelcome objDoctorWelcome = new DoctorWelcome();
                        this.Hide();
                        objDoctorWelcome.Show();
                    }
                    // Following condition is used to check the condition for Dr.Manjula
                    //else if (dtUserList != null && dtUserList.Rows[0]["StaffID"].ToString() == "SF2" && dtUserList.Rows[0]["UserID"].ToString() == "US01")
                    //{
                    //    frmDoctorParent objDoctorParent = new frmDoctorParent();
                    //    this.Hide();
                    //    objDoctorParent.Show();
                    //}
                    //Following condition is used to check the admin
                    //else if (dtUserList != null && dtUserList.Rows[0]["UserID"].ToString() == "US03")
                    //{
                    //    frmAdminParent objAdminParent = new frmAdminParent();
                    //    this.Hide();
                    //    objAdminParent.Show();
                    //}
                    //Following condition is used to check the staff
                    else if (dtUserList != null && dtUserList.Rows[0]["UserID"].ToString() == "US02")
                    {
                        StaffWelcome objStaffWelcome = new StaffWelcome();
                        this.Hide();
                        objStaffWelcome.Show();
                    }
                    else
                    {
                        MessageBox.Show(ConstatntMessages.strLoginStaus, "Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Username and Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void lblCreateUser_Click(object sender, EventArgs e)
        {
            StaffRegistration objStaffReg = new StaffRegistration();
            this.Hide();
            objStaffReg.Show();
        }
        
    }
}
