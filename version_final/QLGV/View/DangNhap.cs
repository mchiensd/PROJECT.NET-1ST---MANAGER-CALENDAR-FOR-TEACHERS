using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGV.Control;
using QLGV.HOTROSQL;


namespace QLGV.View
{
    public partial class DangNhap : Form
    {
      
        public DangNhap()
        {
            InitializeComponent();
            chuot();
            

        }
       
 

        private void dangnhap1_Click(object sender, EventArgs e)
        {

        }

        private void dangnhap1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void thoat1_MouseHover(object sender, EventArgs e)
        {

        }

        private void dangnhap2_MouseLeave(object sender, EventArgs e)
        {
           
        }
        private void chuot()
        {
            buttonDangNhap1.Cursor = new Cursor(@"tay.cur");
            buttonThoat1.Cursor = new Cursor(@"tay.cur");
            txtmatkhau.Cursor = new Cursor(@"tay.cur");
            txttendangnhap.Cursor = new Cursor(@"tay.cur");
        }
        private void thoat2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
          
            

        }

        private void dangnhap2_Click(object sender, EventArgs e)
        {
           
        }

        private void thoat2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonThoat1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn Thoát không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
            else
                return;


        }

        private void XOA_TEXT()
        {
            txttendangnhap.Clear();
            txtmatkhau.Clear();
            txttendangnhap.Focus();
        }


        private void buttonDangNhap1_Click(object sender, EventArgs e)
        {
            dangnhap();
        }
        
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void DangNhap_Enter(object sender, EventArgs e)
        {

        }
        private void dangnhap()
        {

            string User = txttendangnhap.Text;
            string pass = txtmatkhau.Text;
            string phanquyen = XULY_LOGIN.XL_LOGIN.TIEN_HANH_PHAN_QUYEN(User, pass);

            if (phanquyen != "Admin" && phanquyen != "User")
            {
                MessageBox.Show("Tài khoản không tồn tại..Xin kiểm tra lại", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                XOA_TEXT();
            }

            else
            {
                Main.usser = txttendangnhap.Text;
                if (phanquyen == "Admin")
                {
                    Main.KIEMTRA = true;
                    Form1.KIEMTRA = true;
                    MoiGiang.KIEMTRA = true;
                    FormMonHoc.KIEMTRA = true;
                    LopHocc.KIEMTRA = true;
                }
                else
                {
                    Main.KIEMTRA = false;
                    Form1.KIEMTRA = false;
                    MoiGiang.KIEMTRA = false;
                    FormMonHoc.KIEMTRA = false;
                    LopHocc.KIEMTRA = false;
                }

                Main m = new Main();
                this.Hide();
                m.ShowDialog();
                //this.Show();
                XOA_TEXT();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dangnhap();
        }
    }
}
