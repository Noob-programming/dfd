
using testDG.Logic.Services;
using testDG.Models;
using testDG.View.Interfaces;

namespace testDG.Logic.Presenter
{
	internal class EmployeePresenter
	{
		IEmployee Iemployee;
		EmployeeModel _employeeModel = new EmployeeModel();


		public EmployeePresenter(IEmployee view)
		{
			Iemployee = view;
		}

		private void ConnectBetweenModelInterface()
		{
			_employeeModel.EmployeeGuid = Iemployee.EmployeeGuid;
			_employeeModel.EmployeeId = Iemployee.EmployeeId;
			_employeeModel.EmployeeFirstName = Iemployee.EmployeeFirstName;
			_employeeModel.EmployeeLastName = Iemployee.EmployeeLastName;
			_employeeModel.Date = Iemployee.Date;
			_employeeModel.PhoneNumber = Iemployee.PhoneNumber;
		}

		public bool EmployeeSave()
		{
			ConnectBetweenModelInterface();
			return EmployeeService.EmployeeSave(_employeeModel);
		}

	}
}
