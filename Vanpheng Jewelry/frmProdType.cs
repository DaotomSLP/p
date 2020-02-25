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
            btnSave.Text = "ເພີ່ມ";
        }
        private void LoadByUpdate()
        {
            btnSave.Visible = false;
            btnDel.Visible = false;
            lblW.Visible = true;
            btnSave.Text = "ບັນທຶກການແກ້ໄຂ";
        }

        private void loadData()
        {
            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Product_Type");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ລະຫັດ");
            dataTable.Columns.Add("ຊື່ປະເພດສິນຄ້າ");
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["ລະຫັດ"] = dr["ProdType_id"];
                row["ຊື່ປະເພດສິນຄ້າ"] = dr["ProdType_name"];
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
                txtProdTId.Text + "','" + txtProdTName.Text + "')");
            loadData();
            ClearTextBox();
        }
        private void SaveUpdate()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("ຕ້ອງການແກ້ໄຂຂໍ້ມູນ ຫຼືບໍ່ :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"UPDATE dbo.Product_Type SET ProdType_name = '" + txtProdTName.Text +
                    "' WHERE ProdType_id = '" + txtProdTId.Text + "'");
                loadData();
                ClearTextBox();
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
            DialogResult result = MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ ຫຼືບໍ່ :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"DELETE FROM dbo.Product_Type WHERE ProdType_id = '" + txtProdTId.Text + "'");
                loadData();
                ClearTextBox();
            }
            else
            {

            }

        }
    }
}
