using QLGV.HOTROSQL;
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
    public partial class User : Form
    {
        BindingSource b = new BindingSource();
        int loai = 0;

        public User()
        {
            InitializeComponent();
            DtGvGiangVien.DataSource = b;
            LoadUser();
           // LoadTEXT();
            An(false);
            //   Annut();
            loadCMBma();
            loadCMBquyen();
            chuot();
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            

        }

        void LoadUser()
        {
            string lenh = @"select d.MaGiaoVien, g.TenGiaoVien, TenDangNhap , d.MatKhau , d.Quyen
                            from dbo.ThongTinDangNhap as d, dbo.ThongTinGiangVien as g
                            where d.MaGiaoVien = g.MaGiaoVien";
            b.DataSource = HOTRO.SQL.TAIBANGDULIEU(lenh);
        }


        void LoadTEXT()
        {
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add(new Binding("Text", DtGvGiangVien.DataSource, "Tendangnhap"));
            txtMatkhau.DataBindings.Clear();
            txtMatkhau.DataBindings.Add(new Binding("Text", DtGvGiangVien.DataSource, "MatKhau"));
            comboBox2.DataBindings.Clear();
            comboBox2.DataBindings.Add(new Binding("Text", DtGvGiangVien.DataSource, "MaGiaoVien"));
            comboBox1.DataBindings.Clear();
            comboBox1.DataBindings.Add(new Binding("Text", DtGvGiangVien.DataSource, "Quyen"));
           

        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            TIM();
        }

        void An(bool t)
        {
            comboBox2.Enabled = txtMatkhau.Enabled = txtTen.Enabled = comboBox1.Enabled = t;
        }
        void Don()
        {
            
            txtMatkhau.Clear();
            txtTen.Clear();
            
        }

        void DonSua()
        {
           
            txtMatkhau.Clear();
           
            
        }

        void AnSua()
        {
            comboBox2.Enabled  = txtTen.Enabled = false;
            txtMatkhau.Enabled = comboBox1.Enabled = true;
        }

        
        //void Annut()
        //{
        //    buttonLuu1.Enabled = buttonHuy1.Enabled = false;
        //}

        //void Hiennut()
        //{
        //    buttonLuu1.Enabled = buttonHuy1.Enabled = true;
        //}

        private void buttonThem1_Click(object sender, EventArgs e)
        {
            loai = 1;
           An(true);
           an(true);
            Don();
           //Hiennut();
           
           
        }
        private void an(bool a)
        {
            buttonLuu1.Enabled = a;
            buttonHuy1.Enabled = a;
            buttonThem1.Enabled = !a;
            buttonXoa1.Enabled = !a;
            buttonSua1.Enabled = !a;
        }

        private void buttonSua1_Click(object sender, EventArgs e)
        {
            loai = 2;
            AnSua();
            DonSua();
            //Hiennut();
            an(true);
        }

        private void DtGvGiangVien_Click(object sender, EventArgs e)
        {
            //An(false);
            LoadUser();
           // Annut();
        }

        private void buttonLuu1_Click(object sender, EventArgs e)
        {
            if (loai == 1)
            {
                if (Kiemtrama())
                {
                    if (Kiemtraten())
                    {
                        if (txtTen.Text.ToLower() != "" && txtMatkhau.Text != "" && comboBox2.Text != "" && comboBox1.Text != "")
                        {
                            if ((comboBox1.Text) == "User" || (comboBox1.Text) == "Admin")
                            {
                                string lenh = string.Format(@"insert into dbo.ThongTinDangNhap(TenDangNhap, MatKhau, MaGiaoVien, Quyen) 
                                            values('{0}','{1}','{2}','{3}')", txtTen.Text.ToLower(), txtMatkhau.Text, comboBox2.Text, comboBox1.Text);


                                string thongbao = string.Format(@"Bạn có chắc sẽ thêm:
                  - Tên tài khoản: {0}
                  - Mật khẩu: {1}
                  - Mã số giảng viên: {2}
                  - Quyền: {3}", txtTen.Text.ToLower(), txtMatkhau.Text, comboBox2.Text, comboBox1.Text);
                                if (MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                                {

                                    if (HOTRO.SQL.THEM_XOA_SUA_DULIEU(lenh) > 0)
                                    {
                                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        LoadUser();
                                        An(false);
                                        //                       Annut();
                                        User_Load(sender, e);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }


                                }
                            }
                        }

                        else
                        {
                            MessageBox.Show("Bạn không được để trống ô xin hãy điền  đầy đủ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }

            else
            {
                if (txtTen.Text != "" && txtMatkhau.Text != "" && comboBox2.Text != "" && comboBox1.Text != "")
                {
                    if ((comboBox1.Text) == "User" || (comboBox1.Text) == "Admin")
                    {
                        string lenh = string.Format(@"update dbo.ThongTinDangNhap set MatKhau = '{0}', MaGiaoVien = '{1}', Quyen = '{2}' where TenDangNhap = '{3}'", txtMatkhau.Text, comboBox2.Text, comboBox1.Text, txtTen.Text);


                        string thongbao = string.Format(@"Bạn có chắc sẽ sửa:
                  - Tên tài khoản: {0}
                  - Mật khẩu: {1}
                  - Mã số giảng viên: {2}
                  - Quyền: {3}", txtTen.Text.ToLower(), txtMatkhau.Text, comboBox2.Text, comboBox1.Text);
                        if (MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                        {

                            if (HOTRO.SQL.THEM_XOA_SUA_DULIEU(lenh) > 0)
                            {
                                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadUser();
                                User_Load(sender, e);
               //                  Annut();
                               // a(true);

                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                    }

                    else
                    {
                        MessageBox.Show("Phân quyền không hợp lệ..[Admin - User]", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Bạn không được để trống ô xin hãy điền  đầy đủ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


        }

        private void buttonXoa1_Click(object sender, EventArgs e)
        {
            string lenh = string.Format(@"delete dbo.ThongTinDangNhap where TenDangNhap = '{0}'", txtTen.Text);


            string thongbao = string.Format(@"Bạn có chắc sẽ xóa:
                  - Tên tài khoản: {0}
                  - Mật khẩu: {1}
                  - Mã số giảng viên: {2}
                  - Quyền: {3}", txtTen.Text.ToLower(), txtMatkhau.Text, comboBox2.Text, comboBox1.Text);
            if (MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (HOTRO.SQL.THEM_XOA_SUA_DULIEU(lenh) > 0)
                {
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUser();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHuy1_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                User_Load(sender, e);
                An(false);

            }
            else
                return;
        }

        void TIM()
        {
            string tk = txttim.Text;

            string lenh = string.Format(@"select MaGiaoVien, TenGiaoVien, TenDangNhap , MatKhau , Quyen from (select d.MaGiaoVien, g.TenGiaoVien, TenDangNhap , d.MatKhau , d.Quyen from dbo.ThongTinDangNhap as d, dbo.ThongTinGiangVien as g where d.MaGiaoVien = g.MaGiaoVien)as g where MaGiaoVien like '%{0}%' or TenDangNhap like N'%{1}%' or MatKhau like '%{2}%' or TenGiaoVien like N'%{3}%' or Quyen like '%{4}%'", txttim.Text, txttim.Text, txttim.Text, txttim.Text, txttim.Text);
            b.DataSource = HOTRO.SQL.TAIBANGDULIEU(lenh);
            DataTable dtDS= HOTRO.SQL.TAIBANGDULIEU(lenh);



            if (tk == "")
            {
                this.label2.Text = "Nhấn vào để tìm kiếm tự động";
            }
            else
            {

                string a = Convert.ToString(dtDS.Rows.Count);
                label2.Text = "có " + a + " kết quả được tìm thấy";
            }
        }
        private void loadCMBma()
        {
            comboBox1.Items.Clear();
            DataTable dttb = new System.Data.DataTable();
            string lenh = @"select MaGiaoVien
                            from dbo.ThongTinGiangVien
                           ";
            dttb = HOTRO.SQL.TAIBANGDULIEU(lenh);
            foreach (DataRow row in dttb.Rows) // Duyệt từng dòng (DataRow) trong DataTable
            {

                foreach (var item in row.ItemArray) // Duyệt từng cột của dòng hiện tại
                {

                    comboBox2.Items.Add(item);// In ra giá trị của ô với dòng và cột tương ứng
                }


                comboBox2.SelectedItem = 0;
            }
        }
        private void loadCMBquyen()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("User");
            comboBox1.SelectedItem = 0;
        }
        public void chuot()
        {
            txttim.Cursor = new Cursor(@"tim.cur");
            buttonHuy1.Cursor = new Cursor(@"tay.cur");
            buttonLuu1.Cursor = new Cursor(@"tay.cur");
            buttonSua1.Cursor = new Cursor(@"tay.cur");
            buttonThem1.Cursor = new Cursor(@"tay.cur");
            buttonXoa1.Cursor = new Cursor(@"tay.cur");
        }
        private void User_Load(object sender, EventArgs e)
        {
            //txttim.Text = "Tìm theo mã giáo viên";
            LoadUser();
            
            an(false);
            an(false);
            LoadTEXT();
            //if (comboBox1.SelectedIndex == 0)
            //{
            //    comboBox1.Text = "1";
            //}
            //else
            //    comboBox1.Text = "0";
        }

        private void txttim_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
        }
        public bool Kiemtrama()
        {
            string lenh = @"select MaGiaoVien from ThongTinDangNhap";
            DataTable dt = HOTROSQL.HOTRO.SQL.TAIBANGDULIEU(lenh);

            foreach (DataRow row in dt.Rows) // Duyệt từng dòng (DataRow) trong DataTable
            {

                foreach (var item in row.ItemArray) // Duyệt từng cột của dòng hiện tại
                {

                    if (comboBox2.Text == Convert.ToString(item))
                    {
                        MessageBox.Show("Bạn đã nhập trùng Mã Giáo Viên");
                        return false;
                    }
                }

            }
            return true;

        }
        public bool Kiemtraten()
        {
            string lenh = @"select TenDangNhap from ThongTinDangNhap";
            DataTable dt = HOTROSQL.HOTRO.SQL.TAIBANGDULIEU(lenh);

            foreach (DataRow row in dt.Rows) // Duyệt từng dòng (DataRow) trong DataTable
            {

                foreach (var item in row.ItemArray) // Duyệt từng cột của dòng hiện tại
                {

                    if (txtTen.Text.Trim().ToLower() == Convert.ToString(item))
                    {
                        MessageBox.Show("Tên Đăng Nhập này đã có rồi");
                        return false;
                    }
                }

            }
            return true;

        }

        private void DtGvGiangVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 3) && e.Value != null)
            {
                DtGvGiangVien.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }
    }
}
