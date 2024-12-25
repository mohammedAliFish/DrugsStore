namespace task1.Forms.Item
{
    partial class InputItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputItemForm));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.companylookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.categorylookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ItemNameText = new DevExpress.XtraEditors.TextEdit();
            this.ItemCodeText = new DevExpress.XtraEditors.TextEdit();
            this.ItemDescriptionText = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForItemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.categorylayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companylookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorylookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorylayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.companylookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.categorylookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.ItemNameText);
            this.dataLayoutControl1.Controls.Add(this.ItemCodeText);
            this.dataLayoutControl1.Controls.Add(this.ItemDescriptionText);
            this.dataLayoutControl1.DataSource = this.itemBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(36, 33);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(545, 230);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // companylookUpEdit
            // 
            this.companylookUpEdit.Location = new System.Drawing.Point(20, 188);
            this.companylookUpEdit.Name = "companylookUpEdit";
            this.companylookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companylookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.companylookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.companylookUpEdit.Properties.DataSource = this.companyBindingSource;
            this.companylookUpEdit.Properties.DisplayMember = "CompanyName";
            this.companylookUpEdit.Properties.ValueMember = "CompanyGuid";
            this.companylookUpEdit.Size = new System.Drawing.Size(429, 22);
            this.companylookUpEdit.StyleController = this.dataLayoutControl1;
            this.companylookUpEdit.TabIndex = 8;
            this.companylookUpEdit.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // categorylookUpEdit
            // 
            this.categorylookUpEdit.Location = new System.Drawing.Point(20, 146);
            this.categorylookUpEdit.Name = "categorylookUpEdit";
            this.categorylookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.categorylookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categorylookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "اسم التصنيف"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryGuid", "Name8")});
            this.categorylookUpEdit.Properties.DisplayMember = "CategoryName";
            this.categorylookUpEdit.Properties.ValueMember = "CategoryGuid";
            this.categorylookUpEdit.Size = new System.Drawing.Size(429, 22);
            this.categorylookUpEdit.StyleController = this.dataLayoutControl1;
            this.categorylookUpEdit.TabIndex = 7;
            this.categorylookUpEdit.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // ItemNameText
            // 
            this.ItemNameText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemName", true));
            this.ItemNameText.Location = new System.Drawing.Point(20, 20);
            this.ItemNameText.Name = "ItemNameText";
            this.ItemNameText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameText.Properties.Appearance.Options.UseFont = true;
            this.ItemNameText.Size = new System.Drawing.Size(429, 22);
            this.ItemNameText.StyleController = this.dataLayoutControl1;
            this.ItemNameText.TabIndex = 4;
            // 
            // ItemCodeText
            // 
            this.ItemCodeText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemCode", true));
            this.ItemCodeText.Location = new System.Drawing.Point(20, 62);
            this.ItemCodeText.Name = "ItemCodeText";
            this.ItemCodeText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCodeText.Properties.Appearance.Options.UseFont = true;
            this.ItemCodeText.Size = new System.Drawing.Size(429, 22);
            this.ItemCodeText.StyleController = this.dataLayoutControl1;
            this.ItemCodeText.TabIndex = 5;
            // 
            // ItemDescriptionText
            // 
            this.ItemDescriptionText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemDescription", true));
            this.ItemDescriptionText.Location = new System.Drawing.Point(20, 104);
            this.ItemDescriptionText.Name = "ItemDescriptionText";
            this.ItemDescriptionText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionText.Properties.Appearance.Options.UseFont = true;
            this.ItemDescriptionText.Size = new System.Drawing.Size(429, 22);
            this.ItemDescriptionText.StyleController = this.dataLayoutControl1;
            this.ItemDescriptionText.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.categorylayoutControlItem,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(545, 230);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForItemName,
            this.ItemForItemCode,
            this.ItemForItemDescription});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(525, 126);
            // 
            // ItemForItemName
            // 
            this.ItemForItemName.Control = this.ItemNameText;
            this.ItemForItemName.Location = new System.Drawing.Point(0, 0);
            this.ItemForItemName.Name = "ItemForItemName";
            this.ItemForItemName.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemName.Size = new System.Drawing.Size(525, 42);
            this.ItemForItemName.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForItemCode
            // 
            this.ItemForItemCode.Control = this.ItemCodeText;
            this.ItemForItemCode.Location = new System.Drawing.Point(0, 42);
            this.ItemForItemCode.Name = "ItemForItemCode";
            this.ItemForItemCode.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemCode.Size = new System.Drawing.Size(525, 42);
            this.ItemForItemCode.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForItemDescription
            // 
            this.ItemForItemDescription.Control = this.ItemDescriptionText;
            this.ItemForItemDescription.Location = new System.Drawing.Point(0, 84);
            this.ItemForItemDescription.Name = "ItemForItemDescription";
            this.ItemForItemDescription.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemDescription.Size = new System.Drawing.Size(525, 42);
            this.ItemForItemDescription.TextSize = new System.Drawing.Size(64, 13);
            // 
            // categorylayoutControlItem
            // 
            this.categorylayoutControlItem.Control = this.categorylookUpEdit;
            this.categorylayoutControlItem.Location = new System.Drawing.Point(0, 126);
            this.categorylayoutControlItem.Name = "categorylayoutControlItem";
            this.categorylayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.categorylayoutControlItem.Size = new System.Drawing.Size(525, 42);
            this.categorylayoutControlItem.Text = "اختر التصنيف";
            this.categorylayoutControlItem.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.companylookUpEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(525, 42);
            this.layoutControlItem2.Text = "اختر الشركه";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 13);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnAddOrUpdate);
            this.panelControl1.Location = new System.Drawing.Point(47, 288);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(438, 76);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(43, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 38);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrUpdate.Location = new System.Drawing.Point(295, 18);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(102, 38);
            this.btnAddOrUpdate.TabIndex = 0;
            this.btnAddOrUpdate.Text = "حفظ";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(task1.Model.Entities.Company);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(task1.Model.Entities.Item);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(task1.Model.Entities.Category);
            // 
            // InputItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 413);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادخال بيانات العنصر";
            this.Load += new System.EventHandler(this.InputItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companylookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorylookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorylayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnDelete;
        private DevExpress.XtraEditors.LookUpEdit companylookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit categorylookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem categorylayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}