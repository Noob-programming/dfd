namespace StockMarcte
{
	partial class BillItem
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
			this.Deletes = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.DateBill = new DevExpress.XtraEditors.DateEdit();
			this.LookUPType = new DevExpress.XtraEditors.LookUpEdit();
			this.tBBillBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.billsDataSet = new StockMarcte.BillsDataSet();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtNotes = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtguid = new DevExpress.XtraEditors.TextEdit();
			this.Billcode = new DevExpress.XtraEditors.TextEdit();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.tBBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.billsDataSet1 = new StockMarcte.BillsDataSet1();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colBillGuid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBillcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBillType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.tB_BillTableAdapter = new StockMarcte.BillsDataSet1TableAdapters.TB_BillTableAdapter();
			this.tB_BillTableAdapter1 = new StockMarcte.BillsDataSetTableAdapters.TB_BillTableAdapter();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DateBill.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DateBill.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LookUPType.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtguid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Billcode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.Deletes);
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Controls.Add(this.DateBill);
			this.panelControl1.Controls.Add(this.LookUPType);
			this.panelControl1.Controls.Add(this.labelControl4);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.txtNotes);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.txtguid);
			this.panelControl1.Controls.Add(this.Billcode);
			this.panelControl1.Controls.Add(this.gridControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(975, 561);
			this.panelControl1.TabIndex = 0;
			// 
			// Deletes
			// 
			this.Deletes.Location = new System.Drawing.Point(466, 98);
			this.Deletes.Name = "Deletes";
			this.Deletes.Size = new System.Drawing.Size(121, 54);
			this.Deletes.TabIndex = 9;
			this.Deletes.Text = "Delete";
			this.Deletes.Click += new System.EventHandler(this.Deletes_Click);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(466, 12);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(121, 54);
			this.simpleButton1.TabIndex = 9;
			this.simpleButton1.Text = "Save";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// DateBill
			// 
			this.DateBill.EditValue = null;
			this.DateBill.Location = new System.Drawing.Point(155, 46);
			this.DateBill.Name = "DateBill";
			this.DateBill.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateBill.Properties.Appearance.Options.UseFont = true;
			this.DateBill.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DateBill.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DateBill.Size = new System.Drawing.Size(227, 28);
			this.DateBill.TabIndex = 8;
			// 
			// LookUPType
			// 
			this.LookUPType.Location = new System.Drawing.Point(155, 124);
			this.LookUPType.Name = "LookUPType";
			this.LookUPType.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LookUPType.Properties.Appearance.Options.UseFont = true;
			this.LookUPType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.LookUPType.Properties.DataSource = this.tBBillBindingSource1;
			this.LookUPType.Properties.DisplayMember = "BillType";
			this.LookUPType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.LookUPType.Properties.ValueMember = "BillType";
			this.LookUPType.Size = new System.Drawing.Size(227, 28);
			this.LookUPType.TabIndex = 7;
			// 
			// tBBillBindingSource1
			// 
			this.tBBillBindingSource1.DataMember = "TB_Bill";
			this.tBBillBindingSource1.DataSource = this.billsDataSet;
			// 
			// billsDataSet
			// 
			this.billsDataSet.DataSetName = "BillsDataSet";
			this.billsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(19, 127);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(90, 21);
			this.labelControl4.TabIndex = 6;
			this.labelControl4.Text = "Bill Type";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(19, 87);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(50, 21);
			this.labelControl3.TabIndex = 6;
			this.labelControl3.Text = "Notes";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(155, 80);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNotes.Properties.Appearance.Options.UseFont = true;
			this.txtNotes.Size = new System.Drawing.Size(227, 28);
			this.txtNotes.TabIndex = 5;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(19, 53);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(90, 21);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Bill Date";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(19, 15);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(90, 21);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Bill Code";
			// 
			// txtguid
			// 
			this.txtguid.Location = new System.Drawing.Point(155, 175);
			this.txtguid.Name = "txtguid";
			this.txtguid.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtguid.Properties.Appearance.Options.UseFont = true;
			this.txtguid.Size = new System.Drawing.Size(227, 28);
			this.txtguid.TabIndex = 1;
			// 
			// Billcode
			// 
			this.Billcode.Location = new System.Drawing.Point(155, 12);
			this.Billcode.Name = "Billcode";
			this.Billcode.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Billcode.Properties.Appearance.Options.UseFont = true;
			this.Billcode.Size = new System.Drawing.Size(227, 28);
			this.Billcode.TabIndex = 1;
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.tBBillBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridControl1.Location = new System.Drawing.Point(2, 290);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(971, 269);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// tBBillBindingSource
			// 
			this.tBBillBindingSource.DataMember = "TB_Bill";
			this.tBBillBindingSource.DataSource = this.billsDataSet1;
			// 
			// billsDataSet1
			// 
			this.billsDataSet1.DataSetName = "BillsDataSet1";
			this.billsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillGuid,
            this.colBillcode,
            this.colBillDate,
            this.colNotes,
            this.colBillType});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// colBillGuid
			// 
			this.colBillGuid.FieldName = "BillGuid";
			this.colBillGuid.Name = "colBillGuid";
			this.colBillGuid.Visible = true;
			this.colBillGuid.VisibleIndex = 0;
			// 
			// colBillcode
			// 
			this.colBillcode.FieldName = "Billcode";
			this.colBillcode.Name = "colBillcode";
			this.colBillcode.Visible = true;
			this.colBillcode.VisibleIndex = 1;
			// 
			// colBillDate
			// 
			this.colBillDate.FieldName = "BillDate";
			this.colBillDate.Name = "colBillDate";
			this.colBillDate.Visible = true;
			this.colBillDate.VisibleIndex = 2;
			// 
			// colNotes
			// 
			this.colNotes.FieldName = "Notes";
			this.colNotes.Name = "colNotes";
			this.colNotes.Visible = true;
			this.colNotes.VisibleIndex = 3;
			// 
			// colBillType
			// 
			this.colBillType.FieldName = "BillType";
			this.colBillType.Name = "colBillType";
			this.colBillType.Visible = true;
			this.colBillType.VisibleIndex = 4;
			// 
			// tB_BillTableAdapter
			// 
			this.tB_BillTableAdapter.ClearBeforeFill = true;
			// 
			// tB_BillTableAdapter1
			// 
			this.tB_BillTableAdapter1.ClearBeforeFill = true;
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.Name = "sqlDataSource1";
			// 
			// BillItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(975, 561);
			this.Controls.Add(this.panelControl1);
			this.Name = "BillItem";
			this.Text = "BillItem";
			this.Load += new System.EventHandler(this.BillItem_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DateBill.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DateBill.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LookUPType.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtguid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Billcode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.TextEdit Billcode;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtNotes;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LookUpEdit LookUPType;
		private DevExpress.XtraEditors.DateEdit DateBill;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private BillsDataSet1 billsDataSet1;
		private System.Windows.Forms.BindingSource tBBillBindingSource;
		private BillsDataSet1TableAdapters.TB_BillTableAdapter tB_BillTableAdapter;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraGrid.Columns.GridColumn colBillGuid;
		private DevExpress.XtraGrid.Columns.GridColumn colBillcode;
		private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colBillType;
		private DevExpress.XtraEditors.TextEdit txtguid;
		private BillsDataSet billsDataSet;
		private System.Windows.Forms.BindingSource tBBillBindingSource1;
		private BillsDataSetTableAdapters.TB_BillTableAdapter tB_BillTableAdapter1;
		private DevExpress.XtraEditors.SimpleButton Deletes;
		private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
	}
}