namespace task1.Forms.Company
{
    partial class CompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.companyGridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCompany = new System.Windows.Forms.BindingSource(this.components);
            this.companyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveOrUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CompanyCodeText = new DevExpress.XtraEditors.TextEdit();
            this.CompanyNameText = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCompanyCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompanyName = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonAddorUpdateCompany = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowTree = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyCodeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(27, 44);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.splitContainerControl1.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel1.Controls.Add(this.companyGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainerControl1.Panel2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.label2);
            this.splitContainerControl1.Panel2.Controls.Add(this.label1);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.dataLayoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(944, 617);
            this.splitContainerControl1.SplitterPosition = 458;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // companyGridControl
            // 
            this.companyGridControl.DataSource = this.bindingSourceCompany;
            this.companyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyGridControl.Location = new System.Drawing.Point(0, 0);
            this.companyGridControl.MainView = this.companyGridView;
            this.companyGridControl.Name = "companyGridControl";
            this.companyGridControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.companyGridControl.Size = new System.Drawing.Size(454, 613);
            this.companyGridControl.TabIndex = 0;
            this.companyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.companyGridView});
            this.companyGridControl.Click += new System.EventHandler(this.companyGridControl_Click);
            // 
            // bindingSourceCompany
            // 
            this.bindingSourceCompany.DataSource = typeof(task1.Model.Entities.Company);
            // 
            // companyGridView
            // 
            this.companyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyGuid,
            this.colCompanyCode,
            this.colCompanyName});
            this.companyGridView.GridControl = this.companyGridControl;
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.OptionsBehavior.Editable = false;
            this.companyGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.companyGridView_RowClick);
            this.companyGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.companyGridView_RowCellClick);
            // 
            // colCompanyGuid
            // 
            this.colCompanyGuid.FieldName = "CompanyGUID";
            this.colCompanyGuid.Name = "colCompanyGuid";
            // 
            // colCompanyCode
            // 
            this.colCompanyCode.Caption = "رمز الشركه";
            this.colCompanyCode.FieldName = "CompanyCode";
            this.colCompanyCode.Name = "colCompanyCode";
            this.colCompanyCode.Visible = true;
            this.colCompanyCode.VisibleIndex = 0;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "اسم الشركه";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "اسم الشركه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "رمز الشركه";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.btnShowTree);
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Controls.Add(this.btnSaveOrUpdate);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Location = new System.Drawing.Point(26, 303);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(323, 285);
            this.panelControl1.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
            this.btnExport.Location = new System.Drawing.Point(66, 206);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(187, 35);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "تصدير الى اكسل";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSaveOrUpdate
            // 
            this.btnSaveOrUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrUpdate.Location = new System.Drawing.Point(66, 20);
            this.btnSaveOrUpdate.Name = "btnSaveOrUpdate";
            this.btnSaveOrUpdate.Size = new System.Drawing.Size(187, 34);
            this.btnSaveOrUpdate.TabIndex = 1;
            this.btnSaveOrUpdate.Text = "حفظ";
            this.btnSaveOrUpdate.UseVisualStyleBackColor = true;
            this.btnSaveOrUpdate.Click += new System.EventHandler(this.btnSaveOrUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(66, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLayoutControl1.BackColor = System.Drawing.Color.White;
            this.dataLayoutControl1.Controls.Add(this.CompanyCodeText);
            this.dataLayoutControl1.Controls.Add(this.CompanyNameText);
            this.dataLayoutControl1.DataSource = this.bindingSourceCompany;
            this.dataLayoutControl1.Location = new System.Drawing.Point(26, 120);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(323, 120);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CompanyCodeText
            // 
            this.CompanyCodeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyCodeText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCompany, "CompanyCode", true));
            this.CompanyCodeText.Location = new System.Drawing.Point(20, 20);
            this.CompanyCodeText.Name = "CompanyCodeText";
            this.CompanyCodeText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyCodeText.Properties.Appearance.Options.UseFont = true;
            this.CompanyCodeText.Size = new System.Drawing.Size(283, 26);
            this.CompanyCodeText.StyleController = this.dataLayoutControl1;
            this.CompanyCodeText.TabIndex = 4;
            this.CompanyCodeText.EditValueChanged += new System.EventHandler(this.CompanyCodeTextEdit_EditValueChanged);
            // 
            // CompanyNameText
            // 
            this.CompanyNameText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSourceCompany, "CompanyName", true));
            this.CompanyNameText.Location = new System.Drawing.Point(20, 66);
            this.CompanyNameText.Name = "CompanyNameText";
            this.CompanyNameText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameText.Properties.Appearance.Options.UseFont = true;
            this.CompanyNameText.Size = new System.Drawing.Size(283, 26);
            this.CompanyNameText.StyleController = this.dataLayoutControl1;
            this.CompanyNameText.TabIndex = 5;
            this.CompanyNameText.EditValueChanged += new System.EventHandler(this.CompanyNameTextEdit_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(323, 120);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCompanyCode,
            this.ItemForCompanyName});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(303, 100);
            // 
            // ItemForCompanyCode
            // 
            this.ItemForCompanyCode.Control = this.CompanyCodeText;
            this.ItemForCompanyCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCompanyCode.Name = "ItemForCompanyCode";
            this.ItemForCompanyCode.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCompanyCode.Size = new System.Drawing.Size(303, 46);
            this.ItemForCompanyCode.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForCompanyCode.TextVisible = false;
            // 
            // ItemForCompanyName
            // 
            this.ItemForCompanyName.Control = this.CompanyNameText;
            this.ItemForCompanyName.Location = new System.Drawing.Point(0, 46);
            this.ItemForCompanyName.Name = "ItemForCompanyName";
            this.ItemForCompanyName.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCompanyName.Size = new System.Drawing.Size(303, 54);
            this.ItemForCompanyName.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForCompanyName.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonAddorUpdateCompany,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(995, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 702);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(995, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 682);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(995, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 682);
            // 
            // barButtonAddorUpdateCompany
            // 
            this.barButtonAddorUpdateCompany.Caption = "حفظ";
            this.barButtonAddorUpdateCompany.Id = 0;
            this.barButtonAddorUpdateCompany.Name = "barButtonAddorUpdateCompany";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "اضافه عنصر";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnShowTree
            // 
            this.btnShowTree.BackColor = System.Drawing.Color.White;
            this.btnShowTree.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTree.Location = new System.Drawing.Point(66, 86);
            this.btnShowTree.Name = "btnShowTree";
            this.btnShowTree.Size = new System.Drawing.Size(187, 34);
            this.btnShowTree.TabIndex = 4;
            this.btnShowTree.Text = "شجره الشركات";
            this.btnShowTree.UseVisualStyleBackColor = false;
            this.btnShowTree.Click += new System.EventHandler(this.btnShowTree_Click);
            // 
            // CompanyForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 702);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CompanyForm.IconOptions.Image")));
            this.Name = "CompanyForm";
            this.Text = "اداره الشركات";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            this.splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyCodeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.BindingSource bindingSourceCompany;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit CompanyCodeText;
        private DevExpress.XtraEditors.TextEdit CompanyNameText;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyName;
        private DevExpress.XtraGrid.GridControl companyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView companyGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyGuid;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonAddorUpdateCompany;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveOrUpdate;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.Button btnShowTree;
    }
}