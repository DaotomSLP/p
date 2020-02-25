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
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Supplier");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ລະຫັດ");
            dataTable.Columns.Add("ຊື່");
            dataTable.Columns.Add("ເບີໂທ");
            dataTable.Columns.Add("ທີ່ຢູ່");
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["ລະຫັດ"] = dr["Supp_id"];
                row["ຊື່"] = dr["Supp_name"];
                row["ເບີໂທ"] = dr["Supp_tel"];
                row["ທີ່ຢູ່"] = dr["Supp_addr"];
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
                txtId.Text + "','" + txtName.Text + "','" + txtTel.Text +
                "','" + txtAddr.Text + "')");
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
                database.InsertData(@"UPDATE dbo.Supplier SET Supp_name = '" + txtName.Text +
                    "',Supp_tel = '"+txtTel.Text+"', Supp_addr = '"+txtAddr.Text+
                    "' WHERE Supp_id = '" + txtId.Text + "'");
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
            DialogResult result = MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ ຫຼືບໍ່ :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"DELETE FROM dbo.Supplier WHERE Supp_id = '" + txtId.Text + "'");
                loadData();
                ClearTextBox();
            }
            else
            {

            }
        }
    }
}
