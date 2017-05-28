using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SangamithraClinic.Common;
using Microsoft.Reporting.WinForms;
using SangamithraClinic.BAL;
namespace SangamithraClinic.PL.Reports
{
    public partial class DiseasesReport : Form
    {
        YearBind objYear = null;
        BALReports ObjReports = null;
        DataSet dsDiseasePatients = null;
        int ddlYear;
        public DiseasesReport()
        {
            InitializeComponent();
        }

        private void DiseasesReport_Load(object sender, EventArgs e)
        {
            try
            {
                BindYear();
                ddlYear = DateTime.Now.Year;
                cbYear.SelectedValue = ddlYear;
                BindDiseasePatients(ddlYear);

            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
            this.reportViewer1.RefreshReport();
        }

        private void BindYear()
        {
            try
            {

                objYear = new YearBind();
                cbYear.DataSource = objYear.liYears();
                cbYear.DisplayMember = "Text";
                cbYear.ValueMember = "Value";
                cbYear.SelectedText = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDiseasePatients(int ddlYear)
        {
            dsDiseasePatients = new DataSet();
            ObjReports = new BALReports();
            dsDiseasePatients = ObjReports.GetDiseasePatients(ddlYear);
            ReportDataSource rpdatasource = new ReportDataSource("DiseasePatients", dsDiseasePatients.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rpdatasource);
            this.reportViewer1.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainWindowReports objReports = new MainWindowReports();
            this.Close();
            objReports.Show();
        }

        private void cbYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ddlYear = int.Parse(cbYear.Text);
            BindDiseasePatients(ddlYear);
        }
    }
}
