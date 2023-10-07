namespace StockMarcte
{
	partial class Item
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
			this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
			this.billsDataSet1 = new StockMarcte.BillsDataSet1();
			this.tBItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tB_ItemTableAdapter = new StockMarcte.BillsDataSet1TableAdapters.TB_ItemTableAdapter();
			this.colitemGuid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitemcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitemName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitemPriceSingle = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitemPriceMany = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colparentGuid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colISGroup = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDateOfInsert = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.lookUpEdit1);
			this.panelControl1.Controls.Add(this.checkEdit1);
			this.panelControl1.Controls.Add(this.labelControl8);
			this.panelControl1.Controls.Add(this.labelControl7);
			this.panelControl1.Controls.Add(this.labelControl6);
			this.panelControl1.Controls.Add(this.textEdit6);
			this.panelControl1.Controls.Add(this.labelControl5);
			this.panelControl1.Controls.Add(this.textEdit5);
			this.panelControl1.Controls.Add(this.labelControl4);
			this.panelControl1.Controls.Add(this.textEdit4);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.textEdit3);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.textEdit2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.textEdit1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1078, 661);
			this.panelControl1.TabIndex = 0;
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.tBItemBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridControl1.Location = new System.Drawing.Point(0, 385);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1078, 276);
			this.gridControl1.TabIndex = 1;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemGuid,
            this.colitemcode,
            this.colitemName,
            this.colitemPrice,
            this.colitemPriceSingle,
            this.colitemPriceMany,
            this.colparentGuid,
            this.colISGroup,
            this.colDateOfInsert});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// textEdit1
			// 
			this.textEdit1.Location = new System.Drawing.Point(216, 9);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEdit1.Properties.Appearance.Options.UseFont = true;
			this.textEdit1.Size = new System.Drawing.Size(271, 28);
			this.textEdit1.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(12, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(90, 21);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Item Guid";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(12, 46);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(90, 21);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "Itme code";
			// 
			// textEdit2
			// 
			this.textEdit2.Location = new System.Drawing.Point(216, 43);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEdit2.Properties.Appearance.Options.UseFont = true;
			this.textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEdit2.Properties.MaskSettings.Set("mask", "d");
			this.textEdit2.Size = new System.Drawing.Size(271, 28);
			this.textEdit2.TabIndex = 2;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(12, 84);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(90, 21);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "item name";
			// 
			// textEdit3
			// 
			this.textEdit3.Location = new System.Drawing.Point(216, 81);
			this.textEdit3.Name = "textEdit3";
			this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEdit3.Properties.Appearance.Options.UseFont = true;
			this.textEdit3.Size = new System.Drawing.Size(271, 28);
			this.textEdit3.TabIndex = 4;
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(12, 118);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(100, 21);
			this.labelControl4.TabIndex = 7;
			this.labelControl4.Text = "item price";
			// 
			// textEdit4
			// 
			this.textEdit4.Location = new System.Drawing.Point(216, 115);
			this.textEdit4.Name = "textEdit4";
			this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEdit4.Properties.Appearance.Options.UseFont = true;
			this.textEdit4.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEdit4.Properties.MaskSettings.Set("mask", "c");
			this.textEdit4.Size = new System.Drawing.Size(271, 28);
			this.textEdit4.TabIndex = 6;
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(12, 152);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(150, 21);
			this.labelControl5.TabIndex = 9;
			this.labelControl5.Text = "item price many";
			// 
			// textEdit5
			// 
			this.textEdit5.Location = new System.Drawing.Point(216, 149);
			this.textEdit5.Name = "textEdit5";
			this.textEdit5.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEdit5.Properties.Appearance.Options.UseFont = true;
			this.textEdit5.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEdit5.Properties.MaskSettings.Set("mask", "c");
			this.textEdit5.Size = new System.Drawing.Size(271, 28);
			this.textEdit5.TabIndex = 8;
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(12, 186);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(170, 21);
			this.labelControl6.TabIndex = 11;
			this.labelControl6.Text = "item price singel";
			// 
			// textEdit6
			// 
			this.textEdit6.Location = new System.Drawing.Point(216, 183);
			this.textEdit6.Name = "textEdit6";
			this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEdit6.Properties.Appearance.Options.UseFont = true;
			this.textEdit6.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.textEdit6.Properties.MaskSettings.Set("mask", "c");
			this.textEdit6.Size = new System.Drawing.Size(271, 28);
			this.textEdit6.TabIndex = 10;
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(12, 220);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(110, 21);
			this.labelControl7.TabIndex = 13;
			this.labelControl7.Text = "Parent guid";
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Location = new System.Drawing.Point(12, 254);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(80, 21);
			this.labelControl8.TabIndex = 15;
			this.labelControl8.Text = "IS Group";
			// 
			// checkEdit1
			// 
			this.checkEdit1.Location = new System.Drawing.Point(216, 256);
			this.checkEdit1.Name = "checkEdit1";
			this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkEdit1.Properties.Appearance.Options.UseFont = true;
			this.checkEdit1.Properties.Caption = "is group";
			this.checkEdit1.Size = new System.Drawing.Size(131, 25);
			this.checkEdit1.TabIndex = 16;
			// 
			// lookUpEdit1
			// 
			this.lookUpEdit1.Location = new System.Drawing.Point(216, 217);
			this.lookUpEdit1.Name = "lookUpEdit1";
			this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
			this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lookUpEdit1.Properties.NullText = "";
			this.lookUpEdit1.Properties.ShowFooter = false;
			this.lookUpEdit1.Properties.ShowHeader = false;
			this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.lookUpEdit1.Size = new System.Drawing.Size(271, 28);
			this.lookUpEdit1.TabIndex = 17;
			// 
			// billsDataSet1
			// 
			this.billsDataSet1.DataSetName = "BillsDataSet1";
			this.billsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tBItemBindingSource
			// 
			this.tBItemBindingSource.DataMember = "TB_Item";
			this.tBItemBindingSource.DataSource = this.billsDataSet1;
			// 
			// tB_ItemTableAdapter
			// 
			this.tB_ItemTableAdapter.ClearBeforeFill = true;
			// 
			// colitemGuid
			// 
			this.colitemGuid.FieldName = "itemGuid";
			this.colitemGuid.Name = "colitemGuid";
			this.colitemGuid.Visible = true;
			this.colitemGuid.VisibleIndex = 0;
			// 
			// colitemcode
			// 
			this.colitemcode.FieldName = "itemcode";
			this.colitemcode.Name = "colitemcode";
			this.colitemcode.Visible = true;
			this.colitemcode.VisibleIndex = 1;
			// 
			// colitemName
			// 
			this.colitemName.FieldName = "itemName";
			this.colitemName.Name = "colitemName";
			this.colitemName.Visible = true;
			this.colitemName.VisibleIndex = 2;
			// 
			// colitemPrice
			// 
			this.colitemPrice.FieldName = "itemPrice";
			this.colitemPrice.Name = "colitemPrice";
			this.colitemPrice.Visible = true;
			this.colitemPrice.VisibleIndex = 3;
			// 
			// colitemPriceSingle
			// 
			this.colitemPriceSingle.FieldName = "itemPriceSingle";
			this.colitemPriceSingle.Name = "colitemPriceSingle";
			this.colitemPriceSingle.Visible = true;
			this.colitemPriceSingle.VisibleIndex = 4;
			// 
			// colitemPriceMany
			// 
			this.colitemPriceMany.FieldName = "itemPriceMany";
			this.colitemPriceMany.Name = "colitemPriceMany";
			this.colitemPriceMany.Visible = true;
			this.colitemPriceMany.VisibleIndex = 5;
			// 
			// colparentGuid
			// 
			this.colparentGuid.FieldName = "parentGuid";
			this.colparentGuid.Name = "colparentGuid";
			this.colparentGuid.Visible = true;
			this.colparentGuid.VisibleIndex = 6;
			// 
			// colISGroup
			// 
			this.colISGroup.FieldName = "ISGroup";
			this.colISGroup.Name = "colISGroup";
			this.colISGroup.Visible = true;
			this.colISGroup.VisibleIndex = 7;
			// 
			// colDateOfInsert
			// 
			this.colDateOfInsert.FieldName = "DateOfInsert";
			this.colDateOfInsert.Name = "colDateOfInsert";
			this.colDateOfInsert.Visible = true;
			this.colDateOfInsert.VisibleIndex = 8;
			// 
			// Item
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1078, 661);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.panelControl1);
			this.Name = "Item";
			this.Text = "Item";
			this.Load += new System.EventHandler(this.Item_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.TextEdit textEdit6;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.TextEdit textEdit5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit textEdit4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit textEdit3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
		private DevExpress.XtraEditors.CheckEdit checkEdit1;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private BillsDataSet1 billsDataSet1;
		private System.Windows.Forms.BindingSource tBItemBindingSource;
		private BillsDataSet1TableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter;
		private DevExpress.XtraGrid.Columns.GridColumn colitemGuid;
		private DevExpress.XtraGrid.Columns.GridColumn colitemcode;
		private DevExpress.XtraGrid.Columns.GridColumn colitemName;
		private DevExpress.XtraGrid.Columns.GridColumn colitemPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colitemPriceSingle;
		private DevExpress.XtraGrid.Columns.GridColumn colitemPriceMany;
		private DevExpress.XtraGrid.Columns.GridColumn colparentGuid;
		private DevExpress.XtraGrid.Columns.GridColumn colISGroup;
		private DevExpress.XtraGrid.Columns.GridColumn colDateOfInsert;
	}
}