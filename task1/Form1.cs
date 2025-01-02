using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using task1.Forms.Category;
using task1.Forms.Company;
using task1.Forms.Item;
using task1.Forms.Price;
using task1.Forms.Report;
using task1.Reports;
using task1.Repository;
using task1.DataSet;

namespace task1
{
    public partial class Form1 : CenterForm
    {
        private AllRepository allRepository;
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

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                System.Data.DataSet allDataSet = new System.Data.DataSet("All");


                DataTable allDataTable = sqlHelper.ExecuteStoredProcedure("GetAllTables");

                
                allDataSet.Tables.Add(allDataTable);
                allDataSet.Tables[0].TableName = "AllDataTable"; 

             
                XtraReport report = new XtraReport
                {
                    DataSource = allDataSet,
                    DataMember = "AllDataTable" 
                };

              
                DevExpress.XtraReports.UserDesigner.XRDesignForm designForm = new DevExpress.XtraReports.UserDesigner.XRDesignForm();
                designForm.OpenReport(report);

        
                designForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
