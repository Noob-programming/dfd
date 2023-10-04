using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itemds.View.Interfaces;

namespace Itemds.Logic.DataTableChage
{
	internal static class BillTable
	{
		public static List<T> ToBillList<T>
			(this DataTable dt,Func<DataRow , T> selector)
			where T : class
		{

			List<T> daList = new List<T>();

			foreach (DataRow v in dt.Rows)
			{
				T item = selector(v);
				daList.Add(item);
			}


			return daList;
		}
	}
}
