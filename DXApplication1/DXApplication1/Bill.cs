using DXApplication1.DBHost;
using System;
using System.Windows.Forms;

namespace DXApplication1
{
	public partial class Bill : DevExpress.XtraEditors.XtraForm
	{
		public Bill()
		{
			InitializeComponent();
		}

		private void Bill_Load(object sender, EventArgs e)
		{
			BindingSource source = new BindingSource();

			source.DataSource = DBHelper.GetData("tb_bill_get", () => Class1.GetBills());

			gridControl1.DataSource = source;
		}
	}
}