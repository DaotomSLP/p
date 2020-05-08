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
            btnDel.Visible = false;
            lblW.Visible = false;
            btnSave.Text = "Thêm";
            lblName.Text = "Thêm thông tin nhân viên";
        }
        private void LoadByUpdate()
        {
            if(globalVal.User == "Admin")
            {
                label7.Visible = true;
                label8.Visible = true;
                txtUser.Visible = true;
                txtPassword.Visible = true;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                label7.Visible = false;
                label8.Visible = false;
                txtUser.Visible = false;
                txtPassword.Visible = false;
            }
            btnSave.Visible = false;
            btnDel.Visible = false;
            lblW.Visible = true;
            btnSave.Text = "Lưu thông tin sửa lại";
            lblName.Text = "Chỉnh sửa thông tin nhân viên";
        }
        private void loadData()
        {
            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Employee");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("Tên");
            dataTable.Columns.Add("Số điện thoại");
            dataTable.Columns.Add("Địa chỉ");
            dataTable.Columns.Add("Chức vụ");
            dataTable.Columns.Add("Tiền lương");
            dataTable.Columns.Add("Mẫu");
            if(globalVal.User == "Admin")
            {
                dataTable.Columns.Add("user name");
                dataTable.Columns.Add("password");
            }
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["id"] = dr["Emp_id"];
                row["Tên"] = dr["Emp_name"];
                row["Số điện thoại"] = dr["Emp_tel"];
                row["Địa chỉ"] = dr["Emp_addr"];
                row["Chức vụ"] = dr["Emp_position"];
                row["Tiền lương"] = dr["Emp_salary"];
                row["Mẫu"] = dr["Emp_img"];
                if (globalVal.User == "Admin")
                {
                    row["user name"] = dr["UserName"];
                    row["password"] = dr["Password"];
                }
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
            pictureBox1.Image = pictureBox1.ErrorImage;
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
                txtId.Text + "',N'" + txtName.Text + "',N'" + txtTel.Text +
                "',N'" + txtAddr.Text + "',N'" + txtPosition.Text + "','" + txtSalary.Text +
                "',N'" + txtImg.Text + "',N'"+txtUser.Text+"',N'"+txtPassword.Text+"')");
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
                if (globalVal.User == "Admin")
                {
                    database.InsertData(@"UPDATE dbo.Employee SET Emp_name = N'" + txtName.Text +
                    "',Emp_tel = N'" + txtTel.Text + "', Emp_addr = N'" + txtAddr.Text +
                    "',Emp_position = N'" + txtPosition.Text + "', Emp_salary = '" + txtSalary.Text +
                     "',Emp_img = N'" + txtImg.Text + "',UserName = N'"+txtUser.Text+"', Password = N'"+
                     txtPassword.Text+"' WHERE Emp_id = '" + txtId.Text + "'");
                }
                else
                {
                    database.InsertData(@"UPDATE dbo.Employee SET Emp_name = N'" + txtName.Text +
                    "',Emp_tel = N'" + txtTel.Text + "', Emp_addr = N'" + txtAddr.Text +
                    "',Emp_position = N'" + txtPosition.Text + "', Emp_salary = '" + txtSalary.Text +
                     "',Emp_img = N'" + txtImg.Text + "' WHERE Emp_id = '" + txtId.Text + "'");
                }

                loadData();
                ClearTextBox();
                btnDel.Visible = false;
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
                txtImg.Text = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                pictureBox1.Image = Image.FromFile(dgv.Rows[e.RowIndex].Cells[6].Value.ToString());
                if (globalVal.User == "Admin")
                {
                    txtUser.Text = dgv.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtPassword.Text = dgv.Rows[e.RowIndex].Cells[8].Value.ToString();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Muốn xóa dữ liệu hay không :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"DELETE FROM dbo.Employee WHERE Emp_id = '" + txtId.Text + "'");
                loadData();
                ClearTextBox();
                btnDel.Visible = false;
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
