namespace task1.Forms.Item
{
    partial class ItemsForm
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.itemGridControl = new DevExpress.XtraGrid.GridControl();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ItemNameText = new DevExpress.XtraEditors.TextEdit();
            this.ItemCodeText = new DevExpress.XtraEditors.TextEdit();
            this.ItemDescriptionText = new DevExpress.XtraEditors.TextEdit();
            this.CompanyComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CategoryComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForItemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompany = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompany)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1266, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 622);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1266, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 581);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1266, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 581);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 47);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel1.Controls.Add(this.itemGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.dataLayoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1242, 583);
            this.splitContainerControl1.SplitterPosition = 710;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // itemGridControl
            // 
            this.itemGridControl.DataSource = this.itemBindingSource;
            this.itemGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGridControl.Location = new System.Drawing.Point(0, 0);
            this.itemGridControl.MainView = this.itemGridView;
            this.itemGridControl.MenuManager = this.barManager1;
            this.itemGridControl.Name = "itemGridControl";
            this.itemGridControl.Size = new System.Drawing.Size(706, 575);
            this.itemGridControl.TabIndex = 0;
            this.itemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.itemGridView});
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(task1.Model.Entities.Item);
            // 
            // itemGridView
            // 
            this.itemGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemGUID,
            this.colItemName,
            this.colItemCode,
            this.colItemDescription,
            this.colCategoryGUID,
            this.colCompanyGUID,
            this.colCategory,
            this.colCompany});
            this.itemGridView.GridControl = this.itemGridControl;
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.itemGridView_RowClick);
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
            // colCategoryGUID
            // 
            this.colCategoryGUID.FieldName = "CategoryGUID";
            this.colCategoryGUID.Name = "colCategoryGUID";
            // 
            // colCompanyGUID
            // 
            this.colCompanyGUID.FieldName = "CompanyGUID";
            this.colCompanyGUID.Name = "colCompanyGUID";
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "CategoryName";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 3;
            // 
            // colCompany
            // 
            this.colCompany.FieldName = "CompanyName";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnAddOrUpdate);
            this.panelControl1.Location = new System.Drawing.Point(45, 396);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(449, 100);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(52, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrUpdate.Location = new System.Drawing.Point(318, 31);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(106, 32);
            this.btnAddOrUpdate.TabIndex = 0;
            this.btnAddOrUpdate.Text = "حفظ";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.BackColor = System.Drawing.Color.Silver;
            this.dataLayoutControl1.Controls.Add(this.ItemNameText);
            this.dataLayoutControl1.Controls.Add(this.ItemCodeText);
            this.dataLayoutControl1.Controls.Add(this.ItemDescriptionText);
            this.dataLayoutControl1.Controls.Add(this.CompanyComboBox);
            this.dataLayoutControl1.Controls.Add(this.CategoryComboBox);
            this.dataLayoutControl1.DataSource = this.itemBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(45, 74);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(449, 259);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ItemNameText
            // 
            this.ItemNameText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemName", true));
            this.ItemNameText.Location = new System.Drawing.Point(20, 20);
            this.ItemNameText.MenuManager = this.barManager1;
            this.ItemNameText.Name = "ItemNameText";
            this.ItemNameText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameText.Properties.Appearance.Options.UseFont = true;
            this.ItemNameText.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ItemNameText.Size = new System.Drawing.Size(333, 26);
            this.ItemNameText.StyleController = this.dataLayoutControl1;
            this.ItemNameText.TabIndex = 4;
            this.ItemNameText.EditValueChanged += new System.EventHandler(this.ItemNameTextEdit_EditValueChanged);
            // 
            // ItemCodeText
            // 
            this.ItemCodeText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemCode", true));
            this.ItemCodeText.Location = new System.Drawing.Point(20, 66);
            this.ItemCodeText.MenuManager = this.barManager1;
            this.ItemCodeText.Name = "ItemCodeText";
            this.ItemCodeText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCodeText.Properties.Appearance.Options.UseFont = true;
            this.ItemCodeText.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ItemCodeText.Size = new System.Drawing.Size(333, 26);
            this.ItemCodeText.StyleController = this.dataLayoutControl1;
            this.ItemCodeText.TabIndex = 5;
            // 
            // ItemDescriptionText
            // 
            this.ItemDescriptionText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemDescription", true));
            this.ItemDescriptionText.Location = new System.Drawing.Point(20, 112);
            this.ItemDescriptionText.MenuManager = this.barManager1;
            this.ItemDescriptionText.Name = "ItemDescriptionText";
            this.ItemDescriptionText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionText.Properties.Appearance.Options.UseFont = true;
            this.ItemDescriptionText.Size = new System.Drawing.Size(333, 26);
            this.ItemDescriptionText.StyleController = this.dataLayoutControl1;
            this.ItemDescriptionText.TabIndex = 6;
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "Company", true));
            this.CompanyComboBox.Location = new System.Drawing.Point(20, 204);
            this.CompanyComboBox.MenuManager = this.barManager1;
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyComboBox.Properties.Appearance.Options.UseFont = true;
            this.CompanyComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CompanyComboBox.Size = new System.Drawing.Size(333, 26);
            this.CompanyComboBox.StyleController = this.dataLayoutControl1;
            this.CompanyComboBox.TabIndex = 8;
            this.CompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.CompanyComboBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "Category", true));
            this.CategoryComboBox.Location = new System.Drawing.Point(20, 158);
            this.CategoryComboBox.MenuManager = this.barManager1;
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.Properties.Appearance.Options.UseFont = true;
            this.CategoryComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CategoryComboBox.Size = new System.Drawing.Size(333, 26);
            this.CategoryComboBox.StyleController = this.dataLayoutControl1;
            this.CategoryComboBox.TabIndex = 7;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(449, 259);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForItemName,
            this.ItemForItemCode,
            this.ItemForItemDescription,
            this.ItemForCategory,
            this.ItemForCompany});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(429, 239);
            // 
            // ItemForItemName
            // 
            this.ItemForItemName.Control = this.ItemNameText;
            this.ItemForItemName.Location = new System.Drawing.Point(0, 0);
            this.ItemForItemName.Name = "ItemForItemName";
            this.ItemForItemName.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemName.Size = new System.Drawing.Size(429, 46);
            this.ItemForItemName.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForItemCode
            // 
            this.ItemForItemCode.Control = this.ItemCodeText;
            this.ItemForItemCode.Location = new System.Drawing.Point(0, 46);
            this.ItemForItemCode.Name = "ItemForItemCode";
            this.ItemForItemCode.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemCode.Size = new System.Drawing.Size(429, 46);
            this.ItemForItemCode.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForItemDescription
            // 
            this.ItemForItemDescription.Control = this.ItemDescriptionText;
            this.ItemForItemDescription.Location = new System.Drawing.Point(0, 92);
            this.ItemForItemDescription.Name = "ItemForItemDescription";
            this.ItemForItemDescription.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemDescription.Size = new System.Drawing.Size(429, 46);
            this.ItemForItemDescription.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForCategory
            // 
            this.ItemForCategory.Control = this.CategoryComboBox;
            this.ItemForCategory.Location = new System.Drawing.Point(0, 138);
            this.ItemForCategory.Name = "ItemForCategory";
            this.ItemForCategory.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCategory.Size = new System.Drawing.Size(429, 46);
            this.ItemForCategory.Text = "Category";
            this.ItemForCategory.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForCompany
            // 
            this.ItemForCompany.Control = this.CompanyComboBox;
            this.ItemForCompany.Location = new System.Drawing.Point(0, 184);
            this.ItemForCompany.Name = "ItemForCompany";
            this.ItemForCompany.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCompany.Size = new System.Drawing.Size(429, 55);
            this.ItemForCompany.Text = "Company";
            this.ItemForCompany.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemsForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 642);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompany)).EndInit();
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
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit ItemNameText;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevExpress.XtraEditors.TextEdit ItemCodeText;
        private DevExpress.XtraEditors.TextEdit ItemDescriptionText;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForItemDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategory;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompany;
        private DevExpress.XtraEditors.ComboBoxEdit CompanyComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit CategoryComboBox;
        private DevExpress.XtraGrid.GridControl itemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView itemGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colItemGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyGUID;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddOrUpdate;
    }
}