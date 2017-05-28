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

namespace SangamithraClinic.PL.Staff
{
    public partial class GeneralCheckup : Form
    {
        Guid EditPID;
        string PatientName;
        BALGeneralCheckup objGeneralCheckup = null;
        int GeneralCheckupResult;
        public GeneralCheckup()
        {
            InitializeComponent();
        }
        public GeneralCheckup(Guid PID, string strPatientName)
        {
            this.EditPID = PID;
            this.PatientName = strPatientName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GeneralCheckup_Load(object sender, EventArgs e)
        {
            try
            {
                txtPatientName.Text = this.PatientName;
                txtHeight.Text = "0";
                txtWeight.Text = "0";
                txtFever.Text = "0";
                txtBP.Text = "0";
                if (txtPatientName.Text != string.Empty)
                {
                    btnSave.Enabled = true;
                }
                else
                    btnSave.Enabled = false;

                BindSugarResult();
            }
            catch (Exception ex)
            {

                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }

        }
        private void BindSugarResult()
        {
            cbSugar.DataSource = StaticMethods.GetSugarMethod();
            cbSugar.DisplayMember = "Text";
            cbSugar.ValueMember = "Value";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objGeneralCheckup = new BALGeneralCheckup();
            try
            {
                //if (txtPatientName.Text != string.Empty && txtWeight.Text != string.Empty && txtHeight.Text != string.Empty && txtFever.Text != string.Empty && txtBP.Text != string.Empty)
                //{
                if (txtPatientName.Text != string.Empty)
                {
                    objGeneralCheckup.GeneralCheckupID = Guid.NewGuid();
                    objGeneralCheckup.PatientID = this.EditPID;
                    objGeneralCheckup.Height = txtHeight.Text == "0" ? decimal.Parse("0.00") : decimal.Parse(txtHeight.Text);
                    objGeneralCheckup.Weight = txtWeight.Text == "0" ? int.Parse("0") : int.Parse(txtWeight.Text);
                    objGeneralCheckup.Fever = txtFever.Text == "0" ? decimal.Parse("0.0") : decimal.Parse(txtFever.Text);
                    objGeneralCheckup.Sugar = int.Parse(cbSugar.SelectedValue.ToString());
                    objGeneralCheckup.BP = txtBP.Text == "0" ? string.Empty : txtBP.Text;
                    objGeneralCheckup.InsertStatus = 1;
                    GeneralCheckupResult = objGeneralCheckup.InsertGeneralCheckupDetails(objGeneralCheckup);
                    if (GeneralCheckupResult == 1)
                    {
                        bool status = true;
                        MessageBox.Show("General Checkup" + ConstatntMessages.strSaveSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PatientList objHRPatientList = new PatientList(status, this.EditPID);
                        this.Close();
                        objHRPatientList.Show();
                    }
                }
                else
                {
                    btnSave.Enabled = false;
                }

                //}
                //else
                //{
                //    MessageBox.Show("All fields are Mandatory");
                //}
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }
        private void ClearFields()
        {
            txtPatientName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtHeight.Text = string.Empty;
            txtFever.Text = string.Empty;
            txtBP.Text = string.Empty;
            cbSugar.SelectedValue = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PatientList objPL = new PatientList();
            this.Close();
            objPL.Show();
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFever_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
