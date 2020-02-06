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
        private void hideAndShowSubMenu(Panel panel)
        {
            if(panel.Visible == true)
            {
                panel.Visible = false;
            }else
            {
                panel.Visible = true;
            }
        }
        private void btnData_Click(object sender, EventArgs e)
        {
            hideAndShowSubMenu(panelDataSubMenu);
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            hideForm();

            frmProduct frmProduct = new frmProduct();
            frmProduct.MdiParent = this;
            frmProduct.Location = new Point(0, 0);
            frmProduct.Show();
        }
    }
}
