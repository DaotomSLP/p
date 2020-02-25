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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
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

            Sale sale = new Sale();
            sale.MdiParent = this;
            sale.Location = new Point(0, 0);
            sale.Show();
        }
        private void hideForm()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }
        private void showForm(Form form)
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
                panel.Visible = false;
            }else
            {
                panelDataSubMenu.Visible = false;
                panelUpdateDataSubMenu.Visible = false;
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
    }
}
