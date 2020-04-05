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
    public partial class frmBuyProduct : Form
    {
        public frmBuyProduct()
        {
            InitializeComponent();
        }

        private void frmBuyProduct_Load(object sender, EventArgs e)
        {
           if(globalVal.FrmBuyStatus == "my")
            {
                loadImport_myProduct();
            }
            else if(globalVal.FrmBuyStatus == "new")
            {
                loadImport_newProduct();
            }
        }
        private  void loadImport_myProduct()
        {
            lbl_status.Visible = true;
            rad_full.Visible = true;
            rad_nfull.Visible = true;
            lblName.Text = "ສິນຄ້າຂອງຮ້ານ";
        }
        private void loadImport_newProduct()
        {
            lbl_status.Visible = false;
            rad_full.Visible = false;
            rad_nfull.Visible = false;
            lblName.Text = "ສິນຄ້າໃໝ່";
        }
    }
}
