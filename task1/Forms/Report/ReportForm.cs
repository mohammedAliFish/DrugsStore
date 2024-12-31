using System;
using System.Collections.Generic;
using System.Windows.Forms;
using task1.Model.Entities;
using task1.Repository;

namespace task1.Forms.Report
{
    public partial class ReportForm : CenterForm
    {
        private AllRepository allRepository;

        public ReportForm()
        {
            InitializeComponent();
            allRepository = new AllRepository();
        }

        private void LoadData(string itemName = null, string categoryName = null, string companyName = null)
        {
            try
            {
                List<All> filteredData = allRepository.FilterData(itemName, categoryName, companyName);
                allGridControl.DataSource = filteredData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}");
            }
        }
        private void ApplyFilter()
        {
            string itemName = ItemNameTextEdit.Text?.Trim();
            string categoryName = CategoryNameTextEdit.Text?.Trim();
            string companyName = CompanyNameTextEdit.Text?.Trim();

            LoadData(itemName, categoryName, companyName);
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            List<All> allData = allRepository.GetAllData();
            allGridControl.DataSource = allData;
        }

        private void ItemNameTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void CompanyNameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CategoryNameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ItemNameTextEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
             ApplyFilter();
       
        }
    }
}