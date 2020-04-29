using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Vanpheng_Jewelry
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public void Home_Load(object sender, EventArgs e)
        {
                Login login = new Login();
                showForm(login);
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }
        public void showPanel1()
        {
           panel1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnMenuSale_Click(object sender, EventArgs e)
        {
            if (globalVal.User != "")
            {
                changeMenuColor();
                btnMenuSale.BackColor = Color.White;
                btnMenuSale.ForeColor = Color.DarkGoldenrod;
                hideForm();
                globalVal.FrmSaleOrderStatus = "sale";
                Sale_Order sale_order = new Sale_Order();
                sale_order.MdiParent = this;
                sale_order.Location = new Point(0, 0);
                sale_order.Show();

            }
            else
            {
                
            }
        }
        public void hideForm()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }
        public void showForm(Form form)
        {
            form.MdiParent = this;
            form.Location = new Point(0, 0);
            form.Show();
        }
        private void hideAndShowSubMenu(Panel panel)
        {
            panelDataSubMenu.Visible = false;
            panelUpdateDataSubMenu.Visible = false;
            panelReportSubmenu.Visible = false;
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }else
            {
                panel.Visible = true;
            }
        }

        public void changeMenuColor()
        {
            btnOrder.BackColor = Color.DarkGoldenrod;
            btnMenuSale.BackColor = Color.DarkGoldenrod;
            btnImp.BackColor = Color.DarkGoldenrod;
            btnAddEmp.BackColor = Color.Transparent;
            btnBuy.BackColor = Color.Transparent;
            btnAddPrice.BackColor = Color.Transparent;
            btnAddProd.BackColor = Color.Transparent;
            btnAddProdType.BackColor = Color.Transparent;
            btnAddSupp.BackColor = Color.Transparent;

            btnEditEmp.BackColor = Color.Transparent;
            btnEditProd.BackColor = Color.Transparent;
            btnEditProdT.BackColor = Color.Transparent;
            btnEditSupp.BackColor = Color.Transparent;
            btnBuyReport.BackColor = Color.Transparent;

            btnMenuSale.ForeColor = SystemColors.ControlLightLight;
            btnOrder.ForeColor = SystemColors.ControlLightLight;
            btnImp.ForeColor = SystemColors.ControlLightLight;
            btnBuy.ForeColor = SystemColors.ControlLightLight;
            btnAddEmp.ForeColor = SystemColors.ControlLightLight;
            btnAddPrice.ForeColor = SystemColors.ControlLightLight;
            btnAddProd.ForeColor = SystemColors.ControlLightLight;
            btnAddProdType.ForeColor = SystemColors.ControlLightLight;
            btnAddSupp.ForeColor = SystemColors.ControlLightLight;
            btnBuyReport.ForeColor = SystemColors.ControlLightLight;

            btnEditEmp.ForeColor = SystemColors.ControlLightLight;
            btnEditProd.ForeColor = SystemColors.ControlLightLight;
            btnEditProdT.ForeColor = SystemColors.ControlLightLight;
            btnEditSupp.ForeColor = SystemColors.ControlLightLight;

            btnReportProd.ForeColor = SystemColors.ControlLightLight;
            btnReportSupp.ForeColor = SystemColors.ControlLightLight;
            btnReportProdType.ForeColor = SystemColors.ControlLightLight;
            btnReportEmp.ForeColor = SystemColors.ControlLightLight;
            btnReportImportSum.ForeColor = SystemColors.ControlLightLight;
            btnReportSaleSum.ForeColor = SystemColors.ControlLightLight;
            btnReportSaleSum.BackColor = Color.Transparent;
            btnReportImportSum.BackColor = Color.Transparent;
            btnReportProd.BackColor = Color.Transparent;
            btnReportEmp.BackColor = Color.Transparent;
            btnReportProdType.BackColor = Color.Transparent;
            btnReportSupp.BackColor = Color.Transparent;

        }
        private void btnData_Click(object sender, EventArgs e)
        {
            if (globalVal.User != "")
            {
                changeMenuColor();
                globalVal.FrmDataStatus = "insert";
                hideAndShowSubMenu(panelDataSubMenu);

            }
            else
            {

            }
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            if (globalVal.User != "")
            {

                changeMenuColor();
                globalVal.FrmDataStatus = "update";
                hideAndShowSubMenu(panelUpdateDataSubMenu);
            }
            else
            {

            }
        }
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnAddProd.BackColor = Color.White;
            btnAddProd.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmProduct frmProduct = new frmProduct();
            showForm(frmProduct);

        }

        private void btnAddProdType_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnAddProdType.BackColor = Color.White;
            btnAddProdType.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmProdType frmProdType = new frmProdType();
            showForm(frmProdType);
        }

        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnAddPrice.BackColor = Color.White;
            btnAddPrice.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmDailyPrice frmDailyPrice = new frmDailyPrice();
            showForm(frmDailyPrice);
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnAddSupp.BackColor = Color.White;
            btnAddSupp.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmSupplier frmSupplier = new frmSupplier();
            showForm(frmSupplier);
        }


        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnAddEmp.BackColor = Color.White;
            btnAddEmp.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmEmployee frmEmployee = new frmEmployee();
            showForm(frmEmployee);
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnEditProd.BackColor = Color.White;
            btnEditProd.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmProduct frmProduct = new frmProduct();
            showForm(frmProduct);
        }

        private void btnEditProdT_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnEditProdT.BackColor = Color.White;
            btnEditProdT.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmProdType frmProdType = new frmProdType();
            showForm(frmProdType);
        }


        private void btnEditSupp_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnEditSupp.BackColor = Color.White;
            btnEditSupp.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmSupplier frmSupplier = new frmSupplier();
            showForm(frmSupplier);
        }


        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnEditEmp.BackColor = Color.White;
            btnEditEmp.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmEmployee frmEmployee = new frmEmployee();
            showForm(frmEmployee);
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            if (globalVal.User != "")
            {
                changeMenuColor();
                btnImp.BackColor = Color.White;
                btnImp.ForeColor = Color.DarkGoldenrod;
                globalVal.FrmDataStatus = "addOld";
                hideForm();
                frmImport frmImport = new frmImport();
                showForm(frmImport);

            }
            else
            {

            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (globalVal.User != "")
            {
                changeMenuColor();
                btnOrder.BackColor = Color.White;
                btnOrder.ForeColor = Color.DarkGoldenrod;
                globalVal.FrmSaleOrderStatus = "order";
                hideForm();
                Sale_Order sale_Order = new Sale_Order();
                showForm(sale_Order);

            }
            else
            {

            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (globalVal.User != "")
            {
                changeMenuColor();
                hideAndShowSubMenu(panelReportSubmenu);

            }
            else
            {

            }
        }

        private void btnReportProd_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnReportProd.BackColor = Color.White;
            btnReportProd.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmReportData frmReportData = new frmReportData();
            globalVal.reportStatus = "product";
            showForm(frmReportData);
        }

        private void btnReportProdType_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnReportProdType.BackColor = Color.White;
            btnReportProdType.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmReportData frmReportData = new frmReportData();
            globalVal.reportStatus = "product_type";
            showForm(frmReportData);
        }

        private void btnReportEmp_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnReportEmp.BackColor = Color.White;
            btnReportEmp.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmReportData frmReportData = new frmReportData();
            globalVal.reportStatus = "employee";
            showForm(frmReportData);
        }

        private void btnReportSupp_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnReportSupp.BackColor = Color.White;
            btnReportSupp.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmReportData frmReportData = new frmReportData();
            globalVal.reportStatus = "supplier";
            showForm(frmReportData);
        }

        private void btnReportSaleSum_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnReportSaleSum.BackColor = Color.White;
            btnReportSaleSum.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmReportSaleOrder frmReportSaleOrder = new frmReportSaleOrder();
            globalVal.reportStatus = "sale";
            showForm(frmReportSaleOrder);
        }

        private void btnReportImportSum_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnReportImportSum.BackColor = Color.White;
            btnReportImportSum.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmReportSaleOrder frmReportSaleOrder = new frmReportSaleOrder();
            globalVal.reportStatus = "import";
            showForm(frmReportSaleOrder);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (globalVal.User != "")
            {
                changeMenuColor();
                btnBuy.BackColor = Color.White;
                btnBuy.ForeColor = Color.DarkGoldenrod;
                hideForm();
                frmBuyProduct frmBuyProduct = new frmBuyProduct();
                showForm(frmBuyProduct);
            }
        }

        private void btnBuyReport_Click(object sender, EventArgs e)
        {
            changeMenuColor();
            btnBuyReport.BackColor = Color.White;
            btnBuyReport.ForeColor = Color.DarkGoldenrod;
            hideForm();
            frmReportSaleOrder frmReportSaleOrder = new frmReportSaleOrder();
            globalVal.reportStatus = "buy";
            showForm(frmReportSaleOrder);
        }
    }
}
