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

namespace StockMarcte
{
	public partial class Item : DevExpress.XtraEditors.XtraForm
	{
		public Item()
		{
			InitializeComponent();
		}

		private void Item_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'billsDataSet1.TB_Item' table. You can move, or remove it, as needed.
            this.tB_ItemTableAdapter.Fill(this.billsDataSet1.TB_Item);

        }
    }
}