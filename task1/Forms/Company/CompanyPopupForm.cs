using System;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using task1.Repository;


namespace task1.Forms.Company
{
    public partial class CompanyPopupForm :CenterForm
    {
        private readonly AllRepository allRepository;
        public task1.Model.Entities.Company SelectedCompany { get; private set; }
        public CompanyPopupForm()
        {
            InitializeComponent();
            allRepository = new AllRepository();
            LoadCompanies();
        }

      
        private void LoadCompanies()
        {
            try
            {
                var companies = allRepository.GetCompanies();
                companyPopupGridControl.DataSource = companies;
                var gridView = companyPopupGridControl.MainView as GridView;
                if (gridView != null && gridView.Columns["CompanyGuid"] != null)
                {
                    gridView.Columns["CompanyGuid"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
        private void CompanyPopupForm_Load(object sender, EventArgs e)
        {

        }

        private void companyGridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var gridView = companyPopupGridControl.MainView as GridView;
            if (gridView != null)
            {
                var row = gridView.GetFocusedRow() as task1.Model.Entities.Company;
                if (row != null)
                {
                    SelectedCompany = row;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}