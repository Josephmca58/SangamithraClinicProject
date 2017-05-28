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
using System.Globalization;
using System.Configuration;
namespace SangamithraClinic.PL.Staff
{
    public partial class PatientRegistration : Form
    {
        //Global Variables.
        BALPatientRegistration objPR = null;
        BALHRPatientList objHRPatientList = null;
        DataTable dtHRPatientList = null;
        DoctorNames objDoctorNames;
        int PatientRegResult;
        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblDate.Text = String.Format("{0:dd-MMM-yyyy}", dt);
            dtpRegistrationDate.Text = String.Format("{0:dd-MMM-yyyy HH:mm:ss}", dt);
            dtpRegistrationDate.MinDate = DateTime.Now;
            gbPatientRegistration.Visible = false;
            //Bind Dropdown list..
            try
            {
                BindDocotrsList();   //Binding dropdwon list.
                cbGender.DataSource = StaticMethods.GenderList();//Binding Marital Status.
                cbGender.DisplayMember = "Name";
                cbGender.ValueMember = "Id";
                cbMaritalStatus.DataSource = StaticMethods.GetMaritalStatus();//Binding Gender.
                cbMaritalStatus.DisplayMember = "Name";
                cbMaritalStatus.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtAge.Text != string.Empty && txtAmount.Text != string.Empty && txtAddress.Text != string.Empty && txtPhoneNumber.Text != string.Empty && Convert.ToString(cbDoctorName.SelectedValue) != "0" && Convert.ToString(cbGender.SelectedValue) != "0" && Convert.ToString(cbMaritalStatus.SelectedValue) != "0")
                {
                    //assigning textfields to properties.
                    objPR = new BALPatientRegistration();
                    objPR.PatientID = Guid.NewGuid();
                    objPR.DoctorName = Convert.ToString(cbDoctorName.SelectedValue);
                    objPR.FirstName = txtFirstName.Text;
                    objPR.LastName = txtLastName.Text;
                    objPR.Age = int.Parse(txtAge.Text);
                    objPR.MaritalStatus = Convert.ToString(cbMaritalStatus.SelectedValue);
                    objPR.Gender = Convert.ToString(cbGender.SelectedValue);
                    objPR.RegDate = Convert.ToDateTime(dtpRegistrationDate.Text);
                    objPR.Address = txtAddress.Text;
                    objPR.PhoneNumber = txtPhoneNumber.Text;
                    objPR.Email = Convert.ToString(txtEmail.Text);
                    objPR.ReferralDcotorName = txtReferralDoctorname.Text;
                    objPR.Amount = int.Parse(txtAmount.Text);
                    PatientRegResult = objPR.InsertPatientDetails(objPR);
                    if (PatientRegResult == 1)
                    {
                        MessageBox.Show("Patient Registration" + ConstatntMessages.strSaveSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PrintPreview obj = new PrintPreview();
                        var datetime = DateTime.Now;
                        int hour = Extension.GetTwelveCycleHour(datetime);
                        int min = datetime.Minute;
                        string s = datetime.ToString("tt", CultureInfo.InvariantCulture);
                        obj.lblPatientName.Text = txtFirstName.Text + " " + txtLastName.Text;
                        obj.lblAge.Text = txtAge.Text;
                        obj.lblTime.Text = Convert.ToString(hour) + ":" + Convert.ToString(min) + s;
                        obj.lblBillDate.Text = dtpRegistrationDate.Text;
                        obj.lblGender.Text = cbGender.Text;
                        obj.lblPhoneNumber.Text = txtPhoneNumber.Text;
                        obj.lblConsultantDoctor.Text = cbDoctorName.Text;
                        obj.lblReferredDoctor.Text = txtReferralDoctorname.Text;
                        obj.lblAmountReceived.Text = "Total Sum of Rupees " + txtAmount.Text + "/-";
                        ClearFields();
                        this.Close();
                        obj.Show();
                    }
                }
                else
                {
                    MessageBox.Show("All fields are Mandatory", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }
        private void ClearFields()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAge.Text = string.Empty;
            cbMaritalStatus.SelectedValue = 0;
            cbGender.SelectedValue = 0;
            txtAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtReferralDoctorname.Text = string.Empty;
            txtAmount.Text = string.Empty;
            cbDoctorName.SelectedValue = "0";

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
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StaffWelcome objSW = new StaffWelcome();
            this.Close();
            objSW.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtSearchPhone.Text != "" && chkbSearchPhone.Checked == false)
            {
                objHRPatientList = new BALHRPatientList();
                objHRPatientList.Name = txtName.Text;
                objHRPatientList.Phonenumber = Convert.ToString(txtSearchPhone.Text);
                BindingPatientDetails(objHRPatientList);
            }
            else if (txtSearchPhone.Text != "" && chkbSearchPhone.Checked == true)
            {
                objHRPatientList = new BALHRPatientList();
                objHRPatientList.Name = txtName.Text;
                objHRPatientList.Phonenumber = Convert.ToString(txtSearchPhone.Text);
                BindingPhoneBookingPatientList(objHRPatientList);
            }
            else
            {
                MessageBox.Show("Please Enter Phone Number", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BindingPhoneBookingPatientList(BALHRPatientList objPhoneBookingList)
        {
            dtHRPatientList = new DataTable();
            objHRPatientList = new BALHRPatientList();
            try
            {
                dtHRPatientList = objHRPatientList.SearchPhoneReg(objPhoneBookingList);
                if (dtHRPatientList != null && dtHRPatientList.Rows.Count > 0)
                {
                    txtAddress.Text = Convert.ToString(dtHRPatientList.Rows[0]["Addr"]);
                    txtPhoneNumber.Text = Convert.ToString(dtHRPatientList.Rows[0]["Phno"]);
                    cbDoctorName.SelectedValue = Convert.ToString(dtHRPatientList.Rows[0]["StaffID"]);
                    cbGender.SelectedValue = int.Parse(Convert.ToString(dtHRPatientList.Rows[0]["Sex"]));
                    cbMaritalStatus.SelectedValue = int.Parse(Convert.ToString(dtHRPatientList.Rows[0]["MaritalStatus"]));
                    txtFirstName.Text = Convert.ToString(dtHRPatientList.Rows[0]["Name"]);
                    txtLastName.Text = Convert.ToString(dtHRPatientList.Rows[0]["LastName"]);
                    txtAge.Text = Convert.ToString(dtHRPatientList.Rows[0]["Age"]);
                    txtEmail.Text = Convert.ToString(dtHRPatientList.Rows[0]["Email"]);
                    txtReferralDoctorname.Text = Convert.ToString(dtHRPatientList.Rows[0]["ReferalDoctor"]);
                    TimeSpan ts = Convert.ToDateTime(DateTime.Now) - Convert.ToDateTime(dtHRPatientList.Rows[0]["Registrationdate"]);

                    if (ts.TotalDays > Convert.ToInt16(ConfigurationSettings.AppSettings.Get("OPValidity")))
                    {
                        txtAmount.Text = "0";

                    }
                    else
                    {
                        txtAmount.Text = "0";
                        if (Convert.ToDateTime(DateTime.Now).ToShortDateString().Equals(Convert.ToDateTime(dtHRPatientList.Rows[0]["Registrationdate"]).ToShortDateString()))
                        {
                            txtAmount.ReadOnly = false;
                        }

                        else
                        {
                            txtAmount.ReadOnly = true;
                        }
                    }
                    txtFirstName.ReadOnly = true;
                    txtLastName.ReadOnly = false;
                    txtAge.ReadOnly = true;
                    txtEmail.ReadOnly = false;
                    txtPhoneNumber.Enabled = false;
                    txtReferralDoctorname.ReadOnly = false;
                    dtpRegistrationDate.Enabled = false;
                    cbMaritalStatus.Enabled = false;
                    cbGender.Enabled = false;
                    cbDoctorName.Enabled = false;
                    gbPatientRegistration.Visible = true;
                }
                else
                {
                    gbPatientRegistration.Visible = true;
                    txtFirstName.ReadOnly = false;
                    txtLastName.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    dtpRegistrationDate.Enabled = true;
                    txtPhoneNumber.Enabled = true;
                    gbPatientRegistration.Visible = true;
                    cbDoctorName.Enabled = true;
                    cbGender.Enabled = true;
                    txtAmount.ReadOnly = false;
                    txtPhoneNumber.ReadOnly = false;
                    cbDoctorName.SelectedValue = "0";
                    cbGender.SelectedValue = 0;
                    cbMaritalStatus.SelectedValue = 0;
                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    txtAge.Text = string.Empty;
                    txtPhoneNumber.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtReferralDoctorname.Text = string.Empty;
                    txtAmount.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                }

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
                dtHRPatientList = objHRPatientList.SearchPR(objHRPatientListParameters);
                if (dtHRPatientList != null && dtHRPatientList.Rows.Count > 0)
                {
                    txtAddress.Text = Convert.ToString(dtHRPatientList.Rows[0]["Addr"]);
                    txtPhoneNumber.Text = Convert.ToString(dtHRPatientList.Rows[0]["Phno"]);
                    cbDoctorName.SelectedValue = Convert.ToString(dtHRPatientList.Rows[0]["StaffID"]);
                    cbGender.SelectedValue = int.Parse(Convert.ToString(dtHRPatientList.Rows[0]["Sex"]));
                    cbMaritalStatus.SelectedValue = int.Parse(Convert.ToString(dtHRPatientList.Rows[0]["MaritalStatus"]));
                    txtFirstName.Text = Convert.ToString(dtHRPatientList.Rows[0]["FirstName"]);
                    txtLastName.Text = Convert.ToString(dtHRPatientList.Rows[0]["LastName"]);
                    txtAge.Text = Convert.ToString(dtHRPatientList.Rows[0]["Age"]);
                    txtEmail.Text = Convert.ToString(dtHRPatientList.Rows[0]["Email"]);
                    txtReferralDoctorname.Text = Convert.ToString(dtHRPatientList.Rows[0]["ReferalDoctor"]);
                    TimeSpan ts = Convert.ToDateTime(DateTime.Now) - Convert.ToDateTime(dtHRPatientList.Rows[0]["Registrationdate"]);
                    if (ts.TotalDays > Convert.ToInt16(ConfigurationSettings.AppSettings.Get("OPValidity")))
                        txtAmount.Text = Convert.ToString(dtHRPatientList.Rows[0]["Amount"]);
                    else
                    {
                        txtAmount.Text = "0";
                        txtAmount.ReadOnly = true;
                    }
                    txtFirstName.ReadOnly = true;
                    txtLastName.ReadOnly = true;
                    //txtAge.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    //txtReferralDoctorname.ReadOnly = true;
                    dtpRegistrationDate.Enabled = false;
                    //cbMaritalStatus.Enabled = false;
                    txtPhoneNumber.Enabled = false;
                    cbGender.Enabled = false;
                    cbDoctorName.Enabled = false;
                    gbPatientRegistration.Visible = true;

                }
                else
                {
                    txtFirstName.ReadOnly = false;
                    txtLastName.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    dtpRegistrationDate.Enabled = true;
                    txtPhoneNumber.Enabled = true;
                    gbPatientRegistration.Visible = true;
                    cbDoctorName.Enabled = true;
                    cbGender.Enabled = true;
                    txtAmount.ReadOnly = false;
                    txtPhoneNumber.ReadOnly = false;
                    cbDoctorName.SelectedValue = "0";
                    cbGender.SelectedValue = 0;
                    cbMaritalStatus.SelectedValue = 0;
                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    txtAge.Text = string.Empty;
                    txtPhoneNumber.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtReferralDoctorname.Text = string.Empty;
                    txtAmount.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                }
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

        private void txtSearchPhone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z\b]"))
                e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z\b]"))
                e.Handled = true;
        }

        private void txtReferralDoctorname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z\b]"))
                e.Handled = true;
        }

        private void btnGeneratePhno_Click(object sender, EventArgs e)
        {
            StaticMethods objStaticMethods = new StaticMethods();
            if (txtPhoneNumber.Text == string.Empty)
            {
                txtPhoneNumber.Text = objStaticMethods.GenerateNumber();
            }
        }

    }
    public static class Extension
    {
        public static int GetTwelveCycleHour(this DateTime dateTime)
        {
            if (dateTime.Hour > 12)
            {
                return dateTime.Hour - 12;
            }

            return dateTime.Hour;
        }
    }
}
