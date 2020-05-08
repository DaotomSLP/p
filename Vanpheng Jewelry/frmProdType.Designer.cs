namespace Vanpheng_Jewelry
{
    partial class frmProdType
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdTId = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdTName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProductType = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblW = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(958, 582);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(159, 46);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(336, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã các loại sản phẩm :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProdTId
            // 
            this.txtProdTId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdTId.Location = new System.Drawing.Point(15, 61);
            this.txtProdTId.Name = "txtProdTId";
            this.txtProdTId.ReadOnly = true;
            this.txtProdTId.Size = new System.Drawing.Size(131, 26);
            this.txtProdTId.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Loại sản phẩm :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProdTName
            // 
            this.txtProdTName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdTName.Location = new System.Drawing.Point(15, 136);
            this.txtProdTName.Name = "txtProdTName";
            this.txtProdTName.Size = new System.Drawing.Size(456, 26);
            this.txtProdTName.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProdTId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProdTName);
            this.panel1.Location = new System.Drawing.Point(27, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 612);
            this.panel1.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(217, 22);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Thông tin loại sản phẩm :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.dgvProductType);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(576, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 542);
            this.panel2.TabIndex = 14;
            // 
            // dgvProductType
            // 
            this.dgvProductType.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvProductType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductType.Location = new System.Drawing.Point(0, 0);
            this.dgvProductType.Name = "dgvProductType";
            this.dgvProductType.Size = new System.Drawing.Size(541, 533);
            this.dgvProductType.TabIndex = 14;
            this.dgvProductType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductType_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(349, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "ບັນທຶກ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.Location = new System.Drawing.Point(571, 564);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(365, 22);
            this.lblW.TabIndex = 17;
            this.lblW.Text = "Vui lòng chọn thông tin bạn muốn chỉnh sửa";
            this.lblW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProdType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1145, 650);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdType";
            this.Text = "frmProdType";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProdType_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdTId;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdTName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProductType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblName;
    }
}