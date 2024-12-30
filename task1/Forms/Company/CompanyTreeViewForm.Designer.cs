namespace task1.Forms.Company
{
    partial class CompanyTreeViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyTreeViewForm));
            this.companyTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // companyTreeView
            // 
            this.companyTreeView.Location = new System.Drawing.Point(12, 12);
            this.companyTreeView.Name = "companyTreeView";
            this.companyTreeView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.companyTreeView.RightToLeftLayout = true;
            this.companyTreeView.Size = new System.Drawing.Size(343, 361);
            this.companyTreeView.TabIndex = 0;
            this.companyTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.companyTreeView_AfterSelect);
            // 
            // CompanyTreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 385);
            this.Controls.Add(this.companyTreeView);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CompanyTreeViewForm.IconOptions.Image")));
            this.Name = "CompanyTreeViewForm";
            this.Text = "شجره الشركات";
            this.Load += new System.EventHandler(this.CompanyTreeViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView companyTreeView;
    }
}