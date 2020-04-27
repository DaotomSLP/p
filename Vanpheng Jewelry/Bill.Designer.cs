namespace Vanpheng_Jewelry
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
            this.Sale_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new Vanpheng_Jewelry.Database1DataSet();
            this.reportViewerSaleBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sale_ViewTableAdapter = new Vanpheng_Jewelry.Database1DataSetTableAdapters.Sale_ViewTableAdapter();
            this.reportViewerOrderBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Order_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Order_ViewTableAdapter = new Vanpheng_Jewelry.Database1DataSetTableAdapters.Order_ViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Sale_ViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_ViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Sale_ViewBindingSource
            // 
            this.Sale_ViewBindingSource.DataMember = "Sale_View";
            this.Sale_ViewBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerSaleBill
            // 
            this.reportViewerSaleBill.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sale_ViewBindingSource;
            this.reportViewerSaleBill.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerSaleBill.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.Sale_Bill.rdlc";
            this.reportViewerSaleBill.Location = new System.Drawing.Point(12, 1);
            this.reportViewerSaleBill.Name = "reportViewerSaleBill";
            this.reportViewerSaleBill.ServerReport.BearerToken = null;
            this.reportViewerSaleBill.Size = new System.Drawing.Size(741, 559);
            this.reportViewerSaleBill.TabIndex = 20;
            // 
            // Sale_ViewTableAdapter
            // 
            this.Sale_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerOrderBill
            // 
            this.reportViewerOrderBill.AutoSize = true;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Order_ViewBindingSource;
            this.reportViewerOrderBill.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerOrderBill.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.OrderBill.rdlc";
            this.reportViewerOrderBill.Location = new System.Drawing.Point(12, 1);
            this.reportViewerOrderBill.Name = "reportViewerOrderBill";
            this.reportViewerOrderBill.ServerReport.BearerToken = null;
            this.reportViewerOrderBill.Size = new System.Drawing.Size(741, 559);
            this.reportViewerOrderBill.TabIndex = 21;
            // 
            // Order_ViewBindingSource
            // 
            this.Order_ViewBindingSource.DataMember = "Order_View";
            this.Order_ViewBindingSource.DataSource = this.Database1DataSet;
            // 
            // Order_ViewTableAdapter
            // 
            this.Order_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 572);
            this.Controls.Add(this.reportViewerOrderBill);
            this.Controls.Add(this.reportViewerSaleBill);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sale_ViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_ViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSaleBill;
        private System.Windows.Forms.BindingSource Sale_ViewBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.Sale_ViewTableAdapter Sale_ViewTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerOrderBill;
        private System.Windows.Forms.BindingSource Order_ViewBindingSource;
        private Database1DataSetTableAdapters.Order_ViewTableAdapter Order_ViewTableAdapter;
    }
}