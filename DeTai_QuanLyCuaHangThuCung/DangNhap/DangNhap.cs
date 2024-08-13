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
using System.Data;
using System.Data.SqlClient;

namespace DeTai_QuanLyCuaHangThuCung.DangNhap
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#F6C860");
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                // Đặt focus vào tên đăng nhập khi form được tải
                txtTendn.Focus();
            }));
        }

        public static class UserSession
        {
            public static string MaNV { get; set; }
        }



        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi);

            string tk = txtTendn.Text;
            string mk = txtMatkhau.Text;

            string sql = @"SELECT MANV, MATKHAU, QUYEN FROM NHANVIEN WHERE MANV = @tk AND MatKhau = @mk";

            try
            {

                ketnoi.Open();
                SqlCommand cm = new SqlCommand(sql, ketnoi);
                cm.Parameters.AddWithValue("@tk", tk);
                cm.Parameters.AddWithValue("@mk", mk);
                SqlDataReader read = cm.ExecuteReader();


                if (read.Read() == true)
                {
                    string SQLquyen = read["QUYEN"].ToString();
                    MessageBox.Show("Đăng nhập thành công");
                    frm_trangchu frm = new frm_trangchu();

                    if (SQLquyen == "Quản lý")
                    {
                        frm.XetQuyenQL();
                    }
                    else if (SQLquyen == "Nhân viên")
                    {
                        frm.XetQuyenNV();
                    }
                    this.Hide();
                    frm.Show();
                    UserSession.MaNV = tk;
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    txtMatkhau.Text = "";
                    txtTendn.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối không thành công!");
                throw new Exception("Lỗi: " + ex.Message);
            }
            finally
            {
                ketnoi.Close();
            }
        }

        private void txtTendn_TextChanged(object sender, EventArgs e)
        {
            txtTendn.Text = txtTendn.Text.ToUpper();
            txtTendn.SelectionStart = txtTendn.Text.Length;
        }

        private void txtTendn_Enter(object sender, EventArgs e)
        {

            if (txtTendn.Text == "MÃ NHÂN VIÊN")
            {
                txtTendn.Text = "";
                txtTendn.ForeColor = Color.Black;
            }

        }

        private void txtTendn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTendn.Text))
            {
                txtTendn.Text = "MÃ NHÂN VIÊN";
                txtTendn.ForeColor = Color.Silver;
            }
        }

        private void txtMatkhau_Enter(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == "MẬT KHẨU")
            {
                txtMatkhau.Text = "";
                txtMatkhau.ForeColor = Color.Black;
            }
            txtMatkhau.UseSystemPasswordChar = true;
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                txtMatkhau.Text = "MẬT KHẨU";
                txtMatkhau.ForeColor = Color.Silver;
                txtMatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatkhau.UseSystemPasswordChar = true;
            }

        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private void cmbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTendn_Click(object sender, EventArgs e)
        {

        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatkhau_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btn_DangNhap_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_BackColorChanged(object sender, EventArgs e)
        {

        }
    }

}
