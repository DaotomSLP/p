namespace Vanpheng_Jewelry
{
    partial class frmReportSaleOrder
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new Vanpheng_Jewelry.Database1DataSet();
            this.ImportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerSale = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SaleTableAdapter = new Vanpheng_Jewelry.Database1DataSetTableAdapters.SaleTableAdapter();
            this.reportViewerImport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ImportTableAdapter = new Vanpheng_Jewelry.Database1DataSetTableAdapters.ImportTableAdapter();
            this.reportViewerBuy = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BuyViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BuyViewTableAdapter = new Vanpheng_Jewelry.Database1DataSetTableAdapters.BuyViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleBindingSource
            // 
            this.SaleBindingSource.DataMember = "Sale";
            this.SaleBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ImportBindingSource
            // 
            this.ImportBindingSource.DataMember = "Import";
            this.ImportBindingSource.DataSource = this.Database1DataSet;
            // 
            // reportViewerSale
            // 
            this.reportViewerSale.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SaleBindingSource;
            this.reportViewerSale.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerSale.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.SaleSumary.rdlc";
            this.reportViewerSale.Location = new System.Drawing.Point(238, 9);
            this.reportViewerSale.Name = "reportViewerSale";
            this.reportViewerSale.ServerReport.BearerToken = null;
            this.reportViewerSale.Size = new System.Drawing.Size(652, 592);
            this.reportViewerSale.TabIndex = 4;
            this.reportViewerSale.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "ເລີ່ມຈາກວັນທີ່ :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "ເຖິງວັນທີ່ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Phetsarath OT_Italic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(21, 99);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 24);
            this.dtpStart.TabIndex = 9;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Phetsarath OT_Italic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(21, 174);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 24);
            this.dtpEnd.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(21, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "ສ້າງລາຍງານ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaleTableAdapter
            // 
            this.SaleTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerImport
            // 
            this.reportViewerImport.AutoSize = true;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ImportBindingSource;
            this.reportViewerImport.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerImport.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.ImportSumary.rdlc";
            this.reportViewerImport.Location = new System.Drawing.Point(238, 9);
            this.reportViewerImport.Name = "reportViewerImport";
            this.reportViewerImport.ServerReport.BearerToken = null;
            this.reportViewerImport.Size = new System.Drawing.Size(652, 592);
            this.reportViewerImport.TabIndex = 19;
            this.reportViewerImport.Visible = false;
            // 
            // ImportTableAdapter
            // 
            this.ImportTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerBuy
            // 
            this.reportViewerBuy.AutoSize = true;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.BuyViewBindingSource;
            this.reportViewerBuy.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerBuy.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.BuySummary.rdlc";
            this.reportViewerBuy.Location = new System.Drawing.Point(238, 9);
            this.reportViewerBuy.Name = "reportViewerBuy";
            this.reportViewerBuy.ServerReport.BearerToken = null;
            this.reportViewerBuy.Size = new System.Drawing.Size(652, 592);
            this.reportViewerBuy.TabIndex = 20;
            this.reportViewerBuy.Visible = false;
            // 
            // BuyViewBindingSource
            // 
            this.BuyViewBindingSource.DataMember = "BuyView";
            this.BuyViewBindingSource.DataSource = this.Database1DataSet;
            // 
            // BuyViewTableAdapter
            // 
            this.BuyViewTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportSaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 611);
            this.Controls.Add(this.reportViewerBuy);
            this.Controls.Add(this.reportViewerImport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewerSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportSaleOrder";
            this.Text = "frmReportSaleOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportSaleOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource SaleBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.SaleTableAdapter SaleTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerImport;
        private System.Windows.Forms.BindingSource ImportBindingSource;
        private Database1DataSetTableAdapters.ImportTableAdapter ImportTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBuy;
        private System.Windows.Forms.BindingSource BuyViewBindingSource;
        private Database1DataSetTableAdapters.BuyViewTableAdapter BuyViewTableAdapter;
    }
}