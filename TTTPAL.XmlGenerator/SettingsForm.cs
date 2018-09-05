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
    public partial class SettingsForm : Form
    {
        System.Xml.XmlDocument SettingsDocument;
        System.IO.MemoryStream SettingsStream;
        public SettingsForm()
        {
            InitializeComponent();
        }

        public void SetDataSource(System.Xml.XmlDocument settings)
        {
            SettingsDocument = settings;

            System.Xml.Xsl.XslCompiledTransform xslTrans = new System.Xml.Xsl.XslCompiledTransform();
            xslTrans.Load(System.IO.Path.Combine(new System.IO.DirectoryInfo(Environment.CurrentDirectory).FullName, @"Settings.xsl"));

            System.Xml.XmlReader reader = new System.Xml.XmlNodeReader(settings);
            SettingsStream = new System.IO.MemoryStream();
            xslTrans.Transform(reader, null, SettingsStream);
            SettingsStream.Position = 0;
            reader.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentStream = SettingsStream;
        }
    }
}
