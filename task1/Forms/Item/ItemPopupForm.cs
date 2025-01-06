using System;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

using task1.Data;

using task1.Repository;
using System.Linq;



namespace task1.Forms.Item
{
    public partial class ItemPopupForm : CenterForm
    {
        public task1.Model.Entities.Item SelectedItem { get; private set; }

        private readonly ItemRepository itemRepository;
        private readonly AllRepository allRepository;

        public ItemPopupForm()
        {
            InitializeComponent();
            itemRepository = new ItemRepository();
            allRepository = new AllRepository();


        }
        

        private void ItemPopupForm_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadItems()
        {
            var items = itemRepository.GetItems();

            itemPopupGridControl.DataSource = items;

        }
        public void FilterItems(string filterText)
        {
            if (!string.IsNullOrWhiteSpace(filterText))
            {
               
                var filteredData = allRepository.GetFilteredItemsName()
                    .Where(c => c.ItemName != null && c.ItemName.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();



                    itemPopupGridControl.DataSource = filteredData;
               
            }
            else
            {
                
                LoadItems();
            }
        }



        private void itemGridView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
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

        private void itemGridView_RowClick(object sender, RowClickEventArgs e)
        {
          
        }

        private void itemPopupGridControl_Click(object sender, EventArgs e)
        {

        }

        private void itemGridView_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}