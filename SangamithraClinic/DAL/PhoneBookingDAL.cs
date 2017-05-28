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
    class PhoneBookingDAL
    {
        #region(Public Variables)
        public DataTable dt=null;
        public int CrudResult;
        string connectionString = ConfigurationManager.ConnectionStrings["dbSangamithraClinicConnectionString"].ConnectionString;
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
    
        #endregion
        internal int InsertPhoneBookingDetails(BAL.BALPhoneBookingDetails objPhoneBookingDetails)
        {
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_INSERT_PHONEREGISTRATIONDETAILS, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PId", objPhoneBookingDetails.PatientID);
                cmd.Parameters.AddWithValue("@StaffID", objPhoneBookingDetails.DoctorName);
                cmd.Parameters.AddWithValue("@Name", objPhoneBookingDetails.Name);
                cmd.Parameters.AddWithValue("@Age", objPhoneBookingDetails.Age);
                cmd.Parameters.AddWithValue("@MaritalStatus", objPhoneBookingDetails.MaritalStatus);
                cmd.Parameters.AddWithValue("@Sex", objPhoneBookingDetails.Gender);
                cmd.Parameters.AddWithValue("@RegDate", objPhoneBookingDetails.RegDate);
                cmd.Parameters.AddWithValue("@PhoneNum", objPhoneBookingDetails.PhoneNumber);
                cmd.Parameters.AddWithValue("@Amount", objPhoneBookingDetails.Amount);
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
