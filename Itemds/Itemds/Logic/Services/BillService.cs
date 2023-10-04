using Itemds.Model;
using System.Data;
using System.Data.SqlClient;

namespace Itemds.Logic.Services
{
	public class BillService
	{
		public static bool BillSave(BillModel model)
		{
			return DbHelper.ExecuteData("TB_Bill_Save",
				() => BillParameterSave(model, DbHelper.Command));

		}
		/*
		   @guid as uniqueidentifier = 0x0 output,
		   @billcode as int,
		   @notes as ntext,
		   @Billtype as tinyint
		   Unchecked
		*/
		private static void BillParameterSave(BillModel model, SqlCommand command)
		{
			command.Parameters.Add("@guid",
					SqlDbType.UniqueIdentifier).Value
				= model.BillGuid;
			command.Parameters.Add("@billcode",
					SqlDbType.Int).Value
				= model.BillCode;
			command.Parameters.Add("@notes",
					SqlDbType.NText).Value
				= model.Notes;
			command.Parameters.Add("@Billtype",
					SqlDbType.Bit).Value
				= model.BillType;
			command.Parameters.Add("@date",
					SqlDbType.DateTime).Value
				= model.BillDate;
		}


		static void setparameterbill(string f, SqlCommand command)
		{
			command.Parameters.Add("@chicker",
					SqlDbType.NVarChar).Value = f;
		}

		public static DataTable GetBills()
		{
			return DbHelper.GetData("TB_Bill_Get", () => { });
		}

		private static void ParameterBetweenFirstLast(string status, SqlCommand command)
		{

			command.Parameters.Add("@status",
					SqlDbType.VarChar).Value
				= status;

		}

		public static DataTable GetBillByIndex(string status)
		{
			return DbHelper.GetData("TB_Bill_Get_FirstLastBetween",
				() => ParameterBetweenFirstLast(status, DbHelper.Command));
		}

		public static DataTable GetBillType()
		{
			return DbHelper.GetData("TB_Bill_Get_BillType", (() => { }));
		}
	}
}