using System;
using DevExpress.XtraGrid;
using System.Data;
using System.Windows.Forms;




namespace task1.Forms.Item
{
    public partial class ItemsForm : CenterForm
    {
      
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
                    inputItemForm.LoadCategoriesAndCompanies();
                    inputItemForm.SetItemData(itemGuid,
                                     selectedRow["ItemName"].ToString(),
                                     selectedRow["ItemCode"].ToString(),
                                     selectedRow["ItemDescription"].ToString(),
                                     categoryGuid,
                                     companyGuid);

                    inputItemForm.ShowDialog();
                    LoadItemsData();
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

        private void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Export Data to Excel";
                    saveFileDialog.FileName = "ItemsData.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        string filePath = saveFileDialog.FileName;
                        itemGridView.ExportToXlsx(filePath);

                        MessageBox.Show("تم تصدير  الى كسل!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("هل تريد فتح الملف؟", "فتح الملف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(filePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء التصدير ");
            }
        }

        private void barButtonAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InputItemForm inputItemForm = new InputItemForm(Guid.NewGuid());
            inputItemForm.OpenForNewRecord();
        }
    }
}