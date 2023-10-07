namespace StockMarcte
{
	partial class Form1
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
			this.lookupstatus = new DevExpress.XtraEditors.LookUpEdit();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.txtQuintity = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtGuid = new DevExpress.XtraEditors.TextEdit();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.viewShowstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.billsDataSet1 = new StockMarcte.BillsDataSet1();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colitemGuid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitemName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuintity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.billsDataSet = new StockMarcte.BillsDataSet();
			this.billsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.view_Show_stockTableAdapter = new StockMarcte.BillsDataSet1TableAdapters.View_Show_stockTableAdapter();
			this.tBStockItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tB_StockItemTableAdapter = new StockMarcte.BillsDataSet1TableAdapters.TB_StockItemTableAdapter();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.lookupstatus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtQuintity.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGuid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewShowstockBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lookupstatus
			// 
			this.lookupstatus.Location = new System.Drawing.Point(168, 39);
			this.lookupstatus.Name = "lookupstatus";
			this.lookupstatus.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lookupstatus.Properties.Appearance.Options.UseFont = true;
			this.lookupstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lookupstatus.Properties.ShowHeader = false;
			this.lookupstatus.Properties.ShowLines = false;
			this.lookupstatus.Size = new System.Drawing.Size(196, 28);
			this.lookupstatus.TabIndex = 0;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.simpleButton2);
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Controls.Add(this.txtQuintity);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.txtGuid);
			this.panelControl1.Controls.Add(this.gridControl1);
			this.panelControl1.Controls.Add(this.lookupstatus);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(993, 620);
			this.panelControl1.TabIndex = 1;
			// 
			// txtQuintity
			// 
			this.txtQuintity.Location = new System.Drawing.Point(168, 73);
			this.txtQuintity.Name = "txtQuintity";
			this.txtQuintity.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuintity.Properties.Appearance.Options.UseFont = true;
			this.txtQuintity.Size = new System.Drawing.Size(196, 28);
			this.txtQuintity.TabIndex = 7;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(12, 80);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(80, 21);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "Quintity";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(12, 46);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(60, 21);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "status";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(12, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(90, 21);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "item guid";
			// 
			// txtGuid
			// 
			this.txtGuid.Location = new System.Drawing.Point(168, 5);
			this.txtGuid.Name = "txtGuid";
			this.txtGuid.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuid.Properties.Appearance.Options.UseFont = true;
			this.txtGuid.Size = new System.Drawing.Size(196, 28);
			this.txtGuid.TabIndex = 2;
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.tBStockItemBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridControl1.Location = new System.Drawing.Point(2, 286);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(989, 332);
			this.gridControl1.TabIndex = 1;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// viewShowstockBindingSource
			// 
			this.viewShowstockBindingSource.DataMember = "View_Show_stock";
			this.viewShowstockBindingSource.DataSource = this.billsDataSet1;
			// 
			// billsDataSet1
			// 
			this.billsDataSet1.DataSetName = "BillsDataSet1";
			this.billsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colitemGuid,
            this.colitemName,
            this.colQuintity,
            this.colstatus});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// colitemGuid
			// 
			this.colitemGuid.FieldName = "itemGuid";
			this.colitemGuid.Name = "colitemGuid";
			this.colitemGuid.Visible = true;
			this.colitemGuid.VisibleIndex = 0;
			// 
			// colitemName
			// 
			this.colitemName.FieldName = "itemName";
			this.colitemName.Name = "colitemName";
			this.colitemName.Visible = true;
			this.colitemName.VisibleIndex = 1;
			// 
			// colQuintity
			// 
			this.colQuintity.FieldName = "Quintity";
			this.colQuintity.Name = "colQuintity";
			this.colQuintity.Visible = true;
			this.colQuintity.VisibleIndex = 2;
			// 
			// colstatus
			// 
			this.colstatus.FieldName = "status";
			this.colstatus.Name = "colstatus";
			this.colstatus.Visible = true;
			this.colstatus.VisibleIndex = 3;
			// 
			// billsDataSet
			// 
			this.billsDataSet.DataSetName = "BillsDataSet";
			this.billsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// billsDataSetBindingSource
			// 
			this.billsDataSetBindingSource.DataSource = this.billsDataSet;
			this.billsDataSetBindingSource.Position = 0;
			// 
			// view_Show_stockTableAdapter
			// 
			this.view_Show_stockTableAdapter.ClearBeforeFill = true;
			// 
			// tBStockItemBindingSource
			// 
			this.tBStockItemBindingSource.DataMember = "TB_StockItem";
			this.tBStockItemBindingSource.DataSource = this.billsDataSet1;
			// 
			// tB_StockItemTableAdapter
			// 
			this.tB_StockItemTableAdapter.ClearBeforeFill = true;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(168, 121);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(196, 38);
			this.simpleButton1.TabIndex = 8;
			this.simpleButton1.Text = "Save";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(168, 178);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(196, 38);
			this.simpleButton2.TabIndex = 9;
			this.simpleButton2.Text = "Delete";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 620);
			this.Controls.Add(this.panelControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.lookupstatus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtQuintity.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGuid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewShowstockBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBStockItemBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LookUpEdit lookupstatus;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.TextEdit txtQuintity;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtGuid;
		private System.Windows.Forms.BindingSource billsDataSetBindingSource;
		private BillsDataSet billsDataSet;
		private BillsDataSet1 billsDataSet1;
		private System.Windows.Forms.BindingSource viewShowstockBindingSource;
		private BillsDataSet1TableAdapters.View_Show_stockTableAdapter view_Show_stockTableAdapter;
		private DevExpress.XtraGrid.Columns.GridColumn colitemGuid;
		private DevExpress.XtraGrid.Columns.GridColumn colitemName;
		private DevExpress.XtraGrid.Columns.GridColumn colQuintity;
		private DevExpress.XtraGrid.Columns.GridColumn colstatus;
		private System.Windows.Forms.BindingSource tBStockItemBindingSource;
		private BillsDataSet1TableAdapters.TB_StockItemTableAdapter tB_StockItemTableAdapter;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
	}
}

