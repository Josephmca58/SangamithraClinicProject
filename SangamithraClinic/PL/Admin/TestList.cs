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

namespace SangamithraClinic.PL.Admin
{
    public partial class TestList : Form
    {
        #region(Global Variables.)
        BALTestITems objTestItems = null;
        DataTable dtTestItems = null;
        string staffID = string.Empty, strOperationName = string.Empty, rowID;
        int TestCrudResult, columnIndex;
        DiseaseName objDiseaseName = null;
        DoctorNames objDoctorNames;
        #endregion
        public TestList()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SAVE THE DISEASE LIST INTO DATABASE.
            try
            {
                objTestItems = new BALTestITems();
                #region(CRUD OPERATIONS)
                if (txtTestName.Text != string.Empty && Convert.ToString(cbDiseaseName.SelectedValue.ToString()) != "0" && Convert.ToString(cbDoctorName.SelectedValue) != "0")
                {
                    if (strOperationName == "Edit")
                    {
                        if (Convert.ToString(cbDiseaseName.SelectedValue) == "0")
                        {
                            objTestItems.DiseaseID = "";
                        }
                        else
                            objTestItems.DiseaseID = Convert.ToString(cbDiseaseName.SelectedValue);
                        objTestItems.TestName = txtTestName.Text;
                        objTestItems.TestID = lblInvestigationID.Text;
                        TestCrudResult = objTestItems.UpdateDiseaseList(objTestItems);
                        if (TestCrudResult == 1)
                        {
                            objTestItems.DiseaseID = string.Empty;
                            objTestItems.TestName = string.Empty;
                            dtTestItems = new DataTable();
                            dtTestItems = objTestItems.GetTestItemsList(objTestItems);
                            dgTestItems.DataSource = dtTestItems;
                            dgTestItems.Rows[0].Cells[0].Selected = false;
                            txtTestName.Text = string.Empty;
                            cbDiseaseName.SelectedValue = 0;
                            MessageBox.Show("Test" + ConstatntMessages.strUpdateSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //dgTestItems.ReadOnly = true;
                            //dgTestItems.Columns[0].Visible = false;
                        }

                    }
                    else
                    {
                        objTestItems.TestID = txtTestName.Text + "1";
                        objTestItems.TestName = txtTestName.Text;
                        objTestItems.DiseaseID = Convert.ToString(cbDiseaseName.SelectedValue);
                        TestCrudResult = objTestItems.InsertDiseaseList(objTestItems);
                        if (TestCrudResult == 1)
                        {
                            objTestItems.DiseaseID = string.Empty;
                            objTestItems.TestName = string.Empty;
                            dtTestItems = new DataTable();
                            dtTestItems = objTestItems.GetTestItemsList(objTestItems);
                            dgTestItems.DataSource = dtTestItems;
                            dgTestItems.Rows[1].Cells[0].Selected = false;
                            dgTestItems.CurrentCell.Selected = false;
                            //dgTestItems.ReadOnly = true;
                            //dgTestItems.Columns[0].Visible = false;
                            txtTestName.Text = string.Empty;
                            cbDiseaseName.SelectedValue = 0;
                            MessageBox.Show("Test" + ConstatntMessages.strSaveSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are Mandatory", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                #endregion
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void clearFields()
        {
            txtTestName.Text = string.Empty;
            cbDoctorName.SelectedValue = 0;
            cbDiseaseName.SelectedValue = 0;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BindTestItemsGrid();
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void TestList_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dt1 = DateTime.Now;
                lblCurrentDate.Text = string.Format("{0:dd-MMM-yyyy}", dt1);
            
                //Filling Doctor Details...
                BindDocotrsList();
                //Bind Disease Names.
                BindDiseaseNames(staffID);
                // staffID = cbDoctorName.SelectedValue.ToString();
                //Bind TestITems DataGrid.
                BindTestItemsGrid();
                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkColumnEdit";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                dgTestItems.Columns.Add(Editlink);

                DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                Deletelink.UseColumnTextForLinkValue = true;
                Deletelink.HeaderText = "Delete";
                Deletelink.DataPropertyName = "lnkColumnDelete";
                Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                Deletelink.Text = "Delete";
                dgTestItems.Columns.Add(Deletelink);
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDocotrsList()
        {
            try
            {
                objDoctorNames = new DoctorNames();
                cbDoctorName.DataSource = objDoctorNames.liDoctorNames();
                cbDoctorName.DisplayMember = "DoctorName";
                cbDoctorName.ValueMember = "DoctorId";
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void BindTestItemsGrid()
        {
            try
            {
                objTestItems = new BALTestITems();
                if (Convert.ToString(cbDiseaseName.SelectedValue) == "0")
                {
                    objTestItems.DiseaseID = "";
                }
                else
                    objTestItems.DiseaseID = Convert.ToString(cbDiseaseName.SelectedValue);
                objTestItems.TestName = txtTestName.Text;
                dtTestItems = objTestItems.GetTestItemsList(objTestItems);
                dgTestItems.DataSource = dtTestItems;
                dgTestItems.ReadOnly = true;
                dgTestItems.Columns[0].Visible = false;
                dgTestItems.AutoGenerateColumns = false;
                dgTestItems.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void BindDiseaseNames(string staffID)
        {
            try
            {
                objDiseaseName = new DiseaseName();
                cbDiseaseName.DataSource = objDiseaseName.liDiseaseNames(staffID);
                cbDiseaseName.ValueMember = "DiseaseID";
                cbDiseaseName.DisplayMember = "DiseaseName";
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void cbDoctorName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            staffID = Convert.ToString(cbDoctorName.SelectedValue);
            BindDiseaseNames(staffID);
        }

        private void dgTestItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objTestItems = new BALTestITems();
            try
            {
                rowID = dgTestItems.Rows[e.RowIndex].Cells["InvstID"].Value.ToString();
                columnIndex = e.ColumnIndex;
                columnIndex = dgTestItems.CurrentCell.ColumnIndex;
                if (columnIndex == 4)
                {
                    strOperationName = dgTestItems.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
                    GetTestItemsByID(rowID);
                }
                else if (columnIndex == 5)
                {
                    strOperationName = dgTestItems.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
                    TestCrudResult = objTestItems.DeleteRecord(rowID);
                    if (TestCrudResult == 1)
                    {
                        dtTestItems = new DataTable();
                        objTestItems.DiseaseID = "";
                        objTestItems.TestName = "";
                        dtTestItems = objTestItems.GetTestItemsList(objTestItems);
                        dgTestItems.DataSource = dtTestItems;
                        dgTestItems.Rows[0].Cells[0].Selected = false;
                        txtTestName.Text = "";
                        cbDiseaseName.SelectedValue = 0;
                        MessageBox.Show(ConstatntMessages.strDeleteSuccess, "Alert");
                        //dgTestItems.ReadOnly = true;
                        //dgTestItems.Columns[0].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }
        private void GetTestItemsByID(string rowID)
        {
            try
            {
                objTestItems = new BALTestITems();
                dtTestItems = objTestItems.GetTestNamesByID(rowID);
                txtTestName.Text = dtTestItems.Rows[0]["InvstName"].ToString();
                cbDiseaseName.SelectedIndex = cbDiseaseName.FindString(dtTestItems.Rows[0]["DiseaseName"].ToString());
                lblInvestigationID.Text = dtTestItems.Rows[0]["InvstID"].ToString();
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DoctorWelcome objDWL = new DoctorWelcome();
            this.Close();
            objDWL.Show();
        }
    }
}
