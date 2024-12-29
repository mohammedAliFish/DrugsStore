

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using task1.Data;

namespace task1.Forms.Item
{
    public partial class InputItemForm : Form 
    {
        private readonly Guid _itemsG;
        public event Action DataUpdated;






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
       
        public void LoadCategoriesAndCompanies()
        {
            try
            {
               

                CategoryRepository categoryRepository = new CategoryRepository();
                CompanyRepository companyRepository = new CompanyRepository();

                var categories = categoryRepository.GetCategories();
                var companies = companyRepository.GetCompanies();





                CategorylookUpEdit.Properties.DataSource = categories;
                CategorylookUpEdit.Properties.DisplayMember = "CategoryName";
                CategorylookUpEdit.Properties.ValueMember = "CategoryGuid";



                CompanylookUpEdit.Properties.DataSource = companies;
                CompanylookUpEdit.Properties.DisplayMember = "CompanyName";
                CompanylookUpEdit.Properties.ValueMember = "CompanyGuid";
               



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
                    CategorylookUpEdit.EditValue == null ||
                    CompanylookUpEdit.EditValue == null ||
                    string.IsNullOrWhiteSpace(itemPriceTextBox.Text) ||
                    string.IsNullOrWhiteSpace(wholesalePriceTextBox.Text) ||
                    string.IsNullOrWhiteSpace(distributorPriceTextBox.Text))
                {
                    MessageBox.Show("الرجاء ملء جميع الحقول المطلوبة.");
                    return;
                }

                if (!Guid.TryParse(CategorylookUpEdit.EditValue.ToString(), out var selectedCategoryGuid) ||
                    !Guid.TryParse(CompanylookUpEdit.EditValue.ToString(), out var selectedCompanyGuid))
                {
                    MessageBox.Show("خطأ في اختيار الشركة أو التصنيف.");
                    return;
                }

                
                if (!decimal.TryParse(itemPriceTextBox.Text, out var itemPrice) ||
                    !decimal.TryParse(wholesalePriceTextBox.Text, out var wholesalePrice) ||
                    !decimal.TryParse(distributorPriceTextBox.Text, out var distributorPrice))
                {
                    MessageBox.Show("الرجاء إدخال أسعار صحيحة.");
                    return;
                }

                
                ItemRepository itemRepository = new ItemRepository();
                var item = new Model.Entities.Item
                {
                    ItemGUID = selectedItemGuid == Guid.Empty ? Guid.NewGuid() : selectedItemGuid,
                    ItemName = ItemNameText.Text.Trim(),
                    ItemCode = ItemCodeText.Text.Trim(),
                    ItemDescription = ItemDescriptionText.Text.Trim(),
                    Category = new Model.Entities.Category { CategoryGuid = selectedCategoryGuid },
                    Company = new Model.Entities.Company { CompanyGuid = selectedCompanyGuid }
                };

                itemRepository.SaveItem(item);

              
                if (selectedItemGuid == Guid.Empty)
                {
                    selectedItemGuid = itemRepository.GetItemGUIDByCode(item.ItemCode); 
                }

                if (selectedItemGuid == Guid.Empty)
                {
                    MessageBox.Show("حدث خطأ أثناء حفظ العنصر.");
                    return;
                }

              
                var pricesTable = new DataTable();
                pricesTable.Columns.Add("PriceGUID", typeof(Guid));
                pricesTable.Columns.Add("ItemGUID", typeof(Guid));
                pricesTable.Columns.Add("ItemPrice", typeof(decimal));
                pricesTable.Columns.Add("PriceNumber", typeof(byte));

                pricesTable.Rows.Add(Guid.NewGuid(), selectedItemGuid, itemPrice, 1);
                pricesTable.Rows.Add(Guid.NewGuid(), selectedItemGuid, wholesalePrice, 2); 
                pricesTable.Rows.Add(Guid.NewGuid(), selectedItemGuid, distributorPrice, 3); 

               
                SavePricesToDatabase(pricesTable);

                MessageBox.Show("تم الحفظ بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataUpdated?.Invoke(); 
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message} \n {ex.StackTrace}");
            }
        }

        private void SavePricesToDatabase(DataTable pricesTable)
        {
            try
            {
                var parameter = new SqlParameter
                {
                    ParameterName = "@Prices",
                    SqlDbType = SqlDbType.Structured,
                    Value = pricesTable,
                    TypeName = "PriceTableType" 
                };

              
                sqlHelper.ExecuteNonQuery("PriceSaveMultiple", CommandType.StoredProcedure, new[] { parameter });

                MessageBox.Show("تم حفظ الأسعار بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ الأسعار: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
               
                var confirmResult = MessageBox.Show("هل تريد  حذف  العنصر؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return; 
                }

              
               

               
                ItemRepository itemRepository = new ItemRepository();
                itemRepository.DeleteItem(selectedItemGuid);

                MessageBox.Show("تم حذف  .", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataUpdated?.Invoke();


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ  : {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetItemData(Guid itemGuid, string itemName, string itemCode, string itemDescription, Guid categoryGuid, Guid companyGuid)
        {
            

            if (ItemNameText == null || ItemCodeText == null || ItemDescriptionText == null)
                throw new NullReferenceException("حدث خطأ");
            selectedItemGuid = itemGuid;
            ItemNameText.Text = itemName;
            ItemCodeText.Text = itemCode;
            ItemDescriptionText.Text = itemDescription;



            CategorylookUpEdit.EditValue = categoryGuid;
            CompanylookUpEdit.EditValue = companyGuid;

         



            isNewRecord = false;
        }

        private void itemPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wholesalePriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void distributorPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
