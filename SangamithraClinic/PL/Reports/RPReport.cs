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
    public partial class RPReport : Form
    {
        YearBind objYear = null;
        BALReports ObjReports = null;
        DataSet dsTotalPatients = null;
        int ddlYear;
        public RPReport()
        {
            InitializeComponent();
        }

        private void RPReport_Load(object sender, EventArgs e)
        {
            try
            {
                BindYear();
                ddlYear = DateTime.Now.Year;
                cbYear.SelectedValue = ddlYear;
                BindTotalPatients(ddlYear);

            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
            this.rptvRepeatedPatients.RefreshReport();
        }
        private void BindTotalPatients(int yearvalue)
        {
            dsTotalPatients = new DataSet();
            ObjReports = new BALReports();
            dsTotalPatients = ObjReports.GetRepeatedPatients(yearvalue);
            ReportDataSource rpdatasource = new ReportDataSource("RepeatedPatients", dsTotalPatients.Tables[0]);
            this.rptvRepeatedPatients.LocalReport.DataSources.Clear();
            this.rptvRepeatedPatients.LocalReport.DataSources.Add(rpdatasource);
            this.rptvRepeatedPatients.RefreshReport();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainWindowReports objReports = new MainWindowReports();
            this.Close();
            objReports.Show();
        }

        private void cbYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ddlYear = int.Parse(cbYear.Text);
            BindTotalPatients(ddlYear);
        }
    }
}
