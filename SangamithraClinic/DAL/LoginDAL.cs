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
    class LoginDAL
    {
        public DataTable dt;
        public string strLoginResult = string.Empty;
        string connectionString = ConfigurationManager.ConnectionStrings["dbSangamithraClinicConnectionString"].ConnectionString;
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
        internal DataTable GetStaffID(BAL.BALLogin objBALLogin)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_GET_LOGINSTATUS, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", objBALLogin.UserName);
                cmd.Parameters.AddWithValue("@PWD", objBALLogin.Password);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                strLoginResult = Convert.ToString(dt.Rows[0]["StaffID"]);
                return dt;
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
