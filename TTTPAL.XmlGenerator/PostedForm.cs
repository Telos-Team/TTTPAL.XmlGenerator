using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TTTPAL.XmlGenerator
{
    public partial class PostedForm : Form
    {
        public string Type = "InvoiceReceipt";
        public string Id = "";
        public int Status = 0;
        public string VoucherSeries = "";
        public string VoucherNo = "";
        public PostedForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Id = tbId.Text;
            Status = lbStatus.SelectedIndex;
            VoucherSeries = tbVoucherSeries.Text;
            VoucherNo = tbVoucherNo.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Id = "";
            Status = -1;
            VoucherSeries = "";
            VoucherNo = "";
        }
    }
}
