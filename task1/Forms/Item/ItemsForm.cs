using System;
using DevExpress.XtraGrid;
using System.Data;
using task1.Data;
using DevExpress.Utils.MVVM;
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
            CategoryComboBox.SelectedIndex = 0;
            CompanyComboBox.SelectedIndex = 0;
            CategoryRepository categoryRepository = new CategoryRepository();
            CompanyRepository companyRepository = new CompanyRepository();

            var categories = categoryRepository.GetCategories();
            var companyies = companyRepository.GetCompanies();

            CategoryComboBox.Properties.Items.Clear();
            CompanyComboBox.Properties.Items.Clear();
            foreach (var category in categories)
            {
                CategoryComboBox.Properties.Items.Add(category.CategoryName);
            }
            foreach (var company in companyies) 
            {
                CompanyComboBox.Properties.Items.Add(company.CompanyName);
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
    }
}