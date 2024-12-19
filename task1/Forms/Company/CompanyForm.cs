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
            if (table.Rows.Count > 0)
            {
                companyGridView.FocusedRowHandle = table.Rows.Count - 1;
            }
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

        //    sqlHelper.ExecuteNonQuery(CompanySave, CommandType.StoredProcedure, pr);

        //    MessageBox.Show("اضافه تمت");

        //    LoadCompanyData();

        //    CompanyCodeText.Text = string.Empty;
        //    CompanyNameText.Text = string.Empty;

        //}

        //private void btnSaveOrUpdate_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
              
        //        string companyGUID = companyGridView.GetFocusedRowCellValue("CompanyGUID").ToString(); 
        //        string companyName = CompanyNameText.Text; 
        //        string companyCode = CompanyCodeText.Text; 

        //        if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(companyCode))
        //        {
        //            MessageBox.Show("الرجاء إدخال اسم الشركة ورمز الشركة");
        //            return;
        //        }

        //        string CompanySave = "CompanySave";

              
        //        SqlParameter[] parameters = new SqlParameter[]
        //        {
        //    new SqlParameter("@CompanyGUID", SqlDbType.UniqueIdentifier)
        //    {
        //        Value = string.IsNullOrEmpty(companyGUID) ? (object)DBNull.Value : Guid.Parse(companyGUID),
        //        Direction = ParameterDirection.InputOutput
        //    },
        //    new SqlParameter("@CompanyName", SqlDbType.NVarChar) { Value = companyName },
        //    new SqlParameter("@CompanyCode", SqlDbType.NVarChar) { Value = companyCode }
        //        };

        //        sqlHelper.ExecuteStoredProcedureWithOutput(CompanySave, parameters);

              
        //        MessageBox.Show("تم الحفظ ");

             
        //        LoadCompanyData();

             
        //        CompanyCodeText.Text = string.Empty;
        //        CompanyNameText.Text = string.Empty;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"حدث خطأ: {ex.Message}");
        //    }
        //}




        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        object companyGuidObj = companyGridControl.GetFocusedRowCellValue("CompanyGUID");
        //        if (companyGuidObj == null || string.IsNullOrWhiteSpace(companyGuidObj.ToString()))
        //        {
        //            MessageBox.Show("الرجاء تحديد الشركة المراد حذفها.");
        //            return;
        //        }

        //        Guid companyGuid = Guid.Parse(companyGuidObj.ToString());


        //        var confirmResult = MessageBox.Show("هل تريد حذف الشركة");
        //        if (confirmResult == DialogResult.Yes)
        //        {

        //            string DeleteCompany = "DeleteCompany";
        //            SqlParameter[] parameters = {
        //        new SqlParameter("@CompanyGUID", companyGuid)
        //    };

        //            sqlHelper.ExecuteNonQuery(DeleteCompany, CommandType.StoredProcedure, parameters);

        //            MessageBox.Show("تم حذف  بنجاح");


        //            LoadCompanyData();


        //            CompanyCodeText.Text = string.Empty;
        //            CompanyNameText.Text = string.Empty;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"حدث خطأ   : {ex.Message}");
        //    }
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                object companyGuidObj = companyGridView.GetFocusedRowCellValue("CompanyGUID");
                if (companyGuidObj == null || string.IsNullOrWhiteSpace(companyGuidObj.ToString()))
                {
                    MessageBox.Show("الرجاء تحديد الشركة المراد حذفها");
                    return;
                }

                Guid companyGuid = Guid.Parse(companyGuidObj.ToString());


                var confirmResult = MessageBox.Show("هل تريد حذف الشركة؟");
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }


                string CompanyDelete = "CompanyDelete";
                SqlParameter[] parameters = {
            new SqlParameter("@CompanyGUID", SqlDbType.UniqueIdentifier) { Value = companyGuid }
        };


                sqlHelper.ExecuteNonQuery(CompanyDelete, CommandType.StoredProcedure, parameters);


                MessageBox.Show("تم الحذف بنجاح");


                LoadCompanyData();


                CompanyCodeText.Text = string.Empty;
                CompanyNameText.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ   : {ex.Message}");
            }
        }

        private void btnSaveOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from input fields
                string companyGUID = companyGridView.GetFocusedRowCellValue("CompanyGUID").ToString(); // Get GUID if a row is selected
                string companyName = CompanyNameText.Text.Trim(); // Get company name
                string companyCode = CompanyCodeText.Text.Trim(); // Get company code

                // Validate input
                if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(companyCode))
                {
                    MessageBox.Show("الرجاء إدخال اسم الشركة ورمز الشركة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Define stored procedure name
                string CompanySave = "CompanySave";

                // Prepare parameters for the stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@CompanyGUID", SqlDbType.UniqueIdentifier)
            {
                Value = string.IsNullOrEmpty(companyGUID) ? (object)DBNull.Value : Guid.Parse(companyGUID), // Null for new records
                Direction = ParameterDirection.InputOutput // For output of GUID after insert
            },
            new SqlParameter("@CompanyName", SqlDbType.NVarChar) { Value = companyName },
            new SqlParameter("@CompanyCode", SqlDbType.NVarChar) { Value = companyCode }
                };

                // Execute the stored procedure
                sqlHelper.ExecuteStoredProcedureWithOutput(CompanySave, parameters);

                // Display success message
                MessageBox.Show("تم الحفظ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reload data in the grid
                LoadCompanyData();

                // Clear input fields
                CompanyCodeText.Text = string.Empty;
                CompanyNameText.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطا  : {ex.Message}");
            }
        }

    }
}