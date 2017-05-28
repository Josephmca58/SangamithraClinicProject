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
    class DiseaseDAL
    {
        #region(Public Variables)
        public DataTable dt;
        public int CrudResult;
        string connectionString = ConfigurationManager.ConnectionStrings["dbSangamithraClinicConnectionString"].ConnectionString;
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
        #endregion
        #region(Public Methods)
        public DataTable GetDoctorNames()
        {
            try
            {
                dt = new DataTable();
                SqlConnection con = new SqlConnection(ConstatntMessages.strConnectionString);
                //con = new SqlConnection(connectionString);
                da = new SqlDataAdapter(ConstatntMessages.strUSP_GET_DOCTORNAMES, con);
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
        public int InsertDisease(BAL.BALDiseaseList ObjDiseaseList)
        {
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_INSERT_DISEASELIST, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DiseaseID", ObjDiseaseList.DiseaseID);
                cmd.Parameters.AddWithValue("@StaffID", ObjDiseaseList.DoctorName);
                cmd.Parameters.AddWithValue("@DiseaseName", ObjDiseaseList.DiseaseName);
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
        public DataTable GetDiseases(BAL.BALDiseaseList ObjDiseaseList)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_ADMIN_SEARCHDISEASE, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@STAFFID", ObjDiseaseList.DoctorName);
                cmd.Parameters.AddWithValue("@DISEASENAME", ObjDiseaseList.DiseaseName);
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
        public DataTable DiseaseListByID(string rowID)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_GET_DISEASELISTBYID, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DiseaseID", rowID);
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
        public int DeleteDisease(string rowID)
        {
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_DELETE_tbl_admin_DiseaseList, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DiseaseID", rowID);
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
        internal int UpdateDisease(BAL.BALDiseaseList ObjDiseaseList)
        {
            try
            {
                //con = new SqlConnection(connectionString);
                SqlConnection con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_UPDATE_tbl_admin_DiseaseList, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DiseaseID", ObjDiseaseList.DiseaseID);
                cmd.Parameters.AddWithValue("@DiseaseName", ObjDiseaseList.DiseaseName);
                cmd.Parameters.AddWithValue("@StaffID", ObjDiseaseList.DoctorName);
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
        #endregion
    }
}
