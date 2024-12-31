using System;
using System.Windows.Forms;
using task1.Forms.Category;
using task1.Forms.Company;
using task1.Forms.Item;
using task1.Forms.Price;
using task1.Forms.Report;

namespace task1
{
    public partial class Form1 : CenterForm
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            companyForm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PriceForm priceForm = new PriceForm();
            priceForm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }
    }
}
