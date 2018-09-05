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
    public partial class RejectedForm : Form
    {
        public string Type = "InvoiceReceipt";
        public string Id = "";
        public int Status = 4;
        public string Reason = "";
        public RejectedForm()
        {
            InitializeComponent();
            lbStatus.SelectedIndex = 4;
            tbId.Select();
            //comboBox1.DropDownStyle = ComboBoxStyle
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Id = tbId.Text;
            Status = lbStatus.SelectedIndex;
            Reason = tbReason.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Id = "";
            Status = -1;
            Reason = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
