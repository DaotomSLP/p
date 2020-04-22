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
    public partial class Sale_Order : Form
    {
        public Sale_Order()
        {
            InitializeComponent();
        }
        int dgvSelRow = 0;
         int total = 0;
        private void Sale_Order_Load(object sender, EventArgs e)
        {
            if(globalVal.FrmSaleOrderStatus == "sale")
            {
                Sale_load();
            }
            else if(globalVal.FrmSaleOrderStatus == "order")
            {
                Order_load();
            }
        }

        private void Sale_load()
        {
            lblTatal.Visible = true;
            cboSupp.Visible = false;
            lblHead.Text = "ການຂາຍ";
            label1.Text = "Total";
            DgvLoad();
            loadProduct("WHERE Prod_instock > 0 Order by Prod_id DESC");
            ComboBoxLoadProd_type();
            Database database = new Database();
            txtId.Text = database.generateId("SELECT MAX(Sale_id) FROM Sale").ToString();
        }

        private void Order_load()
        {
            lblTatal.Visible = false;
            cboSupp.Visible = true;
            label1.Text = "ຜູ້ສະໜອງສິນຄ້າ";
            lblHead.Text = "ການສັ່ງຊື້";
            DgvLoad();
            loadProduct("Order by Prod_id DESC");
            ComboBoxLoadProd_type();
            Database database = new Database();
            txtId.Text = database.generateId("SELECT MAX(Order_id) FROM Orders").ToString();
            ComboBoxLoadSupplier();
        }



        private void DgvLoad()
        {
            if (globalVal.FrmSaleOrderStatus == "sale")
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
            else if(globalVal.FrmSaleOrderStatus == "order")
            {
                dgv.ColumnCount = 3;
                dgv.Columns[0].Name = "ລະຫັດ";
                dgv.Columns[1].Name = "ຊື່ສິນຄ້າ";
                dgv.Columns[2].Name = "ຈຳນວນ";

                dgv.RowHeadersWidth = 20;
                dgv.Columns[0].Width = 50;
                dgv.Columns[1].Width = 200;
                dgv.Columns[2].Width = 200;
                dgv.Columns[0].Visible = false;
            }
        }
        private void ComboBoxLoadProd_type()
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
        private void ComboBoxLoadSupplier()
        {
            Database database = new Database();
            SqlDataReader dr = database.LoadData(@"SELECT * FROM dbo.Supplier");
            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
            cboSupp.DisplayMember = "Supp_name";
            cboSupp.ValueMember = "Supp_id";
            cboSupp.DataSource = dataTable;
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
            numeric.Minimum = 1;
            numeric.Dock = DockStyle.Right;
            if(globalVal.FrmSaleOrderStatus == "sale")
            {
                numeric.Maximum = Convert.ToInt32(product[8].ToString());
            }

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
                    label2.Text = "ລາຄາ : " + price.ToString() + "  (ກີບ) :";
                    textBox.Text = price.ToString();
                }
                else if (Convert.ToInt32(product[i]) > 0 && i == 6)
                {
                    label.Text = "ນ້ຳໜັກ  " + product[i].ToString() + " ສະຫຼຶງ";
                    while (dr.Read())
                    {
                        price = Convert.ToInt32(product[3]) + (Convert.ToInt32(dr[2]) * Convert.ToInt32(product[i]));
                    }
                    label2.Text = "ລາຄາ : "+ price.ToString() + "  (ກີບ) :";
                    textBox.Text = price.ToString();
                }
                else if (Convert.ToInt32(product[i]) > 0 && i == 7)
                {
                    label.Text = "ນ້ຳໜັກ  " + product[i].ToString() + " ຫຸນ";
                    while (dr.Read())
                    {
                        price = Convert.ToInt32(product[3]) + (Convert.ToInt32(dr[3]) * Convert.ToInt32(product[i]));
                    }
                    label2.Text = "ລາຄາ : " + price.ToString() + "  (ກີບ) :";
                        textBox.Text= price.ToString();
                }

                textBox.Visible = false;
            }
            labelDesignPri.Text = "ລາຄາລາຍ : "+product[3];
            labelDesignPri.ForeColor = Color.Black;
            labelDesignPri.Font = new Font("Phetsarath OT", 12, FontStyle.Regular);
            labelDesignPri.Dock = DockStyle.Bottom;

            label.ForeColor = Color.Black;
            label.Font = new Font("Phetsarath OT", 12, FontStyle.Regular);
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

            if(globalVal.FrmSaleOrderStatus == "order")
            {
                labelDesignPri.Visible = false;
                label2.Visible = false;
                label.Visible = false;
                group.Height = 200;
            }

            button.Click += new EventHandler(button_Click);

                    
        }
        protected void button_Click(object sender, EventArgs e)
        {
            if(globalVal.FrmSaleOrderStatus == "sale")
            {
                onSelectItems_bySale(sender);
            }
            else if(globalVal.FrmSaleOrderStatus == "order")
            {
                onSelectItems_byOrder(sender);
            }
        }

        private void onSelectItems_bySale(object sender)
        {
            string count = "";
            string name = "";
            string weight = "";
            int price = 0;
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
                                price = Convert.ToInt32(text.Text);
                            }
                        }
                    }
                    foreach (DataGridViewRow rows in dgv.Rows)
                    {
                        //MessageBox.Show(row.Cells[0].Value);
                        if (Convert.ToString(rows.Cells[0].Value) == button.Name)
                        {
                            total -= Convert.ToInt32(rows.Cells[5].Value.ToString());
                            dgv.Rows.Remove(rows);
                        }
                    }

                    Database database = new Database();
                    SqlDataReader dr = database.LoadData(@"SELECT Design_price,Prod_weight1,Prod_weight2,Prod_weight3 FROM dbo.Product WHERE Prod_id = '" + groupBox.Name + "'");
                    while (dr.Read())
                    {
                        DsPrice = dr["Design_price"].ToString();
                        if (dr["Prod_weight1"].ToString() != "0")
                        {
                            weight = dr["Prod_weight1"].ToString() + " ບາດ";
                        }
                        else if (dr["Prod_weight2"].ToString() != "0")
                        {
                            weight = dr["Prod_weight2"].ToString() + " ສະຫຼຶງ";
                        }
                        else if (dr["Prod_weight3"].ToString() != "0")
                        {
                            weight = dr["Prod_weight3"].ToString() + " ຫຸນ";
                        }
                    }
                    dr.Close();

                    price *= Convert.ToInt32(count);

                    string[] row = new string[] { id, name, DsPrice, weight, count, price.ToString() };
                    dgv.Rows.Add(row);
                    total += Convert.ToInt32(price);
                    lblTatal.Text = total.ToString();

                }

            }
        }
        private void onSelectItems_byOrder(object sender)
        {
            string count = "";
            string name = "";
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
                    }
                    foreach (DataGridViewRow rows in dgv.Rows)
                    {
                        //MessageBox.Show(row.Cells[0].Value);
                        if (Convert.ToString(rows.Cells[0].Value) == button.Name)
                        {
                            dgv.Rows.Remove(rows);
                        }
                    }

                    string[] row = new string[] { id, name, count };
                    dgv.Rows.Add(row);

                }

            }
        }

        private void btnDelLi_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.Rows.RemoveAt(dgvSelRow);
                if (globalVal.FrmSaleOrderStatus == "sale")
                {
                    string price = "";
                    price = dgv.Rows[dgvSelRow].Cells[5].Value.ToString();

                    total -= Convert.ToInt32(price);
                    lblTatal.Text = total.ToString();
                }
            }
            catch
            {
                MessageBox.Show("list is empty");
            }


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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (globalVal.FrmSaleOrderStatus == "sale")
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("ພິມໃບບິນ ? :", "", buttons);
                if (result == DialogResult.Yes)
                {

                    Database database = new Database();
                    int Bill_no = 0;
                    Bill_no = Convert.ToInt32(database.generateBillNo("SELECT MAX(Bill_no) from Sale"));
                    database.InsertData(@"INSERT INTO Sale VALUES('" + txtId.Text + "','" + DateTime.Now.ToString() +
                        "','" + lblTatal.Text + "','" + Bill_no.ToString() + "')");

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        database.InsertData(@"INSERT INTO Sale_Detail VALUES('" +
                                txtId.Text + "','" + Convert.ToInt32(row.Cells[0].Value) +
                                "','" + row.Cells[4].Value + "','" + Convert.ToDecimal(row.Cells[5].Value) + "')");

                            SqlDataReader dr = database.LoadData(@"SELECT Prod_instock FROM Product WHERE Prod_id = '" +
                           Convert.ToInt32(row.Cells[0].Value.ToString()) + "'");
                            while (dr.Read())
                            {
                               int instock = Convert.ToInt32(dr["Prod_instock"].ToString()) - Convert.ToInt32(row.Cells[4].Value);
                        
                                database.InsertData(@"UPDATE Product SET Prod_instock = '" + instock + "' WHERE Prod_id ='" +
                                    Convert.ToInt32(row.Cells[0].Value.ToString()) + "'");
                            }
                            dr.Close();
                    }
                    rerunForm();
                    MessageBox.Show("Success...");
                }
                else
                {

                }
            }
            else if(globalVal.FrmSaleOrderStatus == "order")
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("ພິມໃບສັ່ງຊື້ ? :", "", buttons);
                if (result == DialogResult.Yes)
                {
                    Database database = new Database();
                    int Order_no = 0;
                    Order_no = Convert.ToInt32(database.generateBillNo("SELECT MAX(Order_no) from Orders"));
                    database.InsertData(@"INSERT INTO Orders VALUES('" + txtId.Text + "','" + DateTime.Now.ToString() + "','" + Order_no.ToString() + "','" + cboSupp.SelectedValue + "','1')");
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        try
                        {
                            database.InsertData(@"INSERT INTO Order_Detail VALUES('" + Convert.ToInt32(row.Cells[0].Value) + "','" + txtId.Text + "','" + row.Cells[2].Value + "','1')");
                        }
                        catch
                        {

                        }
                    }     
                    rerunForm();
                    MessageBox.Show("Success...");
                }
                else
                {

                }
            }

        }

        private void rerunForm()
        {
            dgv.Rows.Clear();


            if(globalVal.FrmSaleOrderStatus == "sale")
            {
                Database database = new Database();
                txtId.Text = database.generateId("SELECT MAX(Sale_id) FROM Sale").ToString();
                Sale_load();
            }
            else if(globalVal.FrmSaleOrderStatus == "order")
            {
                Database database = new Database();
                txtId.Text = database.generateId("SELECT MAX(Order_id) FROM Orders").ToString();
            }

        }
    }
}
