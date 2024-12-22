using System;
using DevExpress.XtraGrid;
using System.Data;



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

        }

        private void CompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}