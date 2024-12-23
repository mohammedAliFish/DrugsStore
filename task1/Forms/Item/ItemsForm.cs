using System;
using DevExpress.XtraGrid;
using System.Data;
using task1.Data;
using System.Windows.Forms;




namespace task1.Forms.Item
{
    public partial class ItemsForm : CenterForm
    {
       
       
        public ItemsForm()
        {
            InitializeComponent();
        }
        private bool isNewRecord = true;
        private Guid selectedItemGuid = Guid.Empty;

        private void LoadItemsData()
        {
            
            string GetAllItems = "ItemGet";
            DataTable table = sqlHelper.ExecuteStoredProcedure(GetAllItems);
            itemGridControl.DataSource = table;

            itemGridView.ClearSelection();
            itemGridView.FocusedRowHandle = GridControl.InvalidRowHandle;

            isNewRecord = true;
            ItemCodeText.Text = string.Empty;
            ItemDescriptionText.Text = string.Empty;
            ItemNameText.Text = string.Empty;
            CategoryComboBox.SelectedIndex = -1;
            CompanyComboBox.SelectedIndex = -1;


            CategoryRepository categoryRepository = new CategoryRepository();
            CompanyRepository companyRepository = new CompanyRepository();

            var categories = categoryRepository.GetCategories();
            var companies = companyRepository.GetCompanies();


            CategoryComboBox.Properties.Items.Clear();
            foreach (var category in categories)
            {
                CategoryComboBox.Properties.Items.Add(category);
            }

            CompanyComboBox.Properties.Items.Clear();
            foreach (var company in companies)
            {
                CompanyComboBox.Properties.Items.Add(company);
            }

        }




        private void ItemsForm_Load(object sender, EventArgs e)
        {
            LoadItemsData();
        }

        private void ItemNameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null)
            {
                string selectedCategory = CategoryComboBox.SelectedItem.ToString();
                MessageBox.Show($"Selected Category: {selectedCategory}");
                
            }
        }

        private void CompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CompanyComboBox.SelectedItem != null) 
            {
            
                string selectedCompany = CompanyComboBox.SelectedItem.ToString();
                MessageBox.Show($"Selected Company");
            }
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ItemNameText.Text) || CategoryComboBox.SelectedItem == null || CompanyComboBox.SelectedItem == null)
                {
                    MessageBox.Show("الرجاء ملء جميع الحقول المطلوبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                var selectedCategory = CategoryComboBox.SelectedItem as Model.Entities.Category;
                var selectedCompany = CompanyComboBox.SelectedItem as Model.Entities.Company;

                if (selectedCategory == null || selectedCompany == null)
                {
                    MessageBox.Show("الرجاء تحديد تصنيف وشركة صحيحين.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                ItemRepository itemRepository = new ItemRepository();  

                var item = new Model.Entities.Item
                {
                    ItemGUID = isNewRecord ? Guid.Empty : selectedItemGuid,
                    ItemName = ItemNameText.Text.Trim(),
                    ItemCode = ItemCodeText.Text.Trim(),
                    ItemDescription = ItemDescriptionText.Text.Trim(),
                    Category = selectedCategory,
                    Company = selectedCompany
                };

                
                itemRepository.SaveItem(item);

                MessageBox.Show(isNewRecord ? "تمت إضافة العنصر بنجاح." : "تم تحديث العنصر بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                LoadItemsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
             
                if (itemGridView.FocusedRowHandle < 0)
                {
                    MessageBox.Show("الرجاء تحديد عنصر لحذفه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                var selectedRow = itemGridView.GetFocusedDataRow();
                if (selectedRow == null)
                {
                    MessageBox.Show("لا يوجد عنصر محدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                var confirmResult = MessageBox.Show("هل تريد بالتأكيد حذف هذا العنصر؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

                Guid itemGuid = Guid.Parse(selectedRow["ItemGUID"].ToString());

               
                ItemRepository itemRepository = new ItemRepository();
                itemRepository.DeleteItem(itemGuid);

                MessageBox.Show("تم حذف العنصر بنجاح.", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
                LoadItemsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}");
            }
        }

        private void itemGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var selectedRow = itemGridView.GetFocusedDataRow();
                if (selectedRow != null)
                {
                    selectedItemGuid = Guid.Parse(selectedRow["ItemGUID"].ToString());
                    ItemNameText.Text = selectedRow["ItemName"].ToString();
                    ItemCodeText.Text = selectedRow["ItemCode"].ToString();
                    ItemDescriptionText.Text = selectedRow["ItemDescription"].ToString();
                    CategoryComboBox.SelectedItem = selectedRow["CategoryName"].ToString();
                    CompanyComboBox.SelectedItem = selectedRow["CompanyName"].ToString();
                    isNewRecord = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}");
            }
        }
    }
}