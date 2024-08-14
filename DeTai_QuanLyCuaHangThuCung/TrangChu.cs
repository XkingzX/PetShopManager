using DeTai_QuanLyCuaHangThuCung.DangNhap;
using DeTai_QuanLyCuaHangThuCung.GiaoDich;
using DeTai_QuanLyCuaHangThuCung.HangHoa;
using DeTai_QuanLyCuaHangThuCung.QuanLyKH;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;
using static DeTai_QuanLyCuaHangThuCung.DangNhap.frm_DangNhap;

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class frm_trangchu : Form
    {
        private string quyen;
        private string hoTEN;
        public frm_trangchu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            //mnTen.Text = UserSession.HoTen;
        }

        public void XetQuyenQL()
        {
            mn_nhanvien.Visible = true;
        }
        public void XetQuyenNV()
        {
            mn_nhanvien.Visible = false;
        }

        private void mn_tongquan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_trangchu trangchu = new frm_trangchu();
            trangchu.Show();
        }

        private void mn_danhmuc_Click(object sender, EventArgs e)
        {
            frm_danhmuc frm = new frm_danhmuc();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            this.Width = 755;
            this.Width = 845;
            frm.Show();


        }

        private void mn_kiemkho_Click(object sender, EventArgs e)
        {
            frm_KiemKho frm = new frm_KiemKho();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            this.Width = 755;
            this.Width = 845;
            frm.Show();
        }

        private void frm_trangchu_Load(object sender, EventArgs e)
        {
            /*if (!string.IsNullOrEmpty(UserSession.HoTen))
            {
                mnTen.Text = UserSession.HoTen;
            }
            this.Width = 855;
            this.Height = 740;*/
            this.Hide();
        }

        private void mn_thongtinkhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            this.Width = 890;
            this.Height = 500;
            frm.Show();
        }

        private void mn_thongtinnv_Click(object sender, EventArgs e)
        {
            frm_thongtinnv frmDangmo = null;
            foreach (Form Frm in this.MdiChildren) //sử dụng vòng lặp for each để kiếm tra tất cả các form con, nếu có form con của form chính đang mở thì gán nó vào biến frmDangmo 
            {
                if (Frm is frm_thongtinnv)
                {
                    frmDangmo = (frm_thongtinnv)Frm;
                    break; //Nếu có đã tìm đc frm đang mở thì hủy vòng lặp
                }
            }
            if (frmDangmo != null) //tức là form đang mơ, đưa lên trước
            {
                frmDangmo.BringToFront();
            }

            else //ngược lại thì tạo form mới
            {
                frm_thongtinnv newfrm = new frm_thongtinnv();
                newfrm.MdiParent = this;
                newfrm.Dock = DockStyle.Fill;
                newfrm.Show();
            }
            this.Width = 760;
            this.Height = 680;
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_DangNhap frm = new frm_DangNhap();
                frm.Show();
                this.Hide();
            }

        }

        private void mnTTCN_Click(object sender, EventArgs e)
        {
            frmTTCN frmDangmo = null;
            foreach (Form Frm in this.MdiChildren)
            {
                if (Frm is frmTTCN)
                {
                    frmDangmo = (frmTTCN)Frm;
                    break;
                }
            }
            if (frmDangmo != null) //tức là form đang mơ, đưa lên trước
            {
                frmDangmo.BringToFront();
            }

            else
            {
                frmTTCN newfrm = new frmTTCN();
                newfrm.MdiParent = this;
                newfrm.Dock = DockStyle.Fill;
                newfrm.Show();
            }
            this.Width = 800;
            this.Height = 420;
        }

        private void mn_xemhoadon_Click(object sender, EventArgs e)
        {
            frm_hoadon frm = new frm_hoadon();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            this.Width = 890;
            this.Height = 470;
            frm.Show();
        }

        private void mn_muahang_Click(object sender, EventArgs e)
        {
            MuaHang frm = new MuaHang();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            this.Width = 955;
            this.Height = 640;
            frm.Show();
        }

        private void frm_trangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void mn_doanhthu_Click(object sender, EventArgs e)
        {
            DoanhThu frm = new DoanhThu();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            this.Width = 855;
            this.Height = 440;
            frm.Show();
        }
    }

}
