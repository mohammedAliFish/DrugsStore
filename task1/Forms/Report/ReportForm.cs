using System;
using System.Collections.Generic;
using System.Windows.Forms;
using task1.Forms.Category;
using task1.Forms.Company;
using task1.Forms.Item;
using task1.Model.Entities;
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
            var companyPopupForm = new CompanyPopupForm();
            if(companyPopupForm.ShowDialog() == DialogResult.OK)
            {
                var selectedCompany = companyPopupForm.SelectedCompany;
                if (selectedCompany != null)
                {
                    CompanyNameBtnEdit.EditValue = selectedCompany.CompanyName;
                    CompanyNameBtnEdit.Tag = selectedCompany.CompanyGuid;
                }
            }

        }

        private void ItemNameBtnEdit_Properties_Click(object sender, EventArgs e)
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
                    MessageBox.Show("No data found for the selected criteria.");
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
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void ItemNameBtnEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
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
                    MessageBox.Show("No data found for the selected criteria.");
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
             
        }

        private void ItemNameBtnEdit_Properties_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void CompanyNameBtnEdit_Properties_DoubleClick(object sender, EventArgs e)
        {

        }

        private void printReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
            //    var dataSource = allGridControl.DataSource;
            //    if (dataSource == null)
            //    {
            //        MessageBox.Show("No data to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    FilteredReport report = new FilteredReport
            //    {
            //        DataSource = dataSource,
            //        DataMember = "YourTableName" 
            //    };

            //    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            //    {
            //        saveFileDialog.Filter = "PDF Files|*.pdf|Excel Files|*.xlsx";
            //        saveFileDialog.Title = "Export Report";
            //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //        {
            //            string filePath = saveFileDialog.FileName;
            //            if (filePath.EndsWith(".pdf"))
            //            {
            //                report.ExportToPdf(filePath);
            //            }
            //            else if (filePath.EndsWith(".xlsx"))
            //            {
            //                report.ExportToXlsx(filePath);
            //            }

            //            MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
            //            if (MessageBox.Show("Do you want to open the file?", "Open File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //            {
            //                System.Diagnostics.Process.Start(filePath);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

    }
}


        