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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
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
            txtId.Text = database.generateId("SELECT MAX(Emp_id) FROM Employee").ToString();
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
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Employee");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ລະຫັດ");
            dataTable.Columns.Add("ຊື່");
            dataTable.Columns.Add("ເບີໂທ");
            dataTable.Columns.Add("ທີ່ຢູ່");
            dataTable.Columns.Add("ຕຳແໜ່ງ");
            dataTable.Columns.Add("ເງິນເດືອນ");
            dataTable.Columns.Add("ຮູບ");
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["ລະຫັດ"] = dr["Emp_id"];
                row["ຊື່"] = dr["Emp_name"];
                row["ເບີໂທ"] = dr["Emp_tel"];
                row["ທີ່ຢູ່"] = dr["Emp_addr"];
                row["ຕຳແໜ່ງ"] = dr["Emp_position"];
                row["ເງິນເດືອນ"] = dr["Emp_salary"];
                row["ຮູບ"] = dr["Emp_img"];
                dataTable.Rows.Add(row);
            }
            dgv.DataSource = dataTable;
            dr.Close();
        }
        private void ClearTextBox()
        {
            Database database = new Database();
            txtId.Text = database.generateId("SELECT MAX(Emp_id) FROM Employee").ToString();
            txtName.Clear();
            txtTel.Clear();
            txtAddr.Clear();
            txtImg.Clear();
            txtPosition.Clear();
            txtSalary.Clear();

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
            database.InsertData(@"INSERT INTO dbo.Employee VALUES('" +
                txtId.Text + "','" + txtName.Text + "','" + txtTel.Text +
                "','" + txtAddr.Text + "','" + txtPosition.Text + "','" + txtSalary.Text +
                "','" + txtImg.Text + "')");
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
                database.InsertData(@"UPDATE dbo.Employee SET Emp_name = '" + txtName.Text +
                    "',Emp_tel = '" + txtTel.Text + "', Emp_addr = '" + txtAddr.Text +
                    "',Emp_position = '" + txtPosition.Text + "', Emp_salary = '" + txtSalary.Text +
                     "',Emp_img = '" + txtImg.Text + "' WHERE Emp_id = '" + txtId.Text + "'");
                loadData();
                ClearTextBox();
            }
            else
            {

            }
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
                txtPosition.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSalary.Text = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtId.Text = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ ຫຼືບໍ່ :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"DELETE FROM dbo.Employee WHERE Emp_id = '" + txtId.Text + "'");
                loadData();
                ClearTextBox();
            }
            else
            {

            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                FilterIndex = 2,
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImg.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(txtImg.Text);
            }
        }
    }
}
