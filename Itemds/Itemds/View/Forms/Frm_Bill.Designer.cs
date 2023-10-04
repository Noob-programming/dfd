namespace Itemds.View.Forms
{
	partial class Frm_Bill
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bill));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
			this.txtguid = new DevExpress.XtraEditors.TextEdit();
			this.dtpicer = new DevExpress.XtraEditors.DateEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtNotes = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtID = new DevExpress.XtraEditors.TextEdit();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
			this.FirstOne = new DevExpress.XtraEditors.SimpleButton();
			this.LastOne = new DevExpress.XtraEditors.SimpleButton();
			this.Next = new DevExpress.XtraEditors.SimpleButton();
			this.Prefices = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
			this.Save = new DevExpress.XtraEditors.SimpleButton();
			this.Delete = new DevExpress.XtraEditors.SimpleButton();
			this.DeleteAll = new DevExpress.XtraEditors.SimpleButton();
			this.gcBill = new DevExpress.XtraGrid.GridControl();
			this.tBBillBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.billsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.billsDataSet = new Itemds.BillsDataSet();
			this.gvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colBillGuid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBillcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBillType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.tBBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
			this.tB_BillTableAdapter = new Itemds.BillsDataSetTableAdapters.TB_BillTableAdapter();
			this.fKBillitemsBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tB_BillitemsTableAdapter = new Itemds.BillsDataSetTableAdapters.TB_BillitemsTableAdapter();
			this.cbtype = new DevExpress.XtraEditors.LookUpEdit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
			this.panelControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtguid.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpicer.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpicer.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
			this.panelControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
			this.panelControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemCheck)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKBillitemsBillBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbtype.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.panelControl3);
			this.panelControl1.Controls.Add(this.panelControl2);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1123, 292);
			this.panelControl1.TabIndex = 0;
			// 
			// panelControl3
			// 
			this.panelControl3.Controls.Add(this.cbtype);
			this.panelControl3.Controls.Add(this.txtguid);
			this.panelControl3.Controls.Add(this.dtpicer);
			this.panelControl3.Controls.Add(this.labelControl4);
			this.panelControl3.Controls.Add(this.labelControl3);
			this.panelControl3.Controls.Add(this.txtNotes);
			this.panelControl3.Controls.Add(this.labelControl2);
			this.panelControl3.Controls.Add(this.labelControl1);
			this.panelControl3.Controls.Add(this.txtID);
			this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelControl3.Location = new System.Drawing.Point(2, 2);
			this.panelControl3.Name = "panelControl3";
			this.panelControl3.Size = new System.Drawing.Size(626, 288);
			this.panelControl3.TabIndex = 1;
			// 
			// txtguid
			// 
			this.txtguid.Location = new System.Drawing.Point(199, 207);
			this.txtguid.Name = "txtguid";
			this.txtguid.Size = new System.Drawing.Size(196, 20);
			this.txtguid.TabIndex = 31;
			// 
			// dtpicer
			// 
			this.dtpicer.EditValue = null;
			this.dtpicer.Location = new System.Drawing.Point(199, 44);
			this.dtpicer.Name = "dtpicer";
			this.dtpicer.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpicer.Properties.Appearance.Options.UseFont = true;
			this.dtpicer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpicer.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dtpicer.Size = new System.Drawing.Size(196, 26);
			this.dtpicer.TabIndex = 28;
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(9, 115);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(81, 19);
			this.labelControl4.TabIndex = 27;
			this.labelControl4.Text = "Bill Type";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(9, 83);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(45, 19);
			this.labelControl3.TabIndex = 25;
			this.labelControl3.Text = "Notes";
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(199, 76);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNotes.Properties.Appearance.Options.UseFont = true;
			this.txtNotes.Size = new System.Drawing.Size(196, 26);
			this.txtNotes.TabIndex = 24;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(9, 51);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(81, 19);
			this.labelControl2.TabIndex = 23;
			this.labelControl2.Text = "Bill Date";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(9, 16);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(81, 19);
			this.labelControl1.TabIndex = 22;
			this.labelControl1.Text = "Bill Code";
			// 
			// txtID
			// 
			this.txtID.EditValue = 0;
			this.txtID.Location = new System.Drawing.Point(199, 6);
			this.txtID.Name = "txtID";
			this.txtID.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Properties.Appearance.Options.UseFont = true;
			this.txtID.Properties.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(196, 26);
			this.txtID.TabIndex = 20;
			// 
			// panelControl2
			// 
			this.panelControl2.Controls.Add(this.panelControl4);
			this.panelControl2.Controls.Add(this.panelControl5);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelControl2.Location = new System.Drawing.Point(626, 2);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(495, 288);
			this.panelControl2.TabIndex = 0;
			// 
			// panelControl4
			// 
			this.panelControl4.Controls.Add(this.FirstOne);
			this.panelControl4.Controls.Add(this.LastOne);
			this.panelControl4.Controls.Add(this.Next);
			this.panelControl4.Controls.Add(this.Prefices);
			this.panelControl4.Location = new System.Drawing.Point(3, 240);
			this.panelControl4.Name = "panelControl4";
			this.panelControl4.Size = new System.Drawing.Size(487, 43);
			this.panelControl4.TabIndex = 10;
			// 
			// FirstOne
			// 
			this.FirstOne.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FirstOne.Appearance.Options.UseFont = true;
			this.FirstOne.Appearance.Options.UseTextOptions = true;
			this.FirstOne.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.FirstOne.AppearanceHovered.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FirstOne.AppearanceHovered.Options.UseFont = true;
			this.FirstOne.AppearanceHovered.Options.UseTextOptions = true;
			this.FirstOne.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.FirstOne.AppearancePressed.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FirstOne.AppearancePressed.Options.UseFont = true;
			this.FirstOne.AppearancePressed.Options.UseTextOptions = true;
			this.FirstOne.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.FirstOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.FirstOne.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("FirstOne.ImageOptions.Image")));
			this.FirstOne.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
			this.FirstOne.Location = new System.Drawing.Point(5, 5);
			this.FirstOne.Name = "FirstOne";
			this.FirstOne.Size = new System.Drawing.Size(106, 33);
			this.FirstOne.TabIndex = 3;
			this.FirstOne.Click += new System.EventHandler(this.FirstOne_Click);
			// 
			// LastOne
			// 
			this.LastOne.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LastOne.Appearance.Options.UseFont = true;
			this.LastOne.Appearance.Options.UseTextOptions = true;
			this.LastOne.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.LastOne.AppearanceHovered.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LastOne.AppearanceHovered.Options.UseFont = true;
			this.LastOne.AppearanceHovered.Options.UseTextOptions = true;
			this.LastOne.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.LastOne.AppearancePressed.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LastOne.AppearancePressed.Options.UseFont = true;
			this.LastOne.AppearancePressed.Options.UseTextOptions = true;
			this.LastOne.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.LastOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.LastOne.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LastOne.ImageOptions.Image")));
			this.LastOne.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
			this.LastOne.Location = new System.Drawing.Point(376, 5);
			this.LastOne.Name = "LastOne";
			this.LastOne.Size = new System.Drawing.Size(106, 33);
			this.LastOne.TabIndex = 6;
			this.LastOne.Click += new System.EventHandler(this.LastOne_Click);
			// 
			// Next
			// 
			this.Next.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Next.Appearance.Options.UseFont = true;
			this.Next.Appearance.Options.UseTextOptions = true;
			this.Next.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Next.AppearanceHovered.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Next.AppearanceHovered.Options.UseFont = true;
			this.Next.AppearanceHovered.Options.UseTextOptions = true;
			this.Next.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Next.AppearancePressed.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Next.AppearancePressed.Options.UseFont = true;
			this.Next.AppearancePressed.Options.UseTextOptions = true;
			this.Next.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Next.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Next.ImageOptions.Image")));
			this.Next.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
			this.Next.Location = new System.Drawing.Point(117, 5);
			this.Next.Name = "Next";
			this.Next.Size = new System.Drawing.Size(106, 33);
			this.Next.TabIndex = 4;
			// 
			// Prefices
			// 
			this.Prefices.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Prefices.Appearance.Options.UseFont = true;
			this.Prefices.Appearance.Options.UseTextOptions = true;
			this.Prefices.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Prefices.AppearanceHovered.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Prefices.AppearanceHovered.Options.UseFont = true;
			this.Prefices.AppearanceHovered.Options.UseTextOptions = true;
			this.Prefices.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Prefices.AppearancePressed.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Prefices.AppearancePressed.Options.UseFont = true;
			this.Prefices.AppearancePressed.Options.UseTextOptions = true;
			this.Prefices.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Prefices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Prefices.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Prefices.ImageOptions.Image")));
			this.Prefices.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
			this.Prefices.Location = new System.Drawing.Point(264, 5);
			this.Prefices.Name = "Prefices";
			this.Prefices.Size = new System.Drawing.Size(106, 33);
			this.Prefices.TabIndex = 5;
			// 
			// panelControl5
			// 
			this.panelControl5.Controls.Add(this.Save);
			this.panelControl5.Controls.Add(this.Delete);
			this.panelControl5.Controls.Add(this.DeleteAll);
			this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl5.Location = new System.Drawing.Point(2, 2);
			this.panelControl5.Name = "panelControl5";
			this.panelControl5.Size = new System.Drawing.Size(491, 51);
			this.panelControl5.TabIndex = 9;
			// 
			// Save
			// 
			this.Save.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.Appearance.Options.UseFont = true;
			this.Save.Appearance.Options.UseTextOptions = true;
			this.Save.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Save.AppearanceHovered.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.AppearanceHovered.Options.UseFont = true;
			this.Save.AppearanceHovered.Options.UseTextOptions = true;
			this.Save.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Save.AppearancePressed.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.AppearancePressed.Options.UseFont = true;
			this.Save.AppearancePressed.Options.UseTextOptions = true;
			this.Save.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Save.ImageOptions.Image")));
			this.Save.Location = new System.Drawing.Point(8, 8);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(140, 33);
			this.Save.TabIndex = 0;
			this.Save.Text = "Save";
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// Delete
			// 
			this.Delete.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.Appearance.Options.UseFont = true;
			this.Delete.Appearance.Options.UseTextOptions = true;
			this.Delete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Delete.AppearanceHovered.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.AppearanceHovered.Options.UseFont = true;
			this.Delete.AppearanceHovered.Options.UseTextOptions = true;
			this.Delete.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Delete.AppearancePressed.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.AppearancePressed.Options.UseFont = true;
			this.Delete.AppearancePressed.Options.UseTextOptions = true;
			this.Delete.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.Image")));
			this.Delete.Location = new System.Drawing.Point(154, 9);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(140, 33);
			this.Delete.TabIndex = 1;
			this.Delete.Text = "Delete";
			// 
			// DeleteAll
			// 
			this.DeleteAll.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteAll.Appearance.Options.UseFont = true;
			this.DeleteAll.Appearance.Options.UseTextOptions = true;
			this.DeleteAll.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.DeleteAll.AppearanceHovered.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteAll.AppearanceHovered.Options.UseFont = true;
			this.DeleteAll.AppearanceHovered.Options.UseTextOptions = true;
			this.DeleteAll.AppearanceHovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.DeleteAll.AppearancePressed.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteAll.AppearancePressed.Options.UseFont = true;
			this.DeleteAll.AppearancePressed.Options.UseTextOptions = true;
			this.DeleteAll.AppearancePressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.DeleteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAll.ImageOptions.Image")));
			this.DeleteAll.Location = new System.Drawing.Point(300, 9);
			this.DeleteAll.Name = "DeleteAll";
			this.DeleteAll.Size = new System.Drawing.Size(140, 33);
			this.DeleteAll.TabIndex = 2;
			this.DeleteAll.Text = "Delete All";
			// 
			// gcBill
			// 
			this.gcBill.DataSource = this.tBBillBindingSource1;
			this.gcBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcBill.Location = new System.Drawing.Point(0, 292);
			this.gcBill.MainView = this.gvBill;
			this.gcBill.Name = "gcBill";
			this.gcBill.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.itemCheck});
			this.gcBill.Size = new System.Drawing.Size(1123, 335);
			this.gcBill.TabIndex = 1;
			this.gcBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill});
			// 
			// tBBillBindingSource1
			// 
			this.tBBillBindingSource1.DataMember = "TB_Bill";
			this.tBBillBindingSource1.DataSource = this.billsDataSetBindingSource;
			// 
			// billsDataSetBindingSource
			// 
			this.billsDataSetBindingSource.DataSource = this.billsDataSet;
			this.billsDataSetBindingSource.Position = 0;
			// 
			// billsDataSet
			// 
			this.billsDataSet.DataSetName = "BillsDataSet";
			this.billsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gvBill
			// 
			this.gvBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillGuid,
            this.colBillcode,
            this.colBillDate,
            this.colNotes,
            this.colBillType});
			this.gvBill.GridControl = this.gcBill;
			this.gvBill.Name = "gvBill";
			this.gvBill.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvBill_FocusedRowChanged);
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
			this.colBillType.ColumnEdit = this.itemCheck;
			this.colBillType.FieldName = "BillType";
			this.colBillType.Name = "colBillType";
			this.colBillType.Visible = true;
			this.colBillType.VisibleIndex = 4;
			// 
			// itemCheck
			// 
			this.itemCheck.AutoHeight = false;
			this.itemCheck.Name = "itemCheck";
			// 
			// tBBillBindingSource
			// 
			this.tBBillBindingSource.DataMember = "TB_Bill";
			this.tBBillBindingSource.DataSource = this.billsDataSetBindingSource;
			// 
			// tB_BillTableAdapter
			// 
			this.tB_BillTableAdapter.ClearBeforeFill = true;
			// 
			// fKBillitemsBillBindingSource
			// 
			this.fKBillitemsBillBindingSource.DataMember = "FK_Billitems_Bill";
			this.fKBillitemsBillBindingSource.DataSource = this.tBBillBindingSource;
			// 
			// tB_BillitemsTableAdapter
			// 
			this.tB_BillitemsTableAdapter.ClearBeforeFill = true;
			// 
			// cbtype
			// 
			this.cbtype.Location = new System.Drawing.Point(199, 112);
			this.cbtype.Name = "cbtype";
			this.cbtype.Properties.Appearance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbtype.Properties.Appearance.Options.UseFont = true;
			this.cbtype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbtype.Size = new System.Drawing.Size(192, 26);
			this.cbtype.TabIndex = 32;
			// 
			// Frm_Bill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1123, 627);
			this.Controls.Add(this.gcBill);
			this.Controls.Add(this.panelControl1);
			this.Name = "Frm_Bill";
			this.Text = "Bill";
			this.Load += new System.EventHandler(this.Frm_Bill_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
			this.panelControl3.ResumeLayout(false);
			this.panelControl3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtguid.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpicer.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpicer.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
			this.panelControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
			this.panelControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.billsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemCheck)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBBillBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKBillitemsBillBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbtype.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraGrid.GridControl gcBill;
		private DevExpress.XtraGrid.Views.Grid.GridView gvBill;
		private DevExpress.XtraEditors.PanelControl panelControl5;
		private DevExpress.XtraEditors.SimpleButton Save;
		private DevExpress.XtraEditors.SimpleButton Delete;
		private DevExpress.XtraEditors.SimpleButton DeleteAll;
		private DevExpress.XtraEditors.PanelControl panelControl4;
		private DevExpress.XtraEditors.SimpleButton FirstOne;
		private DevExpress.XtraEditors.SimpleButton LastOne;
		private DevExpress.XtraEditors.SimpleButton Next;
		private DevExpress.XtraEditors.SimpleButton Prefices;
		private DevExpress.XtraEditors.PanelControl panelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtNotes;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtID;
		private DevExpress.XtraEditors.DateEdit dtpicer;
		private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
		private System.Windows.Forms.BindingSource billsDataSetBindingSource;
		private BillsDataSet billsDataSet;
		private System.Windows.Forms.BindingSource tBBillBindingSource;
		private BillsDataSetTableAdapters.TB_BillTableAdapter tB_BillTableAdapter;
		private DevExpress.XtraGrid.Columns.GridColumn colBillGuid;
		private DevExpress.XtraGrid.Columns.GridColumn colBillcode;
		private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
		private DevExpress.XtraGrid.Columns.GridColumn colNotes;
		private DevExpress.XtraGrid.Columns.GridColumn colBillType;
		private DevExpress.XtraEditors.TextEdit txtguid;
		private System.Windows.Forms.BindingSource fKBillitemsBillBindingSource;
		private BillsDataSetTableAdapters.TB_BillitemsTableAdapter tB_BillitemsTableAdapter;
		private System.Windows.Forms.BindingSource tBBillBindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit itemCheck;
		private DevExpress.XtraEditors.LookUpEdit cbtype;
	}
}