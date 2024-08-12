﻿using System;
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
        private string cstr = @"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";

        // Hàm khởi tạo của form
        public frmKhachHang()
        {
            InitializeComponent();
            LoadDuLieu();
            LoadNhomKhachHang();
            LoadNhanVien();

            // Liên kết sự kiện Click với các nút
            btnXoa.Click += BtnXoa_Click; ;
            btnSua.Click += BtnSua_Click; ;
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;

        }

        // Phương thức tải dữ liệu khách hàng
        public void LoadDuLieu()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cstr))
                {
                    connection.Open();
                    string query = "SELECT MAKH, HOTEN, SODT, LOAIKH FROM KHACHHANG";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dgvThongTinKhachHang.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi nội dung của ô tìm kiếm thay đổi
        private void TxtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                TimKiemThongTinKH(searchValue);
            }
            else
            {
                LoadDuLieu();
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
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện khi nhấn nút Xóa
        private void BtnXoa_Click(object? sender, EventArgs e)
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
                        string maKhachHang = row.Cells["MAKH"].Value.ToString();
                        XoaKhachHang(maKhachHang);
                    }
                    LoadDuLieu();
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
            if (dgvThongTinKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvThongTinKhachHang.SelectedRows[0];
                string maKhachHang = selectedRow.Cells["MAKH"].Value.ToString();

                ThemThongTinKhachHang themThongTinKhachHangForm = new ThemThongTinKhachHang(maKhachHang);
                themThongTinKhachHangForm.KhachHangUpdated += ThemThongTinKhachHangForm_KhachHangUpdated;
                themThongTinKhachHangForm.ShowDialog();

                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThemThongTinKhachHangForm_KhachHangUpdated(object? sender, EventArgs e)
        {
            LoadDuLieu();
        }

        // Xử lý sự kiện khi thêm khách hàng mới
        private void KhachHangUpdated(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        //Xử lý sự kiện khi form được tải
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        // Xử lý sự kiện khi nhấn nút thêm khách hàng
        private void button1_Click(object sender, EventArgs e)
        {
            string maKhachHang = "KH01";

            ThemThongTinKhachHang themForm = new ThemThongTinKhachHang(maKhachHang);
            themForm.DaHuy += ThemForm_DaHuy;
            themForm.ShowDialog();

            //themForm.KhachHangAdded += OnKhachHangAdded;

        }

        private void ThemForm_DaHuy(object? sender, EventArgs e)
        {
            LoadDuLieu();
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

                    if (dt.Columns.Contains("MaLoaiKH") && dt.Columns.Contains("TenLoaiKH"))
                    {
                        cbxNhomKhachHang.DataSource = dt;
                        cbxNhomKhachHang.DisplayMember = "TenLoaiKH";
                        cbxNhomKhachHang.ValueMember = "MaLoaiKH";
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
                            cbxNguoiTao.DisplayMember = "HOTEN";
                            cbxNguoiTao.ValueMember = "MANV";   
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDuLieu();
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
            try
            {
                using (SqlConnection connection = new SqlConnection(cstr))
                {
                    connection.Open();
                    string query = "SELECT MAKH, HOTEN, SODT, LOAIKH, NGDK FROM KHACHHANG WHERE NGDK BETWEEN @StartDate AND @EndDate";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", TuNgay);
                        command.Parameters.AddWithValue("@EndDate", DenNgay);

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
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lọc dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
