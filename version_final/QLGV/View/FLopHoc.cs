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
using System.Data.SqlClient;

namespace QLGV.View
{
    public partial class LopHocc : Form
    {
        public static bool KIEMTRA;
        LopHocCtrl lhCtrl = new LopHocCtrl();
        int co = 0;
        public LopHocc()
        {
            InitializeComponent();
            buttonThem1.Visible = buttonXoa1.Visible = buttonSua1.Visible = buttonLuu1.Visible = buttonHuy1.Visible = KIEMTRA;
            chuot();
            txtmalop.Enabled = false;
            
        }

        private void LopHocc_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = lhCtrl.Getdata();
            DtGvMonHoc.DataSource = dtDS;
            doitencot();
            binhding();
            annut(false);
            antext(false);

        }
        private bool loi()
        {
            if (txttenlop.Text == "")
            {
                // DialogResult a = new DialogResult();
                MessageBox.Show("Chưa nhập tên lớp", "Thông báo");
                return false;
            }
            return true;
        }
        public void chuot()
        {
            txttimlop.Cursor = new Cursor(@"tim.cur");
            buttonHuy1.Cursor = new Cursor(@"tay.cur");
            buttonLuu1.Cursor = new Cursor(@"tay.cur");
            buttonSua1.Cursor = new Cursor(@"tay.cur");
            buttonThem1.Cursor = new Cursor(@"tay.cur");
            buttonXoa1.Cursor = new Cursor(@"tay.cur");
        }
        private void binhding()
        {
            txtmalop.DataBindings.Clear();
            txtmalop.DataBindings.Add("Text", DtGvMonHoc.DataSource, "MaLop");
            txttenlop.DataBindings.Clear();
            txttenlop.DataBindings.Add("Text", DtGvMonHoc.DataSource, "TenLop");


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
        
        private void antext(bool e)
        {
           //xtmalop.Enabled = e;
            txttenlop.Enabled = e;


        }

        private void doitencot()
        {
            DtGvMonHoc.Columns[0].HeaderText = " Mã Lớp";
            DtGvMonHoc.Columns[1].HeaderText = " Tên Lớp";

        }
        private void clearData()
        {
            txtmalop.Text = "";
            txttenlop.Text = "";

        }
        private void addData(LopHoc x)
        {
            x.MaLop1 = txtmalop.Text.Trim();
            x.TenLop1 = txttenlop.Text.Trim().ToUpper();
        }

        private void buttonThem1_Load(object sender, EventArgs e)
        {

        }
        private void tim()
        {
            LopHoc l = new LopHoc();
            string tk = txttimlop.Text;
            DataTable dtDS = new System.Data.DataTable();
            dtDS = lhCtrl.Timdata(tk);
            DtGvMonHoc.DataSource = dtDS;
        }
        private void txttimlop_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void buttonThem1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSua1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonXoa1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonLuu1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonThem1_Click_1(object sender, EventArgs e)
        {
            co = 0;
            clearData();
            string a = lhCtrl.Tangma();
           
            txtmalop.Text = a;
            annut(true);
            antext(true);
        }

        private void buttonXoa1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (lhCtrl.Deldata(txtmalop.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công! Bạn phải xóa thông tin lớp học đã liên kết bên Bảng Chi Tiết Mời Giảng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LopHocc_Load(sender, e);
            }
        }

        private void buttonSua1_Click_1(object sender, EventArgs e)
        {
            co = 1;
            annut(true);
            antext(true);
            txtmalop.Enabled = false;
        }

        private void buttonLuu1_Click_1(object sender, EventArgs e)
        {
            LopHoc lhObj = new LopHoc();
            addData(lhObj);
            if (co == 0)
            {
                if (Kiemtraten())
                {
                    if (loi())
                    {
                        if (lhCtrl.Addata(lhObj))
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
               

            }
            else
            {
                if (loi())
                {
                    if (lhCtrl.Update(lhObj))
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LopHocc_Load(sender, e);
        }




        private void buttonHuy1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LopHocc_Load(sender, e);

            }
            else
                return;
        }

        private void txttimlop_TextChanged_1(object sender, EventArgs e)
        {
            if (txttimlop.Text == "")
            {
                label1.Text = "Nhập dữ liệu cần tìm";
                LopHocc_Load(sender, e);
            }
            else
            {
                tim();
                int a = DtGvMonHoc.Rows.Count - 1;
                label1.Text = txttimlop.Text + " Có " + a + " kết quả được tìm thấy";

            }
        }
        public bool Kiemtraten()
        {
            string lenh = @"select tenlop from thongtinlop";
            DataTable dt = HOTROSQL.HOTRO.SQL.TAIBANGDULIEU(lenh);
          
            foreach (DataRow row in dt.Rows) // Duyệt từng dòng (DataRow) trong DataTable
            {

                foreach (var item in row.ItemArray) // Duyệt từng cột của dòng hiện tại
                {

                    if (txttenlop.Text.Trim().ToUpper()== Convert.ToString(item))
                    {
                        MessageBox.Show("Bạn đã nhập trùng lớp");
                        return false;
                    }
                }

            }
            return true;

        }

        private void DtGvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
