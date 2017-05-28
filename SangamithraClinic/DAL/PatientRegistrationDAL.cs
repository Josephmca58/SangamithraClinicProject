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
    class PatientRegistrationDAL
    {
        #region(Public Variables)
        public DataTable dt;
        public int CrudResult;
        string connectionString = ConfigurationManager.ConnectionStrings["dbSangamithraClinicConnectionString"].ConnectionString;
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
        #endregion
        internal int InsertPatientDetails(BAL.BALPatientRegistration objPR)
        {
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_INSERT_PATIENTDETAILS, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PId", objPR.PatientID);
                cmd.Parameters.AddWithValue("@StaffID", objPR.DoctorName);
                cmd.Parameters.AddWithValue("@FirstName", objPR.FirstName);
                cmd.Parameters.AddWithValue("@LastName", objPR.LastName);
                cmd.Parameters.AddWithValue("@Age", objPR.Age);
                cmd.Parameters.AddWithValue("@MaritalStatus", objPR.MaritalStatus);
                cmd.Parameters.AddWithValue("@Sex", objPR.Gender);
                cmd.Parameters.AddWithValue("@RegDate", objPR.RegDate);
                cmd.Parameters.AddWithValue("@Addr", objPR.Address);
                cmd.Parameters.AddWithValue("@PhoneNum", objPR.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", objPR.Email);
                cmd.Parameters.AddWithValue("@RefferalDoctorName", objPR.ReferralDcotorName);
                cmd.Parameters.AddWithValue("@Amount", objPR.Amount);
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
