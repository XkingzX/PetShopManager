using DeTai_QuanLyCuaHangThuCung.HangHoa;
using DeTai_QuanLyCuaHangThuCung.QuanLyKH;

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class frm_trangchu : Form
    {
        public frm_trangchu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
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
            MuaHang frm = new MuaHang();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
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

        private void mn_thongtinkhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }

}
