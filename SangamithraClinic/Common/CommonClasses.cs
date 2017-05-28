using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangamithraClinic.Common
{

    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ReportsList
    {
        public string ReportId { get; set; }
        public string ReportName { get; set; }
    }
    public class UserType
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
    }

    public class DoctorList
    {
        public string DoctorId { get; set; }
        public string DoctorName { get; set; }
    }
    public class DiseaseList
    {
        public string DiseaseId { get; set; }
        public string DiseaseName { get; set; }
    }
    public class TestItems
    {
        public string TestId { get; set; }
        public string TestName { get; set; }
    }
    public class MaritalStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Sugar
    {
        public int Value { get; set; }
        public string Text { get; set; }
    }

    public class Year
    {
        public int Value { get; set; }
        public string Text { get; set; }
    }

}
