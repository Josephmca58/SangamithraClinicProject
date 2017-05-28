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

namespace SangamithraClinic.PL.Staff
{
    public partial class PhoneBooking : Form
    {
        BALPhoneBookingDetails objPhoneBookingDetails = null;
        DoctorNames objDoctorNames;
        int PhoneRegResult;
        public PhoneBooking()
        {
            InitializeComponent();
        }

        private void PhoneBooking_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblDate.Text = String.Format("{0:dd-MMM-yyyy}", dt);
            dtpRegistrationDate.Text = String.Format("{0:dd-MMM-yyyy}", dt);
            //Inserting PhoneBooking Details
            try
            {
                //Bind Dropdown list..
                BindDocotrsList();   //Binding dropdwon list.
                cbGender.DataSource = StaticMethods.GenderList();//Binding Marital Status.
                cbGender.DisplayMember = "Name";
                cbGender.ValueMember = "Id";
                cbMaritalStatus.DataSource = StaticMethods.GetMaritalStatus();//Binding Gender.
                cbMaritalStatus.DisplayMember = "Name";
                cbMaritalStatus.ValueMember = "Id";
                dtpRegistrationDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                throw ex;
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
                throw ex;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StaffWelcome objSW = new StaffWelcome();
            this.Close();
            objSW.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != string.Empty && txtAge.Text != string.Empty && dtpRegistrationDate.Text != string.Empty && txtPhoneNumber.Text != string.Empty && txtAmount.Text != string.Empty && Convert.ToString(cbDoctorName.SelectedValue) != "0" && Convert.ToString(cbMaritalStatus.SelectedValue) != "0" && Convert.ToString(cbGender.SelectedValue) != "0")
                {
                    objPhoneBookingDetails = new BALPhoneBookingDetails();
                    objPhoneBookingDetails.PatientID = Guid.NewGuid();
                    objPhoneBookingDetails.DoctorName = Convert.ToString(cbDoctorName.SelectedValue);
                    objPhoneBookingDetails.Name = txtName.Text;
                    objPhoneBookingDetails.Age = int.Parse(txtAge.Text);
                    objPhoneBookingDetails.MaritalStatus = Convert.ToString(cbMaritalStatus.SelectedValue);
                    objPhoneBookingDetails.Gender = Convert.ToString(cbGender.SelectedValue);
                    objPhoneBookingDetails.RegDate = Convert.ToDateTime(dtpRegistrationDate.Text);
                    objPhoneBookingDetails.PhoneNumber = txtPhoneNumber.Text;
                    objPhoneBookingDetails.Amount = int.Parse(txtAmount.Text);
                    PhoneRegResult = objPhoneBookingDetails.InsertPhoneReg(objPhoneBookingDetails);
                    if (PhoneRegResult == 1)
                    {
                        ClearFields();
                        MessageBox.Show("Phone Booking" + ConstatntMessages.strSaveSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("All fields are Mandatory", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ClearFields()
        {
            DateTime dt = DateTime.Now;
            cbDoctorName.SelectedValue = 0;
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            cbMaritalStatus.SelectedValue = 0;
            cbGender.SelectedValue = 0;
            dtpRegistrationDate.Text = dt.ToString();
            txtPhoneNumber.Text = string.Empty;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
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
}
