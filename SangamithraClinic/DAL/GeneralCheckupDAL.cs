using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SangamithraClinic.Constants;
using SangamithraClinic.Common;
namespace SangamithraClinic.DAL
{
    class GeneralCheckupDAL
    {
        #region(Public Variables)
        public DataTable dt;
        public int CrudResult;
        string connectionString = ConfigurationManager.ConnectionStrings["dbSangamithraClinicConnectionString"].ConnectionString;
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
        #endregion
        internal int InsertGeneralCheckupDetails(BAL.BALGeneralCheckup objGeneralCheckup)
        {
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_INSERT_GENERALCHECKUPDETAILS, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GeneralCheckupID", objGeneralCheckup.GeneralCheckupID);
                cmd.Parameters.AddWithValue("@PID", objGeneralCheckup.PatientID);
                cmd.Parameters.AddWithValue("@Height", objGeneralCheckup.Height);
                cmd.Parameters.AddWithValue("@Weight", objGeneralCheckup.Weight);
                cmd.Parameters.AddWithValue("@Fever", objGeneralCheckup.Fever);
                cmd.Parameters.AddWithValue("@Sugar", objGeneralCheckup.Sugar);
                cmd.Parameters.AddWithValue("@BP", objGeneralCheckup.BP);
                cmd.Parameters.AddWithValue("@InsertStatus", objGeneralCheckup.InsertStatus);
                CrudResult = cmd.ExecuteNonQuery();
                con.Close();
                return CrudResult;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return 0;
            }
        }
    }
}
