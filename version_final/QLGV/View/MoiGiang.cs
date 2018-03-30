using QLGV.Control;
using QLGV.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGV.Model;

namespace QLGV.View
{
    public partial class MoiGiang : Form
    {
        public static bool KIEMTRA;
        int co = 0;
        ChitietCtrl ctc = new ChitietCtrl();
        public MoiGiang()
        {
            InitializeComponent();
            buttonThem1.Visible = buttonXoa1.Visible = buttonSua1.Visible = buttonLuu1.Visible = buttonHuy1.Visible = KIEMTRA;
            chuot();
            this.cbbmagv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmamon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            txtMamoi.Enabled = false;
        }

        private void excel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void excel2_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void excel1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void MoiGiang_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = ctc.Getdata();
            DtGvGiangVien.DataSource = dtDS;
            doitencot();
            binhding();
            annut(false);
            antext(false);
            loadcbbmagv();
            loadcbbmalop();
            loadcbbmamon();
            
        }
        private void binhding()
        {
            txtMamoi.DataBindings.Clear();
            txtMamoi.DataBindings.Add("Text", DtGvGiangVien.DataSource, "MaMoiGiang");
            cbbmagv.DataBindings.Clear();
            cbbmagv.DataBindings.Add("Text", DtGvGiangVien.DataSource, "MaGiaoVien");
            cbbmalop.DataBindings.Clear();
            cbbmalop.DataBindings.Add("Text", DtGvGiangVien.DataSource, "MaLop");
            cbbmamon.DataBindings.Clear();
            cbbmamon.DataBindings.Add("Text", DtGvGiangVien.DataSource, "MaMon");
            ngaybatdau.DataBindings.Clear();
            ngaybatdau.DataBindings.Add("Text", DtGvGiangVien.DataSource, "NgayBatDau");
            ngayketthuc.DataBindings.Clear();
            ngayketthuc.DataBindings.Add("Text", DtGvGiangVien.DataSource, "NgayKetThuc");
           

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
        private void annut(bool a)//them xoa sua
        {



            buttonLuu1.Enabled = a;
            buttonHuy1.Enabled = a;
            buttonThem1.Enabled = !a;
            buttonXoa1.Enabled = !a;
            buttonSua1.Enabled = !a;


        }
        private void antext(bool e)
        {
           // txtMamoi.Enabled = e;
            cbbmagv.Enabled = e;
            cbbmalop.Enabled = e;
            cbbmamon.Enabled = e;
            ngaybatdau.Enabled = e;
            ngayketthuc.Enabled = e;
          
            //  txttim.Enabled = e;
        }
        private void doitencot()
        {
            DtGvGiangVien.Columns[0].HeaderText = " Mã Phiếu Mời";
            DtGvGiangVien.Columns[1].HeaderText = " Mã Giảng Viên";
            DtGvGiangVien.Columns[2].HeaderText = "Mã Lớp";
            DtGvGiangVien.Columns[3].HeaderText = " Mã Môn";
            DtGvGiangVien.Columns[4].HeaderText = " Ngày Bắt Đầu";
            DtGvGiangVien.Columns[5].HeaderText = " Ngày Kết Thúc";
            
        }
    
         private void clearData()
    {
        txtMamoi.Text = "";
        cbbmagv.Text = "";
        cbbmalop.Text = "";
        cbbmamon.Text = "";
        
        ngaybatdau.Value = DateTime.Now.Date;
        ngayketthuc.Value = DateTime.Now.Date;
    }
       private void addData(ChiTietMG nv)
        {

           
            nv.MaMoiGiang1 = txtMamoi.Text.Trim();
            nv.MaGiaoVien1 = cbbmagv.Text.Trim();
            nv.MaLop1 = cbbmalop.Text.Trim();
            nv.MaMon1 = cbbmamon.Text.Trim();
            nv.NgayBatDau1 = ngaybatdau.Text;
            nv.NgayKetThuc1 = ngayketthuc.Text;

        }
        private void tim()
        {
            ChiTietMG gv = new ChiTietMG();
            string tk = txttim.Text;
            DataTable dtDS = new System.Data.DataTable();
            dtDS = ctc.Timdata(tk);
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
        private void buttonEx1_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 




            DataTable dtDS = new System.Data.DataTable();
            dtDS = ctc.Getdata();
            DtGvGiangVien.DataSource = dtDS;
            excel.Export(dtDS, "Danh sach", "DANH SÁCH CÁC GiẢNG VIÊN");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
            tim();
        }
        public void loadcbbmagv()
        {
            loadcbb("select MaGiaoVien from ThongTinGiangVien", cbbmagv);
        }
        public void loadcbbmalop()
        {
            loadcbb("select MaLop from ThongTinLop", cbbmalop);
        }
        public void loadcbbmamon()
        {
            loadcbb("select MaMon from ThongTinMonHoc", cbbmamon);
        }
        public void loadcbb(string lenh, ComboBox a)
        {
            a.Items.Clear();
            ChiTietMG gv = new ChiTietMG();
            ConnecttoSQL con = new ConnecttoSQL();
            con.OpenCon();
            DataTable dttb = new System.Data.DataTable();
            SqlCommand cmd = new SqlCommand(lenh, con.Connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.CloseCon();
            da.Fill(dttb);

            foreach (DataRow row in dttb.Rows) // Duyệt từng dòng (DataRow) trong DataTable
            {

                foreach (var item in row.ItemArray) // Duyệt từng cột của dòng hiện tại
                {

                    a.Items.Add(item);// In ra giá trị của ô với dòng và cột tương ứng
                }


                a.SelectedItem = 0;
            }
        }
        private void buttonThem1_Click(object sender, EventArgs e)
        {
            co = 0;
            clearData();
            string a = ctc.Tangma();
            txtMamoi.Text = a;
            annut(true);
            antext(true);
        }

        private void buttonSua1_Click(object sender, EventArgs e)
        {
            co = 1;
            annut(true);
            antext(true);
            txtMamoi.Enabled = false;
            loadcbbmagv();
            loadcbbmalop();
            loadcbbmamon();
           
        }

        private void buttonXoa1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ctc.Deldata(txtMamoi.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MoiGiang_Load(sender, e);
            }
        }

        private void buttonLuu1_Click(object sender, EventArgs e)
        {

            ChiTietMG nvObj = new ChiTietMG();
            addData(nvObj);
            if (co == 0)
            {
                
                
                    if (ctc.Addata(nvObj))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công! Bạn chưa điền đủ thông tin Hoặc Ngày bắt đầu lớn hơn ngày kết thúc ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                
                
                    if (ctc.Upddata(nvObj))
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            MoiGiang_Load(sender, e);
        }

        private void buttonHuy1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MoiGiang_Load(sender, e);

            }
            else
                return;
        }

        private void buttonEx1_Click_1(object sender, EventArgs e)
        {
            ExportToExcelct excel = new ExportToExcelct();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 




            DataTable dtDS = new System.Data.DataTable();
            dtDS = ctc.Getdata();
            DtGvGiangVien.DataSource = dtDS;
            excel.Export(dtDS, "Danh sach", "DANH SÁCH MỜI GiẢNG");
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            tim();
        }

        private void MoiGiang_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
            tim();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void DtGvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void exitform(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                System.Threading.Thread.Sleep(50);
                this.Opacity = this.Opacity - 0.03;
            }
            if (this.Opacity < 0.1) this.Close();

        }

        private void DtGvGiangVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
        }
    }
}
