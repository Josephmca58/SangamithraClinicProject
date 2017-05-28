using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SangamithraClinic.BAL;
using SangamithraClinic.Constants;
using SangamithraClinic.Common;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using Microsoft.Office.Interop.Word;
using Novacode;
using System.Diagnostics;
using System.Configuration;
namespace SangamithraClinic.PL.Admin
{
    public partial class TestDetails : Form
    {
        public string strStaffID = string.Empty;
        DiseaseName objDiseaseName = null;
        System.Data.DataTable dtTestNames = null;
        BALTestDetails objTestDetailsBAL = null;
        BALGeneralCheckup objGeneralCheckup = new BALGeneralCheckup();
        string strDiseaseID = string.Empty;
        string _strPatientName = string.Empty, _strPhoneNumber = string.Empty;
        string _strDoctorName = string.Empty, _strGender = string.Empty, _strAge = string.Empty, _strLinkText = string.Empty;
        DateTime _dtRegistrationDate;
        string _strBp = string.Empty; string _strSugar = string.Empty; string _strfever = string.Empty; string _strWeight = string.Empty; string _strHeight = string.Empty;
        Guid guidPID;
        string _strWordDocumentPath = Convert.ToString(ConfigurationSettings.AppSettings["WordDocumentPath"]);
        string _strExcelPath = Convert.ToString(ConfigurationSettings.AppSettings["ExcelPath"]);
        Microsoft.Office.Interop.Excel.Application oXL;
        Microsoft.Office.Interop.Excel._Workbook oWB;
        Microsoft.Office.Interop.Excel._Worksheet oSheet;
        Microsoft.Office.Interop.Excel.Range oRng;
        object misvalue = System.Reflection.Missing.Value;

        // private static Microsoft.Office.Interop.Excel.Workbook mWorkBook;
        private static Microsoft.Office.Interop.Excel.Sheets mWorkSheets;
        // private static Microsoft.Office.Interop.Excel.Worksheet mWSheet1;
        // private static Microsoft.Office.Interop.Excel.Application oXL1;
        public TestDetails()
        {
            InitializeComponent();
        }
        public TestDetails(string _LinkText, DateTime _RegistrationDate, string _PatientName, string _PhoneNumber, Guid PID, string _DoctorName, string _Age, string _Gender, string _Bp, string _Sugar, string _Fever, string _Weight, string _Height)
        {
            InitializeComponent();
            this._strPatientName = _PatientName;
            this._strPhoneNumber = _PhoneNumber;
            this._dtRegistrationDate = _RegistrationDate;
            this.guidPID = PID;
            this._strDoctorName = _DoctorName;
            this._strAge = _Age + "yrs";
            this._strGender = _Gender;
            this._strBp = _Bp;
            this._strSugar = _Sugar;
            this._strfever = _Fever;
            this._strWeight = _Weight;
            this._strHeight = _Height;
            this._strLinkText = _LinkText;
            if (_LinkText == "download")
            {
                bool result;
                System.Data.DataTable dt1 = new System.Data.DataTable();
                result = CreateDocxDocument(dt1, 0);
                this.Hide();
            }
        }
        private void TestDetails_Load(object sender, EventArgs e)
        {
            //Bind Disease Name.
            strStaffID = "SF1";
            DateTime dt1 = DateTime.Now;
            lblCurrentDate.Text = string.Format("{0:dd-MMM-yyyy}", dt1);
            BindingDiseaseNames();
            if (_strLinkText == "download")
            {
                _strPatientName = _strPatientName.Replace(" ", "");
                //string strPhysicalPath = @"F:\Projects\HospitalManagement\PatientListDocument\WordDocuments\";
                string strFileName = _strPatientName + "_" + _strPhoneNumber + "_" + ".docx";
                string filePath = _strWordDocumentPath + strFileName;
                if (File.Exists(filePath))
                {
                    // Open in Word:
                    Process.Start("WINWORD.EXE", filePath);
                }
                else
                {
                    MessageBox.Show("Record is not available");
                }
                this.Close();
            }
        }

