using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itemds
{
	public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
	{
		public XtraForm1()
		{
			InitializeComponent();
		}

		private void tB_BillBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.tB_BillBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.billsDataSet);

        }

		private void XtraForm1_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'billsDataSet.TB_Bill' table. You can move, or remove it, as needed.
            this.tB_BillTableAdapter.Fill(this.billsDataSet.TB_Bill);

        }
    }
}