using System;

namespace testDG.View.Forms
{
	public partial class Frm_Main : DevExpress.XtraEditors.XtraForm
	{
		public Frm_Main()
		{
			InitializeComponent();
		}
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			Frm_Employee formEmployee = new Frm_Employee();
			formEmployee.ShowDialog();

		}
	}
}