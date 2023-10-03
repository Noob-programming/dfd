using Itemds.Logic.Services;
using Itemds.Model;
using Itemds.View.Interfaces;
using System;

namespace Itemds.Logic.Presnter
{
    public class BillPresenter
    {
        private IBill _bill;
        BillModel _billModel = new BillModel();

        public BillPresenter(IBill view)
        {
            this._bill = view;
        }
        void ConnectBetweenModelInterface()
        {
            _billModel.BillGuid = _bill.BillGuid;

            _billModel.BillCode = _bill.BillCode;
            _billModel.Notes = _bill.Notes;
            _billModel.BillType = _bill.BillType;
            _billModel.BillDate = _bill.BillDate;
            _billModel.Dgv = _bill.Dgv;
        }

        public bool Save()
        {
            ConnectBetweenModelInterface();
            bool checks = BillService.BillSave(_billModel);
            ClearFiled();
            AutoNumber();
            return checks;
        }

        public void GetAll()
        {
            //ConnectBetweenModelInterface();
            _bill.Dgv = BillService.GetBills();
        }

        private void AutoNumber()
        {
            _bill.BillCode = BillService.GetBills().Rows.Count + 1;
        }

        private void ClearFiled()
        {
            ConnectBetweenModelInterface();

            _bill.BillGuid = Guid.Empty;
            _bill.BillCode = 0;
            _bill.Notes = string.Empty;
            _bill.BillType = false;
            _bill.BillDate = null;
        }

        public void getFirstRow()
        {
            object dt = new object();
            dt = BillService.GetFirstBill();
            _bill.BillGuid = Guid.Parse(dt[]);
            _bill.BillCode = int.Parse(dt["BillCode"].ToString());
            _bill.BillDate = (DateTime)dt.Rows[0][2];
            _bill.Notes = dt.Rows[0][3].ToString();
            _bill.BillType = Convert.ToBoolean(dt.Rows[0][4]);
        }


    }
}