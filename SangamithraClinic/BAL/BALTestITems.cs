using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SangamithraClinic.DAL;
namespace SangamithraClinic.BAL
{
    class BALTestITems
    {
        #region(Public Variables.)
        DataTable dtDiseses = null;
        TestItemsDAL objTestITems = null;
        int CrudResult;
        #endregion
        #region(Properites)
        public string DiseaseID { get; set; }
        public string TestName { get; set; }
        public string TestID { get; set; }
        #endregion

        public DataTable GetDiseaseNames(string staffID)
        {
            dtDiseses = new DataTable();
            objTestITems = new TestItemsDAL();
            try
            {
                dtDiseses = objTestITems.GetDiSeaesNames(staffID);
                return dtDiseses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable GetTestItemsList(BALTestITems objTestItems)
        {
            dtDiseses = new DataTable();
            objTestITems = new TestItemsDAL();
            try
            {
                dtDiseses = objTestITems.GetTestList(objTestItems);
                return dtDiseses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal int UpdateDiseaseList(BALTestITems objTestItems)
        {
            try
            {
                objTestITems = new TestItemsDAL();
                CrudResult = objTestITems.UpdateTestItems(objTestItems);
                return CrudResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal int InsertDiseaseList(BALTestITems objTestItems)
        {
            objTestITems = new TestItemsDAL();
            CrudResult = objTestITems.InsertDisease(objTestItems);
            return CrudResult;
        }

        internal DataTable GetTestNamesByID(string rowID)
        {
            dtDiseses = new DataTable();
            objTestITems = new TestItemsDAL();
            try
            {
                dtDiseses = objTestITems.GetTestListByID(rowID);
                return dtDiseses;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteRecord(string rowID)
        {
            try
            {
                objTestITems = new TestItemsDAL();
                CrudResult = objTestITems.DeleteTestItems(rowID);
                return CrudResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
