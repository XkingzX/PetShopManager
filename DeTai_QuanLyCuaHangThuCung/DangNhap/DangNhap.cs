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
        }
        public static class UserSession
        {
            public static string MaNV { get; set; }
            public static string HoTen { get; set; }
        }


        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi);
            string tk = txtTendn.Text;
            string mk = txtMatkhau.Text;
            string quyen = cmbQuyen.SelectedItem?.ToString();
            string hoTen = "Tài khoản chưa đặt tên";

            if (string.IsNullOrEmpty(quyen))
            {
                MessageBox.Show("Vui lòng chọn quyền trước khi đăng nhập!");
                return;
            }
            string sql = @"SELECT MANV, QUYEN, HOTEN FROM NHANVIEN WHERE MANV = @tk AND MatKhau = @mk";

            try
            {
                ketnoi.Open();
                SqlCommand cm = new SqlCommand(sql, ketnoi);
                cm.Parameters.AddWithValue("@tk", tk);
                cm.Parameters.AddWithValue("@mk", mk);
                cm.Parameters.AddWithValue("@HOTEN", hoTen);

                SqlDataReader read = cm.ExecuteReader();

                if (read.Read() == true)
                {
                    string SQLquyen = read["QUYEN"].ToString();
                    //string hoTenx = read["HOTEN"].ToString();
                    //MessageBox.Show("Quyền từ CSDL: " + SQLquyen + "\nQuyền từ combobox: " + quyen); cái này dùng để check nó xuất dữ liệu như nào 
                    if (SQLquyen == quyen)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        frm_trangchu frm = new frm_trangchu("@HOTEN");

                        if (SQLquyen == "Quản lý")
                        {
                            frm.XetQuyenQL();
                        }
                        else if (SQLquyen == "Nhân viên")
                        {
                            frm.XetQuyenNV();
                        }
                        frm.Show();
                        this.Hide();
                        UserSession.MaNV = tk;
                    }
                    else
                    {
                        MessageBox.Show("Quyền không hợp lệ. Vui lòng chọn đúng quyền của bạn!");
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    txtMatkhau.Text = "";
                    //hoTen = "";
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

        private void cmbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
