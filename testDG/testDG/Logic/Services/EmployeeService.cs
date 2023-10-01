using System.Data;
using System.Data.SqlClient;
using testDG.Models;

namespace testDG.Logic.Services
{
	internal static class EmployeeService
	{
		/*
		   @EmployeeGuid uniqueidentifier = null,
		   @EmployeeID int= null,
		   @EmployeeFirstName nvarchar(250)= null,
		   @EmployeeLastName nvarchar(250)= null,
		   @Date date= null,
		   @Phone nvarchar(20)= null
		 */
		private static void EmployeeParameterSave(EmployeeModel employeeModel, SqlCommand command)
		{
			command.Parameters.Add("@EmployeeGuid", SqlDbType.UniqueIdentifier).Value
				= employeeModel.EmployeeGuid;
			command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value
				= employeeModel.EmployeeId;
			command.Parameters.Add("@EmployeeFirstName", SqlDbType.NVarChar).Value
				= employeeModel.EmployeeFirstName;
			command.Parameters.Add("@EmployeeLastName", SqlDbType.NVarChar).Value
				= employeeModel.EmployeeLastName;
			command.Parameters.Add("@Date", SqlDbType.Date).Value
				= employeeModel.Date;
			command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value
				= employeeModel.PhoneNumber;
		}

		public static bool EmployeeSave(EmployeeModel employeeModel)
		{
			return DbHelper.ExecuteData("TB_Employee_Save",
				() => EmployeeParameterSave(employeeModel, DbHelper.Command));
		}

		private static void EmployeeParameterDelete(EmployeeModel employeeModel, SqlCommand command)
		{
			command.Parameters.Add("@EmployeeGuid", SqlDbType.UniqueIdentifier).Value
				= employeeModel.EmployeeGuid;

		}

		public static bool EmployeeDelete(EmployeeModel employeeModel)
		{
			return DbHelper.ExecuteData("TB_Employee_Delete",
				() => EmployeeParameterSave(employeeModel, DbHelper.Command));
		}
	}
}