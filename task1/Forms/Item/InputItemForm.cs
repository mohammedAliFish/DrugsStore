

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using task1.Data;

namespace task1.Forms.Item
{
    public partial class InputItemForm : Form 
    {
        private readonly Guid _itemsG;
        private DevExpress.XtraEditors.LookUpEdit categoryLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit companyLookUpEdit;




        private bool isNewRecord = true;
        private Guid selectedItemGuid = Guid.Empty;

       
        public InputItemForm(Guid itemsG)
        {
            InitializeComponent();
            _itemsG = itemsG; 
        }
        public void OpenForNewRecord()
        {
            ResetFormFields(); 
            ShowDialog();     
        }
        public void InputItemForm_Load(object sender, EventArgs e)
        {
            try
            {
              

            
                
                LoadCategoriesAndCompanies();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل البيانات: {ex.Message}");
            }
        }

        public void ResetFormFields()
        {
            isNewRecord = true;
            ItemNameText.Text = string.Empty;
            ItemCodeText.Text = string.Empty;
            ItemDescriptionText.Text = string.Empty;
           
        }
        class itemCategory1
        {
            public string CategoryName { get; set; }
            public Guid CategoryGuid { get; set; }
        }
        public void LoadCategoriesAndCompanies()
        {
            try
            {
               

                CategoryRepository categoryRepository = new CategoryRepository();
                CompanyRepository companyRepository = new CompanyRepository();

                var categories = categoryRepository.GetCategories();
                var companies = companyRepository.GetCompanies();

                var item = new List<itemCategory1>();
                itemCategory1 it = new itemCategory1();
                it.CategoryName = "moh";
                it.CategoryGuid = Guid.NewGuid();

                item.Add(it);

                categoryLookUpEdit.Properties.DataSource = item;
                categoryLookUpEdit.Properties.DisplayMember = "CategoryName";
                categoryLookUpEdit.Properties.ValueMember = "CategoryGuid";

                companyLookUpEdit.Properties.DataSource = companies;
                companyLookUpEdit.Properties.DisplayMember = "CompanyName";
                companyLookUpEdit.Properties.ValueMember = "CompanyGuid";



            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل التصنيفات أو الشركات: {ex.Message}");
            }
        }


       
        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ItemNameText.Text) ||
                categoryLookUpEdit.EditValue == null ||
                companyLookUpEdit.EditValue == null)
                {
                    MessageBox.Show("الرجاء ملء جميع الحقول المطلوبة.");
                    return;
                }

                var selectedCategoryGuid = (Guid)categoryLookUpEdit.EditValue;
                var selectedCompanyGuid = (Guid)companyLookUpEdit.EditValue;

                ItemRepository itemRepository = new ItemRepository();

                var item = new Model.Entities.Item
                {
                    ItemGUID = selectedItemGuid,
                    ItemName = ItemNameText.Text.Trim(),
                    ItemCode = ItemCodeText.Text.Trim(),
                    ItemDescription = ItemDescriptionText.Text.Trim(),
                    Category = new Model.Entities.Category { CategoryGuid = selectedCategoryGuid },
                    Company = new Model.Entities.Company { CompanyGuid = selectedCompanyGuid },
                  

                };

                itemRepository.SaveItem(item);

                MessageBox.Show("تم   بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ  : {ex.Message} {ex.StackTrace}");
                Console.WriteLine(ex.StackTrace);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (_itemsForm != null && _itemsForm.ItemGridView != null)
            //    {
            //        var selectedRow = _itemsForm.ItemGridView.GetFocusedDataRow();
            //        if (selectedRow == null)
            //        {
            //            MessageBox.Show("لا يوجد عنصر محدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        var confirmResult = MessageBox.Show("هل تريد بالتأكيد حذف هذا العنصر؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (confirmResult != DialogResult.Yes)
            //        {
            //            return;
            //        }

            //        Guid itemGuid = Guid.Parse(selectedRow["ItemGUID"].ToString());
            //        ItemRepository itemRepository = new ItemRepository();
            //        itemRepository.DeleteItem(itemGuid);

            //        MessageBox.Show("تم حذف العنصر بنجاح.", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        RefreshItemsFormGrid();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}");
            //}
        }
        public void SetItemData(Guid itemGuid, string itemName, string itemCode, string itemDescription, Guid categoryGuid, Guid companyGuid)
        {
            selectedItemGuid = itemGuid;
            ItemNameText.Text = itemName;
            ItemCodeText.Text = itemCode;
            ItemDescriptionText.Text = itemDescription;

           
            

            

          
            categoryLookUpEdit.EditValue = categoryGuid;
            companyLookUpEdit.EditValue = companyGuid;

          

            isNewRecord = false;
        }



        private void RefreshItemsFormGrid()
        {
            //if (_itemsForm != null)
            //{
            //    _itemsForm.LoadItemsData(); 
            //}
        }

        private void CategoryComboBox_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
