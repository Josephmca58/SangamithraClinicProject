using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SangamithraClinic.DAL;

namespace SangamithraClinic.BAL
{
    class BALTestDetails
    {
        TestDetailsDAL objTestDetailsDAL = null;
        internal DataTable GetTestNames(string DiseaseID)
        {
            try
            {
                DataTable dt = new DataTable ();
                objTestDetailsDAL=new TestDetailsDAL ();
                dt = objTestDetailsDAL.GetTestList(DiseaseID);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal int InsertTestDetails(DataTable dtInvestigation)
        {
            try
            {
                int result;
                objTestDetailsDAL = new TestDetailsDAL();
                result = objTestDetailsDAL.SaveTestDetails(dtInvestigation);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal int InsertDocName(string p, DateTime dateTime)
        {
            try
            {
                int result;
                objTestDetailsDAL = new TestDetailsDAL();
                result = objTestDetailsDAL.SaveDocName(p,dateTime);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable GetDocNames(string strPatientName)
        {
            try
            {
                DataTable dt = new DataTable();
                objTestDetailsDAL = new TestDetailsDAL();
                dt = objTestDetailsDAL.GetDocNames(strPatientName);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
