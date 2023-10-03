namespace DXApplication1
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbgender = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repgender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Deleter = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmployeeID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.EmployeeAge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.EmployeeName = new DevExpress.XtraEditors.TextEdit();
            this.EmpUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.EmpAdd = new DevExpress.XtraEditors.SimpleButton();
            this.EmpDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deleter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.employeesBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 197);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Deleter,
            this.cmbgender});
            this.gridControl1.Size = new System.Drawing.Size(1105, 355);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataSource = typeof(DXApplication1.Model.Employees);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmGuid,
            this.colEmployeeId,
            this.colName,
            this.colAge,
            this.repgender});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1183, 377, 264, 272);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Age", null, "{0:N}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawGroupRow);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colEmGuid
            // 
            this.colEmGuid.ColumnEdit = this.cmbgender;
            this.colEmGuid.FieldName = "EmGuid";
            this.colEmGuid.Name = "colEmGuid";
            this.colEmGuid.Visible = true;
            this.colEmGuid.VisibleIndex = 1;
            this.colEmGuid.Width = 197;
            // 
            // cmbgender
            // 
            this.cmbgender.AutoHeight = false;
            serializableAppearanceObject2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            serializableAppearanceObject2.Options.UseBorderColor = true;
            this.cmbgender.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmbgender.Name = "cmbgender";
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.FieldName = "EmployeeId";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.OptionsFilter.AllowFilter = false;
            this.colEmployeeId.Visible = true;
            this.colEmployeeId.VisibleIndex = 2;
            this.colEmployeeId.Width = 82;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            this.colName.Width = 241;
            // 
            // colAge
            // 
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 4;
            this.colAge.Width = 241;
            // 
            // repgender
            // 
            this.repgender.Caption = "Gender";
            this.repgender.ColumnEdit = this.cmbgender;
            this.repgender.FieldName = "Gender";
            this.repgender.Name = "repgender";
            this.repgender.Visible = true;
            this.repgender.VisibleIndex = 5;
            // 
            // Deleter
            // 
            this.Deleter.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.Deleter.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.Deleter.Name = "Deleter";
            this.Deleter.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.Deleter.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Deleter_ButtonClick);
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(453, 212);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.gridLookUpEdit1.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(110, 36);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(232, 20);
            this.EmployeeID.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "EmployeeID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "EmployeeAge";
            // 
            // EmployeeAge
            // 
            this.EmployeeAge.Location = new System.Drawing.Point(110, 88);
            this.EmployeeAge.Name = "EmployeeAge";
            this.EmployeeAge.Size = new System.Drawing.Size(232, 20);
            this.EmployeeAge.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Employee Name";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(110, 62);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(232, 20);
            this.EmployeeName.TabIndex = 6;
            // 
            // EmpUpdate
            // 
            this.EmpUpdate.Location = new System.Drawing.Point(559, 39);
            this.EmpUpdate.Name = "EmpUpdate";
            this.EmpUpdate.Size = new System.Drawing.Size(96, 35);
            this.EmpUpdate.TabIndex = 8;
            this.EmpUpdate.Text = "EmpUpdate";
            this.EmpUpdate.Click += new System.EventHandler(this.EmpUpdate_Click);
            // 
            // EmpAdd
            // 
            this.EmpAdd.Location = new System.Drawing.Point(457, 39);
            this.EmpAdd.Name = "EmpAdd";
            this.EmpAdd.Size = new System.Drawing.Size(96, 35);
            this.EmpAdd.TabIndex = 9;
            this.EmpAdd.Text = "Add";
            this.EmpAdd.Click += new System.EventHandler(this.EmpAdd_Click);
            // 
            // EmpDelete
            // 
            this.EmpDelete.Location = new System.Drawing.Point(661, 39);
            this.EmpDelete.Name = "EmpDelete";
            this.EmpDelete.Size = new System.Drawing.Size(96, 35);
            this.EmpDelete.TabIndex = 10;
            this.EmpDelete.Text = "Delete";
            this.EmpDelete.Click += new System.EventHandler(this.EmpDelete_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(559, 80);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(96, 35);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "counter";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 552);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.EmpDelete);
            this.Controls.Add(this.EmpAdd);
            this.Controls.Add(this.EmpUpdate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.EmployeeAge);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbgender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deleter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmGuid;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraEditors.TextEdit EmployeeID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit EmployeeAge;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit EmployeeName;
        private DevExpress.XtraEditors.SimpleButton EmpUpdate;
        private DevExpress.XtraEditors.SimpleButton EmpAdd;
        private DevExpress.XtraEditors.SimpleButton EmpDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Deleter;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbgender;
        private DevExpress.XtraGrid.Columns.GridColumn repgender;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
    }
}

