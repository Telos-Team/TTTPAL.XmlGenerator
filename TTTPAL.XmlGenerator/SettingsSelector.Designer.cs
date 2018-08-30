namespace TTTPAL.XmlGenerator
{
    partial class SettingsSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsSelector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewConfigurations = new System.Windows.Forms.DataGridView();
            this.dataGridViewCompanies = new System.Windows.Forms.DataGridView();
            this.dataGridViewNumberSeries = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigurations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumberSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(713, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(632, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewConfigurations, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewCompanies, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewNumberSeries, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 421);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewConfigurations
            // 
            this.dataGridViewConfigurations.AllowUserToAddRows = false;
            this.dataGridViewConfigurations.AllowUserToDeleteRows = false;
            this.dataGridViewConfigurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfigurations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConfigurations.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewConfigurations.MultiSelect = false;
            this.dataGridViewConfigurations.Name = "dataGridViewConfigurations";
            this.dataGridViewConfigurations.ReadOnly = true;
            this.dataGridViewConfigurations.Size = new System.Drawing.Size(794, 132);
            this.dataGridViewConfigurations.TabIndex = 0;
            // 
            // dataGridViewCompanies
            // 
            this.dataGridViewCompanies.AllowUserToAddRows = false;
            this.dataGridViewCompanies.AllowUserToDeleteRows = false;
            this.dataGridViewCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompanies.Location = new System.Drawing.Point(3, 141);
            this.dataGridViewCompanies.MultiSelect = false;
            this.dataGridViewCompanies.Name = "dataGridViewCompanies";
            this.dataGridViewCompanies.ReadOnly = true;
            this.dataGridViewCompanies.Size = new System.Drawing.Size(794, 132);
            this.dataGridViewCompanies.TabIndex = 1;
            // 
            // dataGridViewNumberSeries
            // 
            this.dataGridViewNumberSeries.AllowUserToAddRows = false;
            this.dataGridViewNumberSeries.AllowUserToDeleteRows = false;
            this.dataGridViewNumberSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumberSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNumberSeries.Location = new System.Drawing.Point(3, 279);
            this.dataGridViewNumberSeries.MultiSelect = false;
            this.dataGridViewNumberSeries.Name = "dataGridViewNumberSeries";
            this.dataGridViewNumberSeries.ReadOnly = true;
            this.dataGridViewNumberSeries.Size = new System.Drawing.Size(794, 139);
            this.dataGridViewNumberSeries.TabIndex = 2;
            // 
            // SettingsSelector
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsSelector";
            this.Text = "TTTPAL Xml Generator - Configuration Selector";
            this.Load += new System.EventHandler(this.SettingsSelector_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigurations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumberSeries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewConfigurations;
        private System.Windows.Forms.DataGridView dataGridViewCompanies;
        private System.Windows.Forms.DataGridView dataGridViewNumberSeries;
    }
}