using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SangamithraClinic.PL.Admin;
using SangamithraClinic.PL;

namespace SangamithraClinic
{
    public partial class DoctorWelcome : Form
    {
        private int yPos = 300;
        public DoctorWelcome()
        {
            InitializeComponent();
        }

        private void DoctorWelcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yPos == -900)
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

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            DoctorPatientList objDoctorPL = new DoctorPatientList();
            this.Close();
            objDoctorPL.Show();
        }

        private void btnPatientTrackRecord_Click(object sender, EventArgs e)
        {
            DownLoadReports objDownloadRep = new DownLoadReports();
            this.Close();
            objDownloadRep.Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Close();
            objLogin.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MainWindowReports objReports = new MainWindowReports();
            this.Close();
            objReports.Show();
        }

        private void lblAddDisease_Click(object sender, EventArgs e)
        {
            DiseaseList objDL = new DiseaseList();
            this.Close();
            objDL.Show();
        }

        private void lblAddTestItems_Click(object sender, EventArgs e)
        {
            TestList objTL = new TestList();
            this.Close();
            objTL.Show();
        }
    }
}
