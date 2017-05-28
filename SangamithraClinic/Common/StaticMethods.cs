using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SangamithraClinic.BAL;
using System.Data;

namespace SangamithraClinic.Common
{
    class StaticMethods
    {
        public static List<Gender> GenderList()
        {
            List<Gender> liGender = new List<Gender> { 
                new Gender{ Id=0,Name="Select Gender"},
            new Gender { Id=1, Name="Male"},
            new Gender { Id=2, Name="Female"}
            };
            return liGender;
        }
        public static List<ReportsList> GetReportList()
        {
            List<ReportsList> liReportList = new List<ReportsList>() {
                new ReportsList(){ReportId="0",ReportName="Select Report"},
             new ReportsList (){ReportId ="Rep01",ReportName="Total Patients Month Wise"},
             new ReportsList () {ReportId="Rep02",ReportName="Repeated Patients Month Wise"},
             new ReportsList () {ReportId="Rep03",ReportName="Repeated Diseases Month Wise"}
            };
            return liReportList;
        }
        public static List<UserType> UserList()
        {
            List<UserType> liUserList = new List<UserType> { 
                new UserType{ UserId="0",UserName="Select User Type"},
            new UserType { UserId="US01", UserName="Doctor"},
            new UserType { UserId="US02", UserName="Staff"}
            };
            return liUserList;
        }
        public static List<MaritalStatus> GetMaritalStatus()
        {
            List<MaritalStatus> liMaritalStatus = new List<MaritalStatus> { 
                new MaritalStatus{ Id=0,Name="Select Marital Status"},
            new MaritalStatus { Id=1, Name="Married"},
            new MaritalStatus { Id=2, Name="UnMarried"}
            };
            return liMaritalStatus;
        }
        public static List<Sugar> GetSugarMethod()
        {
            List<Sugar> liMaritalStatus = new List<Sugar> { 
                new Sugar{ Value=0,Text="Select Sugar"},
            new Sugar { Value=1, Text="Yes"},
            new Sugar { Value=2, Text="No"}
            };
            return liMaritalStatus;
        }

        public string GenerateNumber()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 11; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }

        

    }
    public class DoctorNames
    {
        DataTable dt = new DataTable();
        BALDiseaseList ObjDiseaseList = new BALDiseaseList();
        DoctorList objDoctorList;
        public List<DoctorList> liDoctorNames()
        {
            try
            {
                dt = ObjDiseaseList.GetDoctorNames();
                List<DoctorList> li = new List<DoctorList>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objDoctorList = new DoctorList();
                    objDoctorList.DoctorId = dt.Rows[i]["StaffID"].ToString();
                    objDoctorList.DoctorName = dt.Rows[i]["UserName"].ToString();
                    li.Add(objDoctorList);
                }
                li.Insert(0, new DoctorList { DoctorId = "0", DoctorName = "Select Doctor Name" });
                return li;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return null;
            }
        }
    }
    public class DiseaseName
    {
        DataTable dt = new DataTable();
        BALTestITems ObjTestItems = new BALTestITems();
        DiseaseList ObjDiseaseList;
        public List<DiseaseList> liDiseaseNames(string staffID)
        {
            try
            {
                List<DiseaseList> li = new List<DiseaseList>();
                if (!string.IsNullOrEmpty(staffID))
                {
                    dt = ObjTestItems.GetDiseaseNames(staffID);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ObjDiseaseList = new DiseaseList();
                        ObjDiseaseList.DiseaseId = dt.Rows[i]["DiseaseID"].ToString();
                        ObjDiseaseList.DiseaseName = dt.Rows[i]["DiseaseName"].ToString();
                        li.Add(ObjDiseaseList);
                    }
                    li.Insert(0, new DiseaseList { DiseaseId = "0", DiseaseName = "Select Disease Name" });
                    return li;
                }
                else
                {
                    li.Insert(0, new DiseaseList { DiseaseId = "0", DiseaseName = "Select Disease Name" });
                    return li;
                }
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return null;
            }
        }
    }

    public class YearBind
    {
        DataTable dt = new DataTable();
        BALReports ObjReports = new BALReports();
        Year ObjYear = null;
        public List<Year> liYears()
        {
            try
            {
                List<Year> li = new List<Year>();

                dt = ObjReports.GetYears();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ObjYear = new Year();
                    ObjYear.Text = dt.Rows[i]["Years"].ToString();
                    ObjYear.Value = int.Parse(dt.Rows[i]["Years"].ToString());
                    li.Add(ObjYear);
                }
                li.Insert(0, new Year { Value = 0, Text = "Please Select Year" });
                return li;
                //}
                //else
                //{
                //    li.Insert(0, new Year { DiseaseId = "0", DiseaseName = "Select Disease Name" });
                //    return li;
                //}
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return null;
            }
        }
    }
}
