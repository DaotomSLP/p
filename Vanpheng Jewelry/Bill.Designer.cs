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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerImport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerImport
            // 
            this.reportViewerImport.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            this.reportViewerImport.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerImport.LocalReport.ReportEmbeddedResource = "Vanpheng_Jewelry.ImportSumary.rdlc";
            this.reportViewerImport.Location = new System.Drawing.Point(12, 1);
            this.reportViewerImport.Name = "reportViewerImport";
            this.reportViewerImport.ServerReport.BearerToken = null;
            this.reportViewerImport.Size = new System.Drawing.Size(741, 559);
            this.reportViewerImport.TabIndex = 20;
            this.reportViewerImport.Visible = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 572);
            this.Controls.Add(this.reportViewerImport);
            this.Name = "Bill";
            this.Text = "Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerImport;
    }
}