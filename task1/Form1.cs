using System;

using task1.Forms.Category;
using task1.Forms.Company;
using task1.Forms.Item;

namespace task1
{
    public partial class Form1 : CenterForm
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
