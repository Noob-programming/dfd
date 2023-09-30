using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DXApplication1.Model;
using DXApplication1.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridControlLoad();
        }

        private readonly List<Employees> _load = Repostory.Load();

        private void GridControlLoad()
        {
            try
            {

                var s = new BindingSource();
                s.DataSource = _load;
                gridControl1.DataSource = s;
                string[] gender = { "Male", "Female" };
                foreach (var v in gender)
                {
                    cmbgender.Items.Add(v);
                }
                var item = new GridGroupSummaryItem
                {
                    DisplayFormat = @"Count = {0:N0}",
                    FieldName = "Age",
                    ShowInGroupColumnFooter = gridView1.Columns["Show In GroupRow"],
                    SummaryType = DevExpress.Data.SummaryItemType.Count
                };
                gridView1.GroupSummary.Add(item);

            }
            catch (Exception e)
            {
                MessageBox.Show($@"{e}");
            }

        }



        private void EmpAdd_Click(object sender, EventArgs e)
        {
            try
            {

                gridView1.AddNewRow();
                //id = Convert.ToInt32(EmployeeID.Text);
                //name = EmployeeName.Text;
                //age = Convert.ToInt32(EmployeeAge.Text);
                //load.Add(new Employees { EmGuid = Guid.NewGuid(), Age = age, Name = name, EmployeeId = id });
                //GridControlLoad();
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, "EmGuid", Guid.NewGuid());

                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, "Id", EmployeeID.Text);
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, "Name", EmployeeName.Text);
                gridView1.SetRowCellValue(GridControl.NewItemRowHandle, "Age", EmployeeAge.Text);

                MessageBox.Show(@"done");

            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show($@"{exception}");
            }
        }

        private void EmpUpdate_Click(object sender, EventArgs e)
        {
            /*
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "EmployeeId", EmployeeID.Text);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Name", EmployeeName.Text);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Age", EmployeeAge.Text);*/
            List<int> row = gridView1.GetSelectedRows().Where(c => c > 0).ToList();

            row.ForEach(a =>
            {
                // gridView1.SetRowCellValue(a, "EmGuid", Guid.NewGuid());

                gridView1.SetRowCellValue(a, "Id", EmployeeID.Text);
                gridView1.SetRowCellValue(a, "Name", EmployeeName.Text);
                gridView1.SetRowCellValue(a, "Age", EmployeeAge.Text);

            });

            MessageBox.Show(@"done");
        }


        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                // string guid = gridView1.GetFocusedRowCellValue("EmpGuid").ToString();
                //   EmployeeID.Text = gridView1.GetFocusedRowCellValue("EmployeeId").ToString();
                //    EmployeeName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
                //   EmployeeAge.Text = gridView1.GetFocusedRowCellValue("Age").ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }

        private void EmpDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void Deleter_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //MessageBox.Show("Test");
            if (XtraMessageBox.Show("delete", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // gridView1.SetRowCellValue(a, "EmGuid", Guid.NewGuid())
                gridView1.DeleteSelectedRows();
            }
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName != "Age") return;
            if (view != null)
            {
                int age = int.Parse(view.GetRowCellValue(e.RowHandle, "Age").ToString());
                e.Appearance.ForeColor = Color.White;
                //  e.Appearance.Font = System.Drawing.Font.FromLogFont(this);
                if (age > 20 && age < 40)
                {
                    e.Appearance.BackColor = Color.Blue;
                }
                else if (age > 40 && age < 60)
                {
                    e.Appearance.BackColor = Color.DarkGreen;
                }
                else
                {
                    e.Appearance.BackColor = Color.Red;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int rowCount = gridView1.DataRowCount;
            int column = gridView1.Columns.Count;

            XtraMessageBox.Show($@"{rowCount} - {column}");


        }

        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            if (sender is GridView gv)
            {
                var rowLevel = gv.GetRowLevel(e.RowHandle);
                if (rowLevel == 0)
                {
                    e.Appearance.BackColor = Color.Aqua;
                    e.Appearance.ForeColor = Color.Bisque;
                }
                else if (rowLevel > 0 && rowLevel < 3)
                {
                    e.Appearance.BackColor = Color.Magenta;
                    e.Appearance.ForeColor = Color.DarkCyan;
                }
                else
                {
                    e.Appearance.BackColor = Color.GhostWhite;
                    e.Appearance.ForeColor = Color.Gray;


                }
            }
        }
    }
}
