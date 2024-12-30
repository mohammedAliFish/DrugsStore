using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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
                    DataTable items = sqlHelper.ExecuteStoredProcedure("GetItemsByCompany", parameters);

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
                MessageBox.Show($"حدث خطأ أثناء تحميل TreeView: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}