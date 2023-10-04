namespace Itemds
{
	partial class XtraForm1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
			this.billsDataSet = new Itemds.BillsDataSet();
			this.tB_BillBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tB_BillTableAdapter = new Itemds.BillsDataSetTableAdapters.TB_BillTableAdapter();
			this.tableAdapterManager = new Itemds.BillsDataSetTableAdapters.TableAdapterManager();
			this.tB_BillBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.tB_BillBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.tB_BillGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tB_BillBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tB_BillBindingNavigator)).BeginInit();
			this.tB_BillBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tB_BillGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// billsDataSet
			// 
			this.billsDataSet.DataSetName = "BillsDataSet";
			this.billsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tB_BillBindingSource
			// 
			this.tB_BillBindingSource.DataMember = "TB_Bill";
			this.tB_BillBindingSource.DataSource = this.billsDataSet;
			// 
			// tB_BillTableAdapter
			// 
			this.tB_BillTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.TB_BillitemsTableAdapter = null;
			this.tableAdapterManager.TB_BillTableAdapter = this.tB_BillTableAdapter;
			this.tableAdapterManager.TB_ItemTableAdapter = null;
			this.tableAdapterManager.TB_StockItemTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Itemds.BillsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// tB_BillBindingNavigator
			// 
			this.tB_BillBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tB_BillBindingNavigator.BindingSource = this.tB_BillBindingSource;
			this.tB_BillBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tB_BillBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tB_BillBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tB_BillBindingNavigatorSaveItem});
			this.tB_BillBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.tB_BillBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tB_BillBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tB_BillBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tB_BillBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tB_BillBindingNavigator.Name = "tB_BillBindingNavigator";
			this.tB_BillBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tB_BillBindingNavigator.Size = new System.Drawing.Size(1109, 25);
			this.tB_BillBindingNavigator.TabIndex = 0;
			this.tB_BillBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// tB_BillBindingNavigatorSaveItem
			// 
			this.tB_BillBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tB_BillBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tB_BillBindingNavigatorSaveItem.Image")));
			this.tB_BillBindingNavigatorSaveItem.Name = "tB_BillBindingNavigatorSaveItem";
			this.tB_BillBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.tB_BillBindingNavigatorSaveItem.Text = "Save Data";
			this.tB_BillBindingNavigatorSaveItem.Click += new System.EventHandler(this.tB_BillBindingNavigatorSaveItem_Click);
			// 
			// tB_BillGridControl
			// 
			this.tB_BillGridControl.DataSource = this.tB_BillBindingSource;
			this.tB_BillGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tB_BillGridControl.Location = new System.Drawing.Point(0, 188);
			this.tB_BillGridControl.MainView = this.gridView1;
			this.tB_BillGridControl.Name = "tB_BillGridControl";
			this.tB_BillGridControl.Size = new System.Drawing.Size(1109, 392);
			this.tB_BillGridControl.TabIndex = 1;
			this.tB_BillGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.tB_BillGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// XtraForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1109, 580);
			this.Controls.Add(this.tB_BillGridControl);
			this.Controls.Add(this.tB_BillBindingNavigator);
			this.Name = "XtraForm1";
			this.Text = "XtraForm1";
			this.Load += new System.EventHandler(this.XtraForm1_Load);
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tB_BillBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tB_BillBindingNavigator)).EndInit();
			this.tB_BillBindingNavigator.ResumeLayout(false);
			this.tB_BillBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tB_BillGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BillsDataSet billsDataSet;
		private System.Windows.Forms.BindingSource tB_BillBindingSource;
		private BillsDataSetTableAdapters.TB_BillTableAdapter tB_BillTableAdapter;
		private BillsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator tB_BillBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton tB_BillBindingNavigatorSaveItem;
		private DevExpress.XtraGrid.GridControl tB_BillGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}