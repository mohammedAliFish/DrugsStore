//using System;
//using System.Data;
//using System.Windows.Forms;
//using task1.Data;


//namespace task1.Forms.Item
//{
//    public partial class InputItemForm : CenterForm
//    {
//        private ItemsForm _itemsForm;

//        private bool isNewRecord = true;
//        private Guid selectedItemGuid = Guid.Empty;
//        public InputItemForm()
//        {
//            InitializeComponent();
//            _itemsForm = itemsForm;
//        }

//        private void InputItemForm_Load(object sender, EventArgs e)
//        {
//            try
//            {

//                string GetAllItems = "ItemGet";
//                DataTable table = sqlHelper.ExecuteStoredProcedure(GetAllItems);
//                itemGridControl.DataSource = table;

//                itemGridView.ClearSelection();
//                itemGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;

//                isNewRecord = true;
//                ItemNameText.Text = string.Empty;
//                ItemCodeText.Text = string.Empty;
//                ItemDescriptionText.Text = string.Empty;
//                CategoryComboBox.SelectedIndex = -1;
//                CompanyComboBox.SelectedIndex = -1;


//                CategoryRepository categoryRepository = new CategoryRepository();
//                CompanyRepository companyRepository = new CompanyRepository();

//                var categories = categoryRepository.GetCategories();
//                var companies = companyRepository.GetCompanies();

//                CategoryComboBox.Properties.Items.Clear();
//                foreach (var category in categories)
//                {
//                    CategoryComboBox.Properties.Items.Add(category);
//                }

//                CompanyComboBox.Properties.Items.Clear();
//                foreach (var company in companies)
//                {
//                    CompanyComboBox.Properties.Items.Add(company);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"خطأ أثناء تحميل البيانات: {ex.Message}");
//            }
//        }
//        private void LoadItemsData()
//        {
//            LoadItemsData();
//            //try
//            //{

//            //    string GetAllItems = "ItemGet";
//            //    DataTable table = sqlHelper.ExecuteStoredProcedure(GetAllItems);


//            //    itemGridControl.DataSource = table;


//            //    itemGridView.ClearSelection();
//            //    itemGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;


//            //    isNewRecord = true;
//            //    ItemNameText.Text = string.Empty;
//            //    ItemCodeText.Text = string.Empty;
//            //    ItemDescriptionText.Text = string.Empty;
//            //    CategoryComboBox.SelectedIndex = -1;
//            //    CompanyComboBox.SelectedIndex = -1;


//            //    CategoryRepository categoryRepository = new CategoryRepository();
//            //    CompanyRepository companyRepository = new CompanyRepository();

//            //    var categories = categoryRepository.GetCategories();
//            //    var companies = companyRepository.GetCompanies();


//            //    CategoryComboBox.Properties.Items.Clear();
//            //    foreach (var category in categories)
//            //    {
//            //        CategoryComboBox.Properties.Items.Add(category);
//            //    }


//            //    CompanyComboBox.Properties.Items.Clear();
//            //    foreach (var company in companies)
//            //    {
//            //        CompanyComboBox.Properties.Items.Add(company);
//            //    }
//            //}
//            //catch (Exception ex)
//            //{
//            //    MessageBox.Show($"خطأ أثناء تحميل البيانات: {ex.Message}");
//            //}
//        }


//        private void btnAddOrUpdate_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (string.IsNullOrWhiteSpace(ItemNameText.Text) || CategoryComboBox.SelectedItem == null || CompanyComboBox.SelectedItem == null)
//                {
//                    MessageBox.Show("الرجاء ملء جميع الحقول المطلوبة.");
//                    return;
//                }

//                var selectedCategory = CategoryComboBox.SelectedItem as Model.Entities.Category;
//                var selectedCompany = CompanyComboBox.SelectedItem as Model.Entities.Company;

//                if (selectedCategory == null || selectedCompany == null)
//                {
//                    MessageBox.Show("الرجاء تحديد تصنيف وشركة صحيحين.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;
//                }

//                ItemRepository itemRepository = new ItemRepository();

//                var item = new Model.Entities.Item
//                {
//                    ItemGUID = isNewRecord ? Guid.Empty : selectedItemGuid,
//                    ItemName = ItemNameText.Text.Trim(),
//                    ItemCode = ItemCodeText.Text.Trim(),
//                    ItemDescription = ItemDescriptionText.Text.Trim(),
//                    Category = selectedCategory,
//                    Company = selectedCompany
//                };

//                itemRepository.SaveItem(item);

//                MessageBox.Show(isNewRecord ? "تمت إضافة العنصر بنجاح." : "تم تحديث العنصر بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                LoadItemsData();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnDelete_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (itemGridView.FocusedRowHandle < 0)
//                {
//                    MessageBox.Show("الرجاء تحديد عنصر لحذفه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;
//                }

//                var selectedRow = itemGridView.GetFocusedDataRow();
//                if (selectedRow == null)
//                {
//                    MessageBox.Show("لا يوجد عنصر محدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    return;
//                }

//                var confirmResult = MessageBox.Show("هل تريد بالتأكيد حذف هذا العنصر؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//                if (confirmResult != DialogResult.Yes)
//                {
//                    return;
//                }

//                Guid itemGuid = Guid.Parse(selectedRow["ItemGUID"].ToString());

//                ItemRepository itemRepository = new ItemRepository();
//                itemRepository.DeleteItem(itemGuid);

//                MessageBox.Show("تم حذف العنصر بنجاح.", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                LoadItemsData();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}");
//            }
//        }
//    }
//}

using System;
using System.Data;
using System.Windows.Forms;
using task1.Data;

namespace task1.Forms.Item
{
    public partial class InputItemForm : CenterForm
    {
        private readonly ItemsForm _itemsForm;
        private DevExpress.XtraGrid.GridControl itemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView itemGridView;

        private bool isNewRecord = true;
        private Guid selectedItemGuid = Guid.Empty;

       
        public InputItemForm(ItemsForm itemsForm)
        {
            InitializeComponent();
            _itemsForm = itemsForm; 
        }

        public void InputItemForm_Load(object sender, EventArgs e)
        {
            try
            {
                
                if (_itemsForm != null)
                {
                    var itemsData = (DataTable)_itemsForm.ItemGridControl.DataSource;
                    itemGridControl.DataSource = itemsData;
                }

            
                ResetFormFields();
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
            CategoryComboBox.SelectedIndex = -1;
            CompanyComboBox.SelectedIndex = -1;
        }

        public void LoadCategoriesAndCompanies()
        {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل التصنيفات أو الشركات: {ex.Message}");
            }
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ItemNameText.Text) || CategoryComboBox.SelectedItem == null || CompanyComboBox.SelectedItem == null)
                {
                    MessageBox.Show("الرجاء ملء جميع الحقول المطلوبة.");
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

                RefreshItemsFormGrid(); 
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

                RefreshItemsFormGrid(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}");
            }
        }

        private void RefreshItemsFormGrid()
        {
            if (_itemsForm != null)
            {
                _itemsForm.LoadItemsData(); 
            }
        }
    }
}
