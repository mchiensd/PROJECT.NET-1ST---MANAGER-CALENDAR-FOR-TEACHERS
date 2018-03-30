namespace QLGV.View
{
    partial class LopHocc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LopHocc));
            this.txttimlop = new System.Windows.Forms.TextBox();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.DtGvMonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLuu1 = new ButtonByNhom.ButtonLuu();
            this.buttonHuy1 = new ButtonByNhom.ButtonHuy();
            this.buttonXoa1 = new ButtonByNhom.ButtonXoa();
            this.buttonSua1 = new ButtonByNhom.ButtonSua();
            this.buttonThem1 = new ButtonByNhom.ButtonThem();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtGvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimlop
            // 
            this.txttimlop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttimlop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimlop.Location = new System.Drawing.Point(272, 152);
            this.txttimlop.Name = "txttimlop";
            this.txttimlop.Size = new System.Drawing.Size(172, 15);
            this.txttimlop.TabIndex = 80;
            this.txttimlop.TextChanged += new System.EventHandler(this.txttimlop_TextChanged_1);
            // 
            // txtmalop
            // 
            this.txtmalop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmalop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmalop.Location = new System.Drawing.Point(269, 106);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(206, 15);
            this.txtmalop.TabIndex = 79;
            // 
            // txttenlop
            // 
            this.txttenlop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttenlop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenlop.Location = new System.Drawing.Point(269, 62);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(206, 15);
            this.txttenlop.TabIndex = 77;
            // 
            // DtGvMonHoc
            // 
            this.DtGvMonHoc.AllowUserToAddRows = false;
            this.DtGvMonHoc.AllowUserToDeleteRows = false;
            this.DtGvMonHoc.AllowUserToResizeColumns = false;
            this.DtGvMonHoc.AllowUserToResizeRows = false;
            this.DtGvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGvMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.DtGvMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtGvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DtGvMonHoc.Location = new System.Drawing.Point(68, 270);
            this.DtGvMonHoc.Name = "DtGvMonHoc";
            this.DtGvMonHoc.RowHeadersVisible = false;
            this.DtGvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGvMonHoc.Size = new System.Drawing.Size(959, 208);
            this.DtGvMonHoc.TabIndex = 92;
            this.DtGvMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGvMonHoc_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLop";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Mã Lớp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLop";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Tên Lớp";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(305, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Nhấn vào để tìm kiếm tự động";
            // 
            // buttonLuu1
            // 
            this.buttonLuu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLuu1.BackgroundImage")));
            this.buttonLuu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLuu1.Location = new System.Drawing.Point(570, 117);
            this.buttonLuu1.Name = "buttonLuu1";
            this.buttonLuu1.Size = new System.Drawing.Size(122, 60);
            this.buttonLuu1.TabIndex = 99;
            this.buttonLuu1.Click += new System.EventHandler(this.buttonLuu1_Click_1);
            // 
            // buttonHuy1
            // 
            this.buttonHuy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHuy1.BackgroundImage")));
            this.buttonHuy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHuy1.Location = new System.Drawing.Point(720, 117);
            this.buttonHuy1.Name = "buttonHuy1";
            this.buttonHuy1.Size = new System.Drawing.Size(122, 60);
            this.buttonHuy1.TabIndex = 98;
            this.buttonHuy1.Click += new System.EventHandler(this.buttonHuy1_Click);
            // 
            // buttonXoa1
            // 
            this.buttonXoa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXoa1.BackgroundImage")));
            this.buttonXoa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXoa1.Location = new System.Drawing.Point(647, 53);
            this.buttonXoa1.Name = "buttonXoa1";
            this.buttonXoa1.Size = new System.Drawing.Size(122, 60);
            this.buttonXoa1.TabIndex = 97;
            this.buttonXoa1.Click += new System.EventHandler(this.buttonXoa1_Click_1);
            // 
            // buttonSua1
            // 
            this.buttonSua1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSua1.BackgroundImage")));
            this.buttonSua1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSua1.Location = new System.Drawing.Point(788, 53);
            this.buttonSua1.Name = "buttonSua1";
            this.buttonSua1.Size = new System.Drawing.Size(122, 60);
            this.buttonSua1.TabIndex = 96;
            this.buttonSua1.Click += new System.EventHandler(this.buttonSua1_Click_1);
            // 
            // buttonThem1
            // 
            this.buttonThem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThem1.BackgroundImage")));
            this.buttonThem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThem1.Location = new System.Drawing.Point(509, 53);
            this.buttonThem1.Name = "buttonThem1";
            this.buttonThem1.Size = new System.Drawing.Size(122, 60);
            this.buttonThem1.TabIndex = 95;
            this.buttonThem1.Load += new System.EventHandler(this.buttonThem1_Load);
            this.buttonThem1.Click += new System.EventHandler(this.buttonThem1_Click_1);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::QLGV.Properties.Resources.gblop;
            this.pictureBox10.Location = new System.Drawing.Point(37, 226);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(990, 294);
            this.pictureBox10.TabIndex = 93;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QLGV.Properties.Resources.tbtt3;
            this.pictureBox4.Location = new System.Drawing.Point(157, 142);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(332, 35);
            this.pictureBox4.TabIndex = 70;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLGV.Properties.Resources.malop;
            this.pictureBox3.Location = new System.Drawing.Point(157, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(332, 35);
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLGV.Properties.Resources.tenlop1;
            this.pictureBox1.Location = new System.Drawing.Point(157, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 35);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::QLGV.Properties.Resources.gbtieudemonhoc;
            this.pictureBox11.Location = new System.Drawing.Point(195, -8);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(667, 59);
            this.pictureBox11.TabIndex = 94;
            this.pictureBox11.TabStop = false;
            // 
            // LopHocc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLuu1);
            this.Controls.Add(this.buttonHuy1);
            this.Controls.Add(this.buttonXoa1);
            this.Controls.Add(this.buttonSua1);
            this.Controls.Add(this.buttonThem1);
            this.Controls.Add(this.DtGvMonHoc);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.txttimlop);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox11);
            this.Name = "LopHocc";
            this.Text = "LopHoc";
            this.Load += new System.EventHandler(this.LopHocc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttimlop;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DtGvMonHoc;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private ButtonByNhom.ButtonThem buttonThem1;
        private ButtonByNhom.ButtonSua buttonSua1;
        private ButtonByNhom.ButtonXoa buttonXoa1;
        private ButtonByNhom.ButtonHuy buttonHuy1;
        private ButtonByNhom.ButtonLuu buttonLuu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}