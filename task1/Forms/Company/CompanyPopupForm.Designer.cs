namespace task1.Forms.Company
{
    partial class CompanyPopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyPopupForm));
            this.companyPopupGridControl = new DevExpress.XtraGrid.GridControl();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companyPopupGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyPopupGridControl
            // 
            this.companyPopupGridControl.DataSource = this.companyBindingSource;
            this.companyPopupGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyPopupGridControl.Location = new System.Drawing.Point(0, 0);
            this.companyPopupGridControl.MainView = this.companyGridView;
            this.companyPopupGridControl.Name = "companyPopupGridControl";
            this.companyPopupGridControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.companyPopupGridControl.Size = new System.Drawing.Size(783, 593);
            this.companyPopupGridControl.TabIndex = 0;
            this.companyPopupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.companyGridView});
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(task1.Model.Entities.Company);
            // 
            // companyGridView
            // 
            this.companyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyGuid,
            this.colCompanyCode,
            this.colCompanyName});
            this.companyGridView.GridControl = this.companyPopupGridControl;
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.OptionsBehavior.Editable = false;
            this.companyGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.companyGridView_RowCellClick);
            // 
            // colCompanyGuid
            // 
            this.colCompanyGuid.FieldName = "CompanyGuid";
            this.colCompanyGuid.Name = "colCompanyGuid";
            // 
            // colCompanyCode
            // 
            this.colCompanyCode.FieldName = "CompanyCode";
            this.colCompanyCode.Name = "colCompanyCode";
            this.colCompanyCode.Visible = true;
            this.colCompanyCode.VisibleIndex = 0;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 1;
            // 
            // CompanyPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 593);
            this.Controls.Add(this.companyPopupGridControl);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CompanyPopupForm.IconOptions.Image")));
            this.Name = "CompanyPopupForm";
            this.Text = "نافذه جدول الشركات";
            this.Load += new System.EventHandler(this.CompanyPopupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyPopupGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl companyPopupGridControl;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView companyGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyGuid;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
    }
}