        private void BindingDiseaseNames()
        {
            try
            {
                objDiseaseName = new DiseaseName();
                cbDiseaseName.DataSource = objDiseaseName.liDiseaseNames(strStaffID);
                cbDiseaseName.ValueMember = "DiseaseID";
                cbDiseaseName.DisplayMember = "DiseaseName";
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void cbDiseaseName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                strDiseaseID = cbDiseaseName.SelectedValue.ToString();
                objTestDetailsBAL = new BALTestDetails();
                dtTestNames = new System.Data.DataTable();
                dtTestNames = objTestDetailsBAL.GetTestNames(strDiseaseID);
                if (dtTestNames.Rows.Count > 0)
                {
                    OpenExcel();
                }
                else
                    MessageBox.Show("Test Details are not available");
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }
        private void OpenExcel()
        {
            try
            {
                string mySheet = string.Empty;
                //Start Excel and get Application object.
                DateTime dateAndTime = DateTime.Now;
                string date = dateAndTime.Date.ToString("yyyy-MM-dd");
                _strPatientName = _strPatientName.Replace(" ", "");
                //string strPhysicalPath = @"F:\Projects\HospitalManagement\PatientListDocument\Excel\";
                oXL = new Microsoft.Office.Interop.Excel.Application();
                //logic to create a folder for each day (BEGIN)
                if (!System.IO.Directory.Exists(_strExcelPath + DateTime.Now.Date.ToString("yyyy-MM-dd")))
                    System.IO.Directory.CreateDirectory(_strExcelPath + DateTime.Now.Date.ToString("yyyy-MM-dd"));
                //logic to create a folder for each day (END)
                mySheet = _strExcelPath + DateTime.Now.Date.ToString("yyyy-MM-dd") + @"\" + _strPatientName + "_" + _strPhoneNumber + "_" + date + ".xls";


                if (!File.Exists(mySheet))
                {
                    //Get a new workbook.
                    oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                    oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Worksheets.get_Item(1);
                    oSheet.Name = cbDiseaseName.Text;
                }
                else
                {
                    oWB = oXL.Workbooks.Open(mySheet, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                    //Get all the sheets in the workbook
                    mWorkSheets = oWB.Worksheets;
                    // Keeping track
                    bool found = false;
                    string dropdownText = cbDiseaseName.Text;
                    foreach (Excel.Worksheet sheet in oWB.Sheets)
                    {
                        // Check the name of the current sheet
                        if (sheet.Name == dropdownText)
                        {
                            found = true;
                            break; // Exit the loop now
                        }
                    }
                    if (found)
                    {
                        MessageBox.Show("Patient details already exist");
                        return;
                    }
                    else
                    {
                        // Create it
                        oSheet = (Excel.Worksheet)oWB.Sheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                        oSheet.Name = dropdownText;

                    }


                    // oSheet.Name = "";
                }
                oSheet.Cells[1, 4] = "Value";
                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "D1").Font.Bold = true;
                oSheet.get_Range("A1", "D1").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                int rowCount = 1;
                foreach (DataRow dr in dtTestNames.Rows)
                {
                    rowCount += 1;
                    for (int i = 1; i < dtTestNames.Columns.Count + 1; i++)
                    {
                        // Add the header the first time through 
                        if (rowCount == 2)
                        {
                            oSheet.Cells[1, i] = dtTestNames.Columns[i - 1].ColumnName;
                        }
                        oSheet.Cells[rowCount, i] = dr[i - 1].ToString();
                    }
                }
                //AutoFit columns A:D.
                oRng = oSheet.get_Range("A1", "D1");
                oRng.EntireColumn.AutoFit();
                oXL.Visible = true;
                oXL.DisplayAlerts = false;
                oXL.UserControl = true;
                oWB.SaveAs(mySheet, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(oWB);
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(oXL);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new System.Windows.Forms.OpenFileDialog();
            op1.Multiselect = true;
            op1.ShowDialog();
            op1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            txtFileUpload.Text = op1.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TestDetailsResult;
            try
            {
                if (txtFileUpload.Text != string.Empty)
                {
                    DateTime dateAndTime = DateTime.Now;
                    Excel.Range range;
                    string date = dateAndTime.Date.ToString("yyyy-MM-dd");
                    _strPatientName = _strPatientName.Replace(" ", "");
                    string mySheet = _strExcelPath + DateTime.Now.Date.ToString("yyyy-MM-dd") + @"\" + _strPatientName + "_" + _strPhoneNumber + "_" + date + ".xls";
                    string str;
                    int rCnt = 0;
                    int cCnt = 0;
                    oXL = new Excel.Application();
                    oWB = oXL.Workbooks.Open(mySheet);
                    System.Data.DataTable dtInvestigation = new System.Data.DataTable();
                    dtInvestigation.Columns.Add("DiseaseID", typeof(string));
                    dtInvestigation.Columns.Add("InvstID", typeof(string));
                    dtInvestigation.Columns.Add("Value", typeof(string));
                    dtInvestigation.Columns.Add("PId", typeof(Guid));
                    dtInvestigation.Columns.Add("RegistrationDate", typeof(string));
                    System.Data.DataTable dtDummy = new System.Data.DataTable();
                    dtDummy.Columns.Add("InvestinagtionName", typeof(string));
                    dtDummy.Columns.Add("Value", typeof(string));
                    DataRow dr, drdummy;
                    string strSheetName = string.Empty;
                    List<string> lstDiseases = new List<string>();
                    foreach (Excel.Worksheet sheet in oWB.Sheets)
                    {
                        range = sheet.UsedRange;
                        DataRow dummyRow = dtDummy.NewRow();
                        dummyRow[0] = "Disease Name :" + sheet.Name;
                        dtDummy.Rows.Add(dummyRow);
                        for (rCnt = 2; rCnt <= range.Rows.Count; rCnt++)
                        {
                            for (cCnt = 1; cCnt <= 1; cCnt++)
                            {
                                dr = dtInvestigation.NewRow();
                                drdummy = dtDummy.NewRow();
                                dr["DiseaseID"] = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
                                dr["InvstID"] = (string)(range.Cells[rCnt, cCnt + 1] as Excel.Range).Value2;
                                dr["Value"] = (string)(range.Cells[rCnt, cCnt + 3] as Excel.Range).Value2;
                                dr["PId"] = this.guidPID;
                                dr["RegistrationDate"] = txtRegistrationDate.Text;
                                dtInvestigation.Rows.Add(dr);
                                drdummy["InvestinagtionName"] = (string)(range.Cells[rCnt, cCnt + 2] as Excel.Range).Value2;
                                drdummy["Value"] = (string)(range.Cells[rCnt, cCnt + 3] as Excel.Range).Value2;
                                dtDummy.Rows.Add(drdummy);
                            }
                        }

                    }
                    int rowsCount = dtInvestigation.Rows.Count;
                    objTestDetailsBAL = new BALTestDetails();
                    TestDetailsResult = objTestDetailsBAL.InsertTestDetails(dtInvestigation);
                    if (TestDetailsResult == rowsCount)
                    {
                        bool status = false;
                        objTestDetailsBAL = new BALTestDetails();
                        //Get the Document List...
                        System.Data.DataTable dt = objTestDetailsBAL.GetDocNames(_strPatientName + "_" + _strPhoneNumber + "_");
                        int rowCount = dt.Rows.Count;
                        TestDetailsResult = objTestDetailsBAL.InsertDocName(_strPatientName + "_" + _strPhoneNumber + "_" + date, DateTime.Now);
                        status = CreateDocxDocument(dtDummy, rowCount);//, lstDiseases
                        if (status)
                        {
                            MessageBox.Show("Test Details" + ConstatntMessages.strSaveSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            DoctorPatientList objPL = new DoctorPatientList();
                            objPL.Show();
                        }
                        else
                            MessageBox.Show("Insertion Failed");
                    }

                }
                else
                {
                    MessageBox.Show("Select the ExcelSheet");
                }
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        public bool CreateDocxDocument(System.Data.DataTable dtFormal, int rCount)//, List<string> lstDieseases
        {
            //creating the docx document.
            try
            {
                _strPatientName = _strPatientName.Replace(" ", "");
                //string strPhysicalPath = @"F:\Projects\HospitalManagement\PatientListDocument\WordDocuments\";
                //string strFileName = _strPatientName + "_" + _strPhoneNumber + "_" + string.Format("{0:dd-MMM-yyyy}", _dtRegistrationDate) + ".docx";
                string strFileName = _strPatientName + "_" + _strPhoneNumber + "_" + ".docx";
                string strTitleTextName = "Sangamithra Clinic";
                string strTitleTextAddress = "D.No:29-13-22,Kaleswararao Rao,Suryaraopet,Vijayawada.";
                string strEmptyPragraph = "";
                string strHeadingGeneralInfo = "Patient General Information:";
                string strHeadingGeneralCheckupInfo = "Patient General Checkup Information:";
                string strHeadingTestReport = "Test Report:";
                #region(Paragraphs Formats)
                // A formatting object for our Title Tex
                var TitleTextFormat = new Formatting();
                TitleTextFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
                TitleTextFormat.Size = 14D;
                TitleTextFormat.Bold = true;
                TitleTextFormat.Italic = true;
                // A formatting object for our Address Text
                var AddressTextFormat = new Formatting();
                AddressTextFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
                AddressTextFormat.Size = 11D;
                AddressTextFormat.Bold = true;
                AddressTextFormat.Italic = true;
                // A formatting object for our DoctorName Text
                var DoctorNameTextFormat = new Formatting();
                DoctorNameTextFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
                DoctorNameTextFormat.Size = 11D;
                DoctorNameTextFormat.Bold = true;
                // A formatting object for our RegistrationDate Text
                var RegistrationDateTextFormat = new Formatting();
                RegistrationDateTextFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
                RegistrationDateTextFormat.Size = 11D;
                RegistrationDateTextFormat.Bold = true;
                // A formatting object for our Heading General information Text
                var HeadingGeneralInfoFormat = new Formatting();
                HeadingGeneralInfoFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
                HeadingGeneralInfoFormat.Size = 12D;
                HeadingGeneralInfoFormat.Bold = true;
                // A formatting object for our Heading General checkup information Text
                var HeadingGeneralcheckupInfoFormat = new Formatting();
                HeadingGeneralcheckupInfoFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
                HeadingGeneralcheckupInfoFormat.Size = 12D;
                HeadingGeneralcheckupInfoFormat.Bold = true;
                // A formatting object for our Heading General checkup information Text
                var HeadingTestReportFormat = new Formatting();
                HeadingTestReportFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
                HeadingTestReportFormat.Size = 12D;
                HeadingTestReportFormat.Bold = true;
                #endregion

                //logic to create a folder for each day (BEGIN)
                if (rCount == 0 && dtFormal.Rows.Count > 0)
                {
                    var doc = DocX.Create(_strWordDocumentPath + strFileName);
                    #region(Tables Structures)
                    // Add a Table to this document.
                    //Following table is used to display the doctor name and registration date
                    Novacode.Table tableDoctor = doc.AddTable(2, 3);
                    tableDoctor.Alignment = Alignment.left;
                    tableDoctor.Design = TableDesign.TableNormal;
                    tableDoctor.AutoFit = AutoFit.Contents;
                    //add content to the table
                    tableDoctor.Rows[0].Cells[0].Paragraphs.First().Append("Doctor Name").Bold();
                    tableDoctor.Rows[0].Cells[1].Paragraphs.First().Append(":");
                    tableDoctor.Rows[0].Cells[2].Paragraphs.First().Append(_strDoctorName);
                    tableDoctor.Rows[1].Cells[0].Paragraphs.First().Append("Registration Date").Bold();
                    tableDoctor.Rows[1].Cells[1].Paragraphs.First().Append(":");
                    tableDoctor.Rows[1].Cells[2].Paragraphs.First().Append(string.Format("{0:dd-MMM-yyyy}", System.DateTime.Now));
                    // Add a Patient General Information Table to this document.
                    Novacode.Table tablePatientGeneralInfo = doc.AddTable(2, 4);
                    tablePatientGeneralInfo.Alignment = Alignment.left;
                    tablePatientGeneralInfo.Design = TableDesign.MediumGrid1Accent2;
                    tablePatientGeneralInfo.AutoFit = AutoFit.Window;
                    //add content to the table
                    tablePatientGeneralInfo.Rows[0].Cells[0].Paragraphs.First().Append("Name").Bold();
                    tablePatientGeneralInfo.Rows[0].Cells[1].Paragraphs.First().Append(_strPatientName);
                    tablePatientGeneralInfo.Rows[0].Cells[2].Paragraphs.First().Append("Age").Bold();
                    tablePatientGeneralInfo.Rows[0].Cells[3].Paragraphs.First().Append(_strAge);
                    tablePatientGeneralInfo.Rows[1].Cells[0].Paragraphs.First().Append("Phone Number").Bold();
                    tablePatientGeneralInfo.Rows[1].Cells[1].Paragraphs.First().Append(_strPhoneNumber);
                    tablePatientGeneralInfo.Rows[1].Cells[2].Paragraphs.First().Append("Gender").Bold();
                    tablePatientGeneralInfo.Rows[1].Cells[3].Paragraphs.First().Append(_strGender);
                    // Add a Patient General Checkup Information Table to this document.
                    Novacode.Table tablePatientGeneralcheckupInfo = doc.AddTable(5, 2);
                    tablePatientGeneralcheckupInfo.Alignment = Alignment.left;
                    tablePatientGeneralcheckupInfo.Design = TableDesign.MediumGrid1Accent2;
                    tablePatientGeneralcheckupInfo.AutoFit = AutoFit.Window;
                    //add content to the table
                    tablePatientGeneralcheckupInfo.Rows[0].Cells[0].Paragraphs.First().Append("BP").Bold();
                    tablePatientGeneralcheckupInfo.Rows[0].Cells[1].Paragraphs.First().Append(_strBp);
                    tablePatientGeneralcheckupInfo.Rows[1].Cells[0].Paragraphs.First().Append("Sugar").Bold();
                    tablePatientGeneralcheckupInfo.Rows[1].Cells[1].Paragraphs.First().Append(_strSugar);
                    tablePatientGeneralcheckupInfo.Rows[2].Cells[0].Paragraphs.First().Append("Fever").Bold();
                    tablePatientGeneralcheckupInfo.Rows[2].Cells[1].Paragraphs.First().Append(_strfever);
                    tablePatientGeneralcheckupInfo.Rows[3].Cells[0].Paragraphs.First().Append("Height").Bold();
                    tablePatientGeneralcheckupInfo.Rows[3].Cells[1].Paragraphs.First().Append(_strHeight);
                    tablePatientGeneralcheckupInfo.Rows[4].Cells[0].Paragraphs.First().Append("Weight").Bold();
                    tablePatientGeneralcheckupInfo.Rows[4].Cells[1].Paragraphs.First().Append(_strWeight);
                    //Add a Test report to this document
                    Novacode.Table tableTestReport = doc.AddTable(dtFormal.Rows.Count, dtFormal.Columns.Count);
                    Novacode.Table tblName = doc.AddTable(dtFormal.Rows.Count, dtFormal.Columns.Count);
                    tableTestReport.Alignment = Alignment.left;
                    tableTestReport.Design = TableDesign.MediumGrid1Accent2;
                    tableTestReport.AutoFit = AutoFit.Window;
                    //add content to the table.
                    //int tblCount = 0;
                    for (int i = 0; i < dtFormal.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtFormal.Columns.Count; j++)
                        {
                            if (j == 0)
                            {
                                tableTestReport.Rows[i].Cells[j].Paragraphs.First().Append(Convert.ToString(dtFormal.Rows[i][j])).Bold();
                            }
                            else
                            {
                                tableTestReport.Rows[i].Cells[j].Paragraphs.First().Append(Convert.ToString(dtFormal.Rows[i][j]));
                            }
                        }
                    }
                    #endregion
                    #region(appending paragraphs and tables to document)
                    // Insert a paragrpah:
                    doc.InsertParagraph(strTitleTextName, false, TitleTextFormat).Alignment = Alignment.center;
                    doc.InsertParagraph(strTitleTextAddress, false, AddressTextFormat).Alignment = Alignment.center;
                    doc.InsertParagraph(strEmptyPragraph, false);
                    doc.InsertParagraph(strEmptyPragraph, false);
                    doc.InsertTable(tableDoctor);
                    doc.InsertParagraph(strEmptyPragraph, false);
                    doc.InsertParagraph(strHeadingGeneralInfo, false, HeadingGeneralInfoFormat).Alignment = Alignment.left;
                    doc.InsertTable(tablePatientGeneralInfo);
                    doc.InsertParagraph(strEmptyPragraph, false);
                    doc.InsertParagraph(strHeadingGeneralCheckupInfo, false, HeadingGeneralcheckupInfoFormat).Alignment = Alignment.left;
                    doc.InsertTable(tablePatientGeneralcheckupInfo);
                    doc.InsertParagraph(strEmptyPragraph, false);
                    doc.InsertParagraph(strEmptyPragraph, false);
                    doc.InsertParagraph(strHeadingTestReport, false, HeadingTestReportFormat).Alignment = Alignment.left;
                    doc.InsertTable(tableTestReport);
                    doc.Save();
                    #endregion
                }
                else
                {
                    if (rCount == 0 && dtFormal.Rows.Count == 0)
                    {
                        var doc = DocX.Load(_strWordDocumentPath + strFileName);
                    }
                    else
                    {
                        #region(Tables Structures)
                        // Add a Table to this document.
                        //Following table is used to display the doctor name and registration date
                        var doc = DocX.Load(_strWordDocumentPath + strFileName);
                        Novacode.Table tableDoctor = doc.AddTable(2, 3);
                        tableDoctor.Alignment = Alignment.left;
                        tableDoctor.Design = TableDesign.TableNormal;
                        tableDoctor.AutoFit = AutoFit.Contents;
                        //add content to the table
                        tableDoctor.Rows[0].Cells[0].Paragraphs.First().Append("Doctor Name").Bold();
                        tableDoctor.Rows[0].Cells[1].Paragraphs.First().Append(":");
                        tableDoctor.Rows[0].Cells[2].Paragraphs.First().Append(_strDoctorName);
                        tableDoctor.Rows[1].Cells[0].Paragraphs.First().Append("Registration Date").Bold();
                        tableDoctor.Rows[1].Cells[1].Paragraphs.First().Append(":");
                        tableDoctor.Rows[1].Cells[2].Paragraphs.First().Append(string.Format("{0:dd-MMM-yyyy}", System.DateTime.Now));
                        // Add a Patient General Information Table to this document.
                        Novacode.Table tablePatientGeneralInfo = doc.AddTable(2, 4);
                        tablePatientGeneralInfo.Alignment = Alignment.left;
                        tablePatientGeneralInfo.Design = TableDesign.MediumGrid1Accent2;
                        tablePatientGeneralInfo.AutoFit = AutoFit.Window;
                        //add content to the table
                        tablePatientGeneralInfo.Rows[0].Cells[0].Paragraphs.First().Append("Name").Bold();
                        tablePatientGeneralInfo.Rows[0].Cells[1].Paragraphs.First().Append(_strPatientName);
                        tablePatientGeneralInfo.Rows[0].Cells[2].Paragraphs.First().Append("Age").Bold();
                        tablePatientGeneralInfo.Rows[0].Cells[3].Paragraphs.First().Append(_strAge);
                        tablePatientGeneralInfo.Rows[1].Cells[0].Paragraphs.First().Append("Phone Number").Bold();
                        tablePatientGeneralInfo.Rows[1].Cells[1].Paragraphs.First().Append(_strPhoneNumber);
                        tablePatientGeneralInfo.Rows[1].Cells[2].Paragraphs.First().Append("Gender").Bold();
                        tablePatientGeneralInfo.Rows[1].Cells[3].Paragraphs.First().Append(_strGender);
                        // Add a Patient General Checkup Information Table to this document.
                        Novacode.Table tablePatientGeneralcheckupInfo = doc.AddTable(5, 2);
                        tablePatientGeneralcheckupInfo.Alignment = Alignment.left;
                        tablePatientGeneralcheckupInfo.Design = TableDesign.MediumGrid1Accent2;
                        tablePatientGeneralcheckupInfo.AutoFit = AutoFit.Window;
                        //add content to the table
                        tablePatientGeneralcheckupInfo.Rows[0].Cells[0].Paragraphs.First().Append("BP").Bold();
                        tablePatientGeneralcheckupInfo.Rows[0].Cells[1].Paragraphs.First().Append(_strBp);
                        tablePatientGeneralcheckupInfo.Rows[1].Cells[0].Paragraphs.First().Append("Sugar").Bold();
                        tablePatientGeneralcheckupInfo.Rows[1].Cells[1].Paragraphs.First().Append(_strSugar);
                        tablePatientGeneralcheckupInfo.Rows[2].Cells[0].Paragraphs.First().Append("Fever").Bold();
                        tablePatientGeneralcheckupInfo.Rows[2].Cells[1].Paragraphs.First().Append(_strfever);
                        tablePatientGeneralcheckupInfo.Rows[3].Cells[0].Paragraphs.First().Append("Height").Bold();
                        tablePatientGeneralcheckupInfo.Rows[3].Cells[1].Paragraphs.First().Append(_strHeight);
                        tablePatientGeneralcheckupInfo.Rows[4].Cells[0].Paragraphs.First().Append("Weight").Bold();
                        tablePatientGeneralcheckupInfo.Rows[4].Cells[1].Paragraphs.First().Append(_strWeight);
                        //Add a Test report to this document
                        Novacode.Table tableTestReport = doc.AddTable(dtFormal.Rows.Count, dtFormal.Columns.Count);
                        tableTestReport.Alignment = Alignment.left;
                        tableTestReport.Design = TableDesign.MediumGrid1Accent2;
                        tableTestReport.AutoFit = AutoFit.Window;
                        //add content to the table.
                        for (int i = 0; i < dtFormal.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtFormal.Columns.Count; j++)
                            {
                                if (j == 0)
                                {
                                    tableTestReport.Rows[i].Cells[j].Paragraphs.First().Append(Convert.ToString(dtFormal.Rows[i][j])).Bold();
                                }
                                else
                                {
                                    tableTestReport.Rows[i].Cells[j].Paragraphs.First().Append(Convert.ToString(dtFormal.Rows[i][j]));
                                }
                            }
                        }
                        #endregion
                        #region(appending paragraphs and tables to document)
                        doc.InsertTable(tableDoctor);
                        doc.InsertParagraph(strEmptyPragraph, false);
                        doc.InsertParagraph(strHeadingGeneralInfo, false, HeadingGeneralInfoFormat).Alignment = Alignment.left;
                        doc.InsertTable(tablePatientGeneralInfo);
                        doc.InsertParagraph(strEmptyPragraph, false);
                        doc.InsertParagraph(strHeadingGeneralCheckupInfo, false, HeadingGeneralcheckupInfoFormat).Alignment = Alignment.left;
                        doc.InsertTable(tablePatientGeneralcheckupInfo);
                        doc.InsertParagraph(strEmptyPragraph, false);
                        doc.InsertParagraph(strEmptyPragraph, false);
                        doc.InsertParagraph(strHeadingTestReport, false, HeadingTestReportFormat).Alignment = Alignment.left;
                        doc.InsertTable(tableTestReport);
                        doc.Save();
                        #endregion
                    }


                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
                return false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorWelcome objDW = new DoctorWelcome();
            this.Close();
            objDW.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbDiseaseName.SelectedIndex = 0;
            txtFileUpload.Text = string.Empty;
        }
    }

}
