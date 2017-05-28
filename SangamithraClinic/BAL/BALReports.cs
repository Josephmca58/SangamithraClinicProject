using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SangamithraClinic.DAL;
using SangamithraClinic.Common;

namespace SangamithraClinic.BAL
{
    class BALReports
    {
        #region(Public Variables.)
        DataTable dtYearReports = null;
        ReportsDAL objYearReports = null;
        DataSet dsTotalPatients = null;
        int CrudResult;
        #endregion
        internal DataTable GetYears()
        {
            dtYearReports = new DataTable();
            objYearReports = new ReportsDAL();
            try
            {
                dtYearReports = objYearReports.GetOnlyYear();
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
            return dtYearReports;

        }

        internal DataSet GetTotalPatients(int yearValue)
        {
            dsTotalPatients = new DataSet();
            try
            {
                objYearReports = new ReportsDAL();
                dsTotalPatients = objYearReports.GetTotalPatientsReport(yearValue);
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
            return dsTotalPatients;
        }

        internal DataSet GetRepeatedPatients(int yearvalue)
        {
            dsTotalPatients = new DataSet();
            try
            {
                objYearReports = new ReportsDAL();
                dsTotalPatients = objYearReports.GetRepeatedPatientsReport(yearvalue);
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
            return dsTotalPatients;
        }

        internal DataSet GetDiseasePatients(int ddlYear)
        {
            dsTotalPatients = new DataSet();
            try
            {
                objYearReports = new ReportsDAL();
                dsTotalPatients = objYearReports.GetDiseasePatientsReport(ddlYear);
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
            return dsTotalPatients;
        }
    }
}
