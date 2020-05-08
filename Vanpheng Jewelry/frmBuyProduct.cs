using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            dgv.ColumnCount = 5;
            dgv.Columns[0].Name = "Mùa hàng";
            dgv.Columns[1].Name = "Giá";
            dgv.Columns[2].Name = "Cân nặng";
            dgv.Columns[3].Name = "Số";
            dgv.Columns[4].Name = "Bao gồm tiền";
            

            dgv.RowHeadersWidth = 20;
            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 80;
            dgv.Columns[2].Width = 110;
            dgv.Columns[3].Width = 60;
            dgv.Columns[4].Width = 150;

            lblTatal.Text = total.ToString();
        }

        private void clearTextbox()
        {
            txtPrice.Text = "";
            txtName.Text = "";
            numQty.Value = 1;
            numWeight.Value = 1;
        }

        int total = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string amount = "";
            amount = (Convert.ToInt32(txtPrice.Text) * numQty.Value).ToString();
            total += Convert.ToInt32(amount);
            string[] row = new string[] {  txtName.Text, txtPrice.Text, numWeight.Value.ToString(), numQty.Value.ToString(), amount };
            dgv.Rows.Add(row);
            lblTatal.Text = total.ToString();
            clearTextbox();
        }
        int dgvSelRow;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDel.Visible = true;
            dgvSelRow = e.RowIndex;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.Rows.RemoveAt(dgvSelRow);
                if (globalVal.FrmSaleOrderStatus == "sale")
                {
                    string price = "";
                    price = dgv.Rows[dgvSelRow].Cells[5].Value.ToString();

                    total -= Convert.ToInt32(price);
                    lblTatal.Text = total.ToString();
                }
            }
            catch
            {
                MessageBox.Show("list is empty");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("In hóa đơn ? :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                string Cid = database.generateId("SELECT MAX(Cus_id) FROM Customer");
                string Bid = database.generateId("SELECT MAX(Buy_id) FROM Buy");
                string Billno = database.generateBillNo("SELECT MAX(Buy_no) from Buy");
                database.InsertData("INSERT INTO Customer VALUES('"+ Cid + "','"+txtName1.Text+"','"+txtTel.Text+"','"+txtAddr+"','0')");
                database.InsertData("INSERT INTO Buy VALUES('" + Bid + "','" + DateTime.Now.ToString() + "','" + lblTatal.Text + "','" + Cid + "','"+Billno+"')");

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    database.InsertData(@"INSERT INTO Buy_detail VALUES('" +
                            Bid + "','" + row.Cells[0].Value +
                            "','" + row.Cells[4].Value + "','" + Convert.ToInt32(row.Cells[3].Value) + "','" +
                            Convert.ToInt32(row.Cells[1].Value) + "','" + row.Cells[2].Value + "')");
                }
                //print bill :
                Bill bill = new Bill();
                globalVal.Buy_id = Bid;
                globalVal.reportStatus = "BuyBill";
                bill.ShowDialog();
                dgv.Rows.Clear();

                dgv.ColumnCount = 5;
                dgv.Columns[0].Name = "Mùa hàng";
                dgv.Columns[1].Name = "Giá";
                dgv.Columns[2].Name = "Cân nặng";
                dgv.Columns[3].Name = "Số";
                dgv.Columns[4].Name = "Bao gồm tiền";


                dgv.RowHeadersWidth = 20;
                dgv.Columns[0].Width = 100;
                dgv.Columns[1].Width = 80;
                dgv.Columns[2].Width = 110;
                dgv.Columns[3].Width = 60;
                dgv.Columns[4].Width = 150;

                clearTextbox();
                txtName.Text = "";
                txtAddr.Text = "";
                txtTel.Text = "";

                lblTatal.Text = total.ToString();
                MessageBox.Show("Success...");
            }
        }
    }
}
