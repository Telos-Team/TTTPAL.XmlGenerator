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
    public partial class SettingsSelector : Form
    {
        public System.Xml.XmlDocument SettingsDocument;
        public int SelectedConfigurationId = -1;
        public int SelectedCompanyId = -1;
        public String SelectedConfiguration = "";
        public String SelectedFolder = "";
        public String SelectedFilename = "";
        public String SelectedCompany = "";
        public String SelectedNumberSeries = "";
        private System.Data.DataSet settingsDataSet;

        public SettingsSelector()
        {
            InitializeComponent();
        }

        private void SettingsSelector_Load(object sender, EventArgs e)
        {
            dataGridViewConfigurations.DataSource = settingsDataSet.Tables["Configuration"];
            dataGridViewCompanies.DataSource = settingsDataSet.Tables["Company"];
            dataGridViewNumberSeries.DataSource = settingsDataSet.Tables["NumberSeries"];

            dataGridViewConfigurations.CellClick += DataGridViewConfigurations_CellClick;
            dataGridViewCompanies.CellClick += DataGridViewCompanies_CellClick;
            dataGridViewNumberSeries.CellClick += DataGridViewNumberSeries_CellClick;

            dataGridViewConfigurations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNumberSeries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewConfigurations.Columns.Add("Configuration_Id", "Configuration_Id");
            dataGridViewConfigurations.Columns["Configuration_Id"].DataPropertyName = "Configuration_Id";
            dataGridViewConfigurations.Columns["Configuration_Id"].Visible = false;
            dataGridViewCompanies.Columns.Add("Configuration_Id", "Configuration_Id");
            dataGridViewCompanies.Columns["Configuration_Id"].DataPropertyName = "Configuration_Id";
            dataGridViewCompanies.Columns["Configuration_Id"].Visible = false;
            dataGridViewCompanies.Columns.Add("Company_Id", "Company_Id");
            dataGridViewCompanies.Columns["Company_Id"].DataPropertyName = "Company_Id";
            dataGridViewCompanies.Columns["Company_Id"].Visible = false;
            dataGridViewNumberSeries.Columns.Add("Company_Id", "Company_Id");
            dataGridViewNumberSeries.Columns["Company_Id"].DataPropertyName = "Company_Id";
            dataGridViewNumberSeries.Columns["Company_Id"].Visible = false;

            dataGridViewConfigurations.AllowUserToOrderColumns = false;
            dataGridViewCompanies.AllowUserToOrderColumns = false;
            dataGridViewNumberSeries.AllowUserToOrderColumns = false;

            dataGridViewConfigurations.AutoResizeColumns();
            dataGridViewCompanies.AutoResizeColumns();
            dataGridViewNumberSeries.AutoResizeColumns();

            SelectConfiguration(-1);
        }

        private void DataGridViewConfigurations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            SelectConfiguration(int.Parse(dgv.SelectedRows[0].Cells["Configuration_Id"].Value.ToString()));
        }
        private void DataGridViewCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            SelectCompany(int.Parse(dgv.SelectedRows[0].Cells["Company_Id"].Value.ToString()));
            SelectNumberSeries(dataGridViewNumberSeries.Rows[0].Cells["NumberSeries_Column"].Value.ToString());
        }
        private void DataGridViewNumberSeries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            SelectNumberSeries(dgv.SelectedRows[0].Cells["NumberSeries_Column"].Value.ToString());
        }


        public void SetDataSource(System.Xml.XmlDocument settings)
        {
            SettingsDocument = settings;

            System.Xml.XmlReader reader = new System.Xml.XmlNodeReader(settings);
            settingsDataSet = new DataSet();
            settingsDataSet.ReadXmlSchema(@"Settings.xsd");
            settingsDataSet.ReadXml(reader, XmlReadMode.ReadSchema);
            //settingsDataSet.ReadXml(reader);
            reader.Close();
        }

        private void SelectConfiguration(int id)
        {
            SelectedConfigurationId = id;
            SelectedConfiguration = "";
            SelectedFolder = "";
            SelectedFilename = "";
            SelectCompany(-1);
            SetFilterCompany(id);

            if (id == -1)
            {
                return;
            }
            SelectedConfigurationId = id;
            SelectedConfiguration = settingsDataSet.Tables["Configuration"].Rows[id]["Name"].ToString();
            SelectedFolder = settingsDataSet.Tables["Configuration"].Rows[id]["Folder"].ToString();
            SelectedFilename = settingsDataSet.Tables["Configuration"].Rows[id]["Filename"].ToString();
        }
        private void SelectCompany(int id)
        {
            SelectedCompanyId = id;
            SelectedCompany = "";
            SelectNumberSeries("");
            SetFilterNumberSeries(id);

            if (id == -1)
            {
                return;
            }
            SelectedCompany = settingsDataSet.Tables["Company"].Rows[id]["Name"].ToString();
            SelectNumberSeries((dataGridViewNumberSeries.DataSource as DataTable).Rows[0]["NumberSeries_Column"].ToString());
        }

        private void SelectNumberSeries(string text)
        {
            SelectedNumberSeries = text;
        }

        private void SetFilterCompany(int configuration_id)
        {
            (dataGridViewCompanies.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Configuration_Id] = '{0}'", configuration_id.ToString());
        }

        private void SetFilterNumberSeries(int company_id)
        {
            (dataGridViewNumberSeries.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Company_Id] = '{0}'", company_id.ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
