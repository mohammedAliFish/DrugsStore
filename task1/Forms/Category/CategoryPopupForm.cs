using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using task1.Repository;

namespace task1.Forms.Category
{
    public partial class CategoryPopupForm : CenterForm
    {
        private readonly AllRepository allRepository;
        public task1.Model.Entities.Category SelectedCategory { get; private set; }

        public CategoryPopupForm()
        {
            InitializeComponent();
            allRepository = new AllRepository();
            LoadCategories();
        }
        private void LoadCategories()
        {
            try
            {
                var categories = allRepository.GetCategories(); 
                categoryPopupGridControl.DataSource = categories; 

                
                var gridView = categoryPopupGridControl.MainView as GridView;
                if (gridView != null && gridView.Columns["CategoryGuid"] != null)
                {
                    gridView.Columns["CategoryGuid"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error  data: {ex.Message}");
            }
        }
        private void categoryPopupGridControl_Click(object sender, EventArgs e)
        {
            var gridView = categoryPopupGridControl.MainView as GridView;
            if (gridView != null)
            {
                var row = gridView.GetFocusedRow() as task1.Model.Entities.Category; 
                if (row != null)
                {
                    SelectedCategory = row;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void categoryPopupGridView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                var gridView = sender as GridView;
                if (gridView != null)
                {
                    var row = gridView.GetRow(e.RowHandle) as task1.Model.Entities.Category;
                    if (row != null)
                    {
                        SelectedCategory = row;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
       

        private void CategoryPopupForm_Load(object sender, EventArgs e)
        {

        }

        private void categoryPopupGridView_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}