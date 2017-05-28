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
using SangamithraClinic.PL.Reports;
namespace SangamithraClinic.PL
{
    public partial class MainWindowReports : Form
    {
        public MainWindowReports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //cbReportList.DataSource = StaticMethods.GetReportList();//Binding Marital Status.
            //cbReportList.DisplayMember = "ReportName";
            //cbReportList.ValueMember = "ReportId";
        }

        private void lblTpShow_Click(object sender, EventArgs e)
        {
            TPReport objTPReports = new TPReport();
            this.Close();
            objTPReports.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorWelcome objDoctorWel = new DoctorWelcome();
            this.Close();
            objDoctorWel.Show();
        }

        private void lblRPShow_Click(object sender, EventArgs e)
        {
            RPReport objRPReports = new RPReport();
            this.Close();
            objRPReports.Show();
        }

        private void lblRDShow_Click(object sender, EventArgs e)
        {
            DiseasesReport objDReport = new DiseasesReport();
            this.Close();
            objDReport.Show();
                 
        }
    }
}
