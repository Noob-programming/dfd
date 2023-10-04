using DXApplication1.DBHost;
using System.Data;

namespace DXApplication1
{
	public static class Class1
	{
		public static DataTable GetBills()
		{
			return DBHelper.GetData("TB_Bill_Get", () => { });
		}
	}
}