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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            if (database.Login(txtUser.Text, txtPassword.Text) != "notUser")
            {
                groupBox1.Visible = false;
                label1.Visible = true;
            }
            else
            {
                MessageBox.Show("Username or Password not correct!!!");
            }
        }
    }
}
