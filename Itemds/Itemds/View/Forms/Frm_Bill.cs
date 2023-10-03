using Itemds.Logic.Presnter;
using Itemds.View.Interfaces;
using System;
using System.Windows.Forms;

namespace Itemds.View.Forms
{
    public partial class Frm_Bill : DevExpress.XtraEditors.XtraForm, IBill
    {
        readonly BillPresenter _presenter;
        public Frm_Bill()
        {
            InitializeComponent();
            _presenter = new BillPresenter(this);

        }

        private void Save_Click(object sender, System.EventArgs e)
        {
            try
            {
                bool save = _presenter.Save();
                MessageBox.Show(!save ? @"error" : @"save done");
            }

            catch (Exception exception)
            {
                MessageBox.Show($@"{exception}");
            }
        }
        /// <inheritdoc />
        public Guid BillGuid
        {
            get
            {
                if (!string.IsNullOrEmpty(txtguid.Text))
                    return Guid.Parse(txtguid.Text);
                return Guid.NewGuid();
            }
            set => txtguid.Text = value.ToString();
        }

        /// <inheritdoc />
        public int BillCode { get => Convert.ToInt32(txtID.Text); set => txtID.Text = value.ToString(); }

        /// <inheritdoc />
        public object BillType
        {
            get => cbtype.SelectedItem;
            set => cbtype.EditValue = value;

        }

        /// <inheritdoc />
        public DateTime? BillDate
        {
            get => dtpicer.DateTime;
            set
            {
                if (value != null) dtpicer.DateTime = (DateTime)value;
                else dtpicer.DateTime = DateTime.MinValue;
            }
        }

        /// <inheritdoc />
        public string Notes { get => txtNotes.Text; set => txtNotes.Text = value.ToString(); }

        /// <inheritdoc />
        public object Dgv { get => gcBill.DataSource; set => gcBill.DataSource = value; }

        private void Frm_Bill_Load(object sender, EventArgs e)
        {
            _presenter.GetAll();
        }

        private void gvBill_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtguid.Text = gvBill.GetFocusedRowCellValue("BillGuid").ToString();
            txtID.Text = gvBill.GetFocusedRowCellValue("Billcode").ToString();
            txtNotes.Text = gvBill.GetFocusedRowCellValue("Notes").ToString();
            dtpicer.DateTime = (DateTime)gvBill.GetFocusedRowCellValue("BillDate");
            cbtype.EditValue = gvBill.GetFocusedRowCellValue("BillType") as string;

        }

        private void FirstOne_Click(object sender, EventArgs e)
        {
            _presenter.getFirstRow();
        }
    }
}