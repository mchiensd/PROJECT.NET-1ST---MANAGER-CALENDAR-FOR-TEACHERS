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

namespace QLGV.View
{
    public partial class FormMonHoc : Form
    {
        MonHocCtrl mht = new MonHocCtrl();
        int co = 0;
        public static bool KIEMTRA;
        public FormMonHoc()
        {
            InitializeComponent();
            chuot();
            buttonThem1.Visible = buttonXoa1.Visible = buttonSua1.Visible = buttonLuu1.Visible = buttonHuy1.Visible = KIEMTRA;
            txtmamon.Enabled = false;
            
        }
        private void binhding()
        {
            txtmamon.DataBindings.Clear();
            txtmamon.DataBindings.Add("Text", DtGvMonHoc.DataSource, "MaMon");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", DtGvMonHoc.DataSource, "TenMon");
            txtsotiet.DataBindings.Clear();
            txtsotiet.DataBindings.Add("Text", DtGvMonHoc.DataSource, "SoTiet");


        }
        private void antext(bool e)
        {
          //  txtmamon.Enabled = e;
            txtten.Enabled = e;
            txtsotiet.Enabled = e;

            //  txttim.Enabled = e;
        }
        private void clearData()
        {
            txtmamon.Text = "";
            txtten.Text = "";
            txtsotiet.Text = "";
        }
        private void addData(MonHoc mh)
        {
            mh.MaMon1 = txtmamon.Text.Trim();

            mh.TenMon1 = txtten.Text.Trim();
            mh.SoTiet1 = txtsotiet.Text.Trim();


        }
        private void annut(bool a)//them xoa sua
        {

            buttonLuu1.Enabled = a;
            buttonHuy1.Enabled = a;
            buttonThem1.Enabled = !a;
            buttonXoa1.Enabled = !a;
            buttonSua1.Enabled = !a;

        }
        private void doitencot()
        {
            //DtGvMonHoc.Columns[0].HeaderText = " STT";
            //DtGvMonHoc.Columns[1].HeaderText = " Mã Môn Học";
            //DtGvMonHoc.Columns[2].HeaderText = " Tên Môn Học";
            //DtGvMonHoc.Columns[3].HeaderText = "Số tiết";

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            
            DataTable dtDS = new System.Data.DataTable();
            dtDS = mht.Getdata();
            DtGvMonHoc.DataSource = dtDS;
            
            doitencot();
            annut(false);
            binhding();
            antext(false);

        }
        private bool loi()
        {
            if (txtten.Text == "" || txtsotiet.Text=="")
            {
                // DialogResult a = new DialogResult();
                MessageBox.Show("Chưa đủ thông tin", "Thông báo");
                return false;
            }
            return true;
        }

        private void xoa1_Click(object sender, EventArgs e)
        {

        }

        private void them1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void xoa1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void sua1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void luu1_Click(object sender, EventArgs e)
        {

        }

        private void luu1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void huy1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void them2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void xoa2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void sua2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void luu2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void huy2_MouseLeave(object sender, EventArgs e)
        {
            
        }
       
        private void them2_Click(object sender, EventArgs e)
        {
           
        }

        private void xoa2_Click(object sender, EventArgs e)
        {
           
        }

        private void sua2_Click(object sender, EventArgs e)
        {
           
        }

        private void luu2_Click(object sender, EventArgs e)
        {
            
        }

        private void huy2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tim();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
        private void tim()
        {
            GiangVien gv = new GiangVien();
            string tk = txttim.Text;
            DataTable dtDS = new System.Data.DataTable();
            dtDS = mht.Timdata(tk);
            DtGvMonHoc.DataSource = dtDS;


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
        private void buttonThem1_Click(object sender, EventArgs e)
        {
            co = 0;
            clearData();
            string a = mht.Tangma();
            txtmamon.Text = a;
            annut(true);
            antext(true);
        }

        private void buttonXoa1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa môn học này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (mht.Deldata(txtmamon.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công! Bạn phải xóa thông tin môn học đã liên kết bên Bảng Chi Tiết Mời Giảng trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormMonHoc_Load(sender, e);
            }
        }

        private void buttonSua1_Click(object sender, EventArgs e)
        {
            co = 1;
            annut(true);
            antext(true);
            txtmamon.Enabled = false;
        }

        private void buttonHuy1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                FormMonHoc_Load(sender, e);
            else
                return;
        }

        private void buttonLuu1_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            addData(mh);
            if (co == 0)
            {
                if (loi())
                {
                    if (mht.Adddata(mh))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            else
            {
                if (loi())
                {
                    if (mht.Upddata(mh))
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }

            FormMonHoc_Load(sender, e);
        }

        private void FormMonHoc_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
            tim();
        }

        private void buttonLuu1_Load(object sender, EventArgs e)
        {

        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            tim();
        }
    }
}
