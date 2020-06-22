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
    public partial class frmImport : Form
    {
        public static string detail_price;
        public frmImport()
        {
            InitializeComponent();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            dgvOrder_Load("");
            dgvDetail_Create();
        }
         private void dgvOrder_Load(string where_condition)
        {
            Database database = new Database();
            SqlDataReader dr;
            if (where_condition == "")
            {
                 dr = database.LoadData(@"SELECT O.*,S.Supp_name FROM dbo.Orders O INNER JOIN dbo.Supplier"+
                     " S ON O.Supp_id=S.Supp_id WHERE O.Orders_is_success = 1");
            }
            else
            {
                 dr = database.LoadData(@"SELECT O.*,S.Supp_name FROM dbo.Orders O INNER JOIN dbo.Supplier"+
                    " S ON O.Supp_id=S.Supp_id WHERE Order_no LIKE '%"+where_condition+"%' OR Order_date LIKE '%"+
                    where_condition+ "%' AND O.Orders_is_success = 1");
            }
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("Mã đặt hàng");
            dataTable.Columns.Add("Tên người cũng cấp");
            dataTable.Columns.Add("Ngày đặt hàng");
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["id"] = dr["Order_id"];
                row["Mã đặt hàng"] = dr["Order_no"];
                row["Tên người cũng cấp"] = dr["Supp_name"];
                row["Ngày đặt hàng"] = dr["Order_date"];
                dataTable.Rows.Add(row);
            }
            dgv_Orders.DataSource = dataTable;
            dr.Close();
            dgv_Orders.Columns[0].Visible = false;
            dgv_Orders.Columns[2].Visible = false;
            dgv_Orders.Columns[1].Width = 100;
            dgv_Orders.Columns[3].Width = 200;

        }

        private void dgvDetail_Create()
        {
            dgvOrder_details.ColumnCount = 4;
            dgvOrder_details.Columns[0].Name = "id";
            dgvOrder_details.Columns[1].Name = "Mã sản phẩm";
            dgvOrder_details.Columns[2].Name = "Số";
            dgvOrder_details.Columns[3].Name = "Giá";

            dgvOrder_details.RowHeadersWidth = 20;
            dgvOrder_details.Columns[0].Width = 50;
            dgvOrder_details.Columns[1].Width = 100;
            dgvOrder_details.Columns[2].Width = 100;
            dgvOrder_details.Columns[3].Width = 100;
            dgvOrder_details.Columns[0].Visible = false;

            DataGridViewCheckBoxColumn dgvCheck = new DataGridViewCheckBoxColumn();
            dgvCheck.ValueType = typeof(bool);
            dgvCheck.Name = "check";
            dgvCheck.HeaderText = "";

            dgvOrder_details.Columns.Add(dgvCheck);
        }

        //private void dgvDetail_Load(string ord_id) {
        //    Database database = new Database();
        //    SqlDataReader dr;
        //        dr = database.LoadData(@"SELECT P.Prod_id,Prod_name,Order_qty FROM dbo.Orders O
        //    INNER JOIN dbo.Order_detail Od ON O.Order_id=Od.Order_id INNER JOIN 
        //     Product P ON Od.Prod_id=P.Prod_id");

        //    DataTable dataTable = new DataTable();
        //    dataTable.Columns.Add("ລະຫັດ");
        //    dataTable.Columns.Add("ລະຫັດສິນຄ້າ");
        //    dataTable.Columns.Add("ຈຳນວນ");
        //    dataTable.Columns.Add("ລາຄາ");
        //    while (dr.Read())
        //    {
        //        DataRow row = dataTable.NewRow();
        //        row["ລະຫັດ"] = dr["Prod_id"];
        //        row["ລະຫັດສິນຄ້າ"] = dr["Prod_name"];
        //        row["ຈຳນວນ"] = dr["Order_qty"];
        //        row["ລາຄາ"] = '0';
        //        dataTable.Rows.Add(row);
        //    }
        //    dgvOrder_details.DataSource = dataTable;
        //    dr.Close();
        //    dgvOrder_details.Columns[0].Visible = false;
        //    dgvOrder_details.Columns[1].Width = 100;
        //    dgvOrder_details.Columns[3].Width = 200;

        //}

        private void dgv_Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderNo.Text = dgv_Orders.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSupp.Text = dgv_Orders.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtOrderDate.Text = dgv_Orders.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtOrder_id.Text = dgv_Orders.Rows[e.RowIndex].Cells[0].Value.ToString();

            foreach (DataGridViewRow row in dgvOrder_details.Rows)
            {
                dgvOrder_details.Rows.Clear();
            }

            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT P.Prod_id,Prod_name,Order_qty FROM dbo.Orders O
            INNER JOIN dbo.Order_detail Od ON O.Order_id=Od.Order_id INNER JOIN 
             Product P ON Od.Prod_id=P.Prod_id WHERE O.Order_id = '"+txtOrder_id.Text+ "' AND Od.Order_is_success = 1 AND P.enable = 0");
            while (dr.Read())
            {
                dgvOrder_details.Rows.Add(
                    dr["Prod_id"].ToString(), dr["Prod_name"].ToString(),
                    dr["Order_qty"].ToString(), 0, false);
            }
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool is_Order_success = true;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Lưu nhập khẩu ? :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                string id = database.generateId("SELECT MAX(Imp_id) FROM Import").ToString();
                database.InsertData(@"INSERT INTO Import VALUES('" + id + "','" + DateTime.Now.ToString() +
                    "','" + txtTotal.Text + "','" + txtOrder_id.Text + "')");
                foreach (DataGridViewRow row in dgvOrder_details.Rows)
                {
                    int instock = 0;
                    if (row.Cells[4].Value.ToString() == "True")
                        {
                            database.InsertData(@"INSERT INTO Import_detail VALUES('" + row.Cells[0].Value.ToString() +
                            "','" + id + "','" + row.Cells[2].Value.ToString() +
                            "','" + row.Cells[3].Value.ToString() + "')");

                            database.InsertData(@"UPDATE Order_detail SET Order_is_success = 0 WHERE Prod_id ='" +
                                Convert.ToInt32(row.Cells[0].Value.ToString()) + "' AND Order_id ='"+txtOrder_id.Text+"' ");


                            SqlDataReader dr = database.LoadData(@"SELECT Prod_instock FROM Product WHERE Prod_id = '" +
                               Convert.ToInt32(row.Cells[0].Value.ToString()) + "'");
                        while (dr.Read())
                            {
                            instock = Convert.ToInt32(dr["Prod_instock"].ToString()) + Convert.ToInt32(row.Cells[2].Value);
                                database.InsertData(@"UPDATE Product SET Prod_instock = '"+ instock + "' WHERE Prod_id ='" +
                                    Convert.ToInt32(row.Cells[0].Value.ToString()) + "'");
                            }
                            dr.Close();

                        }
                        else if(row.Cells[4].Value.ToString() == "False")
                        {
                            is_Order_success = false;
                        }
                        

                }
                if(is_Order_success == true)
                {
                    database.InsertData(@"UPDATE Orders SET Orders_is_success = 0 WHERE Order_id ='" + txtOrder_id.Text + "'");

                }
                MessageBox.Show("Success...");
            }
            else
            {

            }
        }
        private void dgvOrder_details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int total = 0;
            if (dgvOrder_details.Rows[e.RowIndex].Cells[4].Value.ToString() == "False")
            {
                frmGetImportPrice frmGetImportPrice = new frmGetImportPrice();
                frmGetImportPrice.ShowDialog();
                dgvOrder_details.Rows[e.RowIndex].Cells[3].Value = detail_price;
                dgvOrder_details.Rows[e.RowIndex].Cells[4].Value = true;

                
                foreach (DataGridViewRow row in dgvOrder_details.Rows)
                {
                    total += (Convert.ToInt32(row.Cells[3].Value.ToString()) * Convert.ToInt32(row.Cells[2].Value.ToString()));
                }

            }
            else
            {
                dgvOrder_details.Rows[e.RowIndex].Cells[4].Value = false;
                foreach (DataGridViewRow row in dgvOrder_details.Rows)
                {
                    total += (Convert.ToInt32(row.Cells[3].Value.ToString())* Convert.ToInt32(row.Cells[2].Value.ToString()));
                }
                total -= (Convert.ToInt32(dgvOrder_details.Rows[e.RowIndex].Cells[3].Value.ToString())* Convert.ToInt32(dgvOrder_details.Rows[e.RowIndex].Cells[2].Value.ToString()));

            }
            txtTotal.Text = total.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvOrder_Load(txtSearch.Text);
        }
    }
}
