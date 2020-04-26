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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerProduct = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet = new Vanpheng_Jewelry.Database1DataSet();
            this.ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductTableAdapter = new Vanpheng_Jewelry.Database1DataSetTableAdapters.ProductTableAdapter();
            this.reportViewerProductType = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Product_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Product_TypeTableAdapter = new Vanpheng_Jewelry.Database1DataSetTableAdapters.Product_TypeTableAdapter();
            this.reportViewerEmp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerSupp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeTableAdapter = new Vanpheng_Jewelry.Database1DataSetTableAdapters.EmployeeTableAdapter();
            this.SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierTableAdapter = new Vanpheng_Jewelry.Database1DataSetTableAdapters.SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product_TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerProduct
            // 
            this.reportViewerProduct.AutoSize = true;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.ProductBindingSource;
            this.reportViewerProduct.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerProduct.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.Report1.rdlc";
            this.reportViewerProduct.Location = new System.Drawing.Point(105, 12);
            this.reportViewerProduct.Name = "reportViewerProduct";
            this.reportViewerProduct.ServerReport.BearerToken = null;
            this.reportViewerProduct.Size = new System.Drawing.Size(652, 570);
            this.reportViewerProduct.TabIndex = 0;
            this.reportViewerProduct.Visible = false;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductBindingSource
            // 
            this.ProductBindingSource.DataMember = "Product";
            this.ProductBindingSource.DataSource = this.Database1DataSet;
            // 
            // ProductTableAdapter
            // 
            this.ProductTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerProductType
            // 
            this.reportViewerProductType.AutoSize = true;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.Product_TypeBindingSource;
            this.reportViewerProductType.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerProductType.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.ProductType.rdlc";
            this.reportViewerProductType.Location = new System.Drawing.Point(105, 12);
            this.reportViewerProductType.Name = "reportViewerProductType";
            this.reportViewerProductType.ServerReport.BearerToken = null;
            this.reportViewerProductType.Size = new System.Drawing.Size(652, 570);
            this.reportViewerProductType.TabIndex = 1;
            this.reportViewerProductType.Visible = false;
            // 
            // Product_TypeBindingSource
            // 
            this.Product_TypeBindingSource.DataMember = "Product_Type";
            this.Product_TypeBindingSource.DataSource = this.Database1DataSet;
            // 
            // Product_TypeTableAdapter
            // 
            this.Product_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerEmp
            // 
            this.reportViewerEmp.AutoSize = true;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.EmployeeBindingSource;
            this.reportViewerEmp.LocalReport.DataSources.Add(reportDataSource7);
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
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.SupplierBindingSource;
            this.reportViewerSupp.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewerSupp.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.Supplier.rdlc";
            this.reportViewerSupp.Location = new System.Drawing.Point(105, 12);
            this.reportViewerSupp.Name = "reportViewerSupp";
            this.reportViewerSupp.ServerReport.BearerToken = null;
            this.reportViewerSupp.Size = new System.Drawing.Size(652, 592);
            this.reportViewerSupp.TabIndex = 3;
            this.reportViewerSupp.Visible = false;
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataMember = "Employee";
            this.EmployeeBindingSource.DataSource = this.Database1DataSet;
            // 
            // EmployeeTableAdapter
            // 
            this.EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // SupplierBindingSource
            // 
            this.SupplierBindingSource.DataMember = "Supplier";
            this.SupplierBindingSource.DataSource = this.Database1DataSet;
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
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product_TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProduct;
        private System.Windows.Forms.BindingSource ProductBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.ProductTableAdapter ProductTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductType;
        private System.Windows.Forms.BindingSource Product_TypeBindingSource;
        private Database1DataSetTableAdapters.Product_TypeTableAdapter Product_TypeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEmp;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSupp;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private Database1DataSetTableAdapters.EmployeeTableAdapter EmployeeTableAdapter;
        private System.Windows.Forms.BindingSource SupplierBindingSource;
        private Database1DataSetTableAdapters.SupplierTableAdapter SupplierTableAdapter;
    }
}