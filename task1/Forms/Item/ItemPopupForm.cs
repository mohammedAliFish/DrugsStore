using System;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

using task1.Data;
using DevExpress.XtraGrid;
using task1.Repository;



namespace task1.Forms.Item
{
    public partial class ItemPopupForm : CenterForm
    {
        public task1.Model.Entities.Item SelectedItem { get; private set; }

        private readonly ItemRepository itemRepository;

        public ItemPopupForm()
        {
            InitializeComponent();
            itemRepository = new ItemRepository();
           

        }
        private void LoadFilteredData(string filterText)
        {
            try
            {
                var allRepository = new AllRepository();
                var filteredData = allRepository.GetFilteredItemsByName(filterText, null, null);

                if (filteredData != null && filteredData.Rows.Count > 0)
                {

                    itemPopupGridControl.DataSource = filteredData;
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على نتائج!", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل البيانات: {ex.Message}");
            }
        }
        private void ItemPopupForm_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
        private void LoadItems()
        {
            var items = itemRepository.GetItems();

            itemPopupGridControl.DataSource = items;

        }


        private void itemGridView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var gridView = itemPopupGridControl.MainView as GridView;
            if (gridView != null)
            {
               
                var row = gridView.GetFocusedRow() as task1.Model.Entities.Item;

                if (row != null)
                {
                 
                    SelectedItem = row;

                  
                   

                   
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void itemGridView_RowClick(object sender, RowClickEventArgs e)
        {
            var gridView = itemPopupGridControl.MainView as GridView;
            if (gridView != null)
            {

                var row = gridView.GetFocusedRow() as task1.Model.Entities.Item;

                if (row != null)
                {

                    SelectedItem = row;


                    


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void itemPopupGridControl_Click(object sender, EventArgs e)
        {

        }

        private void itemGridView_DoubleClick(object sender, EventArgs e)
        {
            var gridView = itemPopupGridControl.MainView as GridView;
            if (gridView != null)
            {

                var row = gridView.GetFocusedRow() as task1.Model.Entities.Item;

                if (row != null)
                {

                    SelectedItem = row;





                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}