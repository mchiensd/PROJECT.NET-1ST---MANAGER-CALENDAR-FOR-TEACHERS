namespace QLGV.View
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tamdung = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.buttonMon1 = new ButtonByNhom.ButtonMon();
            this.buttonMoi1 = new ButtonByNhom.ButtonMoi();
            this.buttonNguoi1 = new ButtonByNhom.ButtonNguoi();
            this.buttonLop1 = new ButtonByNhom.ButtonLop();
            this.buttonGiao1 = new ButtonByNhom.ButtonGiao();
            this.dongho = new System.Windows.Forms.Timer(this.components);
            this.dongholb = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamdung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 534);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FS Tropen Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xin chào";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLGV.Properties.Resources.Nhóm1_copy;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 616);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLGV.Properties.Resources.Nhóm11;
            this.pictureBox2.Location = new System.Drawing.Point(5, 616);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tamdung
            // 
            this.tamdung.Image = global::QLGV.Properties.Resources.pause2;
            this.tamdung.Location = new System.Drawing.Point(40, 616);
            this.tamdung.Name = "tamdung";
            this.tamdung.Size = new System.Drawing.Size(32, 29);
            this.tamdung.TabIndex = 0;
            this.tamdung.TabStop = false;
            this.tamdung.Click += new System.EventHandler(this.tamdung_Click);
            // 
            // play
            // 
            this.play.Image = global::QLGV.Properties.Resources.play_button1;
            this.play.Location = new System.Drawing.Point(40, 616);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(32, 29);
            this.play.TabIndex = 1;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // buttonMon1
            // 
            this.buttonMon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMon1.BackgroundImage")));
            this.buttonMon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMon1.Location = new System.Drawing.Point(627, 3);
            this.buttonMon1.Name = "buttonMon1";
            this.buttonMon1.Size = new System.Drawing.Size(176, 60);
            this.buttonMon1.TabIndex = 0;
            this.buttonMon1.Load += new System.EventHandler(this.buttonMon1_Load);
            this.buttonMon1.Click += new System.EventHandler(this.buttonMon1_Click);
            // 
            // buttonMoi1
            // 
            this.buttonMoi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMoi1.BackgroundImage")));
            this.buttonMoi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMoi1.Location = new System.Drawing.Point(272, 3);
            this.buttonMoi1.Name = "buttonMoi1";
            this.buttonMoi1.Size = new System.Drawing.Size(176, 60);
            this.buttonMoi1.TabIndex = 4;
            this.buttonMoi1.Load += new System.EventHandler(this.buttonMoi1_Load);
            this.buttonMoi1.Click += new System.EventHandler(this.buttonMoi1_Click);
            // 
            // buttonNguoi1
            // 
            this.buttonNguoi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNguoi1.BackgroundImage")));
            this.buttonNguoi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNguoi1.Location = new System.Drawing.Point(809, 3);
            this.buttonNguoi1.Name = "buttonNguoi1";
            this.buttonNguoi1.Size = new System.Drawing.Size(176, 60);
            this.buttonNguoi1.TabIndex = 3;
            this.buttonNguoi1.Load += new System.EventHandler(this.buttonNguoi1_Load);
            this.buttonNguoi1.Click += new System.EventHandler(this.buttonNguoi1_Click);
            // 
            // buttonLop1
            // 
            this.buttonLop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLop1.BackgroundImage")));
            this.buttonLop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLop1.Location = new System.Drawing.Point(454, 3);
            this.buttonLop1.Name = "buttonLop1";
            this.buttonLop1.Size = new System.Drawing.Size(176, 60);
            this.buttonLop1.TabIndex = 2;
            this.buttonLop1.Load += new System.EventHandler(this.buttonLop1_Load);
            this.buttonLop1.Click += new System.EventHandler(this.buttonLop1_Click);
            // 
            // buttonGiao1
            // 
            this.buttonGiao1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGiao1.BackgroundImage")));
            this.buttonGiao1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGiao1.Location = new System.Drawing.Point(90, 3);
            this.buttonGiao1.Name = "buttonGiao1";
            this.buttonGiao1.Size = new System.Drawing.Size(176, 60);
            this.buttonGiao1.TabIndex = 1;
            this.buttonGiao1.Load += new System.EventHandler(this.buttonGiao1_Load);
            this.buttonGiao1.Click += new System.EventHandler(this.buttonGiao1_Click);
            // 
            // dongho
            // 
            this.dongho.Enabled = true;
            this.dongho.Tick += new System.EventHandler(this.dongho_Tick);
            // 
            // dongholb
            // 
            this.dongholb.AutoSize = true;
            this.dongholb.Font = new System.Drawing.Font("FS Tropen Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongholb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.dongholb.Location = new System.Drawing.Point(987, 616);
            this.dongholb.Name = "dongholb";
            this.dongholb.Size = new System.Drawing.Size(80, 20);
            this.dongholb.TabIndex = 9;
            this.dongholb.Text = "Đồng Hồ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLGV.Properties.Resources.Nhóm1_copy;
            this.pictureBox3.Location = new System.Drawing.Point(1025, 612);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 50);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 645);
            this.Controls.Add(this.dongholb);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tamdung);
            this.Controls.Add(this.play);
            this.Controls.Add(this.buttonMon1);
            this.Controls.Add(this.buttonMoi1);
            this.Controls.Add(this.buttonNguoi1);
            this.Controls.Add(this.buttonLop1);
            this.Controls.Add(this.buttonGiao1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Leave += new System.EventHandler(this.Main_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamdung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ButtonByNhom.ButtonGiao buttonGiao1;
        private ButtonByNhom.ButtonLop buttonLop1;
        private ButtonByNhom.ButtonMon buttonMon1;
        private ButtonByNhom.ButtonNguoi buttonNguoi1;
        private ButtonByNhom.ButtonMoi buttonMoi1;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox tamdung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer dongho;
        private System.Windows.Forms.Label dongholb;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}