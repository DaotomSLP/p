using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanpheng_Jewelry
{
    public partial class frmReportSaleOrder : Form
    {
        public frmReportSaleOrder()
        {
            InitializeComponent();
        }

        private void frmReportSaleOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Import' table. You can move, or remove it, as needed.
            this.ImportTableAdapter.Fill(this.Database1DataSet.Import);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (globalVal.reportStatus == "sale")
            {
                this.reportViewerImport.Visible = false;
                this.reportViewerSale.Visible = true;
                Database database = new Database();
                DataTable dataTable = new DataTable();
                dataTable = database.loadReport("SELECT * FROM Sale WHERE Sale_date BETWEEN '" + dtpStart.Value.ToString() + "' AND '" + dtpEnd.Value.ToString() + "'");
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);
                this.reportViewerSale.LocalReport.DataSources.Clear();
                this.reportViewerSale.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewerSale.RefreshReport();
            }
            else if (globalVal.reportStatus == "import")
            {
                this.reportViewerSale.Visible = false;
                this.reportViewerImport.Visible = true;
                Database database = new Database();
                DataTable dataTable = new DataTable();
                dataTable = database.loadReport("SELECT * FROM Import WHERE Imp_date BETWEEN '" + dtpStart.Value.ToString() + "' AND '" + dtpEnd.Value.ToString() + "'");
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);
                this.reportViewerImport.LocalReport.DataSources.Clear();
                this.reportViewerImport.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewerImport.RefreshReport();
            }
        }
    }
}
