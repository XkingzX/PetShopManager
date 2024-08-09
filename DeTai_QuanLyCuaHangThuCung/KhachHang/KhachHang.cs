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
        // Hàm khởi tạo của form
        public frmKhachHang()
        {
            InitializeComponent();
            LoadNhomKhachHang();
            LoadNhanVien();
            LoadKhachHang();

            // Liên kết sự kiện Click với các nút
            btnXoa.Click += BtnXoa_Click; ;
            btnSua.Click += BtnSua_Click; ;
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
        }

        // Xử lý sự kiện khi nội dung của ô tìm kiếm thay đổi
        private void TxtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim();

            // Chỉ thực hiện tìm kiếm nếu đầu vào không trống
            if (!string.IsNullOrEmpty(searchValue))
            {
                // Cập nhật tìm kiếm dựa trên đầu vào của người dùng
                TimKiemThongTinKH(searchValue);
            }
            else
            {
                // Tải lại tất cả dữ liệu nếu giá trị tìm kiếm bị xóa
                LoadKhachHang();
            }
        }

        // Phương thức tìm kiếm khách hàng dựa trên giá trị đầu vào
        private void TimKiemThongTinKH(string value)
        {
            string query = "SELECT MAKH, HOTEN, SODT, LOAIKH FROM KHACHHANG WHERE MAKH LIKE @Value OR HOTEN LIKE @Value OR SODT LIKE @Value";

            try
            {
                using (SqlConnection connection = new SqlConnection(cstr))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Sử dụng ký tự đại diện để khớp một phần
                        command.Parameters.AddWithValue("@Value", "%" + value + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvThongTinKhachHang.DataSource = dt;


                        // Xử lý các trường hợp không tìm thấy kết quả
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy kết quả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi nhấn nút Xóa
        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
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
                        string maKhachHang = row.Cells["MAKH"].Value.ToString();
                        XoaKhachHang(maKhachHang);
                    }
                    LoadKhachHang();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xử lý sự kiện khi nhấn nút Sửa
        private void BtnSua_Click(object? sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvThongTinKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvThongTinKhachHang.SelectedRows[0];
                string maKhachHang = selectedRow.Cells["MAKH"].Value.ToString();

                // Tạo đối tượng ThemThongTinKhachHang và truyền tham số maKhachHang
                ThemThongTinKhachHang themThongTinKhachHangForm = new ThemThongTinKhachHang(maKhachHang);
                themThongTinKhachHangForm.KhachHangAdded += OnKhachHangAdded;
                themThongTinKhachHangForm.ShowDialog();

                // Cập nhật lại DataGridView sau khi sửa dữ liệu
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Chuỗi kết nối cơ sở dữ liệu
        private string cstr = @"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";


        // Phương thức kiểm tra kết nối cơ sở dữ liệu
        private void TestConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cstr))
                {
                    connection.Open();
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi thêm khách hàng mới
        private void OnKhachHangAdded(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        // Xử lý sự kiện khi form được tải
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadNhanVien();
        }

        // Xử lý sự kiện khi nhấn nút thêm khách hàng
        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một mã khách hàng giả định hoặc từ dữ liệu khác
            string maKhachHang = "KH000001"; // Hoặc lấy giá trị thực tế từ đâu đó

            // Tạo một đối tượng của form ThemThongTinKhachHang với tham số
            ThemThongTinKhachHang themForm = new ThemThongTinKhachHang(maKhachHang);

            // Liên kết sự kiện khi thêm khách hàng mới
            themForm.KhachHangAdded += OnKhachHangAdded;
            themForm.ShowDialog();
        }

        // Phương thức tải nhóm khách hàng
        private void LoadNhomKhachHang()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cstr))
                {
                    connection.Open();
                    string query = "SELECT MaLoaiKH, TenLoaiKH FROM LoaiKhachHang";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Kiểm tra xem DataTable có các cột dự kiến ​​không
                    if (dt.Columns.Contains("MaLoaiKH") && dt.Columns.Contains("TenLoaiKH"))
                    {
                        cbxNhomKhachHang.DataSource = dt;
                        cbxNhomKhachHang.DisplayMember = "TenLoaiKH"; // Tên hiển thị trong ComboBox
                        cbxNhomKhachHang.ValueMember = "MaLoaiKH";   // Giá trị của mục được chọn
                    }
                    else
                    {
                        MessageBox.Show("Data table does not contain required columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức tải dữ liệu nhân viên
        private void LoadNhanVien()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cstr))
                {
                    connection.Open();
                    string query = "SELECT MANV, HOTEN FROM NHANVIEN";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Columns.Contains("MANV") && dt.Columns.Contains("HOTEN"))
                        {
                            cbxNguoiTao.DataSource = dt;
                            cbxNguoiTao.DisplayMember = "HOTEN"; // Tên hiển thị trong ComboBox
                            cbxNguoiTao.ValueMember = "MANV";   // Giá trị của mục được chọn
                        }
                        else
                        {
                            MessageBox.Show("Data table does not contain required columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi người dùng click vào ô trong DataGridView
        private void dgvThongTinKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadKhachHang();
        }

        // Phương thức tải dữ liệu khách hàng
        private void LoadKhachHang()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cstr))
                {
                    connection.Open();
                    string query = "SELECT MAKH, HOTEN, SODT, LOAIKH FROM KHACHHANG";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvThongTinKhachHang.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức xóa khách hàng
        private void XoaKhachHang(string maKhachHang)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
