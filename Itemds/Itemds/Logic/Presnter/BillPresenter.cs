using Itemds.Logic.DataTableChage;
using Itemds.Logic.Services;
using Itemds.Model;
using Itemds.View.Interfaces;
using System;
using System.Linq;

namespace Itemds.Logic.Presnter
{
	public class BillPresenter
	{
		private IBill iBill;
		BillModel billModel = new BillModel();

		public BillPresenter(IBill view)
		{
			this.iBill = view;
		}
		void ConnectBetweenModelInterface()
		{
			billModel.BillGuid = iBill.BillGuid;

			billModel.BillCode = iBill.BillCode;
			billModel.Notes = iBill.Notes;
			billModel.BillType = iBill.BillType;
			billModel.BillDate = iBill.BillDate;
			billModel.Dgv = iBill.Dgv;
		}

		public bool Save()
		{
			ConnectBetweenModelInterface();
			bool checks = BillService.BillSave(billModel);
			ClearFiled();
			//	AutoNumber();
			return checks;
		}

		public void GetAll()
		{
			//ConnectBetweenModelInterface();
			iBill.Dgv = BillService.GetBills();
		}

		private void AutoNumber()
		{
			//List<object> a = BillService.GetBills() as List<object>;
			//iBill.BillCode = (int)(a?.Count + 1);
		}

		private void ClearFiled()
		{
			ConnectBetweenModelInterface();

			iBill.BillGuid = Guid.Empty;
			iBill.BillCode = 0;
			iBill.Notes = string.Empty;
			iBill.BillType = false;
			iBill.BillDate = null;
		}

		public void getFirstRow()
		{
			var r = BillService.GetBillByIndex("ASC")
					.ToBillList(x => new BillModel
					{
						BillGuid = Guid.Parse(x["BillGuid"].ToString()),
						BillCode = Convert.ToInt32(x["Billcode"]),
						Notes = x["Notes"].ToString(),
						BillDate = (DateTime?)x["BillDate"],
						BillType = x["BillType"]
					}).Select(x => x).
						FirstOrDefault();


			if (r == null) return;
			iBill.BillCode = r.BillCode;
			iBill.BillDate = r.BillDate;
			iBill.BillType = r.BillType;
			iBill.BillGuid = r.BillGuid;
			iBill.Notes = r.Notes;
		}


		public void getLastRow()
		{
			var r = BillService.GetBillByIndex("DESC")
				.ToBillList(x => new BillModel
				{
					BillGuid = Guid.Parse(x["BillGuid"].ToString()),
					BillCode = Convert.ToInt32(x["Billcode"]),
					Notes = x["Notes"].ToString(),
					BillDate = (DateTime?)x["BillDate"],
					BillType = x["BillType"]
				}).Select(x => x)
					.FirstOrDefault();

			if (r == null) return;
			iBill.BillCode = r.BillCode;
			iBill.BillDate = r.BillDate;
			iBill.BillType = r.BillType;
			iBill.BillGuid = r.BillGuid;
			iBill.Notes = r.Notes;

		}

		public void FillBillType()
		{
			iBill.CbxBill = BillService.GetBillType();

		}
	}
}