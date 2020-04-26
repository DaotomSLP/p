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
    public partial class frmReportData : Form
    {
        public frmReportData()
        {
            InitializeComponent();
        }

        private void frmReportData_Load(object sender, EventArgs e)
        {
            if(globalVal.reportStatus == "product")
            {
                this.reportViewerProduct.Visible = true;
                // TODO: This line of code loads data into the 'Database1DataSet.Product' table. You can move, or remove it, as needed.
                this.ProductTableAdapter.Fill(this.Database1DataSet.Product);
                this.reportViewerProduct.RefreshReport();
            }
            else if (globalVal.reportStatus == "product_type")
            {
                this.reportViewerProductType.Visible = true;
                // TODO: This line of code loads data into the 'Database1DataSet.Product' table. You can move, or remove it, as needed.
                this.Product_TypeTableAdapter.Fill(this.Database1DataSet.Product_Type);
                this.reportViewerProductType.RefreshReport();
            }
            else if (globalVal.reportStatus == "employee")
            {
                this.reportViewerEmp.Visible = true;
                // TODO: This line of code loads data into the 'Database1DataSet.Product' table. You can move, or remove it, as needed.
                this.EmployeeTableAdapter.Fill(this.Database1DataSet.Employee);
                this.reportViewerEmp.RefreshReport();
            }
            else if (globalVal.reportStatus == "supplier")
            {
                this.reportViewerSupp.Visible = true;
                // TODO: This line of code loads data into the 'Database1DataSet.Product' table. You can move, or remove it, as needed.
                this.SupplierTableAdapter.Fill(this.Database1DataSet.Supplier);
                this.reportViewerSupp.RefreshReport();
            }

        }
    }
}
