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
            this.ItemNameText = new DevExpress.XtraEditors.TextEdit();
            this.ItemCodeText = new DevExpress.XtraEditors.TextEdit();
            this.ItemDescriptionText = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForItemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForItemDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.CompanylookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.CategorylookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.wholesalePriceTextBox = new System.Windows.Forms.TextBox();
            this.distributorPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanylookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategorylookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ItemNameText);
            this.dataLayoutControl1.Controls.Add(this.ItemCodeText);
            this.dataLayoutControl1.Controls.Add(this.ItemDescriptionText);
            this.dataLayoutControl1.DataSource = this.itemBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(122, 48);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(462, 159);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ItemNameText
            // 
            this.ItemNameText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemName", true));
            this.ItemNameText.Location = new System.Drawing.Point(20, 20);
            this.ItemNameText.Name = "ItemNameText";
            this.ItemNameText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameText.Properties.Appearance.Options.UseFont = true;
            this.ItemNameText.Size = new System.Drawing.Size(422, 26);
            this.ItemNameText.StyleController = this.dataLayoutControl1;
            this.ItemNameText.TabIndex = 4;
            // 
            // ItemCodeText
            // 
            this.ItemCodeText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemCode", true));
            this.ItemCodeText.Location = new System.Drawing.Point(20, 66);
            this.ItemCodeText.Name = "ItemCodeText";
            this.ItemCodeText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCodeText.Properties.Appearance.Options.UseFont = true;
            this.ItemCodeText.Size = new System.Drawing.Size(422, 26);
            this.ItemCodeText.StyleController = this.dataLayoutControl1;
            this.ItemCodeText.TabIndex = 5;
            // 
            // ItemDescriptionText
            // 
            this.ItemDescriptionText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemDescription", true));
            this.ItemDescriptionText.Location = new System.Drawing.Point(20, 112);
            this.ItemDescriptionText.Name = "ItemDescriptionText";
            this.ItemDescriptionText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionText.Properties.Appearance.Options.UseFont = true;
            this.ItemDescriptionText.Size = new System.Drawing.Size(422, 26);
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
            this.Root.Size = new System.Drawing.Size(462, 159);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(442, 139);
            // 
            // ItemForItemName
            // 
            this.ItemForItemName.Control = this.ItemNameText;
            this.ItemForItemName.Location = new System.Drawing.Point(0, 0);
            this.ItemForItemName.Name = "ItemForItemName";
            this.ItemForItemName.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemName.Size = new System.Drawing.Size(442, 46);
            this.ItemForItemName.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForItemName.TextVisible = false;
            // 
            // ItemForItemCode
            // 
            this.ItemForItemCode.Control = this.ItemCodeText;
            this.ItemForItemCode.Location = new System.Drawing.Point(0, 46);
            this.ItemForItemCode.Name = "ItemForItemCode";
            this.ItemForItemCode.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemCode.Size = new System.Drawing.Size(442, 46);
            this.ItemForItemCode.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForItemCode.TextVisible = false;
            // 
            // ItemForItemDescription
            // 
            this.ItemForItemDescription.Control = this.ItemDescriptionText;
            this.ItemForItemDescription.Location = new System.Drawing.Point(0, 92);
            this.ItemForItemDescription.Name = "ItemForItemDescription";
            this.ItemForItemDescription.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.ItemForItemDescription.Size = new System.Drawing.Size(442, 47);
            this.ItemForItemDescription.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForItemDescription.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnAddOrUpdate);
            this.panelControl1.Location = new System.Drawing.Point(142, 483);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(533, 76);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(85, 21);
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
            this.btnAddOrUpdate.Location = new System.Drawing.Point(337, 21);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(102, 38);
            this.btnAddOrUpdate.TabIndex = 0;
            this.btnAddOrUpdate.Text = "حفظ";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.CompanylookUpEdit);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.CategorylookUpEdit);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Location = new System.Drawing.Point(144, 221);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(533, 72);
            this.panelControl2.TabIndex = 2;
            // 
            // CompanylookUpEdit
            // 
            this.CompanylookUpEdit.Location = new System.Drawing.Point(9, 28);
            this.CompanylookUpEdit.Name = "CompanylookUpEdit";
            this.CompanylookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanylookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.CompanylookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CompanylookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "اسم الشركه"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyGuid", "Name16", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.CompanylookUpEdit.Properties.NullText = "قائمه الشركات";
            this.CompanylookUpEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CompanylookUpEdit.Size = new System.Drawing.Size(144, 22);
            this.CompanylookUpEdit.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "اختر التصنيف";
            // 
            // CategorylookUpEdit
            // 
            this.CategorylookUpEdit.Location = new System.Drawing.Point(269, 28);
            this.CategorylookUpEdit.Name = "CategorylookUpEdit";
            this.CategorylookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorylookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.CategorylookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CategorylookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "اسم التصنيف"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryGuid", "Name18", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.CategorylookUpEdit.Properties.NullText = "قائمه التصنيفات";
            this.CategorylookUpEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CategorylookUpEdit.Size = new System.Drawing.Size(153, 22);
            this.CategorylookUpEdit.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "اختر الشركه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(597, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "اسم العنصر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(597, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "رمز العنصر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(590, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "وصف العنصر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(583, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "سعر الموزع";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(590, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "سعر الجمله";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(590, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "سعر المفرد";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTextBox.Location = new System.Drawing.Point(413, 324);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemPriceTextBox.Size = new System.Drawing.Size(151, 26);
            this.itemPriceTextBox.TabIndex = 16;
            this.itemPriceTextBox.TextChanged += new System.EventHandler(this.itemPriceTextBox_TextChanged);
            // 
            // wholesalePriceTextBox
            // 
            this.wholesalePriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholesalePriceTextBox.Location = new System.Drawing.Point(413, 372);
            this.wholesalePriceTextBox.Name = "wholesalePriceTextBox";
            this.wholesalePriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wholesalePriceTextBox.Size = new System.Drawing.Size(151, 26);
            this.wholesalePriceTextBox.TabIndex = 17;
            this.wholesalePriceTextBox.TextChanged += new System.EventHandler(this.wholesalePriceTextBox_TextChanged);
            // 
            // distributorPriceTextBox
            // 
            this.distributorPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distributorPriceTextBox.Location = new System.Drawing.Point(413, 416);
            this.distributorPriceTextBox.Name = "distributorPriceTextBox";
            this.distributorPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.distributorPriceTextBox.Size = new System.Drawing.Size(151, 26);
            this.distributorPriceTextBox.TabIndex = 18;
            this.distributorPriceTextBox.TextChanged += new System.EventHandler(this.distributorPriceTextBox_TextChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(task1.Model.Entities.Item);
            // 
            // InputItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(797, 643);
            this.Controls.Add(this.distributorPriceTextBox);
            this.Controls.Add(this.wholesalePriceTextBox);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InputItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادخال بيانات العنصر";
            this.Load += new System.EventHandler(this.InputItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCodeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescriptionText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForItemDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanylookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategorylookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit CompanylookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit CategorylookUpEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.TextBox wholesalePriceTextBox;
        private System.Windows.Forms.TextBox distributorPriceTextBox;
    }
}