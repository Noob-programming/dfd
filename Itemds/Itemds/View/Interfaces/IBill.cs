using System;

namespace Itemds.View.Interfaces
{
	/**
	 *BillGuid	uniqueidentifier	Unchecked
	    Billcode	int	Unchecked
	    BillDate	datetime	Checked
	    Notes	ntext	Checked
	    BillType	tinyint	Unchecked
	    Unchecked
	 */
	public interface IBill
	{
		Guid BillGuid { get; set; }
		int BillCode { get; set; }
		object BillType { get; set; }
		DateTime? BillDate { get; set; }
		string Notes { get; set; }
		object Dgv { get; set; }
		object CbxBill { get; set; }
		string BillDisplayMember { get; set; }
		bool BillValueMember { get; set; }
	}
}