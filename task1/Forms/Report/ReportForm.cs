using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using task1.Forms.Category;
using task1.Forms.Company;
using task1.Forms.Item;
using task1.Reports;
using task1.Repository;


namespace task1.Forms.Report
{
    public partial class ReportForm : CenterForm
    {
        private AllRepository allRepository;
        public ItemPopupForm SelectedItem { get; private set; }
        
        public ReportForm()
        {
            InitializeComponent();
            allRepository = new AllRepository();
        }

        private void CategoryNameBtnEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var categoryPopupForm = new CategoryPopupForm();

           
            if (categoryPopupForm.ShowDialog() == DialogResult.OK)
            {
                var selectedCategory = categoryPopupForm.SelectedCategory;
                if (selectedCategory != null)
                {
                    CategoryNameBtnEdit.EditValue = selectedCategory.CategoryName;
                    CategoryNameBtnEdit.Tag = selectedCategory.CategoryGuid;
                }
            }
        }

  

        private void barButtonItemShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var itemGuid = ItemNameBtnEdit.Tag as Guid?;
                var categoryGuid = CategoryNameBtnEdit.Tag as Guid?;
                var companyGuid = CompanyNameBtnEdit.Tag as Guid?;
                string itemName = ItemNameBtnEdit.Text.Trim();
                string categoryName = CategoryNameBtnEdit.Text.Trim();
                string companyName = CompanyNameBtnEdit.Text.Trim();
                if (string.IsNullOrEmpty(itemName)) itemGuid = null;
                if (string.IsNullOrEmpty(categoryName)) categoryGuid = null;
                if (string.IsNullOrEmpty(companyName)) companyGuid = null;

                var filteredData = allRepository.GetFilteredItems(itemGuid, categoryGuid, companyGuid);

                if (filteredData == null || filteredData.Rows.Count == 0)
                {
                    MessageBox.Show("ماكو بيانات ");
                    return;
                }

                allGridControl.DataSource = filteredData;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($" خطا  {ex.Message}");
            }
        }

        private void ItemNameBtnEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var popupForm = new ItemPopupForm();
            if (popupForm.ShowDialog() == DialogResult.OK && popupForm.SelectedItem != null)
            {
                var item = popupForm.SelectedItem;
                if (item != null)
                {
                    ItemNameBtnEdit.EditValue = item.ItemName;
                    ItemNameBtnEdit.Tag = item.ItemGUID;
                }

            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Export Data to Excel";
                saveFileDialog.FileName = "AllData.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = saveFileDialog.FileName;
                    allGridControl.ExportToXlsx(filePath);

                    MessageBox.Show("تم تصدير  الى كسل!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("هل تريد فتح الملف؟", "فتح الملف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                }
            }

        }
        private void PerformSearch()
        {
            try
            {
                var itemGuid = ItemNameBtnEdit.Tag as Guid?;
                var categoryGuid = CategoryNameBtnEdit.Tag as Guid?;
                var companyGuid = CompanyNameBtnEdit.Tag as Guid?;

                var filteredData = allRepository.GetFilteredItems(itemGuid, categoryGuid, companyGuid);

                if (filteredData == null || filteredData.Rows.Count == 0)
                {
                    MessageBox.Show(" ماكو بيانات ");
                    return;
                }

                allGridControl.DataSource = filteredData;

               
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($" خطا : {ex.Message}");
            }
        }
        private void PerformSearchByName()
        {
            try
            {
                string itemName = ItemNameBtnEdit.Text.Trim();    
                string categoryName = CategoryNameBtnEdit.Text.Trim(); 
                string companyName = CompanyNameBtnEdit.Text.Trim(); 

                DataTable filteredData = allRepository.GetFilteredItemsByName(itemName, categoryName, companyName);

                if (filteredData != null && filteredData.Rows.Count > 0)
                {
                    allGridControl.DataSource = filteredData;
                }
                else
                {
                    MessageBox.Show("ماكو بنات");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ItemNameBtnEdit_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearchByName();


            }
        }

        private void CompanyNameBtnEdit_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearchByName();


            }
       
        }

        private void CategoryNameBtnEdit_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {



                PerformSearchByName();

            }
           
        }
        private void printReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                var gridView = allGridControl.MainView as DevExpress.XtraGrid.Views.Grid.GridView;


                if (gridView == null || gridView.RowCount == 0)
                {
                    MessageBox.Show("ماكو بيانات  ");
                    return;
                }


                var dataTable = new DataTable();


                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                {
                    dataTable.Columns.Add(column.FieldName, column.ColumnType);
                    Console.WriteLine($"Column Name: {column.FieldName}");
                }


                for (int i = 0; i < gridView.RowCount; i++)
                {
                    var row = dataTable.NewRow();
                    foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                    {
                        row[column.FieldName] = gridView.GetRowCellValue(i, column);
                    }
                    dataTable.Rows.Add(row);
                }


                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("ماكو بيانات للطباعة");
                    return;
                }


                var report = new itemsReport
                {
                    DataSource = dataTable,
                    DataMember = dataTable.TableName
                };


                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء الطباعة: {ex.Message}");
            }
        }


 


        private void CompanyNameBtnEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var companyPopupForm = new CompanyPopupForm();
            if (companyPopupForm.ShowDialog() == DialogResult.OK)
            {
                var selectedCompany = companyPopupForm.SelectedCompany;
                if (selectedCompany != null)
                {
                    CompanyNameBtnEdit.EditValue = selectedCompany.CompanyName;
                    CompanyNameBtnEdit.Tag = selectedCompany.CompanyGuid;
                }
            }
        }
    }
}


        