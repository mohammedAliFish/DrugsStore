using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraGrid;



namespace task1.Forms.Category
{
    public partial class CategoryForm : CenterForm
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
                LoadCategoryData();
        }

        

        private bool isNewRecord = true;

        private void LoadCategoryData()
        {
            string GetAllCateory = "CategoryGet";
            DataTable table = sqlHelper.ExecuteStoredProcedure(GetAllCateory);
            categoryGridControl.DataSource = table;


         

            categoryGridView.ClearSelection();
            categoryGridView.FocusedRowHandle = GridControl.InvalidRowHandle;

            isNewRecord = true;
            CategoryCodeText.Text = string.Empty;
            CategoryNameText.Text = string.Empty;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (categoryGridView.FocusedRowHandle >= 0)
                {
                    
                    CategoryCodeText.Text = categoryGridView.GetFocusedRowCellValue("CategoryCode").ToString();
                    CategoryNameText.Text = categoryGridView.GetFocusedRowCellValue("CategoryName").ToString();

                    isNewRecord = false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" خطأ  تحديد التصنيف: {ex.Message}");
            }
        }


      
        private void btnSaveOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryGUID = null;

                
                if (!isNewRecord && categoryGridView.FocusedRowHandle >= 0)
                {
                    categoryGUID = categoryGridView.GetFocusedRowCellValue("CategoryGUID")?.ToString();
                }

                string categoryName = CategoryNameText.Text.Trim();
                string categoryCode = CategoryCodeText.Text.Trim();

               
                if (string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(categoryCode))
                {
                    MessageBox.Show(" إدخال اسم  ورمز اللفئة");
                    return;
                }

               
                string CategorySave = "CategorySave";

                
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@CategoryGUID", SqlDbType.UniqueIdentifier)
            {
                Value = string.IsNullOrEmpty(categoryGUID) ? (object)DBNull.Value : Guid.Parse(categoryGUID),
                Direction = ParameterDirection.InputOutput 
            },
            new SqlParameter("@CategoryName", SqlDbType.NVarChar) { Value = categoryName },
            new SqlParameter("@CategoryCode", SqlDbType.NVarChar) { Value = categoryCode }
                };

               
                sqlHelper.ExecuteStoredProcedureWithOutput(CategorySave, parameters);

                MessageBox.Show(isNewRecord ? "تم الإضافة " : "تم التحديث ");

               
                LoadCategoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($" خطأ  الحفظ: {ex.Message}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                object categoryGuidObj = categoryGridView.GetFocusedRowCellValue("CategoryGUID");

                if (categoryGuidObj == null || string.IsNullOrWhiteSpace(categoryGuidObj.ToString()))
                {
                    MessageBox.Show(" تحديد التصنيف  لحذفه");
                    return;
                }

             
                if (!Guid.TryParse(categoryGuidObj.ToString(), out Guid categoryGuid))
                {
                    MessageBox.Show("تعذر قراءة معرف التصنيف. الرجاء المحاولة مرة أخرى.");
                    return;
                }

                
                var confirmResult = MessageBox.Show("هل تريد حذف التصنيف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

               
                string CategoryDelete = "CategoryDelete";

              
                SqlParameter[] parameters = {
            new SqlParameter("@CategoryGUID", SqlDbType.UniqueIdentifier) { Value = categoryGuid }
        };

               
                int rowsAffected = sqlHelper.ExecuteNonQuery(CategoryDelete, CommandType.StoredProcedure, parameters);

               
                if (rowsAffected > 0)
                {
                    MessageBox.Show("تم الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
                    LoadCategoryData();

                   
                    CategoryCodeText.Text = string.Empty;
                    CategoryNameText.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على التصنيف المراد حذفه.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحذف: لايمكن حذف التصنيف لان هنالك عناصر مرتبطه به");
            }
        }

       

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Export Data to Excel";
                    saveFileDialog.FileName = "CategoryData.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                   
                        string filePath = saveFileDialog.FileName;
                        categoryGridView.ExportToXlsx(filePath);

                        MessageBox.Show("تم تصدير  الى كسل!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("هل تريد فتح الملف؟", "فتح الملف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(filePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء التصدير ");
            }
        }

        private void btnShowTree_Click(object sender, EventArgs e)
        {
            CategoryTreeViewForm categoryTreeViewForm = new CategoryTreeViewForm();
            categoryTreeViewForm.ShowDialog();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}