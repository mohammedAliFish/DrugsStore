using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

using task1.Forms.Category;
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

       
      
        private void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadItemsToSearchLookUpEdit();

          
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}");
            }
        }


        






        private void LoadItemsToSearchLookUpEdit()
        {
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        

       
       

    
       
       

       

        private void ItemNameBtnEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void CompanyNameBtnEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void CategoryNameBtnEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                var itemGuid = ItemNameBtnEdit.Tag as Guid?;
                var categoryGuid = CategoryNameBtnEdit.Tag as Guid?;
                var companyGuid = CompanyNameBtnEdit.Tag as Guid?;

              
                var filteredData = allRepository.GetFilteredItems(itemGuid, categoryGuid, companyGuid);

            
                if (filteredData == null || filteredData.Rows.Count == 0)
                {
                    MessageBox.Show("No data ");
                    return;
                }

                
                allGridControl.DataSource = filteredData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($" error  {ex.Message}");
            }
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

        private void CompanyNameBtnEdit_Properties_Click(object sender, EventArgs e)
        {
       

        }

        private void ItemNameBtnEdit_Properties_Click(object sender, EventArgs e)
        {
            
        }



        private void barButtonItemShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var itemGuid = ItemNameBtnEdit.Tag as Guid?;
                var categoryGuid = CategoryNameBtnEdit.Tag as Guid?;
                var companyGuid = CompanyNameBtnEdit.Tag as Guid?;

                var filteredData = allRepository.GetFilteredItems(itemGuid, categoryGuid, companyGuid);

                if (filteredData == null || filteredData.Rows.Count == 0)
                {
                    MessageBox.Show("No data ");
                    return;
                }

                allGridControl.DataSource = filteredData;
                // ItemNameBtnEdit.EditValue = null;
                // ItemNameBtnEdit.Text = string.Empty;
                // ItemNameBtnEdit.Tag = null;

                //CategoryNameBtnEdit.EditValue = null;
                //CategoryNameBtnEdit.Text = string.Empty;
                //CategoryNameBtnEdit.Tag = null;

                //CompanyNameBtnEdit.EditValue = null;
                //CompanyNameBtnEdit.Text = string.Empty;
                //CompanyNameBtnEdit.Tag = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($" error  {ex.Message}");
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
                    MessageBox.Show("No data ");
                    return;
                }

                allGridControl.DataSource = filteredData;

               
                ItemNameBtnEdit.EditValue = null;
                ItemNameBtnEdit.Text = string.Empty;
                ItemNameBtnEdit.Tag = null;

                CategoryNameBtnEdit.EditValue = null;
                CategoryNameBtnEdit.Text = string.Empty;
                CategoryNameBtnEdit.Tag = null;

                CompanyNameBtnEdit.EditValue = null;
                CompanyNameBtnEdit.Text = string.Empty;
                CompanyNameBtnEdit.Tag = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void ItemNameBtnEdit_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
                e.Handled = true;
                e.SuppressKeyPress = true; 
            }
        }

        private void CompanyNameBtnEdit_Properties_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CategoryNameBtnEdit_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                try
                {
                   
                    var itemGuid = ItemNameBtnEdit.Tag as Guid?;
                    var categoryGuid = CategoryNameBtnEdit.Tag as Guid?;
                    var companyGuid = CompanyNameBtnEdit.Tag as Guid?;

                   
                    var filteredData = allRepository.GetFilteredItems(itemGuid, categoryGuid, companyGuid);

                   
                    if (filteredData == null || filteredData.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for the selected criteria.");
                        return;
                    }

                   
                    allGridControl.DataSource = filteredData;

                    
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        private void ItemNameBtnEdit_Properties_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void CompanyNameBtnEdit_Properties_DoubleClick(object sender, EventArgs e)
        {

        }

        private void printReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
                var itemGuid = ItemNameBtnEdit.Tag as Guid?;
                var categoryGuid = CategoryNameBtnEdit.Tag as Guid?;
                var companyGuid = CompanyNameBtnEdit.Tag as Guid?;
                var filteredData = allRepository.GetFilteredItems(itemGuid, categoryGuid, companyGuid);

                if (filteredData == null || filteredData.Rows.Count == 0)
                {
                    MessageBox.Show("No data ");
                    return;
                }

                
                var report = new itemsReport();

               
                report.DataSource = filteredData;
                report.DataMember = filteredData.TableName ;

                
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($" error printing the report {ex.Message}");
            }
        }

    }
}


        