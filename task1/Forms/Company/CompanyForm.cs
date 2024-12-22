using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraGrid;


namespace task1.Forms.Company
{
    public partial class CompanyForm : CenterForm
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            LoadCompanyData();
        }

        private bool isNewRecord = true;

        private void LoadCompanyData()
        {
            string GetAllCompanies = "CompanyGet";
            DataTable table = sqlHelper.ExecuteStoredProcedure(GetAllCompanies);
            companyGridControl.DataSource = table;

           
            companyGridView.ClearSelection();
            companyGridView.FocusedRowHandle = GridControl.InvalidRowHandle;

           
            isNewRecord = true;
            CompanyCodeText.Text = string.Empty;
            CompanyNameText.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
              
                object companyGuidObj = companyGridView.GetFocusedRowCellValue("CompanyGUID");

                if (companyGuidObj == null || string.IsNullOrWhiteSpace(companyGuidObj.ToString()))
                {
                    MessageBox.Show(" تحديد الشركة  لحذفها");
                    return;
                }

             
                Guid companyGuid;
                if (!Guid.TryParse(companyGuidObj.ToString(), out companyGuid))
                {
                    MessageBox.Show("تعذر قراءة معرف الشركة. الرجاء المحاولة مرة أخرى.");
                    return;
                }


                var confirmResult = MessageBox.Show("هل تريد حذف الشركة؟");
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

           
                string CompanyDelete = "CompanyDelete";

    
                SqlParameter[] parameters = {
            new SqlParameter("@CompanyGUID", SqlDbType.UniqueIdentifier) { Value = companyGuid }
        };

            
                int rowsAffected = sqlHelper.ExecuteNonQuery(CompanyDelete, CommandType.StoredProcedure, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("تم الحذف ");

                
                    LoadCompanyData();

               
                    CompanyCodeText.Text = string.Empty;
                    CompanyNameText.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على الشركة أو تعذر حذفها.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}");
            }
        }



        private void btnSaveOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string companyGUID = null;

                
                if (!isNewRecord && companyGridView.FocusedRowHandle >= 0)
                {
                    companyGUID = companyGridView.GetFocusedRowCellValue("CompanyGUID")?.ToString();
                }

                string companyName = CompanyNameText.Text.Trim();
                string companyCode = CompanyCodeText.Text.Trim();

               
                if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(companyCode))
                {
                    MessageBox.Show(" إدخال اسم ورمز الشركة");
                    return;
                }

               
                string CompanySave = "CompanySave";

                
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@CompanyGUID", SqlDbType.UniqueIdentifier)
            {
                Value = string.IsNullOrEmpty(companyGUID) ? (object)DBNull.Value : Guid.Parse(companyGUID),
                Direction = ParameterDirection.InputOutput
            },
            new SqlParameter("@CompanyName", SqlDbType.NVarChar) { Value = companyName },
            new SqlParameter("@CompanyCode", SqlDbType.NVarChar) { Value = companyCode }
                };

               
                sqlHelper.ExecuteStoredProcedureWithOutput(CompanySave, parameters);

                
                MessageBox.Show(isNewRecord ? "تم الإضافة بنجاح" : "تم التحديث بنجاح");

              
                LoadCompanyData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($" خطأ الحفظ {ex.Message}");
            }
        }






        private void companyGridControl_Click(object sender, EventArgs e)
        {

        }

        private void CompanyCodeTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void CompanyNameTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void companyGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (companyGridView.FocusedRowHandle >= 0)
                {
                  
                    CompanyCodeText.Text = companyGridView.GetFocusedRowCellValue("CompanyCode").ToString();
                    CompanyNameText.Text = companyGridView.GetFocusedRowCellValue("CompanyName").ToString();

                    
                    isNewRecord = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" خطأ تحديد الشركة {ex.Message}");
            }
        }


    }
}