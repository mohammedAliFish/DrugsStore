﻿using System;
using DevExpress.XtraGrid;
using System.Data;
using task1.Data;
using System.Windows.Forms;




namespace task1.Forms.Item
{
    public partial class ItemsForm : CenterForm
    {
        public DevExpress.XtraGrid.GridControl ItemGridControl => itemGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView ItemGridView => itemGridView;
        public ItemsForm()
        {
            InitializeComponent();
        }
       

        public void LoadItemsData()
        {
            
            string GetAllItems = "ItemGet";
            DataTable table = sqlHelper.ExecuteStoredProcedure(GetAllItems);
            itemGridControl.DataSource = table;

            itemGridView.ClearSelection();
            itemGridView.FocusedRowHandle = GridControl.InvalidRowHandle;
        }
        private void ItemsForm_Load(object sender, EventArgs e)
        {
            LoadItemsData();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InputItemForm inputItemForm = new InputItemForm(Guid.NewGuid());
            inputItemForm.OpenForNewRecord();
        }

        private void itemGridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var selectedRow = itemGridView.GetFocusedDataRow();
                if (selectedRow != null)
                {
                    
                    Guid itemGuid = Guid.Parse(selectedRow["ItemGUID"].ToString());
                    Guid categoryGuid = Guid.Parse(selectedRow["CategoryGUID"].ToString());
                    Guid companyGuid = Guid.Parse(selectedRow["CompanyGUID"].ToString());

                    InputItemForm inputItemForm = new InputItemForm(itemGuid);

                    
  
                    inputItemForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات في الصف المحدد.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحديد العنصر: {ex.Message}");
            }
        }



    }
}