namespace task1.Forms.Item
{
    partial class ItemPopupForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemPopupForm));
            this.itemPopupGridControl = new DevExpress.XtraGrid.GridControl();
            this.itemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colItemGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemPopupGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPopupGridControl
            // 
            this.itemPopupGridControl.DataSource = this.itemBindingSource;
            this.itemPopupGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPopupGridControl.Location = new System.Drawing.Point(0, 0);
            this.itemPopupGridControl.MainView = this.itemGridView;
            this.itemPopupGridControl.Name = "itemPopupGridControl";
            this.itemPopupGridControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemPopupGridControl.Size = new System.Drawing.Size(843, 569);
            this.itemPopupGridControl.TabIndex = 0;
            this.itemPopupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.itemGridView});
            // 
            // itemGridView
            // 
            this.itemGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemGUID,
            this.colItemName,
            this.colItemCode,
            this.colItemDescription,
            this.colCategory,
            this.colCompany});
            this.itemGridView.GridControl = this.itemPopupGridControl;
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.itemGridView_RowCellClick);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(task1.Model.Entities.Item);
            // 
            // colItemGUID
            // 
            this.colItemGUID.FieldName = "ItemGUID";
            this.colItemGUID.Name = "colItemGUID";
            // 
            // colItemName
            // 
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 0;
            // 
            // colItemCode
            // 
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            // 
            // colItemDescription
            // 
            this.colItemDescription.FieldName = "ItemDescription";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.Visible = true;
            this.colItemDescription.VisibleIndex = 2;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category.CategoryName";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 3;
            // 
            // colCompany
            // 
            this.colCompany.FieldName = "Company.CompanyName";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 4;
            // 
            // ItemPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 569);
            this.Controls.Add(this.itemPopupGridControl);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ItemPopupForm.IconOptions.Image")));
            this.Name = "ItemPopupForm";
            this.Text = "نافذه العناصر";
            this.Load += new System.EventHandler(this.ItemPopupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPopupGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl itemPopupGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView itemGridView;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colItemGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
    }
}