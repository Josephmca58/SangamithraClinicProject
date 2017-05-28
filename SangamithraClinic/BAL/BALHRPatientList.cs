using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SangamithraClinic.DAL;

namespace SangamithraClinic.BAL
{
    class BALHRPatientList
    {
        //Properties..
        public string DoctorName { get; set; }
        public string Name { get; set; }
        public string RegistrationDate { get; set; }
        public string Phonenumber { get; set; }
        DataTable dt = new DataTable();
        HRPatientListDAL objHRPatientList=null;

        internal System.Data.DataTable GeHRPatientList(BALHRPatientList objHRPatientListParameters)
        {
            objHRPatientList = new HRPatientListDAL();
            try
            {
                dt = objHRPatientList.GetHRPatientDetails(objHRPatientListParameters);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal System.Data.DataTable SearchPR(BALHRPatientList objHRPatientListParameters)
        {
            objHRPatientList = new HRPatientListDAL();
            try
            {
                dt = objHRPatientList.GetSearchPR(objHRPatientListParameters);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable SearchPhoneReg(BALHRPatientList objPhoneBookingList)
        {
            objHRPatientList = new HRPatientListDAL();
            try
            {
                dt = objHRPatientList.GetSearchPhoneReg(objPhoneBookingList);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal string BindTotalPatientCount(string p)
        {
            objHRPatientList = new HRPatientListDAL();
            string Count = string.Empty;
            try
            {
                Count= objHRPatientList.TotalPatients(p);
                return Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal string BindRepeatedPatientCount()
        {
            objHRPatientList = new HRPatientListDAL();
            string Count = string.Empty;
            try
            {
                Count = objHRPatientList.TotalRepeatedPatients();
                return Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
