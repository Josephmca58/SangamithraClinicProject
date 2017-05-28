using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SangamithraClinic.DAL;

namespace SangamithraClinic.BAL
{
    class BALPhoneBookingDetails
    {
        //Global Variables.
        int CrudResult;
        PhoneBookingDAL objPhoneBooking = null;
        //Properties List
        public Guid PatientID { get; set; }
        public string DoctorName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime RegDate { get; set; }
        public string PhoneNumber { get; set; }
        public int Amount { get; set; }



        internal int InsertPhoneReg(BALPhoneBookingDetails objPhoneBookingDetails)
        {
            try
            {
                objPhoneBooking = new PhoneBookingDAL();
                CrudResult = objPhoneBooking.InsertPhoneBookingDetails(objPhoneBookingDetails);
                return CrudResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
