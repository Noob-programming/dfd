using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Windows.Forms;

namespace StockMarcte
{
	public partial class BillItem : XtraForm
	{
		private readonly Bills bills = new Bills();


		private readonly StockStutsDataContext dataContext = new StockStutsDataContext();

		public BillItem()
		{
			InitializeComponent();
		}

		private void BillItem_Load(object sender, EventArgs e)
		{
			tB_BillTableAdapter.Fill(billsDataSet1.TB_Bill);
			LookUPType.Properties.DataSource = dataContext.TB_Bills;
			LookUPType.Properties.DisplayMember = "BillType";
			LookUPType.Properties.ValueMember = "BillType";
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			bills.Billguid = !string.IsNullOrEmpty(txtguid.Text) ? Guid.Parse(txtguid.Text) : Guid.Empty;
			bills.DateTime = DateBill.DateTime;
			bills.billcode = Convert.ToInt32(Billcode.Text);
			bills.notes = txtNotes.Text;
			bills.billtye = Convert.ToBoolean(LookUPType.EditValue.ToString());

			var re = DbHelper.ExcuteData("TB_Bill_Save",
				() => Excution.parmterBill(bills, DbHelper.cmd));

			if (re) getdata();
			MessageBox.Show(re ? "save" : "error");
		}

		private void getdata()
		{
			gridControl1.DataSource = DbHelper.GetData("TB_Bill_GET");
		}

		private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
		{
			Billcode.Text = gridView1.GetFocusedRowCellValue("Billcode").ToString();
			DateBill.Text = gridView1.GetFocusedRowCellValue("BillDate").ToString();
			txtNotes.Text = gridView1.GetFocusedRowCellValue("Notes").ToString();

			LookUPType.EditValue = gridView1.GetFocusedRowCellValue("BillType").ToString() ?? "false";
			txtguid.Text = gridView1.GetFocusedRowCellValue("BillGuid").ToString();
		}

		private void Deletes_Click(object sender, EventArgs e)
		{
			var re = DbHelper.ExcuteData
				("TB_Bill_Delete", () => Excution.ParameterDelete(bills, DbHelper.cmd));

			if (re) getdata();
			MessageBox.Show(re ? "save" : "error");
		}
	}
}