using System;
using System.Windows.Forms;
using testDG.Logic.Presenter;
using testDG.View.Interfaces;

namespace testDG.View.Forms
{
	public partial class Frm_Employee : DevExpress.XtraEditors.XtraForm, IEmployee
	{
		EmployeePresenter _employee;

		public Frm_Employee()
		{
			InitializeComponent();
			_employee = new EmployeePresenter(this);

		}

		/// <inheritdoc />
		public Guid EmployeeGuid { get; set; }

		/// <inheritdoc />
		public int EmployeeId
		{
			get => Convert.ToInt32(EmployeeID.Text);
			set => EmployeeID.Text = value.ToString();

		}

		/// <inheritdoc />
		public string EmployeeFirstName
		{
			get => EmployeeFirstname.Text;
			set => EmployeeFirstname.Text = value;
		}

		/// <inheritdoc />
		public string EmployeeLastName
		{
			get => EmployeeLastname.Text;
			set => EmployeeLastname.Text = value;
		}

		/// <inheritdoc />
		public DateTime Date
		{
			get => Employeedate.DateTime;
			set => Employeedate.DateTime = value;
		}

		/// <inheritdoc />
		public string PhoneNumber
		{
			get => EmployeePhone.Text;
			set => EmployeePhone.Text = value;
		}

		private void SaveData_Click(object sender, EventArgs e)
		{
			try
			{
				bool prosece = _employee.EmployeeSave();
				MessageBox.Show(prosece ? "save done" : "error");
			}

			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}

		}
	}
}