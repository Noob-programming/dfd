namespace DXApplication2
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
			this.billsDataSet = new DXApplication2.BillsDataSet();
			this.tBItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tB_ItemTableAdapter = new DXApplication2.BillsDataSetTableAdapters.TB_ItemTableAdapter();
			this.treeList1 = new DevExpress.XtraTreeList.TreeList();
			this.colitemcode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colitemName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.billsDataSet1 = new DXApplication2.BillsDataSet();
			this.tB_ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableAdapterManager = new DXApplication2.BillsDataSetTableAdapters.TableAdapterManager();
			this.tBItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tB_ItemTableAdapter1 = new DXApplication2.BillsDataSetTableAdapters.TB_ItemTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tB_ItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// billsDataSet
			// 
			this.billsDataSet.DataSetName = "BillsDataSet";
			this.billsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tBItemBindingSource
			// 
			this.tBItemBindingSource.DataMember = "TB_Item";
			this.tBItemBindingSource.DataSource = this.billsDataSet;
			// 
			// tB_ItemTableAdapter
			// 
			this.tB_ItemTableAdapter.ClearBeforeFill = true;
			// 
			// treeList1
			// 
			this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colitemcode,
            this.colitemName});
			this.treeList1.DataMember = "TB_Item";
			this.treeList1.DataSource = this.billsDataSet1;
			this.treeList1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.treeList1.KeyFieldName = "itemGuid";
			this.treeList1.Location = new System.Drawing.Point(0, 392);
			this.treeList1.Name = "treeList1";
			this.treeList1.ParentFieldName = "parentGuid";
			this.treeList1.Size = new System.Drawing.Size(947, 240);
			this.treeList1.TabIndex = 0;
			// 
			// colitemcode
			// 
			this.colitemcode.FieldName = "itemcode";
			this.colitemcode.Name = "colitemcode";
			this.colitemcode.Visible = true;
			this.colitemcode.VisibleIndex = 0;
			// 
			// colitemName
			// 
			this.colitemName.FieldName = "itemName";
			this.colitemName.Name = "colitemName";
			this.colitemName.Visible = true;
			this.colitemName.VisibleIndex = 1;
			// 
			// billsDataSet1
			// 
			this.billsDataSet1.DataSetName = "BillsDataSet";
			this.billsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tB_ItemBindingSource
			// 
			this.tB_ItemBindingSource.DataMember = "TB_Item";
			this.tB_ItemBindingSource.DataSource = this.billsDataSet;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.TB_ItemTableAdapter = this.tB_ItemTableAdapter;
			this.tableAdapterManager.UpdateOrder = DXApplication2.BillsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// tBItemBindingSource1
			// 
			this.tBItemBindingSource1.DataMember = "TB_Item";
			this.tBItemBindingSource1.DataSource = this.billsDataSet;
			// 
			// tB_ItemTableAdapter1
			// 
			this.tB_ItemTableAdapter1.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 632);
			this.Controls.Add(this.treeList1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tB_ItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBItemBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private BillsDataSet billsDataSet;
		private System.Windows.Forms.BindingSource tBItemBindingSource;
		private BillsDataSetTableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter;
		private DevExpress.XtraTreeList.TreeList treeList1;
		private System.Windows.Forms.BindingSource tB_ItemBindingSource;
		private BillsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemcode;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colitemName;
		private BillsDataSet billsDataSet1;
		private System.Windows.Forms.BindingSource tBItemBindingSource1;
		private BillsDataSetTableAdapters.TB_ItemTableAdapter tB_ItemTableAdapter1;
	}
}

