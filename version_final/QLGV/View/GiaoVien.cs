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
using QLGV.Model;
using QLGV.Object;

namespace QLGV
{
    public partial class Form1 : Form
    {

        GiangVienCtrl nvCtr = new GiangVienCtrl();
        int co = 0;
        public static bool KIEMTRA;
        public Form1()
        {
            InitializeComponent();
            buttonThem1.Visible = buttonXoa1.Visible = buttonSua1.Visible = buttonLuu1.Visible = buttonHuy1.Visible = KIEMTRA;
            chuot();
            txtMa.Enabled = false;
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nvCtr.Getdata();
            DtGvGiangVien.DataSource = dtDS;
            doitencot();
            binhding();
            annut(false); 
            antext(false);
           

        }
       
        private void binhding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", DtGvGiangVien.DataSource, "MaGiaoVien");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", DtGvGiangVien.DataSource, "TenGiaoVien");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", DtGvGiangVien.DataSource, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", DtGvGiangVien.DataSource, "DiaChi");
            txtDt.DataBindings.Clear();
            txtDt.DataBindings.Add("Text", DtGvGiangVien.DataSource, "DienThoai");
            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", DtGvGiangVien.DataSource, "NgaySinh");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", DtGvGiangVien.DataSource, "Email");
           
        }
        private void annut(bool a)//them xoa sua
        {
           
               

            buttonLuu1.Enabled = a;
            buttonHuy1.Enabled = a;
            buttonThem1.Enabled = !a;
            buttonXoa1.Enabled = !a;
            buttonSua1.Enabled = !a;
            

        }
        //bao loi khong co du du lieu tu ban phim
        private bool loi()
        {
            if(txtTen.Text=="" )
            {
               // DialogResult a = new DialogResult();
                MessageBox.Show("Chưa nhập tên","Thông báo");
                return false;
            }
            return true;
        }
        private void antext(bool e)
        {
           // txtMa.Enabled = e;
            txtTen.Enabled = e;
            txtDiaChi.Enabled = e;
            txtDt.Enabled = e;
            txtGioiTinh.Enabled = e;
            txtNgaySinh.Enabled = e;
            txtEmail.Enabled = e;
            //  txttim.Enabled = e;
        }
        private void loadCMB()
        {
            txtGioiTinh.Items.Clear();
            txtGioiTinh.Items.Add("Nam");
            txtGioiTinh.Items.Add("Nữ");
            txtGioiTinh.SelectedItem = 0;
        }
        private void doitencot()
        {
            DtGvGiangVien.Columns[0].HeaderText = " Tên Giảng Viên";
            DtGvGiangVien.Columns[1].HeaderText = " Mã Giảng Viên";
            DtGvGiangVien.Columns[2].HeaderText = "Giới tính";
            DtGvGiangVien.Columns[3].HeaderText = " Ngày Sinh";
            DtGvGiangVien.Columns[4].HeaderText = " Địa chỉ";
            DtGvGiangVien.Columns[5].HeaderText = " Email";
            DtGvGiangVien.Columns[6].HeaderText = " Số điện thoại";
        }
        private void clearData()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtDt.Text = "";
            txtEmail.Text = "@gmail.com";
            txtNgaySinh.Value = DateTime.Now.Date;
            loadCMB();
        }
        private void addData(GiangVien nv)
        {

            if (txtGioiTinh.SelectedIndex == 0)
            {
                nv.GioiTinh1 = "Nam";
            }
            else
                nv.GioiTinh1 = "Nữ";
            nv.DiaChi1 = txtDiaChi.Text.Trim();
            nv.DienThoai1 = txtDt.Text.Trim();
            nv.TenGiaoVien1 = txtTen.Text.Trim();
            nv.NgaySinh1 = txtNgaySinh.Text;
            nv.Email1 = txtEmail.Text.Trim();
            nv.MaGiaoVien1 = txtMa.Text.Trim();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
        public void chuot()
        {
            buttonEx1.Cursor = new Cursor(@"tay.cur");
            buttonHuy1.Cursor = new Cursor(@"tay.cur");
            buttonLuu1.Cursor = new Cursor(@"tay.cur");
            buttonSua1.Cursor = new Cursor(@"tay.cur");
            buttonThem1.Cursor = new Cursor(@"tay.cur");
            buttonXoa1.Cursor = new Cursor(@"tay.cur");
            txttim.Cursor = new Cursor(@"tim.cur");
        }
        private void button1_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click_1(object sender, EventArgs e)
    {

    }

    private void txtTen_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtMa_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtDiaChi_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox10_Click(object sender, EventArgs e)
    {

    }

    private void them1_MouseHover(object sender, EventArgs e)
    {

    }

    private void them2_MouseLeave(object sender, EventArgs e)
    {

    }

    private void them2_Click(object sender, EventArgs e)
    {

    }

    private void xoa1_MouseHover(object sender, EventArgs e)
    {

    }

    private void xoa2_MouseLeave(object sender, EventArgs e)
    {

    }

    private void xoa2_Click(object sender, EventArgs e)
    {


    }

    private void sua1_MouseLeave(object sender, EventArgs e)
    {

    }

    private void sua2_MouseLeave(object sender, EventArgs e)
    {

    }

    private void sua2_Click(object sender, EventArgs e)
    {

    }

    private void sua3_MouseHover(object sender, EventArgs e)
    {

    }

    private void sua1_MouseHover(object sender, EventArgs e)
    {

    }

    private void luu1_MouseHover(object sender, EventArgs e)
    {

    }

    private void luu2_MouseLeave(object sender, EventArgs e)
    {

    }

    private void luu2_Click(object sender, EventArgs e)
    {

    }

    private void huy1_MouseHover(object sender, EventArgs e)
    {

    }

    private void huy2_MouseLeave(object sender, EventArgs e)
    {

    }

    private void huy2_Click(object sender, EventArgs e)
    {


    }

    private void button1_Click_1(object sender, EventArgs e)
    {

    }

    private void pictureBox11_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click_2(object sender, EventArgs e)
    {

    }

    private void button1_Click_3(object sender, EventArgs e)
    {

    }

    private void button1_Click_4(object sender, EventArgs e)
    {


    }
        private void tim()
        {
            GiangVien gv = new GiangVien();
            string tk = txttim.Text;
            DataTable dtDS = new System.Data.DataTable();
            dtDS = nvCtr.Timdata(tk);
            DtGvGiangVien.DataSource = dtDS;


            if (tk == "")
            {
                this.label1.Text = "Nhấn vào để tìm kiếm tự động";
            }
            else
            {

                string a = Convert.ToString(dtDS.Rows.Count);
                label1.Text = "có " + a + " kết quả được tìm thấy";
            }
        }
    private void pictureBox8_Click(object sender, EventArgs e)
    {
            tim();
            
           
        }

    private void txttim_TextChanged(object sender, EventArgs e)
    {
            tim();
    }

    private void excel2_MouseHover(object sender, EventArgs e)
    {

    }

    private void excel1_MouseLeave(object sender, EventArgs e)
    {

    }

    private void excel2_Click(object sender, EventArgs e)
    {

    }

    private void buttonSua1_Load(object sender, EventArgs e)
    {

    }

        private void buttonThem1_Load(object sender, EventArgs e)
        {

        }

        private void buttonThem1_Click(object sender, EventArgs e)
        {
            co = 0;
            clearData();
            string a = nvCtr.Tangma();
            txtMa.Text = a;
            annut(true);
            antext(true);
        }

        private void buttonSua1_Click(object sender, EventArgs e)
        {
            co = 1;
            annut(true);
            antext(true);
            txtMa.Enabled = false;
            loadCMB();
        }

        private void buttonXoa1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (nvCtr.Deldata(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công! Bạn phải xóa thông tin tài khoản giảng viên đã liên kết bên Bảng Người Dùng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1_Load(sender, e);
            }
        }

        private void buttonLuu1_Click(object sender, EventArgs e)
        {
            GiangVien nvObj = new GiangVien();
            addData(nvObj);
            if (co == 0)
            {
                if (loi())
                {
                    if (nvCtr.Addata(nvObj))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            else
            {
                if (loi())
                {
                    if (nvCtr.Upddata(nvObj))
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }

            Form1_Load(sender, e);
        }

        private void buttonHuy1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Form1_Load(sender, e);
                
            }
            else
                return;
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 




            DataTable dtDS = new System.Data.DataTable();
            dtDS = nvCtr.Getdata();
            DtGvGiangVien.DataSource = dtDS;
            excel.Export(dtDS, "Danh sach", "DANH SÁCH CÁC GiẢNG VIÊN");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
            tim();
        }

        private void DtGvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
