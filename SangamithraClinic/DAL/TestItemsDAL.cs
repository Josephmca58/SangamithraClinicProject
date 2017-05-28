using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SangamithraClinic.Constants;
using SangamithraClinic.BAL;
using SangamithraClinic.Common;

namespace SangamithraClinic.DAL
{
    class TestItemsDAL
    {
        #region(Global Variables)
        public DataTable dt;
        public int CrudResult;
        string connectionString = ConfigurationManager.ConnectionStrings["dbSangamithraClinicConnectionString"].ConnectionString;
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
        #endregion
        internal DataTable GetDiSeaesNames(string staffID)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_GET_DISEASENAMES, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StaffID", staffID);
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

        internal DataTable GetTestList(BAL.BALTestITems objTestItems)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_ADMIN_INVESTIGATIONSEARCH, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DISEASEID", objTestItems.DiseaseID);
                cmd.Parameters.AddWithValue("@TESTENAME", objTestItems.TestName);
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

        internal int InsertDisease(BAL.BALTestITems objTestItems)
        {
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_INSERT_TESTITEMS, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TestID", objTestItems.TestID);
                cmd.Parameters.AddWithValue("@DiseaseID", objTestItems.DiseaseID);
                cmd.Parameters.AddWithValue("@TestName", objTestItems.TestName);
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

        internal DataTable GetTestListByID(string rowID)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_GET_TESTITEMSBYID, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TestID", rowID);
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

        public int UpdateTestItems(BAL.BALTestITems objTestItems)
        {
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_UPDATE_tbl_admin_InvestigationItemList, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DiseaseID", objTestItems.DiseaseID);
                cmd.Parameters.AddWithValue("@TestName", objTestItems.TestName);
                cmd.Parameters.AddWithValue("@TestID", objTestItems.TestID);
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

        internal int DeleteTestItems(string rowID)
        {
            try
            {
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                con.Open();
                cmd = new SqlCommand(ConstatntMessages.strUSP_DELETE_tbl_admin_InvestigationItemList, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TestID", rowID);
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
