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
    public partial class frmDailyPrice : Form
    {
        SqlDataReader dr;
        SqlCommand comm;
        DataTable dataTable;
        public frmDailyPrice()
        {
            InitializeComponent();
        }

        private void frmDailyPrice_Load(object sender, EventArgs e)
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
            txtId.Text = database.generateId("SELECT MAX(DailyPrice_id) FROM Daily_Price").ToString();
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
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Daily_Price");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ວັນທີ່");
            dataTable.Columns.Add("ລາຄາຕໍ່ 1 ບາດ");
            dataTable.Columns.Add("ລາຄາຕໍ່ 1 ສະຫຼຶງ");
            dataTable.Columns.Add("ລາຄາຕໍ່ 1 ຫຸນ");
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["ວັນທີ່"] = dr["DailyPrice_Date"];
                row["ລາຄາຕໍ່ 1 ບາດ"] = dr["DailyPrice_Ba"];
                row["ລາຄາຕໍ່ 1 ສະຫຼຶງ"] = dr["DailyPrice_Sl"];
                row["ລາຄາຕໍ່ 1 ຫຸນ"] = dr["DailyPrice_Ho"];
                dataTable.Rows.Add(row);
            }
            dgv.DataSource = dataTable;
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.InsertData(@"INSERT INTO dbo.Daily_Price VALUES('" +
                txtId.Text + "','" + txtBa.Text + "','"+txtSl.Text+"','"+txtHo.Text+
                "','"+dtpDate.Value+"')");
            loadData();
            ClearTextBox();
        }
        private void ClearTextBox()
        {
            txtBa.Clear();
            txtHo.Clear();
            txtSl.Clear();
            Database database = new Database();
            txtId.Text = database.generateId("SELECT MAX(DailyPrice_id) FROM Daily_Price").ToString();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (globalVal.FrmDataStatus == "update")
            {
                btnDel.Visible = true;
                txtId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBa.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSl.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtHo.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ ຫຼືບໍ່ :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"DELETE FROM dbo.Daily_Price WHERE DailyPrice_id = '" + txtId.Text + "'");
                loadData();
                ClearTextBox();
            }
            else
            {

            }
        }
    }
}
