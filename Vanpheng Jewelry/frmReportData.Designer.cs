namespace Vanpheng_Jewelry
{
    partial class frmReportData
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanpheng_jewelryDataSet = new Vanpheng_Jewelry.vanpheng_jewelryDataSet();
            this.Product_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerProduct = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductTableAdapter = new Vanpheng_Jewelry.vanpheng_jewelryDataSetTableAdapters.ProductTableAdapter();
            this.reportViewerProductType = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Product_TypeTableAdapter = new Vanpheng_Jewelry.vanpheng_jewelryDataSetTableAdapters.Product_TypeTableAdapter();
            this.reportViewerEmp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerSupp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmployeeTableAdapter = new Vanpheng_Jewelry.vanpheng_jewelryDataSetTableAdapters.EmployeeTableAdapter();
            this.SupplierTableAdapter = new Vanpheng_Jewelry.vanpheng_jewelryDataSetTableAdapters.SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanpheng_jewelryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product_TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductBindingSource
            // 
            this.ProductBindingSource.DataMember = "Product";
            this.ProductBindingSource.DataSource = this.vanpheng_jewelryDataSet;
            // 
            // vanpheng_jewelryDataSet
            // 
            this.vanpheng_jewelryDataSet.DataSetName = "vanpheng_jewelryDataSet";
            this.vanpheng_jewelryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Product_TypeBindingSource
            // 
            this.Product_TypeBindingSource.DataMember = "Product_Type";
            this.Product_TypeBindingSource.DataSource = this.vanpheng_jewelryDataSet;
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataMember = "Employee";
            this.EmployeeBindingSource.DataSource = this.vanpheng_jewelryDataSet;
            // 
            // SupplierBindingSource
            // 
            this.SupplierBindingSource.DataMember = "Supplier";
            this.SupplierBindingSource.DataSource = this.vanpheng_jewelryDataSet;
            // 
            // reportViewerProduct
            // 
            this.reportViewerProduct.AutoSize = true;
            reportDataSource1.Name = "vanpheng_jewelryDataSet";
            reportDataSource1.Value = this.ProductBindingSource;
            this.reportViewerProduct.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerProduct.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.Report1.rdlc";
            this.reportViewerProduct.Location = new System.Drawing.Point(105, 12);
            this.reportViewerProduct.Name = "reportViewerProduct";
            this.reportViewerProduct.ServerReport.BearerToken = null;
            this.reportViewerProduct.Size = new System.Drawing.Size(652, 570);
            this.reportViewerProduct.TabIndex = 0;
            this.reportViewerProduct.Visible = false;
            // 
            // ProductTableAdapter
            // 
            this.ProductTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerProductType
            // 
            this.reportViewerProductType.AutoSize = true;
            reportDataSource2.Name = "vanpheng_jewelryDataSet";
            reportDataSource2.Value = this.Product_TypeBindingSource;
            this.reportViewerProductType.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerProductType.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.ProductType.rdlc";
            this.reportViewerProductType.Location = new System.Drawing.Point(105, 12);
            this.reportViewerProductType.Name = "reportViewerProductType";
            this.reportViewerProductType.ServerReport.BearerToken = null;
            this.reportViewerProductType.Size = new System.Drawing.Size(652, 570);
            this.reportViewerProductType.TabIndex = 1;
            this.reportViewerProductType.Visible = false;
            // 
            // Product_TypeTableAdapter
            // 
            this.Product_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerEmp
            // 
            this.reportViewerEmp.AutoSize = true;
            reportDataSource3.Name = "vanpheng_jewelryDataSet";
            reportDataSource3.Value = this.EmployeeBindingSource;
            this.reportViewerEmp.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerEmp.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.Employee.rdlc";
            this.reportViewerEmp.Location = new System.Drawing.Point(105, 12);
            this.reportViewerEmp.Name = "reportViewerEmp";
            this.reportViewerEmp.ServerReport.BearerToken = null;
            this.reportViewerEmp.Size = new System.Drawing.Size(652, 570);
            this.reportViewerEmp.TabIndex = 2;
            this.reportViewerEmp.Visible = false;
            // 
            // reportViewerSupp
            // 
            this.reportViewerSupp.AutoSize = true;
            reportDataSource4.Name = "vanpheng_jewelryDataSet";
            reportDataSource4.Value = this.SupplierBindingSource;
            this.reportViewerSupp.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerSupp.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.Supplier.rdlc";
            this.reportViewerSupp.Location = new System.Drawing.Point(105, 10);
            this.reportViewerSupp.Name = "reportViewerSupp";
            this.reportViewerSupp.ServerReport.BearerToken = null;
            this.reportViewerSupp.Size = new System.Drawing.Size(652, 592);
            this.reportViewerSupp.TabIndex = 3;
            this.reportViewerSupp.Visible = false;
            // 
            // EmployeeTableAdapter
            // 
            this.EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // SupplierTableAdapter
            // 
            this.SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 616);
            this.Controls.Add(this.reportViewerSupp);
            this.Controls.Add(this.reportViewerEmp);
            this.Controls.Add(this.reportViewerProductType);
            this.Controls.Add(this.reportViewerProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportData";
            this.Text = "frmReportData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanpheng_jewelryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product_TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProduct;
        private System.Windows.Forms.BindingSource ProductBindingSource;
        private vanpheng_jewelryDataSet vanpheng_jewelryDataSet;
        private vanpheng_jewelryDataSetTableAdapters.ProductTableAdapter ProductTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductType;
        private System.Windows.Forms.BindingSource Product_TypeBindingSource;
        private vanpheng_jewelryDataSetTableAdapters.Product_TypeTableAdapter Product_TypeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEmp;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSupp;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private vanpheng_jewelryDataSetTableAdapters.EmployeeTableAdapter EmployeeTableAdapter;
        private System.Windows.Forms.BindingSource SupplierBindingSource;
        private vanpheng_jewelryDataSetTableAdapters.SupplierTableAdapter SupplierTableAdapter;
    }
}