using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SangamithraClinic.DAL;

namespace SangamithraClinic.BAL
{
    class BALPatientRegistration
    {
        //Properties for Patient Registration.
        PatientRegistrationDAL objPatientDAL = null;
        int CrudResult;
        public Guid PatientID { get; set; }
        public string DoctorName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime RegDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ReferralDcotorName { get; set; }
        public int Amount { get; set; }

        //Public Methods to interact with DAL.

        internal int InsertPatientDetails(BALPatientRegistration objPR)
        {
            try
            {
                objPatientDAL = new PatientRegistrationDAL();
                CrudResult = objPatientDAL.InsertPatientDetails(objPR);
                return CrudResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
