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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    DataTable items = sqlHelper.ExecuteStoredProcedure("GetItemsByCategory", parameters);

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
                MessageBox.Show($"حدث خطأ أثناء تحميل TreeView: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void categoryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}