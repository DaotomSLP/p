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
    public partial class frmProdType : Form
    {
        SqlDataReader dr;
        SqlCommand comm;
        DataTable dataTable;
        public frmProdType()
        {
            InitializeComponent();
        }

        private void frmProdType_Load(object sender, EventArgs e)
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
            txtProdTId.Text = database.generateId("SELECT MAX(ProdType_id) FROM Product_Type").ToString();
        }
        private void LoadByAdd()
        {
            btnSave.Visible = true;
            btnDel.Visible = true;
            lblW.Visible = false;
            btnSave.Text = "Thêm";
            lblName.Text = "Thêm thông tin loại sản phẩm";
        }
        private void LoadByUpdate()
        {
            btnSave.Visible = false;
            btnDel.Visible = false;
            lblW.Visible = true;
            btnSave.Text = "Lưu thông tin sửa lại";
            lblName.Text = "Chỉnh sửa thông tin loại sản phẩm";
        }

        private void loadData()
        {
            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Product_Type WHERE enable = '0'");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã các loại sản phẩm");
            dataTable.Columns.Add("Tên Loại sản phẩm");
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Mã các loại sản phẩm"] = dr["ProdType_id"];
                row["Tên Loại sản phẩm"] = dr["ProdType_name"];
                dataTable.Rows.Add(row);
            }
            dgvProductType.DataSource = dataTable;
            dr.Close();
        }
        private void DgvColumAdd()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Product Type ID");
            dataTable.Columns.Add("Product Type Name");
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
            database.InsertData(@"INSERT INTO dbo.Product_Type VALUES('" +
                txtProdTId.Text + "',N'" + txtProdTName.Text + "','0')");
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
                database.InsertData(@"UPDATE dbo.Product_Type SET ProdType_name = N'" + txtProdTName.Text +
                    "' WHERE ProdType_id = '" + txtProdTId.Text + "'");
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
            txtProdTId.Text = database.generateId("SELECT MAX(ProdType_id) FROM Product_Type").ToString();
            txtProdTName.Clear();
        }

        private void dgvProductType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (globalVal.FrmDataStatus == "update")
            {
                btnSave.Visible = true;
                btnDel.Visible = true;
                txtProdTId.Text = dgvProductType.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProdTName.Text = dgvProductType.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Muốn xóa dữ liệu hay không :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"UPDATE dbo.Product_Type SET enable = '1' WHERE ProdType_id = '" + txtProdTId.Text + "'");
                loadData();
                ClearTextBox();
                btnDel.Visible = false;
            }
            else
            {

            }

        }
    }
}
