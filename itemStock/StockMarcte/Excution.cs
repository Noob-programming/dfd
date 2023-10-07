using System.Data;
using System.Data.SqlClient;

namespace StockMarcte
{
	public static class Excution
	{
		public static void parmterStock(Stock stock, SqlCommand command)
		{
			command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value = stock.guid;

			command.Parameters.Add("@status", SqlDbType.NVarChar).Value = stock.status;
			command.Parameters.Add("@Quin", SqlDbType.Int).Value = stock.quintitiy;
		}

		public static void parmeterdelete(Stock stock, SqlCommand cmd)
		{
			cmd.Parameters.Add("@guid", SqlDbType.UniqueIdentifier).Value = stock.guid;
		}

		/*
		 *@guid as uniqueidentifier = 0x0 output,
		   @billcode as int,
		   @notes as ntext,
		   @date  as datetime = null,
		   @Billtype as bit
		 */
		public static void parmterBill(Bills bill, SqlCommand command)
		{
			command.Parameters.Add("@guid", SqlDbType.UniqueIdentifier)
				.Value = bill.Billguid;

			command.Parameters.Add("@billcode", SqlDbType.Int).Value =
				bill.billcode;

			command.Parameters.Add("@notes", SqlDbType.Int).Value =
				bill.notes;

			command.Parameters.Add("@date", SqlDbType.DateTime).Value =
				bill.DateTime;

			command.Parameters.Add("@Billtype", SqlDbType.Bit).Value =
				bill.billtye;
		}

		public static void ParameterDelete(Bills bill, SqlCommand cmd)
		{
			cmd.Parameters.Add("@guid", SqlDbType.UniqueIdentifier)
				.Value = bill.Billguid;
		}
	}
}