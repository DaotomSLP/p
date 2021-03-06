﻿namespace Vanpheng_Jewelry
{
    partial class Bill
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
            this.Sale_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanpheng_jewelryDataSet = new Vanpheng_Jewelry.vanpheng_jewelryDataSet();
            this.Order_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BuyViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerSaleBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sale_ViewTableAdapter = new Vanpheng_Jewelry.vanpheng_jewelryDataSetTableAdapters.Sale_ViewTableAdapter();
            this.reportViewerOrderBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Order_ViewTableAdapter = new Vanpheng_Jewelry.vanpheng_jewelryDataSetTableAdapters.Order_ViewTableAdapter();
            this.reportViewerBuy = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BuyViewTableAdapter = new Vanpheng_Jewelry.vanpheng_jewelryDataSetTableAdapters.BuyViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Sale_ViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanpheng_jewelryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_ViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Sale_ViewBindingSource
            // 
            this.Sale_ViewBindingSource.DataMember = "Sale_View";
            this.Sale_ViewBindingSource.DataSource = this.vanpheng_jewelryDataSet;
            // 
            // vanpheng_jewelryDataSet
            // 
            this.vanpheng_jewelryDataSet.DataSetName = "vanpheng_jewelryDataSet";
            this.vanpheng_jewelryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Order_ViewBindingSource
            // 
            this.Order_ViewBindingSource.DataMember = "Order_View";
            this.Order_ViewBindingSource.DataSource = this.vanpheng_jewelryDataSet;
            // 
            // BuyViewBindingSource
            // 
            this.BuyViewBindingSource.DataMember = "BuyView";
            this.BuyViewBindingSource.DataSource = this.vanpheng_jewelryDataSet;
            // 
            // reportViewerSaleBill
            // 
            this.reportViewerSaleBill.AutoSize = true;
            reportDataSource1.Name = "vanpheng_jewelryDataSet";
            reportDataSource1.Value = this.Sale_ViewBindingSource;
            this.reportViewerSaleBill.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerSaleBill.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.Sale_Bill.rdlc";
            this.reportViewerSaleBill.Location = new System.Drawing.Point(12, 1);
            this.reportViewerSaleBill.Name = "reportViewerSaleBill";
            this.reportViewerSaleBill.ServerReport.BearerToken = null;
            this.reportViewerSaleBill.Size = new System.Drawing.Size(741, 559);
            this.reportViewerSaleBill.TabIndex = 20;
            this.reportViewerSaleBill.Visible = false;
            // 
            // Sale_ViewTableAdapter
            // 
            this.Sale_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerOrderBill
            // 
            this.reportViewerOrderBill.AutoSize = true;
            reportDataSource2.Name = "vanpheng_jewelryDataSet";
            reportDataSource2.Value = this.Order_ViewBindingSource;
            this.reportViewerOrderBill.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerOrderBill.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.OrderBill.rdlc";
            this.reportViewerOrderBill.Location = new System.Drawing.Point(12, 1);
            this.reportViewerOrderBill.Name = "reportViewerOrderBill";
            this.reportViewerOrderBill.ServerReport.BearerToken = null;
            this.reportViewerOrderBill.Size = new System.Drawing.Size(741, 559);
            this.reportViewerOrderBill.TabIndex = 21;
            this.reportViewerOrderBill.Visible = false;
            // 
            // Order_ViewTableAdapter
            // 
            this.Order_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerBuy
            // 
            this.reportViewerBuy.AutoSize = true;
            reportDataSource3.Name = "vanpheng_jewelryDataSet";
            reportDataSource3.Value = this.BuyViewBindingSource;
            this.reportViewerBuy.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerBuy.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.BuyBill.rdlc";
            this.reportViewerBuy.Location = new System.Drawing.Point(8, 7);
            this.reportViewerBuy.Name = "reportViewerBuy";
            this.reportViewerBuy.ServerReport.BearerToken = null;
            this.reportViewerBuy.Size = new System.Drawing.Size(741, 559);
            this.reportViewerBuy.TabIndex = 22;
            this.reportViewerBuy.Visible = false;
            // 
            // BuyViewTableAdapter
            // 
            this.BuyViewTableAdapter.ClearBeforeFill = true;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 572);
            this.Controls.Add(this.reportViewerBuy);
            this.Controls.Add(this.reportViewerOrderBill);
            this.Controls.Add(this.reportViewerSaleBill);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sale_ViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanpheng_jewelryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_ViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSaleBill;
        private System.Windows.Forms.BindingSource Sale_ViewBindingSource;
        private vanpheng_jewelryDataSet vanpheng_jewelryDataSet;
        private vanpheng_jewelryDataSetTableAdapters.Sale_ViewTableAdapter Sale_ViewTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerOrderBill;
        private System.Windows.Forms.BindingSource Order_ViewBindingSource;
        private vanpheng_jewelryDataSetTableAdapters.Order_ViewTableAdapter Order_ViewTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBuy;
        private System.Windows.Forms.BindingSource BuyViewBindingSource;
        private vanpheng_jewelryDataSetTableAdapters.BuyViewTableAdapter BuyViewTableAdapter;
    }
}