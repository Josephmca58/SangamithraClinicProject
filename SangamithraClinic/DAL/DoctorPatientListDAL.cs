using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SangamithraClinic.Common;
using SangamithraClinic.Constants;

namespace SangamithraClinic.DAL
{
    class DoctorPatientListDAL
    {
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        string connectionString = ConfigurationManager.ConnectionStrings["dbSangamithraClinicConnectionString"].ConnectionString;
        SqlConnection con = null;
        SqlDataAdapter da = null;
        SqlCommand cmd = null;
        internal DataSet GetDoctorPatientDetails(BAL.BALDoctorPatientList objDoctorPatientList)
        {
            try
            {
                dt = new DataTable();
                //con = new SqlConnection(connectionString);
                con = new SqlConnection(ConstatntMessages.strConnectionString);
                cmd = new SqlCommand(ConstatntMessages.strUSP_PUBLIC_DOCTORPATIENTLIST, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DoctorName", objDoctorPatientList.DoctorName);
                cmd.Parameters.AddWithValue("@NAME", objDoctorPatientList.Name);
                cmd.Parameters.AddWithValue("@DATE", objDoctorPatientList.RegistrationDate);
                cmd.Parameters.AddWithValue("@PHNO", objDoctorPatientList.Phonenumber);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
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
