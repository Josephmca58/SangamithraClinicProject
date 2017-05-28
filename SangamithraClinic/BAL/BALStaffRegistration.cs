using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SangamithraClinic.DAL;
using System.Data;
namespace SangamithraClinic.BAL
{
    class BALStaffRegistration 
    {
        public string UserList { get; set; }
        public string StaffName { get; set; }
        public string Gender { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public long PhoneNumber { get; set; }
        public string StaffID { get; set; }

        public int Insert(BALStaffRegistration obj)
        {
            int result;
            StaffRegistrationDAL objDAL = new StaffRegistrationDAL();
            result = objDAL.InsertStaffRegristration(obj);
            return result;

        }


        internal string GetStaffID()
        {
            string strStaffID;
            StaffRegistrationDAL objDAL = new StaffRegistrationDAL();
            strStaffID = objDAL.GetStaffID();
            return strStaffID;
        }



        internal System.Data.DataSet GetStaffDetails()
        {
            System.Data.DataSet ds;
            StaffRegistrationDAL objDAL = new StaffRegistrationDAL();
            ds = objDAL.StaffDetails();
            return ds;
        }

        internal System.Data.DataTable GetStaffDetailsByID(string strRowID)
        {
            DataTable dt;
            StaffRegistrationDAL objDal = new StaffRegistrationDAL();
            dt = objDal.GetStaffDetailsByID(strRowID);
            return dt;
        }

        internal int Update(BALStaffRegistration objStaffRegistration)
        {
            int result;
            StaffRegistrationDAL objDAL = new StaffRegistrationDAL();
            result = objDAL.UpdateStaffRegristration(objStaffRegistration);
            return result;
        }

        internal int Delete(string strRowID)
        {
            int result;
            StaffRegistrationDAL objDAL = new StaffRegistrationDAL();
            result = objDAL.DeleteStaffRegristration(strRowID);
            return result;
        }
    }
}
