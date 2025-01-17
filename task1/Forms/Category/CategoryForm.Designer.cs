﻿namespace task1.Forms.Category
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.categoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.categoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnShowTree = new System.Windows.Forms.Button();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveOrUpdate = new System.Windows.Forms.Button();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CategoryCodeText = new DevExpress.XtraEditors.TextEdit();
            this.CategoryNameText = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCategoryCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategoryName = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryCodeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNameText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryName)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1054, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 675);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1054, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 634);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1054, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 634);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(task1.Model.Entities.Category);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 41);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.categoryGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainerControl1.Panel2.Appearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainerControl1.Panel2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel2.Appearance.Options.UseBorderColor = true;
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.label2);
            this.splitContainerControl1.Panel2.Controls.Add(this.label1);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.dataLayoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1054, 634);
            this.splitContainerControl1.SplitterPosition = 492;
            this.splitContainerControl1.TabIndex = 9;
            // 
            // categoryGridControl
            // 
            this.categoryGridControl.DataSource = this.categoryBindingSource;
            this.categoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryGridControl.Location = new System.Drawing.Point(0, 0);
            this.categoryGridControl.MainView = this.categoryGridView;
            this.categoryGridControl.MenuManager = this.barManager1;
            this.categoryGridControl.Name = "categoryGridControl";
            this.categoryGridControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoryGridControl.Size = new System.Drawing.Size(492, 634);
            this.categoryGridControl.TabIndex = 0;
            this.categoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.categoryGridView});
            // 
            // categoryGridView
            // 
            this.categoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryGuid,
            this.colCategoryCode,
            this.colCategoryName});
            this.categoryGridView.GridControl = this.categoryGridControl;
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.OptionsBehavior.Editable = false;
            this.categoryGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colCategoryGuid
            // 
            this.colCategoryGuid.FieldName = "CategoryGUID";
            this.colCategoryGuid.Name = "colCategoryGuid";
            // 
            // colCategoryCode
            // 
            this.colCategoryCode.Caption = "رمز التصنيف";
            this.colCategoryCode.FieldName = "CategoryCode";
            this.colCategoryCode.Name = "colCategoryCode";
            this.colCategoryCode.Visible = true;
            this.colCategoryCode.VisibleIndex = 0;
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "اسم التصنيف";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(386, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "اسم التصنيف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(386, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "رمز التصنيف";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnShowTree);
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnSaveOrUpdate);
            this.panelControl1.Location = new System.Drawing.Point(52, 289);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(305, 247);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // btnShowTree
            // 
            this.btnShowTree.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTree.Location = new System.Drawing.Point(74, 129);
            this.btnShowTree.Name = "btnShowTree";
            this.btnShowTree.Size = new System.Drawing.Size(161, 31);
            this.btnShowTree.TabIndex = 14;
            this.btnShowTree.Text = "شجره التصنيفات";
            this.btnShowTree.UseVisualStyleBackColor = true;
            this.btnShowTree.Click += new System.EventHandler(this.btnShowTree_Click);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
            this.btnExport.Location = new System.Drawing.Point(74, 189);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(161, 38);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "تصدير الى اكسل";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(74, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveOrUpdate
            // 
            this.btnSaveOrUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrUpdate.Location = new System.Drawing.Point(74, 26);
            this.btnSaveOrUpdate.Name = "btnSaveOrUpdate";
            this.btnSaveOrUpdate.Size = new System.Drawing.Size(161, 31);
            this.btnSaveOrUpdate.TabIndex = 0;
            this.btnSaveOrUpdate.Text = "حفظ";
            this.btnSaveOrUpdate.UseVisualStyleBackColor = true;
            this.btnSaveOrUpdate.Click += new System.EventHandler(this.btnSaveOrUpdate_Click);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLayoutControl1.BackColor = System.Drawing.Color.White;
            this.dataLayoutControl1.Controls.Add(this.CategoryCodeText);
            this.dataLayoutControl1.Controls.Add(this.CategoryNameText);
            this.dataLayoutControl1.DataSource = this.categoryBindingSource;
            this.dataLayoutControl1.ForeColor = System.Drawing.Color.DarkGray;
            this.dataLayoutControl1.Location = new System.Drawing.Point(52, 105);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(305, 117);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CategoryCodeText
            // 
            this.CategoryCodeText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoryBindingSource, "CategoryCode", true));
            this.CategoryCodeText.Location = new System.Drawing.Point(20, 20);
            this.CategoryCodeText.MenuManager = this.barManager1;
            this.CategoryCodeText.Name = "CategoryCodeText";
            this.CategoryCodeText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCodeText.Properties.Appearance.Options.UseFont = true;
            this.CategoryCodeText.Size = new System.Drawing.Size(265, 26);
            this.CategoryCodeText.StyleController = this.dataLayoutControl1;
            this.CategoryCodeText.TabIndex = 4;
            // 
            // CategoryNameText
            // 
            this.CategoryNameText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoryBindingSource, "CategoryName", true));
            this.CategoryNameText.Location = new System.Drawing.Point(20, 66);
            this.CategoryNameText.MenuManager = this.barManager1;
            this.CategoryNameText.Name = "CategoryNameText";
            this.CategoryNameText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameText.Properties.Appearance.Options.UseFont = true;
            this.CategoryNameText.Size = new System.Drawing.Size(265, 26);
            this.CategoryNameText.StyleController = this.dataLayoutControl1;
            this.CategoryNameText.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.BorderColor = System.Drawing.Color.White;
            this.Root.AppearanceItemCaption.Options.UseBorderColor = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(305, 117);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCategoryCode,
            this.ItemForCategoryName});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(285, 97);
            // 
            // ItemForCategoryCode
            // 
            this.ItemForCategoryCode.Control = this.CategoryCodeText;
            this.ItemForCategoryCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCategoryCode.Name = "ItemForCategoryCode";
            this.ItemForCategoryCode.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCategoryCode.Size = new System.Drawing.Size(285, 46);
            this.ItemForCategoryCode.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForCategoryCode.TextVisible = false;
            // 
            // ItemForCategoryName
            // 
            this.ItemForCategoryName.Control = this.CategoryNameText;
            this.ItemForCategoryName.Location = new System.Drawing.Point(0, 46);
            this.ItemForCategoryName.Name = "ItemForCategoryName";
            this.ItemForCategoryName.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCategoryName.Size = new System.Drawing.Size(285, 51);
            this.ItemForCategoryName.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForCategoryName.TextVisible = false;
            // 
            // CategoryForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 695);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CategoryForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "CategoryForm";
            this.Text = "اداره التصنيفات";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            this.splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryCodeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNameText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryName)).EndInit();
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
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit CategoryCodeText;
        private DevExpress.XtraEditors.TextEdit CategoryNameText;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategoryCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategoryName;
        private DevExpress.XtraGrid.GridControl categoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView categoryGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryGuid;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveOrUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.Button btnShowTree;
    }
}