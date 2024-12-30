using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace task1.Forms.Category
{
    public partial class CategoryTreeViewForm : CenterForm
    {
        public CategoryTreeViewForm()
        {
            InitializeComponent();
        }

        private void CategoryTreeViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                
                categoryTreeView.Nodes.Clear();

              
                DataTable categories = sqlHelper.ExecuteStoredProcedure("CategoryGet");
                foreach (DataRow categoryRow in categories.Rows)
                {
                   
                    TreeNode categoryNode = new TreeNode
                    {
                        Text = categoryRow["CategoryName"].ToString(),
                        Tag = categoryRow["CategoryGUID"].ToString()
                    };

             
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@CategoryGUID", SqlDbType.UniqueIdentifier)
                {
                    Value = Guid.Parse(categoryRow["CategoryGUID"].ToString())
                }
                    };
                    DataTable items = sqlHelper.ExecuteStoredProcedure("ItemsByCategoryGet", parameters);

                    foreach (DataRow itemRow in items.Rows)
                    {
                       
                        TreeNode itemNode = new TreeNode
                        {
                            Text = itemRow["ItemName"].ToString(),
                            Tag = itemRow["ItemGUID"].ToString()
                        };
                        categoryNode.Nodes.Add(itemNode);
                    }

                   
                    categoryTreeView.Nodes.Add(categoryNode);
                }

                categoryTreeView.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل الشجرخ : ");
            }
        }

        private void categoryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}