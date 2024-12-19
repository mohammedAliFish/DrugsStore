using System;

using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;


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

        private void LoadCompanyData()
        {
            string GetAllCompanies = "CompanyGet";
            DataTable table = sqlHelper.ExecuteStoredProcedure(GetAllCompanies);
            companyGridControl.DataSource = table;
        }

        //private void btnSaveOrUpdate_Click(object sender, EventArgs e)
        //{
        //    //string companyGUID = companyGridView.GetFocusedRowCellValue("CompanyGUID").ToString(); 
        //    string companyName = CompanyNameText.Text; 
        //    string companyCode = CompanyCodeText.Text;

        //    string CompanySave = "CompanySave";
        //    SqlParameter[] pr = new SqlParameter[] 
        //    {

        //        new SqlParameter("@CompanyCode",companyCode),
        //        new SqlParameter("@CompanyName" , companyName)
        //    };

        //    sqlHelper.ExecuteNonQuery(CompanySave, CommandType.StoredProcedure,pr);

        //    MessageBox.Show("اضافه تمت");

        //    LoadCompanyData();

        //    CompanyCodeText.Text = string.Empty;
        //    CompanyNameText.Text = string.Empty;

        //}

        private void btnSaveOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
              
                string companyGUID = companyGridView.GetFocusedRowCellValue("CompanyGUID").ToString(); 
                string companyName = CompanyNameText.Text.Trim(); 
                string companyCode = CompanyCodeText.Text.Trim(); 

                if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(companyCode))
                {
                    MessageBox.Show("الرجاء إدخال اسم الشركة ورمز الشركة");
                    return;
                }

                string storedProcedureName = "CompanySave";

              
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

                sqlHelper.ExecuteStoredProcedureWithOutput(storedProcedureName, parameters);

              
                MessageBox.Show("تم الحفظ ");

             
                LoadCompanyData();

             
                CompanyCodeText.Text = string.Empty;
                CompanyNameText.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}");
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطا  : {ex.Message}");
            }
        }

    }
}