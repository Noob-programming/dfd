using System;

namespace Itemds.Model
{
	public class BillModel
	{
		public Guid BillGuid { get; set; }
		public int BillCode { get; set; }
		public object BillType { get; set; }
		public DateTime? BillDate { get; set; }
		public string Notes { get; set; }
		public object Dgv { get; set; }
		object CbxBill { get; set; }
		string BillDisplayMember { get; set; }
		bool BillValueMember { get; set; }

	}
}