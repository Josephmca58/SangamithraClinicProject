using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SangamithraClinic.DAL;
namespace SangamithraClinic.BAL
{
    class BALGeneralCheckup
    {
        //Global Variables.
        public int CrudResult;
        GeneralCheckupDAL objGeneralCheckupDAL = null;

        //properites.
        public Guid GeneralCheckupID { get; set; }
        public Guid PatientID { get; set; }
        public decimal Height { get; set; }
        public int Weight { get; set; }
        public decimal Fever { get; set; }
        public int Sugar { get; set; }
        public string BP { get; set; }
        public int InsertStatus { get; set; }
        public string SugarStatus { get; set; }
        internal int InsertGeneralCheckupDetails(BALGeneralCheckup objGeneralCheckup)
        {
            try
            {
                objGeneralCheckupDAL = new GeneralCheckupDAL();
                CrudResult = objGeneralCheckupDAL.InsertGeneralCheckupDetails(objGeneralCheckup);
                return CrudResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
