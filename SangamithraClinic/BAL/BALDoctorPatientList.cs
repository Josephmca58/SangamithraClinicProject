using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SangamithraClinic.DAL;
using System.Data;

namespace SangamithraClinic.BAL
{
    class BALDoctorPatientList
    {
        //Properties.
        public string DoctorName { get; set; }
        public string Name { get; set; }
        public string RegistrationDate { get; set; }
        public string Phonenumber { get; set; }
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DoctorPatientListDAL objDoctorPatientListDAL = null;
        internal DataSet GeHRPatientList(BALDoctorPatientList objDoctorPatientList)
        {
            objDoctorPatientListDAL = new DoctorPatientListDAL();
            try
            {
                ds = objDoctorPatientListDAL.GetDoctorPatientDetails(objDoctorPatientList);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
