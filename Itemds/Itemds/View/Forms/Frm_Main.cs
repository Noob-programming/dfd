namespace Itemds.View.Forms
{
	public partial class Frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public Frm_Main()
		{
			InitializeComponent();
		}

		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var form = new Frm_Items();
			form.ShowDialog();
		}

		private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Frm_Bill bill = new Frm_Bill();
			bill.ShowDialog();

		}
	}
}