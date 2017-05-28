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
    class HRPatientListDAL
    {
        DataTable dt = new DataTable();
        string connectionString = ConfigurationManager.ConnectionStrings["dbSangamithraClinicConnectionString"].ConnectionString;
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
        internal System.Data.DataTable GetHRPatientDetails(BAL.BALHRPatientList objHRPatientListParameters)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_PUBLIC_HRPATIENTLIST, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DoctorName", objHRPatientListParameters.DoctorName);
                cmd.Parameters.AddWithValue("@NAME", objHRPatientListParameters.Name);
                cmd.Parameters.AddWithValue("@DATE", objHRPatientListParameters.RegistrationDate);
                cmd.Parameters.AddWithValue("@PHNO", objHRPatientListParameters.Phonenumber);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
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

        internal System.Data.DataTable GetSearchPR(BAL.BALHRPatientList objHRPatientListParameters)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_Public_StaffRegSearch, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", objHRPatientListParameters.Name);
                cmd.Parameters.AddWithValue("@PHNO", objHRPatientListParameters.Phonenumber);
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

        internal DataTable GetSearchPhoneReg(BAL.BALHRPatientList objPhoneBookingList)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_Public_PhoneRegSearch, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", objPhoneBookingList.Name);
                cmd.Parameters.AddWithValue("@PHNO", objPhoneBookingList.Phonenumber);
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

        internal string TotalPatients(string p)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_TotalPatients, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CurrentDate", Convert.ToDateTime(p));
                SqlParameter pvNewId = new SqlParameter();
                pvNewId.ParameterName = "@returnValue";

                pvNewId.DbType = DbType.Int16;
                pvNewId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pvNewId);
                con.Open();
                int n = (int)cmd.ExecuteScalar();
                string s = Convert.ToString(n);
                con.Close();
                return s;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return null;
            }
        }

        internal string TotalRepeatedPatients()
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_GetRepeatedPatients, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pvNewId = new SqlParameter();
                pvNewId.ParameterName = "@returnValue";

                pvNewId.DbType = DbType.Int16;
                pvNewId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pvNewId);
                con.Open();
                int n = (int)cmd.ExecuteScalar();
                string s = Convert.ToString(n);
                con.Close();
                return s;
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
