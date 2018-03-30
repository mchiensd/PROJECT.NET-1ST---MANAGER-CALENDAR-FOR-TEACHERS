namespace QLGV.View
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.buttonDangNhap1 = new ButtonByNhom.ButtonDangNhap();
            this.buttonThoat1 = new ButtonByNhom.ButtonThoat();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttendangnhap.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendangnhap.Location = new System.Drawing.Point(97, 62);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(293, 22);
            this.txttendangnhap.TabIndex = 5;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatkhau.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(96, 127);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(293, 22);
            this.txtmatkhau.TabIndex = 6;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QLGV.Properties.Resources.tbtendn;
            this.pictureBox4.Location = new System.Drawing.Point(25, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(395, 59);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLGV.Properties.Resources.tbmkdn;
            this.pictureBox3.Location = new System.Drawing.Point(25, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(395, 59);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::QLGV.Properties.Resources.thongitndangnhap2;
            this.pictureBox5.Location = new System.Drawing.Point(-3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(451, 227);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // buttonDangNhap1
            // 
            this.buttonDangNhap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDangNhap1.BackgroundImage")));
            this.buttonDangNhap1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDangNhap1.Location = new System.Drawing.Point(96, 180);
            this.buttonDangNhap1.Name = "buttonDangNhap1";
            this.buttonDangNhap1.Size = new System.Drawing.Size(120, 60);
            this.buttonDangNhap1.TabIndex = 7;
            this.buttonDangNhap1.Click += new System.EventHandler(this.buttonDangNhap1_Click);
            // 
            // buttonThoat1
            // 
            this.buttonThoat1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat1.BackgroundImage")));
            this.buttonThoat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThoat1.Location = new System.Drawing.Point(233, 180);
            this.buttonThoat1.Name = "buttonThoat1";
            this.buttonThoat1.Size = new System.Drawing.Size(120, 60);
            this.buttonThoat1.TabIndex = 8;
            this.buttonThoat1.Click += new System.EventHandler(this.buttonThoat1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangNhap
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 249);
            this.Controls.Add(this.buttonThoat1);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonDangNhap1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.Enter += new System.EventHandler(this.DangNhap_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private ButtonByNhom.ButtonDangNhap buttonDangNhap1;
        private ButtonByNhom.ButtonThoat buttonThoat1;
        private System.Windows.Forms.Button button1;
    }
}