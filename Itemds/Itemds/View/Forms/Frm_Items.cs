using Itemds.Logic.Presnter;
using Itemds.View.Interfaces;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Itemds.View.Forms
{
	public partial class Frm_Items : DevExpress.XtraEditors.XtraForm, IItems
	{
		ItemPresenter presenter;
		public Frm_Items()
		{
			InitializeComponent();
			presenter = new ItemPresenter(this);
		}

		private void Frm_Items_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'billsDataSet.TB_Item' table. You can move, or remove it, as needed.
			this.tB_ItemTableAdapter.Fill(this.billsDataSet.TB_Item);
		}

		private void simpleButton6_Click(object sender, EventArgs e)
		{

		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				bool prosece = presenter.Save();
				MessageBox.Show(prosece ? "save done" : "error");
			}

			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}
		}

		public Guid ItemGuid
		{
			get;
			set;
		}

		public int ItemCode
		{
			get => Convert.ToInt32(txtID);
			set => txtID.Text = value.ToString();
		}


		public string ItemName
		{
			get => txtName.Text;
			set => txtName.Text = value;
		}

		public decimal ItemPrice
		{
			get => Convert.ToDecimal(txtPrice.Text);
			set => txtPrice.Text = value.ToString(CultureInfo.InvariantCulture);

		}

		public decimal ItemPriceSingle
		{
			get => Convert.ToDecimal(txtPriceSingle.Text);
			set => txtPriceSingle.Text = value.ToString(CultureInfo.InvariantCulture);
		}

		public decimal ItemPriceMany
		{
			get => Convert.ToDecimal(txtPriceMany.Text);
			set => txtPriceMany.Text = value.ToString(CultureInfo.InvariantCulture);
		}

		public Guid ParentGuid { get; set; }

		public bool IsGroup
		{
			get => cbGroup.Checked;
			set => cbGroup.Checked = Convert.ToBoolean(value);
		}
	}
}