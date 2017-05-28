using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SangamithraClinic.DAL;
using System.Data;
namespace SangamithraClinic.BAL
{
    class BALLogin
    {
        //properties.
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserStaus = string.Empty;
        LoginDAL objLogin = null;
        DataTable dtBAL = null;
        public DataTable  UserType(BALLogin objBALLogin)
        {
            try
            {
                objLogin = new LoginDAL();
                dtBAL = objLogin.GetStaffID(objBALLogin);
                //UserStaus = objLogin.GetStaffID(objBALLogin) == "0" ? string.Empty : objLogin.GetStaffID(objBALLogin);
                return dtBAL;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
