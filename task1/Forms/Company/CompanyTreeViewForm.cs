using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace task1.Forms.Company
{
    public partial class CompanyTreeViewForm : CenterForm
    {
        public CompanyTreeViewForm()
        {
            InitializeComponent();
        }

        private void companyTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void CompanyTreeViewForm_Load(object sender, EventArgs e)
        {
            try
            {

                companyTreeView.Nodes.Clear();


                DataTable categories = sqlHelper.ExecuteStoredProcedure("CompanyGet");
                foreach (DataRow categoryRow in categories.Rows)
                {

                    TreeNode categoryNode = new TreeNode
                    {
                        Text = categoryRow["CompanyName"].ToString(),
                        Tag = categoryRow["CompanyGUID"].ToString()
                    };


                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@CompanyGUID", SqlDbType.UniqueIdentifier)
                {
                    Value = Guid.Parse(categoryRow["CompanyGUID"].ToString())
                }
                    };
                    DataTable items = sqlHelper.ExecuteStoredProcedure("ItemsByCompanyGet", parameters);

                    foreach (DataRow itemRow in items.Rows)
                    {

                        TreeNode itemNode = new TreeNode
                        {
                            Text = itemRow["ItemName"].ToString(),
                            Tag = itemRow["ItemGUID"].ToString()
                        };
                        categoryNode.Nodes.Add(itemNode);
                    }


                    companyTreeView.Nodes.Add(categoryNode);
                }

                companyTreeView.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل الشجره : ");
            }
        }
    }
}