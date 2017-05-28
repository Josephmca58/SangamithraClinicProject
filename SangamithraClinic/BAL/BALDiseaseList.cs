using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SangamithraClinic.DAL;

namespace SangamithraClinic.BAL
{
    class BALDiseaseList
    {
        #region(Public Variable)
        DataTable dt = null;
        DiseaseDAL objDisease = new DiseaseDAL();
        int CrudResult;
        #endregion
        #region(Properties of Diseases)
        public string DoctorName { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseID { get; set; }
        #endregion
        #region(Public Methods.)
        /// <summary>
        /// Get DoctorNames
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable GetDoctorNames()
        {
            dt = new DataTable();
            try
            {
                dt = objDisease.GetDoctorNames();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Insert Disease List
        /// </summary>
        /// <param name="ObjDiseaseList"></param>
        /// <returns>CrudResult </returns>
        public int InsertDiseaseList(BALDiseaseList ObjDiseaseList)
        {
            CrudResult = objDisease.InsertDisease(ObjDiseaseList);
            return CrudResult;
        }
        /// <summary>
        /// Get All Diseses List
        /// </summary>
        /// <param name="ObjDiseaseList"></param>
        /// <returns>dt</returns>
        public DataTable GetDisesesList(BALDiseaseList ObjDiseaseList)
        {
            try
            {
                dt = objDisease.GetDiseases(ObjDiseaseList);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetDiseaseListByID(string rowID)
        {
            try
            {
                dt =objDisease.DiseaseListByID(rowID);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteRecord(string rowID)
        {
            CrudResult = objDisease.DeleteDisease(rowID);
            return CrudResult;
        }
        public int UpdateDiseaseList(BALDiseaseList ObjDiseaseList)
        {
            CrudResult = objDisease.UpdateDisease(ObjDiseaseList);
            return CrudResult;
        }
        #endregion









       
    }
}
