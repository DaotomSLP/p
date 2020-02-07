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
        SqlDataReader dr;
        SqlCommand comm;
        DataTable dataTable;
        public string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\work\windowbase\Vanpheng Jewelry\Vanpheng Jewelry\Database1.mdf;Integrated Security=True";
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {

            loadProduct();
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (GroupBox groupBox in flowLayoutPanel1.Controls)
            {
                if (groupBox.Name == button.Name)
                {
                    try
                    {
                        foreach (NumericUpDown numeric in groupBox.Controls)
                        {
                            if (numeric is NumericUpDown)
                            {
                                string count = Convert.ToString(numeric.Value);
                                MessageBox.Show(count);
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
        public void loadProduct()
        {
            SqlConnection sqlConn = new SqlConnection(connstr);
            sqlConn.Open();
            comm = new SqlCommand(@"SELECT * FROM dbo.Product", sqlConn);
            dr = comm.ExecuteReader();
            dataTable = new DataTable();

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
            group.Height = 240;
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
            picture.Image = Image.FromFile("D:\\work\\windowbase\\Vanpheng Jewelry\\image\\pp.jfif");
            picture.Dock = DockStyle.Left;

            Label label = new Label();
            label.Text = "ນ້ຳໜັກ";
            label.ForeColor = Color.Crimson;
            label.Font = new Font("Phetsarath OT", 12, FontStyle.Bold);
            label.Dock = DockStyle.Bottom;

            group.Controls.Add(numeric);
            group.Controls.Add(picture);
            group.Controls.Add(label);
            group.Controls.Add(button);
            flowLayoutPanel1.Controls.Add(group);

            button.Click += new EventHandler(button_Click);
        }
    }
}
