using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Windows.Forms;

namespace StockMarcte
{
	public partial class Form1 : XtraForm
	{
		private readonly StockStutsDataContext dataContext = new StockStutsDataContext();

		private readonly Stock stock = new Stock();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			getdata();

			lookupstatus.Properties.DataSource =
				dataContext.View_Stock_Items
				//.Select(x => x.status).Distinct()
				;
			lookupstatus.Properties.DisplayMember = "status";
			lookupstatus.Properties.ValueMember = "status";

			//lookUpEdit1.Properties.PopulateColumns();
			//lookUpEdit1.Properties.Columns[0].Visible = false;
			//lookUpEdit1.Properties.Columns[1].Visible = false;
		}

		private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
		{
			txtGuid.Text = gridView1.GetFocusedRowCellValue("itemGuid").ToString();
			txtQuintity.Text = gridView1.GetFocusedRowCellValue("Quintity").ToString();
			lookupstatus.Text = gridView1.GetFocusedRowCellValue("status").ToString();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				stock.guid = string.IsNullOrEmpty(txtGuid.Text) ? Guid.NewGuid() : Guid.Parse(txtGuid.Text);
				stock.quintitiy = Convert.ToInt32(txtQuintity.Text);
				stock.status = lookupstatus.Text;
				var re = DbHelper.ExcuteData("TB_StockItem_Save", () => Excution.parmterStock(stock, DbHelper.cmd));
				if (re) getdata();
				MessageBox.Show(re ? "save" : "error");
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void getdata()
		{
			gridControl1.DataSource = DbHelper.GetData("TB_Stock_Get");
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			var re = DbHelper.DeleteData("TB_Stock_Delete", () => Excution.parmeterdelete(stock, DbHelper.cmd));
			if (re) getdata();
			MessageBox.Show(re ? "save" : "error");
		}
	}
}