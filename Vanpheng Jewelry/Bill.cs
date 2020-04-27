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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            if(globalVal.reportStatus == "SaleBill")
            {
                // TODO: This line of code loads data into the 'Database1DataSet.Sale_View' table. You can move, or remove it, as needed.
                //this.Sale_ViewTableAdapter.Fill(this.Database1DataSet.Sale_View);
                this.reportViewerOrderBill.Visible = false;
                this.reportViewerSaleBill.Visible = true;
                Database database = new Database();
                DataTable dataTable = new DataTable();
                dataTable = database.loadReport("SELECT * FROM Sale_View WHERE Sale_id = '"+globalVal.Sale_id+"'");
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);
                this.reportViewerSaleBill.LocalReport.DataSources.Clear();
                this.reportViewerSaleBill.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewerSaleBill.RefreshReport();
            }
           else if (globalVal.reportStatus == "OrderBill")
            {
                // TODO: This line of code loads data into the 'Database1DataSet.Sale_View' table. You can move, or remove it, as needed.
                //this.Sale_ViewTableAdapter.Fill(this.Database1DataSet.Sale_View);
                this.reportViewerOrderBill.Visible = true;
                this.reportViewerSaleBill.Visible = false;
                Database database = new Database();
                DataTable dataTable = new DataTable();
                dataTable = database.loadReport("SELECT * FROM Order_View WHERE Order_id = '" + globalVal.Order_id + "'");
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);
                this.reportViewerOrderBill.LocalReport.DataSources.Clear();
                this.reportViewerOrderBill.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewerOrderBill.RefreshReport();
            }
        }
    }
}
