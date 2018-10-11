using System;
using System.Windows.Forms;

namespace TTTPAL.XmlGenerator
{
    public partial class MainForm : Form
    {
        public System.Xml.XmlDocument SettingsFile = new System.Xml.XmlDocument();
        string SettingsFilename = "";
        public String SelectedConfiguration = "";
        public String SelectedFolder = "";
        public String SelectedFilename = "";
        public String SelectedCompany = "";
        public String SelectedNumberSeries = "";
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings(@"Settings.xml", true);        
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Loading settings...";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML Files|*.xml";
            dlg.Title = "Select a settings file to load";
            if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                LoadSettings(dlg.FileName, false);
            }
            else
            {
                toolStripStatusLabel1.Text = "Loading cancelled.";
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Saving settings...";
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "XML Files|*.xml";
            dlg.Title = "Select a settings file to save";
            if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SettingsFilename = dlg.FileName;
                SettingsFile.Save(SettingsFilename);
                toolStripStatusLabel1.Text = "Settings saved.";
            }
            else
            {
                toolStripStatusLabel1.Text = "Saving cancelled.";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.SetDataSource(SettingsFile);
            settingsForm.ShowDialog(this);
        }

        private void rejectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateRejected();
        }

        private void postedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePosted();
        }

        private void LoadSettings(string filename, bool initial)
        {
            if (initial)
            {
                if (!System.IO.File.Exists(filename)) return;
            }
            SettingsFilename = filename;
            SettingsFile.Load(SettingsFilename);
            toolStripStatusLabel1.Text = "Settings loaded.";
        }

        private bool SelectSettings()
        {
            SettingsSelector settingsSelector = new SettingsSelector();
            settingsSelector.SetDataSource(SettingsFile);
            if (settingsSelector.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SelectedConfiguration = settingsSelector.SelectedConfiguration;
                SelectedFolder = settingsSelector.SelectedFolder;
                SelectedFilename = settingsSelector.SelectedFilename;
                SelectedCompany = settingsSelector.SelectedCompany;
                SelectedNumberSeries = settingsSelector.SelectedNumberSeries;
                return true;
            }
            return false;
        }

        private void CreateRejected()
        {
            if (!SelectSettings()) return;
            RejectedForm rejectedForm = new RejectedForm();
            if (rejectedForm.ShowDialog(this) != System.Windows.Forms.DialogResult.OK) return;

            string type = rejectedForm.Type;
            string id = rejectedForm.Id;
            int status = rejectedForm.Status;
            string reason = rejectedForm.Reason;
            //if (id == "") throw new Exception("Missing id");
            //if (status == -1) throw new Exception("Missing status");
            //if (reason == "") throw new Exception("Missing reason");
            if (id == "")
            {
                MessageBox.Show("Missing id");
                return;
            }
            if (status == -1)
            {
                MessageBox.Show("Missing status");
                return;
            }

            string xml =
                "<?xml version = \"1.0\" encoding = \"iso-8859-1\"?>" +
                "<InvoiceReceiptCollection xmlns:xsi = \"http://www.w3.org/2001/XMLSchema-instance\" >" +
                    "<InvoiceReceiptItem>" +
                        "<InvoiceSeries>{0}</InvoiceSeries>" +
                        "<InvoiceNo>{1}</InvoiceNo>" +
                        "<Status>{2}</Status>" +
                        "<QueueStatus>{3}</QueueStatus>" +
                        "<ErrorText>{4}</ErrorText>" +
                    "</InvoiceReceiptItem>" +
                "</InvoiceReceiptCollection>";
            xml = xml.Replace("{0}", SelectedNumberSeries);
            xml = xml.Replace("{1}", id);
            xml = xml.Replace("{2}", status.ToString());
            xml = xml.Replace("{3}", "2");
            xml = xml.Replace("{4}", reason);
            SaveXml(xml, GetFilename(type, SelectedConfiguration, SelectedCompany));
        }
        private void CreatePosted()
        {
            if (!SelectSettings()) return;
            PostedForm postedForm = new PostedForm();
            if (postedForm.ShowDialog(this) != System.Windows.Forms.DialogResult.OK) return;

            string type = postedForm.Type;
            string id = postedForm.Id;
            int status = postedForm.Status;
            string voucherSeries = postedForm.VoucherSeries;
            string voucherNo = postedForm.VoucherNo;
            //if (id == "") throw new Exception("Missing id");
            //if (status == -1) throw new Exception("Missing status");
            //if (voucherSeries == "") throw new Exception("Missing voucher series");
            //if (voucherNo == "") throw new Exception("Missing voucher no");
            if (id == "")
            {
                MessageBox.Show("Missing id");
                return;
            }
            if (status == -1)
            {
                MessageBox.Show("Missing status");
                return;
            }
            if (voucherSeries == "")
            {
                MessageBox.Show("Missing voucher series");
                return;
            }
            if (voucherNo == "")
            {
                MessageBox.Show("Missing voucher no");
                return;
            }

            string xml =
                "<?xml version = \"1.0\" encoding = \"iso-8859-1\"?>" +
                "<InvoiceReceiptCollection xmlns:xsi = \"http://www.w3.org/2001/XMLSchema-instance\" >" +
                    "<InvoiceReceiptItem>" +
                        "<InvoiceSeries>{0}</InvoiceSeries>" +
                        "<InvoiceNo>{1}</InvoiceNo>" +
                        "<Status>{2}</Status>" +
                        "<QueueStatus>{3}</QueueStatus>" +
                        "<ArrivalAccountCodingDate>{4}</ArrivalAccountCodingDate>" +
                        "<VoucherSeries>{5}</VoucherSeries>" +
                        "<VoucherNo>{6}</VoucherNo>" +
                    "</InvoiceReceiptItem>" +
                "</InvoiceReceiptCollection>";
            xml = xml.Replace("{0}", SelectedNumberSeries);
            xml = xml.Replace("{1}", id);
            xml = xml.Replace("{2}", status.ToString());
            xml = xml.Replace("{3}", "1");
            xml = xml.Replace("{4}", System.DateTime.Now.ToString("yyyy-MM-dd")); //<Year4>-<Month,2>-<Day,2>
            xml = xml.Replace("{5}", voucherSeries);
            xml = xml.Replace("{6}", voucherNo);
            SaveXml(xml, GetFilename(type, SelectedConfiguration, SelectedCompany));
        }

        private string GetFilename(string type, string configuration, string company)
        {
            string filename;
            filename = System.IO.Path.Combine(SelectedFolder, SelectedFilename);
            filename = filename.Replace("#TYPE#", type);
            filename = filename.Replace("#CONFIGURATION#", configuration);
            filename = filename.Replace("#COMPANY#", company);
            filename = filename.Replace("#DATETIME#", System.DateTime.Now.ToString("yyyyMMddHHmmssfff")); //<Year4,4><Month,2><Day,2><Hours24,2><Minutes,2><Seconds><Thousands>
            filename = filename.Replace("#GUID#", System.Guid.NewGuid().ToString());
            return filename;
        }

        private void SaveXml(string xml, string filename)
        {
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.LoadXml(xml);
            xmlDoc.Save(filename);

            toolStripStatusLabel1.Text = "File saved.";
            MessageBox.Show("File saved:\n" + filename);
        }

    }
}
