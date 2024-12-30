namespace task1.Forms.Category
{
    partial class CategoryTreeViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryTreeViewForm));
            this.categoryTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // categoryTreeView
            // 
            this.categoryTreeView.Location = new System.Drawing.Point(12, 12);
            this.categoryTreeView.Name = "categoryTreeView";
            this.categoryTreeView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoryTreeView.RightToLeftLayout = true;
            this.categoryTreeView.Size = new System.Drawing.Size(384, 416);
            this.categoryTreeView.TabIndex = 0;
            this.categoryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.categoryTreeView_AfterSelect);
            // 
            // CategoryTreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 441);
            this.Controls.Add(this.categoryTreeView);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CategoryTreeViewForm.IconOptions.Image")));
            this.Name = "CategoryTreeViewForm";
            this.Text = "شجره التصنيفات";
            this.Load += new System.EventHandler(this.CategoryTreeViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView categoryTreeView;
    }
}