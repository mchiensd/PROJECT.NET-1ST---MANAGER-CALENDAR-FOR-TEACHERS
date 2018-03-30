namespace QLGV.View
{
    partial class FormMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonHoc));
            this.DtGvMonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtsotiet = new System.Windows.Forms.TextBox();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLuu1 = new ButtonByNhom.ButtonLuu();
            this.buttonHuy1 = new ButtonByNhom.ButtonHuy();
            this.buttonXoa1 = new ButtonByNhom.ButtonXoa();
            this.buttonSua1 = new ButtonByNhom.ButtonSua();
            this.buttonThem1 = new ButtonByNhom.ButtonThem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtGvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
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
            this.Column2,
            this.Column3});
            this.DtGvMonHoc.Location = new System.Drawing.Point(67, 288);
            this.DtGvMonHoc.Name = "DtGvMonHoc";
            this.DtGvMonHoc.RowHeadersVisible = false;
            this.DtGvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGvMonHoc.Size = new System.Drawing.Size(969, 208);
            this.DtGvMonHoc.TabIndex = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMon";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FillWeight = 99.49239F;
            this.Column1.HeaderText = "Mã Môn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMon";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.FillWeight = 99.49239F;
            this.Column2.HeaderText = "Tên Môn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoTiet";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.FillWeight = 99.49239F;
            this.Column3.HeaderText = "Số Tiết";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txtten
            // 
            this.txtten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtten.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(262, 66);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(206, 15);
            this.txtten.TabIndex = 53;
            // 
            // txtsotiet
            // 
            this.txtsotiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsotiet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotiet.Location = new System.Drawing.Point(262, 149);
            this.txtsotiet.Name = "txtsotiet";
            this.txtsotiet.Size = new System.Drawing.Size(206, 15);
            this.txtsotiet.TabIndex = 54;
            // 
            // txtmamon
            // 
            this.txtmamon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmamon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmamon.Location = new System.Drawing.Point(262, 107);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(206, 15);
            this.txtmamon.TabIndex = 55;
            // 
            // txttim
            // 
            this.txttim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(265, 190);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(172, 15);
            this.txttim.TabIndex = 56;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(298, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Nhấn vào để tìm kiếm tự động";
            // 
            // buttonLuu1
            // 
            this.buttonLuu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLuu1.BackgroundImage")));
            this.buttonLuu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLuu1.Location = new System.Drawing.Point(575, 131);
            this.buttonLuu1.Name = "buttonLuu1";
            this.buttonLuu1.Size = new System.Drawing.Size(122, 60);
            this.buttonLuu1.TabIndex = 104;
            this.buttonLuu1.Load += new System.EventHandler(this.buttonLuu1_Load);
            this.buttonLuu1.Click += new System.EventHandler(this.buttonLuu1_Click);
            // 
            // buttonHuy1
            // 
            this.buttonHuy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHuy1.BackgroundImage")));
            this.buttonHuy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHuy1.Location = new System.Drawing.Point(722, 131);
            this.buttonHuy1.Name = "buttonHuy1";
            this.buttonHuy1.Size = new System.Drawing.Size(122, 60);
            this.buttonHuy1.TabIndex = 103;
            this.buttonHuy1.Click += new System.EventHandler(this.buttonHuy1_Click);
            // 
            // buttonXoa1
            // 
            this.buttonXoa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXoa1.BackgroundImage")));
            this.buttonXoa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXoa1.Location = new System.Drawing.Point(649, 65);
            this.buttonXoa1.Name = "buttonXoa1";
            this.buttonXoa1.Size = new System.Drawing.Size(122, 60);
            this.buttonXoa1.TabIndex = 102;
            this.buttonXoa1.Click += new System.EventHandler(this.buttonXoa1_Click);
            // 
            // buttonSua1
            // 
            this.buttonSua1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSua1.BackgroundImage")));
            this.buttonSua1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSua1.Location = new System.Drawing.Point(790, 65);
            this.buttonSua1.Name = "buttonSua1";
            this.buttonSua1.Size = new System.Drawing.Size(122, 60);
            this.buttonSua1.TabIndex = 101;
            this.buttonSua1.Click += new System.EventHandler(this.buttonSua1_Click);
            // 
            // buttonThem1
            // 
            this.buttonThem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThem1.BackgroundImage")));
            this.buttonThem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThem1.Location = new System.Drawing.Point(511, 65);
            this.buttonThem1.Name = "buttonThem1";
            this.buttonThem1.Size = new System.Drawing.Size(122, 60);
            this.buttonThem1.TabIndex = 100;
            this.buttonThem1.Click += new System.EventHandler(this.buttonThem1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QLGV.Properties.Resources.tbtt3;
            this.pictureBox4.Location = new System.Drawing.Point(150, 180);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(332, 35);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLGV.Properties.Resources.mamon;
            this.pictureBox3.Location = new System.Drawing.Point(150, 98);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(332, 35);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLGV.Properties.Resources.sotiet;
            this.pictureBox2.Location = new System.Drawing.Point(150, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 35);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLGV.Properties.Resources.tenmon;
            this.pictureBox1.Location = new System.Drawing.Point(150, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::QLGV.Properties.Resources.gb1mon;
            this.pictureBox10.Location = new System.Drawing.Point(34, 237);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(1002, 286);
            this.pictureBox10.TabIndex = 51;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::QLGV.Properties.Resources.tieudemn1;
            this.pictureBox11.Location = new System.Drawing.Point(194, -8);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(667, 59);
            this.pictureBox11.TabIndex = 52;
            this.pictureBox11.TabStop = false;
            // 
            // FormMonHoc
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
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.txtmamon);
            this.Controls.Add(this.txtsotiet);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.DtGvMonHoc);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMonHoc";
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            this.Click += new System.EventHandler(this.FormMonHoc_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DtGvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView DtGvMonHoc;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtsotiet;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.TextBox txttim;
        private ButtonByNhom.ButtonLuu buttonLuu1;
        private ButtonByNhom.ButtonHuy buttonHuy1;
        private ButtonByNhom.ButtonXoa buttonXoa1;
        private ButtonByNhom.ButtonSua buttonSua1;
        private ButtonByNhom.ButtonThem buttonThem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}