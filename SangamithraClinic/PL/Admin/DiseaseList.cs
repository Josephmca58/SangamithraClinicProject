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
using SangamithraClinic.Common;
using SangamithraClinic.Constants;

namespace SangamithraClinic.PL.Admin
{
    public partial class DiseaseList : Form
    {
        BALDiseaseList ObjDiseaseList = null;
        DataTable dtDiseases = null;
        DoctorNames objDoctorNames;
        int DiseaseCrudResult, columnIndex;
        string rowID = string.Empty, strOperationName = string.Empty;
        public DiseaseList()
        {
            InitializeComponent();
        }

        private void DiseaseList_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblCurrentDate.Text = string.Format("{0:dd-MMM-yyyy}", dt);
            try
            {
                //Filling Doctor Details...
                BindDocotrsList();
                //Bind GridView
                BindGridView();
                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkColumnEdit";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                dgDiseases.Columns.Add(Editlink);

                DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                Deletelink.UseColumnTextForLinkValue = true;
                Deletelink.HeaderText = "Delete";
                Deletelink.DataPropertyName = "lnkColumnDelete";
                Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                Deletelink.Text = "Delete";
                dgDiseases.Columns.Add(Deletelink);
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }
        private void BindGridView()
        {
            dtDiseases = new DataTable();
            ObjDiseaseList = new BALDiseaseList();
            try
            {
                if (Convert.ToString(cbDoctorName.SelectedValue) == "0")
                {
                    ObjDiseaseList.DoctorName = "";
                }
                else
                    ObjDiseaseList.DoctorName = Convert.ToString(cbDoctorName.SelectedValue);
                ObjDiseaseList.DiseaseName = txtDiseaseName.Text;
                dtDiseases = ObjDiseaseList.GetDisesesList(ObjDiseaseList);
                dgDiseases.DataSource = dtDiseases;
                dgDiseases.ReadOnly = true;
                dgDiseases.Columns[0].Visible = false;
                dgDiseases.AutoGenerateColumns = false;
                dgDiseases.AllowUserToAddRows = false;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SAVE THE DISEASE LIST INTO DATABASE.
            try
            {
                ObjDiseaseList = new BALDiseaseList();
                #region(CRUD Operation)
                if (Convert.ToString(cbDoctorName.SelectedValue.ToString()) != "0" && txtDiseaseName.Text != string.Empty)
                {
                    if (strOperationName == "Edit")
                    {
                        if (Convert.ToString(cbDoctorName.SelectedValue) == "0")
                        {
                            ObjDiseaseList.DoctorName = "";
                        }
                        else
                            ObjDiseaseList.DoctorName = Convert.ToString(cbDoctorName.SelectedValue);
                        ObjDiseaseList.DiseaseName = txtDiseaseName.Text;
                        ObjDiseaseList.DiseaseID = lblDiseaseID.Text;
                        DiseaseCrudResult = ObjDiseaseList.UpdateDiseaseList(ObjDiseaseList);
                        if (DiseaseCrudResult == 1)
                        {
                            ObjDiseaseList.DoctorName = string.Empty;
                            ObjDiseaseList.DiseaseName = string.Empty;
                            dtDiseases = new DataTable();
                            dtDiseases = ObjDiseaseList.GetDisesesList(ObjDiseaseList);
                            dgDiseases.DataSource = dtDiseases;
                            txtDiseaseName.Text = string.Empty;
                            cbDoctorName.SelectedValue = 0;
                            MessageBox.Show("Disease" + ConstatntMessages.strUpdateSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        ObjDiseaseList.DoctorName = Convert.ToString(cbDoctorName.SelectedValue);
                        ObjDiseaseList.DiseaseName = txtDiseaseName.Text;
                        ObjDiseaseList.DiseaseID = txtDiseaseName.Text + Convert.ToString(cbDoctorName.SelectedValue);
                        DiseaseCrudResult = ObjDiseaseList.InsertDiseaseList(ObjDiseaseList);
                        if (DiseaseCrudResult == 1)
                        {
                            ObjDiseaseList.DoctorName = string.Empty;
                            ObjDiseaseList.DiseaseName = string.Empty;
                            dtDiseases = new DataTable();
                            dtDiseases = ObjDiseaseList.GetDisesesList(ObjDiseaseList);
                            dgDiseases.DataSource = dtDiseases;
                            txtDiseaseName.Text = string.Empty;
                            cbDoctorName.SelectedValue = 0;
                            MessageBox.Show("Disease" + ConstatntMessages.strSaveSuccess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void GetDiseaseListByID(string rowID)
        {
            try
            {
                ObjDiseaseList = new BALDiseaseList();
                dtDiseases = ObjDiseaseList.GetDiseaseListByID(rowID);
                txtDiseaseName.Text = dtDiseases.Rows[0]["DiseaseName"].ToString();
                cbDoctorName.SelectedIndex = cbDoctorName.FindString(dtDiseases.Rows[0]["StaffName"].ToString());
                lblDiseaseID.Text = dtDiseases.Rows[0]["DiseaseID"].ToString();
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BindGridView();
            }
            catch (Exception ex)
            {
                ErrorLog oErrorLog = new ErrorLog();
                oErrorLog.WriteErrorLog(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BindDocotrsList();
            txtDiseaseName.Text = "";
        }

        private void dgDiseases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ObjDiseaseList = new BALDiseaseList();
            try
            {
                rowID = dgDiseases.Rows[e.RowIndex].Cells["DiseaseID"].Value.ToString();
                columnIndex = e.ColumnIndex;
                if (columnIndex == 3)
                {
                    strOperationName = dgDiseases.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
                    GetDiseaseListByID(rowID);
                }
                else if (columnIndex == 4)
                {
                    strOperationName = dgDiseases.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
                    DiseaseCrudResult = ObjDiseaseList.DeleteRecord(rowID);
                    if (DiseaseCrudResult == 1)
                    {
                        dtDiseases = new DataTable();
                        ObjDiseaseList.DoctorName = string.Empty;
                        ObjDiseaseList.DiseaseName = string.Empty;
                        dtDiseases = ObjDiseaseList.GetDisesesList(ObjDiseaseList);
                        dgDiseases.DataSource = dtDiseases;
                        txtDiseaseName.Text = string.Empty;
                        cbDoctorName.SelectedValue = 0;
                        MessageBox.Show(ConstatntMessages.strDeleteSuccess, "Alert");
                    }
                }
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
