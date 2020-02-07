namespace Vanpheng_Jewelry
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.panelDataSubMenu = new System.Windows.Forms.Panel();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnMenuSale = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Brand = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnAddProdType = new System.Windows.Forms.Button();
            this.btnAddPrice = new System.Windows.Forms.Button();
            this.btnAddSupp = new System.Windows.Forms.Button();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelDataSubMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.panelDataSubMenu);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnData);
            this.panel1.Controls.Add(this.btnMenuSale);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 715);
            this.panel1.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReport.Location = new System.Drawing.Point(0, 461);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(217, 40);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "ລາຍງານ";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // panelDataSubMenu
            // 
            this.panelDataSubMenu.BackColor = System.Drawing.Color.Goldenrod;
            this.panelDataSubMenu.Controls.Add(this.btnAddEmp);
            this.panelDataSubMenu.Controls.Add(this.btnAddCus);
            this.panelDataSubMenu.Controls.Add(this.btnAddSupp);
            this.panelDataSubMenu.Controls.Add(this.btnAddPrice);
            this.panelDataSubMenu.Controls.Add(this.btnAddProdType);
            this.panelDataSubMenu.Controls.Add(this.btnAddProd);
            this.panelDataSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataSubMenu.Location = new System.Drawing.Point(0, 204);
            this.panelDataSubMenu.Name = "panelDataSubMenu";
            this.panelDataSubMenu.Size = new System.Drawing.Size(217, 257);
            this.panelDataSubMenu.TabIndex = 16;
            this.panelDataSubMenu.Visible = false;
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProd.FlatAppearance.BorderSize = 0;
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProd.Location = new System.Drawing.Point(0, 0);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddProd.Size = new System.Drawing.Size(217, 40);
            this.btnAddProd.TabIndex = 15;
            this.btnAddProd.Text = "ຂໍ້ມູນສິນຄ້າ";
            this.btnAddProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(0, 606);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(217, 109);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "ອອກຈາກລະບົບ";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Transparent;
            this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.Location = new System.Drawing.Point(0, 164);
            this.btnData.Name = "btnData";
            this.btnData.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnData.Size = new System.Drawing.Size(217, 40);
            this.btnData.TabIndex = 10;
            this.btnData.Text = "ເພີ່ມຂໍ້ມູນ";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnMenuSale
            // 
            this.btnMenuSale.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSale.FlatAppearance.BorderSize = 0;
            this.btnMenuSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSale.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSale.Location = new System.Drawing.Point(0, 124);
            this.btnMenuSale.Name = "btnMenuSale";
            this.btnMenuSale.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenuSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenuSale.Size = new System.Drawing.Size(217, 40);
            this.btnMenuSale.TabIndex = 11;
            this.btnMenuSale.Text = "ການຂາຍ";
            this.btnMenuSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuSale.UseVisualStyleBackColor = false;
            this.btnMenuSale.Click += new System.EventHandler(this.btnMenuSale_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.Brand);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 124);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.Location = new System.Drawing.Point(12, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 3);
            this.panel5.TabIndex = 2;
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.BackColor = System.Drawing.Color.Transparent;
            this.Brand.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Brand.Location = new System.Drawing.Point(12, 26);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(185, 60);
            this.Brand.TabIndex = 1;
            this.Brand.Text = "TYNA\r\ninspiration of silk";
            this.Brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Location = new System.Drawing.Point(240, 660);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 54);
            this.panel2.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTime.Location = new System.Drawing.Point(783, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 25);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "lblTime";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDate.Location = new System.Drawing.Point(451, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 25);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "lblDate";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUserName.Location = new System.Drawing.Point(230, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(114, 25);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "UserName";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(217, 660);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Location = new System.Drawing.Point(0, 660);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1350, 51);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnAddProdType
            // 
            this.btnAddProdType.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProdType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProdType.FlatAppearance.BorderSize = 0;
            this.btnAddProdType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProdType.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProdType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProdType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProdType.Location = new System.Drawing.Point(0, 40);
            this.btnAddProdType.Name = "btnAddProdType";
            this.btnAddProdType.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddProdType.Size = new System.Drawing.Size(217, 40);
            this.btnAddProdType.TabIndex = 16;
            this.btnAddProdType.Text = "ຂໍ້ມູນປະເພດສິນຄ້າ";
            this.btnAddProdType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProdType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProdType.UseVisualStyleBackColor = false;
            this.btnAddProdType.Click += new System.EventHandler(this.btnAddProdType_Click);
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPrice.FlatAppearance.BorderSize = 0;
            this.btnAddPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrice.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPrice.Location = new System.Drawing.Point(0, 80);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddPrice.Size = new System.Drawing.Size(217, 40);
            this.btnAddPrice.TabIndex = 17;
            this.btnAddPrice.Text = "ຂໍ້ມູນລາຄາປະຈຳວັນ";
            this.btnAddPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPrice.UseVisualStyleBackColor = false;
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click);
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSupp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSupp.FlatAppearance.BorderSize = 0;
            this.btnAddSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupp.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupp.Location = new System.Drawing.Point(0, 120);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddSupp.Size = new System.Drawing.Size(217, 40);
            this.btnAddSupp.TabIndex = 18;
            this.btnAddSupp.Text = "ຂໍ້ມູນຜູ້ສະໜອງ";
            this.btnAddSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSupp.UseVisualStyleBackColor = false;
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            // 
            // btnAddCus
            // 
            this.btnAddCus.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCus.FlatAppearance.BorderSize = 0;
            this.btnAddCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCus.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCus.Location = new System.Drawing.Point(0, 160);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddCus.Size = new System.Drawing.Size(217, 40);
            this.btnAddCus.TabIndex = 19;
            this.btnAddCus.Text = "ຂໍ້ມູນລູກຄ້າ";
            this.btnAddCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCus.UseVisualStyleBackColor = false;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmp.FlatAppearance.BorderSize = 0;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmp.Location = new System.Drawing.Point(0, 200);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddEmp.Size = new System.Drawing.Size(217, 40);
            this.btnAddEmp.TabIndex = 20;
            this.btnAddEmp.Text = "ຂໍ້ມູນພະນັກງານ";
            this.btnAddEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panelDataSubMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnMenuSale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panelDataSubMenu;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnAddPrice;
        private System.Windows.Forms.Button btnAddProdType;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.Button btnAddSupp;
        private System.Windows.Forms.Button btnAddEmp;
    }
}

