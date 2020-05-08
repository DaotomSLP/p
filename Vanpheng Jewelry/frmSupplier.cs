using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vanpheng_Jewelry
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            if (globalVal.FrmDataStatus == "insert")
            {
                LoadByAdd();
            }
            else if (globalVal.FrmDataStatus == "update")
            {
                LoadByUpdate();
            }
            loadData();
            Database database = new Database();
            txtId.Text = database.generateId("SELECT MAX(Supp_id) FROM Supplier").ToString();
        }
        private void LoadByAdd()
        {
            btnSave.Visible = true;
            btnDel.Visible = false;
            lblW.Visible = false;
            btnSave.Text = "Thêm";
            lblName.Text = "Thêm thông tin nhà cũng cấp";
        }
        private void LoadByUpdate()
        {
            btnSave.Visible = false;
            btnDel.Visible = false;
            lblW.Visible = true;
            btnSave.Text = "Lưu thông tin sửa lại";
            lblName.Text = "Chỉnh sửa thông tin nhà cũng cấp";
        }
        private void loadData()
        {
            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Supplier WHERE enable = '0'");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("Tên");
            dataTable.Columns.Add("Số điện thoại");
            dataTable.Columns.Add("Địa chỉ");
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["id"] = dr["Supp_id"];
                row["Tên"] = dr["Supp_name"];
                row["Số điện thoại"] = dr["Supp_tel"];
                row["Địa chỉ"] = dr["Supp_addr"];
                dataTable.Rows.Add(row);
            }
            dgv.DataSource = dataTable;
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (globalVal.FrmDataStatus == "insert")
            {
                SaveInsert();
            }
            else if (globalVal.FrmDataStatus == "update")
            {
                SaveUpdate();
            }
        }
        private void SaveInsert()
        {
            Database database = new Database();
            database.InsertData(@"INSERT INTO dbo.Supplier VALUES('" +
                txtId.Text + "',N'" + txtName.Text + "',N'" + txtTel.Text +
                "',N'" + txtAddr.Text + "','0')");
            loadData();
            ClearTextBox();
        }
        private void SaveUpdate()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Có cần chỉnh sửa dữ liệu hay không :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"UPDATE dbo.Supplier SET Supp_name = N'" + txtName.Text +
                    "',Supp_tel = N'"+txtTel.Text+"', Supp_addr = N'"+txtAddr.Text+
                    "' WHERE Supp_id = '" + txtId.Text + "'");
                loadData();
                ClearTextBox();
                btnDel.Visible = false;
            }
            else
            {

            }
        }
        private void ClearTextBox()
        {
            Database database = new Database();
            txtId.Text = database.generateId("SELECT MAX(Supp_id) FROM Supplier").ToString();
            txtName.Clear();
            txtTel.Clear();
            txtAddr.Clear();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (globalVal.FrmDataStatus == "update")
            {
                btnSave.Visible = true;
                btnDel.Visible = true;
                txtId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTel.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddr.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Muốn xóa dữ liệu hay không :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"UPDATE dbo.Supplier SET enable = '1' WHERE Supp_id = '" + txtId.Text + "'");
                loadData();
                ClearTextBox();
                btnDel.Visible = false;
            }
            else
            {

            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
