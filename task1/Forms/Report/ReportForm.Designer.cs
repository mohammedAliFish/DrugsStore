namespace task1.Forms.Report
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.allGridControl = new DevExpress.XtraGrid.GridControl();
            this.allBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWholesalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistributorPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CompanyNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CategoryNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForItemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompanyName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategoryName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1241, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 642);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1241, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 601);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1241, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 601);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 47);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.allGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.dataLayoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1217, 603);
            this.splitContainerControl1.SplitterPosition = 823;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // allGridControl
            // 
            this.allGridControl.DataSource = this.allBindingSource;
            this.allGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allGridControl.Location = new System.Drawing.Point(0, 0);
            this.allGridControl.MainView = this.allGridView;
            this.allGridControl.MenuManager = this.barManager1;
            this.allGridControl.Name = "allGridControl";
            this.allGridControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allGridControl.Size = new System.Drawing.Size(823, 599);
            this.allGridControl.TabIndex = 0;
            this.allGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.allGridView});
            // 
            // allBindingSource
            // 
            this.allBindingSource.DataSource = typeof(task1.Model.Entities.All);
            // 
            // allGridView
            // 
            this.allGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemGUID,
            this.colItemName,
            this.colItemCode,
            this.colItemDescription,
            this.colCompanyGuid,
            this.colCompanyCode,
            this.colCompanyName,
            this.colCategoryGuid,
            this.colCategoryCode,
            this.colCategoryName,
            this.colItemPrice,
            this.colWholesalePrice,
            this.colDistributorPrice});
            this.allGridView.GridControl = this.allGridControl;
            this.allGridView.Name = "allGridView";
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
            this.colCompanyCode.VisibleIndex = 3;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 4;
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
            this.colCategoryCode.VisibleIndex = 5;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 6;
            // 
            // colItemPrice
            // 
            this.colItemPrice.FieldName = "ItemPrice";
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 7;
            // 
            // colWholesalePrice
            // 
            this.colWholesalePrice.FieldName = "WholesalePrice";
            this.colWholesalePrice.Name = "colWholesalePrice";
            this.colWholesalePrice.Visible = true;
            this.colWholesalePrice.VisibleIndex = 8;
            // 
            // colDistributorPrice
            // 
            this.colDistributorPrice.FieldName = "DistributorPrice";
            this.colDistributorPrice.Name = "colDistributorPrice";
            this.colDistributorPrice.Visible = true;
            this.colDistributorPrice.VisibleIndex = 9;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CompanyNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CategoryNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemNameTextEdit);
            this.dataLayoutControl1.DataSource = this.allBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(-1, 88);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(378, 162);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CompanyNameTextEdit
            // 
            this.CompanyNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.allBindingSource, "CompanyName", true));
            this.CompanyNameTextEdit.Location = new System.Drawing.Point(20, 66);
            this.CompanyNameTextEdit.MenuManager = this.barManager1;
            this.CompanyNameTextEdit.Name = "CompanyNameTextEdit";
            this.CompanyNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.CompanyNameTextEdit.Size = new System.Drawing.Size(262, 26);
            this.CompanyNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CompanyNameTextEdit.TabIndex = 5;
            this.CompanyNameTextEdit.EditValueChanged += new System.EventHandler(this.CompanyNameTextEdit_EditValueChanged);
            // 
            // CategoryNameTextEdit
            // 
            this.CategoryNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.allBindingSource, "CategoryName", true));
            this.CategoryNameTextEdit.Location = new System.Drawing.Point(20, 112);
            this.CategoryNameTextEdit.MenuManager = this.barManager1;
            this.CategoryNameTextEdit.Name = "CategoryNameTextEdit";
            this.CategoryNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.CategoryNameTextEdit.Size = new System.Drawing.Size(262, 26);
            this.CategoryNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CategoryNameTextEdit.TabIndex = 6;
            this.CategoryNameTextEdit.EditValueChanged += new System.EventHandler(this.CategoryNameTextEdit_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(378, 162);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForItemName,
            this.ItemForCompanyName,
            this.ItemForCategoryName});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(358, 142);
            // 
            // ItemForItemName
            // 
            this.ItemForItemName.Control = this.ItemNameTextEdit;
            this.ItemForItemName.Location = new System.Drawing.Point(0, 0);
            this.ItemForItemName.Name = "ItemForItemName";
            this.ItemForItemName.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemName.Size = new System.Drawing.Size(358, 46);
            this.ItemForItemName.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForCompanyName
            // 
            this.ItemForCompanyName.Control = this.CompanyNameTextEdit;
            this.ItemForCompanyName.Location = new System.Drawing.Point(0, 46);
            this.ItemForCompanyName.Name = "ItemForCompanyName";
            this.ItemForCompanyName.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCompanyName.Size = new System.Drawing.Size(358, 46);
            this.ItemForCompanyName.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForCategoryName
            // 
            this.ItemForCategoryName.Control = this.CategoryNameTextEdit;
            this.ItemForCategoryName.Location = new System.Drawing.Point(0, 92);
            this.ItemForCategoryName.Name = "ItemForCategoryName";
            this.ItemForCategoryName.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCategoryName.Size = new System.Drawing.Size(358, 50);
            this.ItemForCategoryName.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemNameTextEdit
            // 
            this.ItemNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.allBindingSource, "ItemName", true));
            this.ItemNameTextEdit.Location = new System.Drawing.Point(20, 20);
            this.ItemNameTextEdit.MenuManager = this.barManager1;
            this.ItemNameTextEdit.Name = "ItemNameTextEdit";
            this.ItemNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ItemNameTextEdit.Properties.EditValueChanged += new System.EventHandler(this.ItemNameTextEdit_Properties_EditValueChanged);
            this.ItemNameTextEdit.Size = new System.Drawing.Size(262, 26);
            this.ItemNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ItemNameTextEdit.TabIndex = 4;
            this.ItemNameTextEdit.EditValueChanged += new System.EventHandler(this.ItemNameTextEdit_EditValueChanged);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 662);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ReportForm.IconOptions.Image")));
            this.Name = "ReportForm";
            this.Text = "التقارير";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl allGridControl;
        private System.Windows.Forms.BindingSource allBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView allGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colItemGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyGuid;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryGuid;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colWholesalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributorPrice;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit CompanyNameTextEdit;
        private DevExpress.XtraEditors.TextEdit CategoryNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategoryName;
        private DevExpress.XtraEditors.TextEdit ItemNameTextEdit;
    }
}