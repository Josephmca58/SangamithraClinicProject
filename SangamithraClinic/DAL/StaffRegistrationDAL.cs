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
    class StaffRegistrationDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbSangamithraClinicConnectionString"].ConnectionString;
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
        internal int InsertStaffRegristration(BAL.BALStaffRegistration obj)
        {
            int n;
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strStaffRegistration_SP, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StaffId", obj.StaffID);
                cmd.Parameters.AddWithValue("@UserID", obj.UserList);
                cmd.Parameters.AddWithValue("@UserName", obj.UserName);
                cmd.Parameters.AddWithValue("@StaffName", obj.StaffName);
                cmd.Parameters.AddWithValue("@PWD", obj.Password);
                cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                cmd.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
                n = cmd.ExecuteNonQuery();
                con.Close();
                return n;

            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return 0;
            }

        }

        internal string GetStaffID()
        {
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                string staffID = string.Empty;
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_GET_StaffID_SP, con);
                cmd.CommandType = CommandType.StoredProcedure;
                staffID = cmd.ExecuteScalar().ToString();
                //SqlParameter outPutParameter = new SqlParameter();
                //outPutParameter.ParameterName = "@STAFFID";
                //outPutParameter.SqlDbType = SqlDbType.VarChar;
                //outPutParameter.Direction = ParameterDirection.Output;
                //cmd.ExecuteNonQuery();
                //cmd.ExecuteReader()
                //string staffID = outPutParameter.Value.ToString();
                //con.Close();
                return staffID;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return string.Empty;
            }
        }
        internal DataSet StaffDetails()
        {
            try
            {
                DataSet ds = new DataSet();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                // SqlCommand cmd = new SqlCommand(ConstatntMessages.strUSP_GET_STAFFDETAILS, con);
                da = new SqlDataAdapter(ConstatntMessages.strUSP_GET_STAFFDETAILS, con);
                da.Fill(ds);
                return ds;
                ///cmd.CommandType = CommandType.StoredProcedure;
                // ds = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return null;
            }
        }

        internal DataTable GetStaffDetailsByID(string strRowID)
        {
            try
            {
                DataTable dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_ADMIN_GET_STAFFDETAILSBYID, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StaffID", strRowID);
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

        internal int UpdateStaffRegristration(BAL.BALStaffRegistration objStaffRegistration)
        {
            int n;
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_ADMIN_UPDATE_STAFFDETAILS, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StaffId", objStaffRegistration.StaffID);
                cmd.Parameters.AddWithValue("@UserID", objStaffRegistration.UserList);
                cmd.Parameters.AddWithValue("@UserName", objStaffRegistration.UserName);
                cmd.Parameters.AddWithValue("@StaffName", objStaffRegistration.StaffName);
                cmd.Parameters.AddWithValue("@PWD", objStaffRegistration.Password);
                cmd.Parameters.AddWithValue("@Gender", objStaffRegistration.Gender);
                cmd.Parameters.AddWithValue("@PhoneNumber", objStaffRegistration.PhoneNumber);
                n = cmd.ExecuteNonQuery();
                con.Close();
                return n;

            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return 0;
            }
        }

        internal int DeleteStaffRegristration(string strRowID)
        {
            int n;
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_ADMIN_DELETE_STAFFDETAILS, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StaffId", strRowID);
                n = cmd.ExecuteNonQuery();
                con.Close();
                return n;

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
