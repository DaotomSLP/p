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
using System.IO;
namespace Vanpheng_Jewelry
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }
        int dgvSelRow = 0;
         int total = 0;
        private void Sale_Load(object sender, EventArgs e)
        {
            DgvLoad();
        loadProduct("Order by Prod_id DESC");
            ComboBoxLoad();
        }

        private void DgvLoad()
        {
            dgv.ColumnCount = 6;
            dgv.Columns[0].Name = "ລະຫັດ";
            dgv.Columns[1].Name = "ຊື່ສິນຄ້າ";
            dgv.Columns[2].Name = "ລາຄາລາຍ";
            dgv.Columns[3].Name = "ນ້ຳໜັກ";
            dgv.Columns[4].Name = "ຈຳນວນ";
            dgv.Columns[5].Name = "ລາຄາ";

            dgv.RowHeadersWidth = 20;
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 80;
            dgv.Columns[2].Width = 110;
            dgv.Columns[3].Width = 60;
            dgv.Columns[4].Width = 60;
            dgv.Columns[5].Width = 110;
            dgv.Columns[0].Visible = false;
        }
        private void ComboBoxLoad()
        {
            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT TOP 30 * FROM dbo.Product_Type");
            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
            comboBox1.DisplayMember = "ProdType_name";
            comboBox1.ValueMember = "ProdType_id";
            comboBox1.DataSource = dataTable;
            dr.Close();
        }
        public void loadProduct(string queryCon)
        {
            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Product "+queryCon);
            while (dr.Read())
            {
                showProduct((IDataRecord)dr);
            }
            dr.Close();
        }

        public void showProduct(IDataRecord product)
        {
            GroupBox group = new GroupBox();
            group.Text = product[1].ToString();
            group.Font = new Font("Phetsarath OT", 12, FontStyle.Bold);
            group.Height = 300;
            group.Name = product[0].ToString();
            group.ForeColor = Color.Crimson;

            Button button = new Button();
            button.Text = "ເພີ່ມ";
            button.ForeColor = Color.White;
            button.Font = new Font("Phetsarath OT", 12, FontStyle.Bold);
            button.Name = product[0].ToString();
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.Salmon;
            button.Height = 30;
            button.Dock = DockStyle.Bottom;

            NumericUpDown numeric = new NumericUpDown();
            numeric.Width = 40;
            numeric.Name = button.Name = product[0].ToString();
            numeric.Value = 1;
            numeric.Dock = DockStyle.Right;

            PictureBox picture = new PictureBox();
            picture.Height = 100;
            picture.Width = 150;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Image = Image.FromFile(product[2].ToString());
            picture.Dock = DockStyle.Left;

            int price=0;
            Label labelDesignPri = new Label();
            Label label2 = new Label();
            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Daily_Price WHERE DailyPrice_id = (SELECT MAX(DailyPrice_id) FROM dbo.Daily_Price)");
            Label label = new Label();
            TextBox textBox = new TextBox();
            for(int i = 5; i <= 7; i++)
            {
                string w = product[i].ToString();
                if (Convert.ToInt32(w) > 0 && i==5)
                {
                    label.Text = "ນ້ຳໜັກ  "+product[i].ToString()+" ບາດ";
                    
                    while (dr.Read())
                    {
                        price =Convert.ToInt32( product[3]) + (Convert.ToInt32(dr[1])* Convert.ToInt32(product[i]));
                    }
                    label2.Text = "ລາຄາ  (ກີບ) :";
                    textBox.Text = price.ToString();
                }
                else if (Convert.ToInt32(product[i]) > 0 && i == 6)
                {
                    label.Text = "ນ້ຳໜັກ  " + product[i].ToString() + " ສະຫຼຶງ";
                    while (dr.Read())
                    {
                        price = Convert.ToInt32(product[3]) + (Convert.ToInt32(dr[2]) * Convert.ToInt32(product[i]));
                    }
                    label2.Text = "ລາຄາ  (ກີບ) :";
                    textBox.Text = price.ToString();
                }
                else if (Convert.ToInt32(product[i]) > 0 && i == 7)
                {
                    label.Text = "ນ້ຳໜັກ  " + product[i].ToString() + " ຫຸນ";
                    while (dr.Read())
                    {
                        price = Convert.ToInt32(product[3]) + (Convert.ToInt32(dr[3]) * Convert.ToInt32(product[i]));
                    }
                    label2.Text = "ລາຄາ  (ກີບ) :";
                        textBox.Text= price.ToString();
                }
            }
            labelDesignPri.Text = "ລາຄາລາຍ : "+product[3];
            labelDesignPri.ForeColor = Color.Crimson;
            labelDesignPri.Font = new Font("Phetsarath OT", 12, FontStyle.Bold);
            labelDesignPri.Dock = DockStyle.Bottom;

            label.ForeColor = Color.Crimson;
            label.Font = new Font("Phetsarath OT", 12, FontStyle.Bold);
            label.Dock = DockStyle.Bottom;

            textBox.ForeColor = Color.Crimson;
            textBox.BackColor = Color.Moccasin;
            textBox.Font = new Font("Phetsarath OT", 12);
            textBox.Dock = DockStyle.Bottom;
            textBox.Enabled = false;


            label2.ForeColor = Color.Crimson;
            label2.Font = new Font("Phetsarath OT", 12, FontStyle.Bold);
            label2.Dock = DockStyle.Bottom;

            
            group.Controls.Add(numeric);
            group.Controls.Add(picture);
            group.Controls.Add(labelDesignPri);
            group.Controls.Add(label);
            group.Controls.Add(label2);
            group.Controls.Add(textBox);
            group.Controls.Add(button);
            flowLayoutPanel1.Controls.Add(group);

            button.Click += new EventHandler(button_Click);
        }
        protected void button_Click(object sender, EventArgs e)
        {
            string count = "";
            string name = "";
            string weight = "";
            string price = "";
            string DsPrice = "";
            string id = "";
            Button button = sender as Button;
            foreach (GroupBox groupBox in flowLayoutPanel1.Controls)
            {
                if (groupBox.Name == button.Name)
                {
                    try
                    {
                        id = groupBox.Name;
                        name = groupBox.Text;
                        foreach (NumericUpDown numeric in groupBox.Controls)
                        {
                            if (numeric is NumericUpDown)
                            {
                                count = Convert.ToString(numeric.Value);
                            }
                        }
                    }
                    catch
                    {
                        foreach (Control text in groupBox.Controls)
                        {
                            if (text is TextBox)
                            {
                                price = text.Text;
                            }
                        }
                    }

                    Database database = new Database();
                        SqlDataReader dr = database.LoadData(@"SELECT Design_price,Prod_weight1,Prod_weight2,Prod_weight3 FROM dbo.Product WHERE Prod_id = '" + groupBox.Name+"'");
                        while (dr.Read())
                        {
                        DsPrice = dr["Design_price"].ToString();
                           if( dr["Prod_weight1"].ToString() != "0")
                            {
                                weight = dr["Prod_weight1"].ToString() + " ບາດ";
                            }
                            else if(dr["Prod_weight2"].ToString() != "0")
                            {
                                weight = dr["Prod_weight2"].ToString()+" ສະຫຼຶງ";
                            }
                            else if(dr["Prod_weight3"].ToString() != "0")
                            {
                                weight = dr["Prod_weight3"].ToString() + " ຫຸນ";
                            }
                        }
                        dr.Close();

                        string[] row = new string[] {id, name, DsPrice, weight, count,price };
                        dgv.Rows.Add(row);
                    total += Convert.ToInt32(price);
                    lblTatal.Text = total.ToString();
                }
            }
        }

        private void btnDelLi_Click(object sender, EventArgs e)
        {
            string price = "";
            price =  dgv.Rows[dgvSelRow].Cells[5].Value.ToString();
            dgv.Rows.RemoveAt(dgvSelRow);
            total -= Convert.ToInt32(price);
            lblTatal.Text = total.ToString();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSelRow = e.RowIndex;
        }

        private void btnSearchbyNo_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadProduct("WHERE Prod_id = '"+txtSearch1.Text+ "' OR Prod_name = '" + txtSearch1.Text + "' Order by Prod_id DESC");
        }

        private void btnSearchbyCate_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadProduct("WHERE ProdType_id = '" + comboBox1.SelectedValue + "' Order by Prod_id DESC");
        }
    }
}
