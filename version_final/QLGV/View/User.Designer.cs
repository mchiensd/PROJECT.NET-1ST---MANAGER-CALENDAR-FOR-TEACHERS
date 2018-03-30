namespace QLGV.View
{
    partial class User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.txttim = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.DtGvGiangVien = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonHuy1 = new ButtonByNhom.ButtonHuy();
            this.buttonLuu1 = new ButtonByNhom.ButtonLuu();
            this.buttonXoa1 = new ButtonByNhom.ButtonXoa();
            this.buttonSua1 = new ButtonByNhom.ButtonSua();
            this.buttonThem1 = new ButtonByNhom.ButtonThem();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtGvGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txttim
            // 
            this.txttim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(650, 68);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(187, 15);
            this.txttim.TabIndex = 81;
            this.txttim.Click += new System.EventHandler(this.txttim_Click);
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatkhau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(283, 151);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(208, 15);
            this.txtMatkhau.TabIndex = 50;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // txtTen
            // 
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(283, 116);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(208, 15);
            this.txtTen.TabIndex = 49;
            // 
            // DtGvGiangVien
            // 
            this.DtGvGiangVien.AllowUserToAddRows = false;
            this.DtGvGiangVien.AllowUserToDeleteRows = false;
            this.DtGvGiangVien.AllowUserToResizeColumns = false;
            this.DtGvGiangVien.AllowUserToResizeRows = false;
            this.DtGvGiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGvGiangVien.BackgroundColor = System.Drawing.Color.White;
            this.DtGvGiangVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtGvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtGvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DtGvGiangVien.Location = new System.Drawing.Point(52, 309);
            this.DtGvGiangVien.Name = "DtGvGiangVien";
            this.DtGvGiangVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DtGvGiangVien.RowHeadersVisible = false;
            this.DtGvGiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGvGiangVien.Size = new System.Drawing.Size(990, 208);
            this.DtGvGiangVien.TabIndex = 91;
            this.DtGvGiangVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtGvGiangVien_CellFormatting);
            this.DtGvGiangVien.Click += new System.EventHandler(this.DtGvGiangVien_Click);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "MaGiaoVien";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.FillWeight = 126.9036F;
            this.Column5.HeaderText = "Mã giáo viên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "TenGiaoVien";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 93.27411F;
            this.Column1.HeaderText = "Tên giáo viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDangNhap";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 93.27411F;
            this.Column2.HeaderText = "Tài khoản";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatKhau";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.FillWeight = 93.27411F;
            this.Column3.HeaderText = "Mật khẩu";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Quyen";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.FillWeight = 93.27411F;
            this.Column4.HeaderText = "Quyền";
            this.Column4.Name = "Column4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(352, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nhấn vào để tìm kiếm tự động";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(650, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 93;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(650, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 24);
            this.comboBox2.TabIndex = 94;
            // 
            // buttonHuy1
            // 
            this.buttonHuy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHuy1.BackgroundImage")));
            this.buttonHuy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHuy1.Location = new System.Drawing.Point(776, 192);
            this.buttonHuy1.Name = "buttonHuy1";
            this.buttonHuy1.Size = new System.Drawing.Size(122, 60);
            this.buttonHuy1.TabIndex = 90;
            this.buttonHuy1.Click += new System.EventHandler(this.buttonHuy1_Click);
            // 
            // buttonLuu1
            // 
            this.buttonLuu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLuu1.BackgroundImage")));
            this.buttonLuu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLuu1.Location = new System.Drawing.Point(639, 192);
            this.buttonLuu1.Name = "buttonLuu1";
            this.buttonLuu1.Size = new System.Drawing.Size(122, 60);
            this.buttonLuu1.TabIndex = 89;
            this.buttonLuu1.Click += new System.EventHandler(this.buttonLuu1_Click);
            // 
            // buttonXoa1
            // 
            this.buttonXoa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXoa1.BackgroundImage")));
            this.buttonXoa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXoa1.Location = new System.Drawing.Point(450, 192);
            this.buttonXoa1.Name = "buttonXoa1";
            this.buttonXoa1.Size = new System.Drawing.Size(122, 60);
            this.buttonXoa1.TabIndex = 88;
            this.buttonXoa1.Click += new System.EventHandler(this.buttonXoa1_Click);
            // 
            // buttonSua1
            // 
            this.buttonSua1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSua1.BackgroundImage")));
            this.buttonSua1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSua1.Location = new System.Drawing.Point(306, 192);
            this.buttonSua1.Name = "buttonSua1";
            this.buttonSua1.Size = new System.Drawing.Size(122, 60);
            this.buttonSua1.TabIndex = 87;
            this.buttonSua1.Click += new System.EventHandler(this.buttonSua1_Click);
            // 
            // buttonThem1
            // 
            this.buttonThem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThem1.BackgroundImage")));
            this.buttonThem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThem1.Location = new System.Drawing.Point(160, 192);
            this.buttonThem1.Name = "buttonThem1";
            this.buttonThem1.Size = new System.Drawing.Size(122, 60);
            this.buttonThem1.TabIndex = 86;
            this.buttonThem1.Click += new System.EventHandler(this.buttonThem1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::QLGV.Properties.Resources.tbtt2;
            this.pictureBox8.Location = new System.Drawing.Point(542, 59);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(333, 41);
            this.pictureBox8.TabIndex = 64;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLGV.Properties.Resources.tendangnhap;
            this.pictureBox1.Location = new System.Drawing.Point(174, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 32);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLGV.Properties.Resources.mat_khau;
            this.pictureBox2.Location = new System.Drawing.Point(174, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(331, 35);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLGV.Properties.Resources.tbtengv12;
            this.pictureBox3.Location = new System.Drawing.Point(544, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(331, 35);
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QLGV.Properties.Resources.quyen;
            this.pictureBox4.Location = new System.Drawing.Point(544, 106);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(331, 35);
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::QLGV.Properties.Resources.tieudeUser1;
            this.pictureBox5.Location = new System.Drawing.Point(154, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(753, 60);
            this.pictureBox5.TabIndex = 84;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QLGV.Properties.Resources.gb1user;
            this.pictureBox6.Location = new System.Drawing.Point(31, 267);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1020, 257);
            this.pictureBox6.TabIndex = 85;
            this.pictureBox6.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 661);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtGvGiangVien);
            this.Controls.Add(this.buttonHuy1);
            this.Controls.Add(this.buttonLuu1);
            this.Controls.Add(this.buttonXoa1);
            this.Controls.Add(this.buttonSua1);
            this.Controls.Add(this.buttonThem1);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGvGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private ButtonByNhom.ButtonHuy buttonHuy1;
        private ButtonByNhom.ButtonLuu buttonLuu1;
        private ButtonByNhom.ButtonXoa buttonXoa1;
        private ButtonByNhom.ButtonSua buttonSua1;
        private ButtonByNhom.ButtonThem buttonThem1;
        private System.Windows.Forms.DataGridView DtGvGiangVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}