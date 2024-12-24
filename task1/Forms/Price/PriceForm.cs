using System;

using System.Windows.Forms;

using task1.Repository;


namespace task1.Forms.Price
{
    public partial class PriceForm : CenterForm
    {
        public PriceForm()
        {
            InitializeComponent();
        }

        private void PriceForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPricesData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($" خطأ  تحميل البيانات: {ex.Message}");
            }
        }
        private void LoadPricesData()
        {
            try
            {
                ItemPriceText.Text = string.Empty;
                PriceRepository priceRepository = new PriceRepository();
              
                var prices = priceRepository.GetPrices();
      
                 priceGridControl.DataSource = prices;
            }
            catch (Exception ex)
            {
                MessageBox.Show($" خطأ  تحميل البيانات: {ex.Message}");
            }
        }
        private void ItemPriceText_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pricrGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletePrice();
        }
        private void DeletePrice()
        {
            try
            {
                PriceRepository priceRepository = new PriceRepository();

                var selectedRow = priceGridView.GetFocusedRow() as task1.Model.Entities.Price;
                if (selectedRow == null)
                {
                    MessageBox.Show("يرجى تحديد صف .");
                    return;
                }

             
                var confirmResult = MessageBox.Show("هل تريد بالتأكيد حذف هذا السعر؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

        
                priceRepository.DeletePrice(selectedRow.PriceGUID);

                MessageBox.Show("تم حذف السعر بنجاح!");

             
                LoadPricesData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void priceGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var selectedRow = priceGridView.GetFocusedRow() as task1.Model.Entities.Price;

                if (selectedRow != null)
                {
                    ItemPriceText.Text = selectedRow.ItemPrice.ToString(); 
                }
                else
                {
                    MessageBox.Show("لم يتم تحديد  .");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ  تحديد : {ex.Message}");
            }
        }

    }
}