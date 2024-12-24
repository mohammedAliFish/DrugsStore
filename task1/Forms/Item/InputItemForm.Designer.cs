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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ItemNameText = new DevExpress.XtraEditors.TextEdit();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemCodeText = new DevExpress.XtraEditors.TextEdit();
            this.ItemDescriptionText = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForItemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompany = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.CategoryComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CompanyComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ItemNameText);
            this.dataLayoutControl1.Controls.Add(this.ItemCodeText);
            this.dataLayoutControl1.Controls.Add(this.ItemDescriptionText);
            this.dataLayoutControl1.Controls.Add(this.CategoryComboBox);
            this.dataLayoutControl1.Controls.Add(this.CompanyComboBox);
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
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(task1.Model.Entities.Item);
            // 
            // ItemCodeText
            // 
            this.ItemCodeText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemCode", true));
            this.ItemCodeText.Location = new System.Drawing.Point(20, 64);
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
            this.ItemDescriptionText.Location = new System.Drawing.Point(20, 106);
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
            this.layoutControlGroup1});
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
            this.ItemForItemDescription,
            this.ItemForCategory,
            this.ItemForCompany});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(525, 210);
            // 
            // ItemForItemName
            // 
            this.ItemForItemName.Control = this.ItemNameText;
            this.ItemForItemName.Location = new System.Drawing.Point(0, 0);
            this.ItemForItemName.Name = "ItemForItemName";
            this.ItemForItemName.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemName.Size = new System.Drawing.Size(525, 44);
            this.ItemForItemName.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForItemCode
            // 
            this.ItemForItemCode.Control = this.ItemCodeText;
            this.ItemForItemCode.Location = new System.Drawing.Point(0, 44);
            this.ItemForItemCode.Name = "ItemForItemCode";
            this.ItemForItemCode.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemCode.Size = new System.Drawing.Size(525, 42);
            this.ItemForItemCode.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForItemDescription
            // 
            this.ItemForItemDescription.Control = this.ItemDescriptionText;
            this.ItemForItemDescription.Location = new System.Drawing.Point(0, 86);
            this.ItemForItemDescription.Name = "ItemForItemDescription";
            this.ItemForItemDescription.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemDescription.Size = new System.Drawing.Size(525, 42);
            this.ItemForItemDescription.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForCategory
            // 
            this.ItemForCategory.Control = this.CategoryComboBox;
            this.ItemForCategory.Location = new System.Drawing.Point(0, 128);
            this.ItemForCategory.Name = "ItemForCategory";
            this.ItemForCategory.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCategory.Size = new System.Drawing.Size(525, 40);
            this.ItemForCategory.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForCompany
            // 
            this.ItemForCompany.Control = this.CompanyComboBox;
            this.ItemForCompany.Location = new System.Drawing.Point(0, 168);
            this.ItemForCompany.Name = "ItemForCompany";
            this.ItemForCompany.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForCompany.Size = new System.Drawing.Size(525, 42);
            this.ItemForCompany.TextSize = new System.Drawing.Size(64, 13);
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
            // CategoryComboBox
            // 
            this.CategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "Category", true));
            this.CategoryComboBox.EditValue = "";
            this.CategoryComboBox.Location = new System.Drawing.Point(20, 148);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.Properties.Appearance.Options.UseFont = true;
            this.CategoryComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CategoryComboBox.Size = new System.Drawing.Size(429, 22);
            this.CategoryComboBox.StyleController = this.dataLayoutControl1;
            this.CategoryComboBox.TabIndex = 7;
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "Company", true));
            this.CompanyComboBox.Location = new System.Drawing.Point(20, 188);
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyComboBox.Properties.Appearance.Options.UseFont = true;
            this.CompanyComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CompanyComboBox.Size = new System.Drawing.Size(429, 22);
            this.CompanyComboBox.StyleController = this.dataLayoutControl1;
            this.CompanyComboBox.TabIndex = 8;
            // 
            // InputItemForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 413);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "InputItemForm";
            this.Text = "InputItemForm";
            this.Load += new System.EventHandler(this.InputItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyComboBox.Properties)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategory;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompany;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnDelete;
        private DevExpress.XtraEditors.ComboBoxEdit CategoryComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit CompanyComboBox;
    }
}