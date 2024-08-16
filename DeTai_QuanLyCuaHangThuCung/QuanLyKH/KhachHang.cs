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

namespace DeTai_QuanLyCuaHangThuCung.QuanLyKH
{
    public partial class frmKhachHang : Form
    {
        // Chuỗi kết nối cơ sở dữ liệu
        private string cstr = @"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";
        public frmKhachHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                connection.Open();
                string query = "SELECT MAKH as N'Mã khách hàng', HOTEN as N'Họ tên', LOAIKH as N'Loại khách hàng', DIEMTHUONG as N'Điểm thưởng', SODT as N'Số điện thoại',NGDK as N'Ngày đăng ký' FROM KHACHHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvThongTinKhachHang.DataSource = dataTable;
                txtTimKiem.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThongTinKhachHang.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvThongTinKhachHang.SelectedRows)
                    {
                        string maKhachHang = row.Cells["Mã khách hàng"].Value.ToString();
                        XoaDuLieu(maKhachHang);
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XoaDuLieu(string maKhachHang)
        {
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                connection.Open();
                string query = "DELETE FROM KHACHHANG WHERE MAKH = @MaKH";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKH", maKhachHang);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            string maKhachHang = "KH001";
            using (ThemThongTinKhachHang formThemThongTin = new ThemThongTinKhachHang(maKhachHang))
            {
                DialogResult result = formThemThongTin.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvThongTinKhachHang.SelectedRows.Count > 0)
            {
                string maKhachHang = dgvThongTinKhachHang.SelectedRows[0].Cells["Mã khách hàng"].Value.ToString();

                using (ThemThongTinKhachHang formThemThongTin = new ThemThongTinKhachHang(maKhachHang))
                {
                    formThemThongTin.ShowDialog();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                TimKiemDuLieu(searchValue);
            }
            else
            {
                LoadData();
            }
        }
        private void TimKiemDuLieu(string value)
        {
            string query = "SELECT MAKH as N'Mã khách hàng', HOTEN as N'Họ tên', LOAIKH as N'Loại khách hàng', DIEMTHUONG as N'Điểm thưởng', SODT as N'Số điện thoại', NGDK as N'Ngày đăng ký' FROM KHACHHANG WHERE MAKH LIKE @Value OR HOTEN LIKE @Value OR SODT LIKE @Value";
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", "%" + value + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvThongTinKhachHang.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime TuNgay = dtpTuNgay.Value.Date;
            DateTime DenNgay = dtpDenNgay.Value.Date;

            if (TuNgay <= DenNgay)
            {
                LocTheoNgay(TuNgay, DenNgay);
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LocTheoNgay(DateTime TuNgay, DateTime DenNgay)
        {
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                connection.Open();
                string query = "SELECT MAKH as N'Mã khách hàng', HOTEN as N'Họ tên', LOAIKH as N'Loại khách hàng', DIEMTHUONG as N'Điểm thưởng', SODT as N'Số điện thoại', NGDK as N'Ngày đăng ký' FROM KHACHHANG WHERE NGDK >= @StartDate AND NGDK <= @EndDate";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", TuNgay);
                    command.Parameters.AddWithValue("@EndDate", DenNgay.AddDays(1).AddTicks(-1));

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvThongTinKhachHang.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có khách hàng nào trong khoảng thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_hienthitatca_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                {
                    cn.Open();
                    string sql = "SELECT MAKH as N'Mã khách hàng', HOTEN as N'Họ tên', LOAIKH as N'Loại khách hàng', DIEMTHUONG as N'Điểm thưởng', SODT as N'Số điện thoại',NGDK as N'Ngày đăng ký' FROM KHACHHANG";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvThongTinKhachHang.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
