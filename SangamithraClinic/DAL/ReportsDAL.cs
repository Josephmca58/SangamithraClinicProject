using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SangamithraClinic.Constants;
using SangamithraClinic.Common;
using System.Configuration;
namespace SangamithraClinic.DAL
{
    class ReportsDAL
    {
        #region(Global Variables)
        public DataTable dt;
        public int CrudResult;
        string connectionString = ConfigurationManager.ConnectionStrings["dbSangamithraClinicConnectionString"].ConnectionString;
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
    
        #endregion

        internal System.Data.DataTable GetOnlyYear()
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_GetYears, con);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return null;
            }
        }

        internal DataSet GetTotalPatientsReport(int yearValue)
        {
            try
            {
                DataSet ds = new DataSet();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_Reports_GetTotalPatients, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", yearValue);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return null;
            }
        }

        internal DataSet GetRepeatedPatientsReport(int yearvalue)
        {
            try
            {
                DataSet ds = new DataSet();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_Reports_RepeatedPatients, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", yearvalue);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return null;
            }
        }

        internal DataSet GetDiseasePatientsReport(int ddlYear)
        {
            try
            {
                DataSet ds = new DataSet();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUsp_Reports_TotalPatients_Diseases, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", ddlYear);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return null;
            }
        }
    }
}
