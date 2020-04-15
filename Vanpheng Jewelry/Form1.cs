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

        private void Home_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Directory.GetCurrentDirectory());
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnMenuSale_Click(object sender, EventArgs e)
        {
            hideForm();
            globalVal.FrmSaleOrderStatus = "sale";
            Sale_Order sale_order = new Sale_Order();
            sale_order.MdiParent = this;
            sale_order.Location = new Point(0, 0);
            sale_order.Show();
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
            if(panel.Visible == true)
            {
                panelDataSubMenu.Visible = false;
                panelUpdateDataSubMenu.Visible = false;
                panOder.Visible = false;
                panBuy.Visible = false;
                panel.Visible = false;
            }else
            {
                panelDataSubMenu.Visible = false;
                panelUpdateDataSubMenu.Visible = false;
                panOder.Visible = false;
                panBuy.Visible = false;
                panel.Visible = true;
            }
        }
        private void btnData_Click(object sender, EventArgs e)
        {
        
            globalVal.FrmDataStatus = "insert";
            hideAndShowSubMenu(panelDataSubMenu);
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            globalVal.FrmDataStatus= "update";
            hideAndShowSubMenu(panelUpdateDataSubMenu);
        }
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            hideForm();
            frmProduct frmProduct = new frmProduct();
            showForm(frmProduct);

        }

        private void btnAddProdType_Click(object sender, EventArgs e)
        {
            hideForm();
            frmProdType frmProdType = new frmProdType();
            showForm(frmProdType);
        }

        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            hideForm();
            frmDailyPrice frmDailyPrice = new frmDailyPrice();
            showForm(frmDailyPrice);
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            hideForm();
            frmSupplier frmSupplier = new frmSupplier();
            showForm(frmSupplier);
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            hideForm();
            frmCustomer frmCustomer = new frmCustomer();
            showForm(frmCustomer);
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            hideForm();
            frmEmployee frmEmployee = new frmEmployee();
            showForm(frmEmployee);
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            hideForm();
            frmProduct frmProduct = new frmProduct();
            showForm(frmProduct);
        }

        private void btnEditProdT_Click(object sender, EventArgs e)
        {
            hideForm();
            frmProdType frmProdType = new frmProdType();
            showForm(frmProdType);
        }

        private void btnEditPrice_Click(object sender, EventArgs e)
        {
            hideForm();
            frmDailyPrice frmDailyPrice = new frmDailyPrice();
            showForm(frmDailyPrice);
        }

        private void btnEditSupp_Click(object sender, EventArgs e)
        {
            hideForm();
            frmSupplier frmSupplier = new frmSupplier();
            showForm(frmSupplier);
        }

        private void btnEditCus_Click(object sender, EventArgs e)
        {
            hideForm();
            frmCustomer frmCustomer = new frmCustomer();
            showForm(frmCustomer);
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            hideForm();
            frmEmployee frmEmployee = new frmEmployee();
            showForm(frmEmployee);
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            hideAndShowSubMenu(panOder);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            hideAndShowSubMenu(panBuy);
        }

        private void btnImpNew_Click(object sender, EventArgs e)
        {
            globalVal.FrmDataStatus = "add";
            hideForm();
            frmProduct frmProduct = new frmProduct();
            showForm(frmProduct);
        }

        private void btnImpOld_Click(object sender, EventArgs e)
        {
            globalVal.FrmDataStatus = "addOld";
            hideForm();
            frmProduct frmProduct = new frmProduct();
            showForm(frmProduct);
        }

        private void btnOrdNew_Click(object sender, EventArgs e)
        {
            globalVal.FrmBuyStatus = "new";
            hideForm();
            frmBuyProduct frmBuyProduct = new frmBuyProduct();
            showForm(frmBuyProduct);
        }

        private void btnOrdMy_Click(object sender, EventArgs e)
        {
            globalVal.FrmSaleOrderStatus = "order";
            hideForm();
            Sale_Order sale_Order = new Sale_Order();
            showForm(sale_Order);
        }
    }
}
