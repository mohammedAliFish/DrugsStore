using System;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using task1.Repository;
using task1.Data;


namespace task1.Forms.Item
{
    public partial class ItemPopupForm : CenterForm
    {
        private readonly ItemRepository itemRepository;
        public Model.Entities.Item SelectedItem { get; private set; }
        public ItemPopupForm()
        {
            InitializeComponent();
            itemRepository = new ItemRepository();
        }

        private void ItemPopupForm_Load(object sender, EventArgs e)
        {
            LoadItems();
        }
        private void LoadItems()
        {
            try
            {
                var items = itemRepository.GetItems();
                Console.WriteLine($"Loaded {items.Count} items.");
                itemPopupGridControl.DataSource = items;

                var gridView = itemPopupGridControl.MainView as GridView;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void itemGridView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var gridView = itemPopupGridControl.MainView as GridView;
            if (gridView != null)
            {
                
                var itemGuid = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ItemGUID");
                var itemName = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ItemName");
                var itemCode = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ItemCode");

                
                SelectedItem = new Model.Entities.Item
                {
                    ItemGUID = Guid.Parse(itemGuid.ToString()),
                    ItemName = itemName.ToString(),
                    ItemCode = itemCode.ToString()
                };

            
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}