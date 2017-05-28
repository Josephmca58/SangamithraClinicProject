using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangamithraClinic.Constants
{
    class ConstatntMessages
    {
        //Messages
        public const string strSaveSuccess = " Details Saved Successfully";
        public const string strUpdateSuccess = " Details Updated Successfully";
        public const string strDeleteSuccess = " Details Deleted Successfully";
        public const string strLoginStaus = "Username and Password did not match. \n Login Failed!";

        //strored Procedure Names
        public const string strConnectionString = "user id=sa;password=Pwd4sql2012;server=JOSEPH-PC;database=dbSangamithraClinic";
        public const string strStaffRegistration_SP = "USP_INSERT_StaffDetails";
        public const string strUSP_GET_StaffID_SP = "USP_GET_StaffID";
        public const string strUSP_GET_STAFFDETAILS = "USP_GET_STAFFDETAILS";
        public const string strUSP_ADMIN_GET_STAFFDETAILSBYID = "USP_ADMIN_GET_STAFFDETAILSBYID";
        public const string strUSP_ADMIN_UPDATE_STAFFDETAILS = "USP_ADMIN_UPDATE_STAFFDETAILS";
        public const string strUSP_ADMIN_DELETE_STAFFDETAILS = "USP_ADMIN_DELETE_STAFFDETAILS";
        public const string strUSP_GET_DOCTORNAMES = "USP_GET_DOCTORNAMES";
        public const string strUSP_INSERT_DISEASELIST = "USP_INSERT_DISEASELIST";
        public const string strUSP_ADMIN_SEARCHDISEASE = "USP_ADMIN_SEARCHDISEASE";
        public const string strUSP_GET_DISEASELISTBYID = "USP_GET_DISEASELISTBYID";
        public const string strUSP_DELETE_tbl_admin_DiseaseList = "USP_DELETE_tbl_admin_DiseaseList";
        public const string strUSP_UPDATE_tbl_admin_DiseaseList = "USP_UPDATE_tbl_admin_DiseaseList";
        public const string strUSP_GET_DISEASENAMES = "USP_GET_DISEASENAMES";
        public const string strUSP_ADMIN_INVESTIGATIONSEARCH = "USP_ADMIN_INVESTIGATIONSEARCH";
        public const string strUSP_INSERT_TESTITEMS = "USP_INSERT_TESTITEMS";
        public const string strUSP_GET_TESTITEMSBYID = "USP_GET_TESTITEMSBYID";
        public const string strUSP_UPDATE_tbl_admin_InvestigationItemList = "USP_UPDATE_tbl_admin_InvestigationItemList";
        public const string strUSP_DELETE_tbl_admin_InvestigationItemList = "USP_DELETE_tbl_admin_InvestigationItemList";
        public const string strUSP_INSERT_PATIENTDETAILS = "USP_INSERT_PATIENTDETAILS";
        public const string strUSP_INSERT_PHONEREGISTRATIONDETAILS = "USP_INSERT_PHONEREGISTRATIONDETAILS";
        public const string strUSP_PUBLIC_HRPATIENTLIST = "USP_PUBLIC_HRPATIENTLIST";
        public const string strUSP_INSERT_GENERALCHECKUPDETAILS = "USP_INSERT_GENERALCHECKUPDETAILS";
        public const string strUSP_PUBLIC_DOCTORPATIENTLIST = "USP_PUBLIC_DOCTORPATIENTLIST";
        public const string strUSP_GET_INVESTIGATIONLISTITEMS = "USP_GET_INVESTIGATIONLISTITEMS";
        public const string strUSP_GET_LOGINSTATUS = "USP_GET_LOGINSTATUS";
        public const string strUSP_INSERT_TESTDETAILS_PATIENT = "USP_INSERT_TESTDETAILS_PATIENT";
        public const string strUSP_Public_StaffRegSearch = "USP_Public_StaffRegSearch";
        public const string strUSP_Public_PhoneRegSearch = "USP_Public_PhoneRegSearch";
        public const string strUSP_AddDocName = "USP_AddDocName";
        public const string strUSP_GetDocName = "USP_GetDocName";
        public const string strUSP_GetRepeatedPatients = "USP_GetRepeatedPatients";
        public const string strUSP_TotalPatients = "USP_TotalPatients";
        public const string strUSP_GetYears = "USP_GetYears";
        public const string strUSP_Reports_GetTotalPatients = "USP_Reports_GetTotalPatients";
        public const string strUSP_Reports_RepeatedPatients = "USP_Reports_RepeatedPatients";
        public const string strUsp_Reports_TotalPatients_Diseases = "Usp_Reports_TotalPatients_Diseases";
    }
}
 


