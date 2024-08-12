using DeTai_QuanLyCuaHangThuCung.DangNhap;
using DeTai_QuanLyCuaHangThuCung.HangHoa;
using DeTai_QuanLyCuaHangThuCung.QuanLyKH;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static DeTai_QuanLyCuaHangThuCung.DangNhap.frm_DangNhap;

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class frm_trangchu : Form
    {
        private string quyen;
        public string hoten {  get; set; }
        public frm_trangchu(string hoten)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            mnTen.Text = UserSession.HoTen;
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
            frm_trangchu trangchu = new frm_trangchu("@HOTEN");
            trangchu.Show();
        }

        private void mn_danhmuc_Click(object sender, EventArgs e)
        {
            frm_danhmuc frm = new frm_danhmuc();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();


        }

        private void mn_kiemkho_Click(object sender, EventArgs e)
        {
            frm_KiemKho frm = new frm_KiemKho();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void mn_hoadon_Click(object sender, EventArgs e)
        {
            //MuaHang frm = new MuaHang();
            //frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            //frm.Show();
        }

        private void Trangchu_FormClosing(object sender, FormClosingEventArgs e)
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
            frm.Show();
        }

        private void mn_thongtinnv_Click(object sender, EventArgs e)
        {
            frm_thongtinnv frm = new frm_thongtinnv();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mn_nhanvien_Click(object sender, EventArgs e)
        {

        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frm_DangNhap frm = new frm_DangNhap();
                frm.Show();

            }

        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void mn_TTCNMenuItem_Click(object sender, EventArgs e)
        {
            frmTTCN frm = new frmTTCN();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }

}
