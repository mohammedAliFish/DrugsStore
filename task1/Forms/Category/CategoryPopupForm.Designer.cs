namespace task1.Forms.Category
{
    partial class CategoryPopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryPopupForm));
            this.categoryPopupGridControl = new DevExpress.XtraGrid.GridControl();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryPopupGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPopupGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPopupGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryPopupGridControl
            // 
            this.categoryPopupGridControl.DataSource = this.categoryBindingSource;
            this.categoryPopupGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryPopupGridControl.Location = new System.Drawing.Point(0, 0);
            this.categoryPopupGridControl.MainView = this.categoryPopupGridView;
            this.categoryPopupGridControl.Name = "categoryPopupGridControl";
            this.categoryPopupGridControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoryPopupGridControl.Size = new System.Drawing.Size(689, 556);
            this.categoryPopupGridControl.TabIndex = 0;
            this.categoryPopupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.categoryPopupGridView});
            this.categoryPopupGridControl.Click += new System.EventHandler(this.categoryPopupGridControl_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(task1.Model.Entities.Category);
            // 
            // categoryPopupGridView
            // 
            this.categoryPopupGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryGuid,
            this.colCategoryCode,
            this.colCategoryName});
            this.categoryPopupGridView.GridControl = this.categoryPopupGridControl;
            this.categoryPopupGridView.Name = "categoryPopupGridView";
            this.categoryPopupGridView.OptionsBehavior.Editable = false;
            this.categoryPopupGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.categoryPopupGridView_RowCellClick);
            this.categoryPopupGridView.DoubleClick += new System.EventHandler(this.categoryPopupGridView_DoubleClick);
            // 
            // colCategoryGuid
            // 
            this.colCategoryGuid.FieldName = "CategoryGuid";
            this.colCategoryGuid.Name = "colCategoryGuid";
            // 
            // colCategoryCode
            // 
            this.colCategoryCode.FieldName = "CategoryCode";
            this.colCategoryCode.Name = "colCategoryCode";
            this.colCategoryCode.Visible = true;
            this.colCategoryCode.VisibleIndex = 0;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            // 
            // CategoryPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 556);
            this.Controls.Add(this.categoryPopupGridControl);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CategoryPopupForm.IconOptions.Image")));
            this.Name = "CategoryPopupForm";
            this.Text = "نافذه جدول التصنيفات";
            this.Load += new System.EventHandler(this.CategoryPopupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryPopupGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPopupGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl categoryPopupGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView categoryPopupGridView;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryGuid;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
    }
}