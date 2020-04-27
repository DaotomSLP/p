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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(globalVal.FrmDataStatus == "insert")
            {
                SaveInsert();
            }else if(globalVal.FrmDataStatus == "update")
            {
                SaveUpdate();
            }
        }
        private void SaveInsert()
        {
            Database database = new Database();
            database.InsertData(@"INSERT INTO Product VALUES('" + txtId.Text + "',N'" +
                txtName.Text + "',N'" + txtPictureName.Text + "','" +
                txtPrice.Text + "','" + comboBox1.SelectedValue + "','" +
                weigBa.Value + "','" + weigSl.Value + "','" + weigHo.Value + "','0')");
            loadData();
            ClearTextBox();
            MessageBox.Show("Insert Success ...");
        }


        private void SaveUpdate()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("ແກ້ໄຂຂໍ້ມູນ ຫຼືບໍ່ :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"UPDATE Product SET Prod_name = N'" + txtName.Text + 
                    "',Prod_img =N'" + txtPictureName.Text + "',Design_price='" + 
                    txtPrice.Text + "',ProdType_id='" + comboBox1.SelectedValue + 
                    "',Prod_weight1='" +weigBa.Value + "',Prod_weight2='" + 
                    weigSl.Value + "',Prod_weight3='" + weigHo.Value +
                    "' WHERE Prod_id='" + txtId.Text+"'");
                loadData();
                ClearTextBox();
                MessageBox.Show("Update Success ...");
                btnDel.Visible = false;
            }
            else
            {
                
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            loadData();
            ComboBoxLoad();
            Database database = new Database();
            txtId.Text = database.generateId("SELECT MAX(Prod_id) FROM Product").ToString();
            if (globalVal.FrmDataStatus == "insert")
            {
                LoadByAdd();
            }
            else if(globalVal.FrmDataStatus == "update")
            {
                LoadByUpdate();
            }

        }
        private void LoadByAdd()
        {
            weigBa.Visible = true;
            weigHo.Visible = true;
            weigSl.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label2.Visible = true;
            txtPrice.Visible = true;
            txtName.Visible = true;
            btnSave.Visible = true;
            lblW.Visible = false;
            btnDel.Visible = false;
            pictureBox1.Visible = true;
            txtPictureName.Visible = true;
            label3.Visible = true;
            btnChoose.Visible = true;
            label4.Visible = true;
            comboBox1.Visible = true;

            lblHead.Text = "ເພີ່ມຂໍ້ມູນສິນຄ້າ :";
            btnSave.Text = "ເພີ່ມ";
        }
        private void LoadByUpdate()
        {
            weigBa.Visible = true;
            weigHo.Visible = true;
            weigSl.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label2.Visible = true;
            txtPrice.Visible = true;
            txtName.Visible = true;
            btnSave.Visible = false;
            btnDel.Visible = false; 
            lblW.Visible = true;
            pictureBox1.Visible = true;
            txtPictureName.Visible = true;
            label3.Visible = true;
            btnChoose.Visible = true;
            label4.Visible = true;
            comboBox1.Visible = true;

            lblHead.Text = "ແກ້ໄຂຂໍ້ມູນສິນຄ້າ :";
            btnSave.Text = "ບັນທຶກການແກ້ໄຂ";
        }

     


        private void ComboBoxLoad()
        {
            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Product_Type");
            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
                comboBox1.DisplayMember = "ProdType_name";
                comboBox1.ValueMember = "ProdType_id";
                comboBox1.DataSource = dataTable;
            dr.Close();
        }
        private void loadData()
        {
            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Product WHERE enable = '0' ORDER BY Prod_id DESC");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ລະຫັດ");
            dataTable.Columns.Add("ຊື່ສິນຄ້າ");
            dataTable.Columns.Add("ລາຄາລາຍ");
            dataTable.Columns.Add("ນ້ຳໜັກ(ບາດ)");
            dataTable.Columns.Add("ນ້ຳໜັກ(ສະຫຼຶງ)");
            dataTable.Columns.Add("ນ້ຳໜັກ(ຫຸນ)");
            dataTable.Columns.Add("ຈຳນວນ");
            dataTable.Columns.Add("ຮູບ");
            while (dr.Read())
            {
                DataRow row = dataTable.NewRow();
                row["ລະຫັດ"] = dr["Prod_id"];
                row["ຊື່ສິນຄ້າ"] = dr["Prod_name"];
                row["ລາຄາລາຍ"] = dr["Design_price"];
                row["ນ້ຳໜັກ(ບາດ)"] = dr["Prod_weight1"];
                row["ນ້ຳໜັກ(ສະຫຼຶງ)"] = dr["Prod_weight2"];
                row["ນ້ຳໜັກ(ຫຸນ)"] = dr["Prod_weight3"];
                row["ຮູບ"] = dr["Prod_img"];
                row["ຈຳນວນ"] = dr["Prod_instock"];
                dataTable.Rows.Add(row);
            }
            dgvProduct.DataSource = dataTable;
            dr.Close();
        }

        private void ClearTextBox()
        {
            txtName.Clear();
            txtPictureName.Clear();
            txtPrice.Clear();
            pictureBox1.Image = pictureBox1.ErrorImage;
            Database database = new Database();
            txtId.Text = database.generateId("SELECT MAX(Prod_id) FROM Product").ToString();
        }

        private void btnOpenImageDialog_Click(object sender, EventArgs e)
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
                txtPictureName.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(txtPictureName.Text);
            }
        }

        private void dgvProduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (globalVal.FrmDataStatus == "update")
            {
                btnSave.Visible = true;
                btnDel.Visible = true;
                txtId.Text = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                weigBa.Value = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[3].Value);
                weigSl.Value = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[4].Value);
                weigHo.Value = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[5].Value);
                txtPictureName.Text = dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
                pictureBox1.Image = Image.FromFile(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ ຫຼືບໍ່ :", "", buttons);
            if (result == DialogResult.Yes)
            {
                Database database = new Database();
                database.InsertData(@"UPDATE dbo.Product SET enable = '1'  WHERE Prod_id='" + txtId.Text + "'");
                loadData();
                ClearTextBox();
                MessageBox.Show("Delete Success ...");
                btnDel.Visible = false;
            }
            else
            {

            }
        }
    }
}
