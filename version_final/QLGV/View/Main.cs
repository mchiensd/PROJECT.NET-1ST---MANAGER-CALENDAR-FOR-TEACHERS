using QLGV.HOTROSQL;
using QLGV.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.View
{
    public partial class Main : Form
    {
        public static string usser;
        public static bool KIEMTRA;
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public Main()
        {
            InitializeComponent();
           // buttonLop1.Visible = buttonMon1.Visible = buttonLop1.Visible =
             buttonNguoi1.Visible = KIEMTRA;
           
            wplayer.URL = "nhacnen.mp3";
            wplayer.controls.play();
            
            XinChao();

        }
        
        private void XinChao()
        {

            DataTable dttb = new System.Data.DataTable();
            
            string matam;
            string xinchao;
            string tendn = usser;
            string lenh2 = @"select MaGiaoVien, TenDangNhap from ThongTinDangNhap where TenDangNhap='"+tendn+"';";
            dttb = HOTRO.SQL.TAIBANGDULIEU(lenh2);
            matam = dttb.Rows[0][0].ToString();

            string lenh = @"select t.MaGiaoVien, TenGiaoVien
                            from  ThongTinDangNhap t, ThongTinGiangVien tgv
							where t.MaGiaoVien=tgv.MaGiaoVien and t.MaGiaoVien='" + matam + "'";
            dttb = HOTRO.SQL.TAIBANGDULIEU(lenh);
            xinchao=dttb.Rows[0][1].ToString();
            string quyen;
            if (KIEMTRA)
            {
                 quyen= "ADMIN";
            }
            else quyen = "USER";
            label1.Text = "Xin Chào " + xinchao+" ___ Bạn đang truy cập bằng quyền " +quyen;

        } 
           
        private void Main_Load(object sender, EventArgs e)
        {
            #region chuot 
            //this.Cursor = new Cursor(@"cursor.cur");
           // this.buttonE1.Cursor = new Cursor(@"tay.cur");
            this.buttonGiao1.Cursor = new Cursor(@"tay.cur");
            this.buttonLop1.Cursor = new Cursor(@"tay.cur");
            this.buttonMoi1.Cursor = new Cursor(@"tay.cur");
            this.buttonMon1.Cursor = new Cursor(@"tay.cur");
            this.buttonNguoi1.Cursor = new Cursor(@"tay.cur");
           play.Cursor = new Cursor(@"tay.cur");
           tamdung.Cursor = new Cursor(@"tay.cur");
            pictureBox2.Cursor= new Cursor(@"tay.cur");
            #endregion

            //  this.Size = new System.Drawing.Size(1121, 587);
            // Xóa hết controls đang tồn tại trong pnl (nếu có)
            this.panel1.Controls.Clear();

            Thongtinnhom frmChild = new Thongtinnhom();
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panel1.Controls.Add(frmChild);
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.WindowState = FormWindowState.Maximized;
            // Hiển thị form
            frmChild.Show();


        }

        private void buttonGiao1_Load(object sender, EventArgs e)
        {


        }

        private void buttonMon1_Load(object sender, EventArgs e)
        {


        }

        private void buttonLop1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMoi1_Load(object sender, EventArgs e)
        {


        }

        private void buttonNguoi1_Load(object sender, EventArgs e)
        {


        }

        private void buttonE1_Load(object sender, EventArgs e)
        {
        }



        private void buttonGiao1_Click(object sender, EventArgs e)
        {
            //  this.Size = new System.Drawing.Size(1121, 587);
            // Xóa hết controls đang tồn tại trong pnl (nếu có)
            this.panel1.Controls.Clear();

            Form1 frmChild = new Form1();
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panel1.Controls.Add(frmChild);
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.WindowState = FormWindowState.Maximized;
            // Hiển thị form
            frmChild.Show();
           
            bool a = true;
            buttonGiao1.Enabled = !a;
            buttonLop1.Enabled = a;
            buttonMoi1.Enabled = a;
            buttonMon1.Enabled = a;
            buttonNguoi1.Enabled = a;



        }

        private void buttonMon1_Click(object sender, EventArgs e)
        {
            //  this.Size = new System.Drawing.Size(1121, 587);
            // Xóa hết controls đang tồn tại trong pnl (nếu có)
            this.panel1.Controls.Clear();

            FormMonHoc frmChild = new FormMonHoc();
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panel1.Controls.Add(frmChild);
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.WindowState = FormWindowState.Maximized;
            // Hiển thị form
            frmChild.Show();
            bool a = true;
            buttonGiao1.Enabled = a;
            buttonLop1.Enabled = a;
            buttonMoi1.Enabled = a;
            buttonMon1.Enabled = !a;
            buttonNguoi1.Enabled = a;

        }

        private void buttonLop1_Click(object sender, EventArgs e)
        {

            //  this.Size = new System.Drawing.Size(1121, 587);
            // Xóa hết controls đang tồn tại trong pnl (nếu có)
            this.panel1.Controls.Clear();

            LopHocc frmChild = new LopHocc();
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panel1.Controls.Add(frmChild);
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.WindowState = FormWindowState.Maximized;
            // Hiển thị form
            frmChild.Show();
            bool a = true;
            buttonGiao1.Enabled = a;
            buttonLop1.Enabled = !a;
            buttonMoi1.Enabled = a;
            buttonMon1.Enabled = a;
            buttonNguoi1.Enabled = a;
        }

        private void buttonMoi1_Click(object sender, EventArgs e)
        {
            //  this.Size = new System.Drawing.Size(1121, 587);
            // Xóa hết controls đang tồn tại trong pnl (nếu có)
            this.panel1.Controls.Clear();

            MoiGiang frmChild = new MoiGiang();
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panel1.Controls.Add(frmChild);
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.WindowState = FormWindowState.Maximized;
            // Hiển thị form
            frmChild.Show();
            bool a = true;
            buttonGiao1.Enabled = a;
            buttonLop1.Enabled = a;
            buttonMoi1.Enabled = !a;
            buttonMon1.Enabled = a;
            buttonNguoi1.Enabled = a;
        }

        private void buttonNguoi1_Click(object sender, EventArgs e)
        {

            //  this.Size = new System.Drawing.Size(1121, 587);
            // Xóa hết controls đang tồn tại trong pnl (nếu có)
            this.panel1.Controls.Clear();

            User frmChild = new User();
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panel1.Controls.Add(frmChild);
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.WindowState = FormWindowState.Maximized;
            // Hiển thị form
            frmChild.Show();
            bool a = true;
            buttonGiao1.Enabled = a;
            buttonLop1.Enabled = a;
            buttonMoi1.Enabled = a;
            buttonMon1.Enabled = a;
            buttonNguoi1.Enabled = !a;
        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn Thoát không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }
       
        private void bntmusic_Click(object sender, EventArgs e)
        {
           
        }

        private void tamdung_Click(object sender, EventArgs e)
        {

            
                wplayer.controls.pause();
                play.BringToFront();
           
                
           
        }

        private void play_Click(object sender, EventArgs e)
        {
            wplayer.controls.play();
            tamdung.BringToFront();
        }

        private void Main_Leave(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

            exitform(sender, e);



        }
        public void exitform(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                System.Threading.Thread.Sleep(50);
                this.Opacity = this.Opacity - 0.08;
                this.Size = new System.Drawing.Size(1121, 683 - (70 * i));
            }
            if (this.Opacity < 0.1) this.Close();
            Application.Exit();

        }
       
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //  this.Size = new System.Drawing.Size(1121, 587);
            // Xóa hết controls đang tồn tại trong pnl (nếu có)
            this.panel1.Controls.Clear();

            Thongtinnhom frmChild = new Thongtinnhom();
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panel1.Controls.Add(frmChild);
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.WindowState = FormWindowState.Maximized;
            // Hiển thị form
            frmChild.Show();
            buttonGiao1.Enabled = buttonLop1.Enabled = buttonMoi1.Enabled = buttonMon1.Enabled = buttonNguoi1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left <= 1100)
                label1.Left += 1;
            else label1.Left = -700;
        }

        private void dongho_Tick(object sender, EventArgs e)
        {
            dongholb.Text = DateTime.Now.ToLongTimeString();
        }
    }
    
}
