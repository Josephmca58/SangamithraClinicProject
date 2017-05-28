using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SangamithraClinic.PL.Staff;
using SangamithraClinic.PL.Admin;

namespace SangamithraClinic
{
    public partial class StaffWelcome : Form
    {
        private int yPos = 300;
        public StaffWelcome()
        {
            InitializeComponent();
        }

        private void StaffWelcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yPos==-900)
            {
                yPos = 300;
                lblMarquee.Location = new System.Drawing.Point(3, yPos);   
            }
            else
            {
                this.lblMarquee.Location = new System.Drawing.Point(3, yPos);
                yPos--;
            }
        }

        private void btnPatientRegistration_Click(object sender, EventArgs e)
        {
            PatientRegistration objPatientReg = new PatientRegistration();
            this.Close();
            objPatientReg.Show();
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            PatientList objPatientList = new PatientList();
            this.Close();
            objPatientList.Show();
        }

        private void btnPatientTrackRecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User role should be doctor to access this!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Close();
            objLogin.Show();
        }

        private void lblPhoneBooking_Click(object sender, EventArgs e)
        {
            PhoneBooking objPB = new PhoneBooking();
            this.Close();
            objPB.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
