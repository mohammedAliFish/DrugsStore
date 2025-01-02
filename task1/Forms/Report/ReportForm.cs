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
        public CategoryPopupForm SelectedCategory { get; private set; }


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
        
                ItemNameBtnEdit.EditValue = popupForm.SelectedItem.ItemName;
                ItemNameBtnEdit.Tag = popupForm.SelectedItem.ItemGUID;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}