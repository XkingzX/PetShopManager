﻿using DeTai_QuanLyCuaHangThuCung.QuanLyKH;
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
using System.Windows.Input;

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class ThemThongTinKhachHang : Form
    {

        public ThemThongTinKhachHang(string maKhachHang)
        {
            InitializeComponent();
            LoadTinh();
            TaoMaKhachHang();
            LoadKhachHang(maKhachHang);
            if (!string.IsNullOrEmpty(maKhachHang))
            {
                LoadKhachHang(maKhachHang);
            }
            dtpNgayDK.Value = DateTime.Now;
            dtpNgayDK.Enabled = true; // Không cho phép chỉnh sửa ngày tạo
        }

        // Chuỗi kết nối cơ sở dữ liệu
        private string cstr = @"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";
                
        // Dữ liệu về tỉnh, huyện và xã
        private Dictionary<string, Dictionary<string, List<string>>> data = new Dictionary<string, Dictionary<string, List<string>>>()
        {
            {
                "Bình Dương", new Dictionary<string, List<string>>()
                {
                    { "Thành phố Thuận An", new List<string> { "Phường An Phú", "Phường An Thạnh", "Phường Bình Chuẩn", "Phường Bình Hòa", "Phường Bình Nhâm", "Phường Hưng Định", "Phường Lái Thiêu", "Phường Thuận Giao", "Phường Vĩnh Phú", "Xã An Sơn" } },
                    { "Thành phố Thủ Dầu Một", new List<string> { "Phường Phú Cường", "Phường Hiệp Thành", "Phường Chánh Nghĩa", "Phường Phú Thọ", "Phường Phú Hòa", "Phường Phú Lợi", "Phường Hiệp An", "Phường Định Hòa", "Phường Phú Mỹ", "Phường Hòa Phú", "Phường Phú Tân" } }
                }
            },
            {
                "Hồ Chí Minh", new Dictionary<string, List<string>>()
                {
                    { "Quận 1", new List<string> { "Phường Bến Nghé", "Phường Bến Thành", "Phường Cô Giang", "Phường Cầu Ông Lãnh", "Phường Cầu Kho", "Phường Đa Kao", "Phường Nguyễn Cư Trinh", "Phường Phạm Ngũ Lão", "Phường Nguyễn Thái Bình", "Phường Tân Định" } },
                    { "Quận 2", new List<string> { "Phường An Khánh", "Phường An Lợi Đông", "Phường An Phú", "Phường Bình An", "Phường Bình Khánh", "Phường Bình Trưng Đông", "Phường Bình Trưng Tây", "Phường Cát Lái", "Phường Thạnh Mỹ Lợi", "Phường Thảo Điền", "Phường Thủ Thiêm" } },

                }
            },
            {
                "Bà Rịa Vũng Tàu", new Dictionary<string, List<string>>()
                {
                    {"Thành Phố Bà Rịa", new List<string>{ "Phường Phước Hưng", "Phường Phước Hiệp", "Phường Phước Nguyên", "Phường Long Toàn", "Phường Long Tâm", "Phường Phước Trung", "Phường Long Hương", "Phường Kim Dinh", "Xã Tân Hưng", "Xã Long Phước", "Xã Hòa Long" } },
                    {"Thành Phố Vũng Tàu", new List<string> { "Phường 1", "Phường 2", "Phường 3", "Phường 4", "Phường 5", "Phường 7", "Phường 8", "Phường 9", "Phường 10", "Phường 11", "Phường 12", "Phường Thắng Nhất", "Phường Thắng Nhì", "Phường Thắng Tam", "Phường Nguyễn An Ninh", "Phường Rạch Dừa", "Xã đảo Long Sơn" } }
                }
            }
        };

        // Phương thức tải dữ liệu tỉnh

        private void LoadTinh()
        {
            cbxTinh.Items.Clear();
            foreach (var Tinh in data.Keys)
            {
                cbxTinh.Items.Add(Tinh);
            }
        }

        // Sự kiện khi thay đổi tỉnh
        private void cbxTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTinh = cbxTinh.SelectedItem.ToString();
            if (selectedTinh != null)
            {
                LoadHuyenQuan(selectedTinh);
            }
        }

        // Phương thức tải dữ liệu huyện/phường
        private void LoadHuyenQuan(string Tinh)
        {
            cbxHuyenQuan.Items.Clear();
            cbxPhuongXa.Items.Clear();
            cbxPhuongXa.Enabled = false;

            if (data.TryGetValue(Tinh, out var HuyenQuanS))
            {
                foreach (var HuyenQuan in HuyenQuanS.Keys)
                {
                    cbxHuyenQuan.Items.Add(HuyenQuan);
                }
                cbxHuyenQuan.Enabled = true;
            }
        }

        // Sự kiện khi thay đổi huyện/quận
        private void cbxHuyenQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTinh = cbxTinh.SelectedItem.ToString();
            var selectedHuyenQuan = cbxHuyenQuan.SelectedItem.ToString();
            if (selectedTinh != null)
            {
                LoadPhuongXa(selectedTinh, selectedHuyenQuan);
            }
        }

        // Phương thức tải dữ liệu phường/xã
        private void LoadPhuongXa(string Tinh, string HuyenQuan)
        {
            cbxPhuongXa.Items.Clear();

            if (data.TryGetValue(Tinh, out var HuyenQuanS) && HuyenQuanS.TryGetValue(HuyenQuan, out var PhuongXaS))
            {
                foreach (var PhuongXa in PhuongXaS)
                {
                    cbxPhuongXa.Items.Add(PhuongXa);
                }
                cbxPhuongXa.Enabled = true;
            }
        }

        // Sự kiện khi nhấn nút thêm khách hàng
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng của form ThongTinKhachHang
            ThemThongTinKhachHang thongTinKhachHangForm = new ThemThongTinKhachHang(this.maKhachHang);

            // Hiển thị form ThongTinKhachHang dưới dạng dialog
            thongTinKhachHangForm.ShowDialog();
        }

        // Phương thức tạo mã khách hàng ngẫu nhiên
        private void TaoMaKhachHang()
        {
            // Tạo mã khách hàng theo định dạng KH******
            txtMaKH.Text = "KH" + ChuoiSoNgauNhienMaKH(2);
        }

        // Phương thức tạo chuỗi số ngẫu nhiên
        private string ChuoiSoNgauNhienMaKH(int length)
        {
            Random random = new Random();
            char[] stringChars = new char[length];
            for (int i = 0; i < length; i++)
            {
                stringChars[i] = (char)('0' + random.Next(10));
            }
            return new string(stringChars);
        }

        public event EventHandler DaHuy;

        // Sự kiện khi nhấn nút bỏ qua
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DaHuy?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void ThemThongTinKhachHang_Load(object sender, EventArgs e)
        {
            
        }

        // Sự kiện khi nhấn nút lưu
        private void btnLua_Click(object sender, EventArgs e)
        {
            if (KiemTraForm())
            {
                LuuThongTinKhachHang();
            }


        }

        // Phương thức kiểm tra tính hợp lệ của form
        private bool KiemTraForm()
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
            string.IsNullOrWhiteSpace(txtTenKH.Text) ||
            string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
            cbxTinh.SelectedItem == null ||
            cbxHuyenQuan.SelectedItem == null ||
            cbxPhuongXa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public delegate void KhachHangAddedEventHandler(object sender, EventArgs e);
        public event KhachHangAddedEventHandler KhachHangAdded;

        // Phương thức tải thông tin khách hàng từ cơ sở dữ liệu
        private void LoadKhachHang(string maKhachHang)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cstr))
                {
                    connection.Open();

                    string query = "SELECT * FROM KHACHHANG WHERE MAKH = @MaKH";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaKH", maKhachHang);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMaKH.Text = reader["MAKH"].ToString();
                                txtTenKH.Text = reader["HOTEN"].ToString();
                                txtDienThoai.Text = reader["SODT"].ToString();
                                if (reader["NGSINH"] != DBNull.Value)
                                {
                                    dtpNgaySinh.Value = (DateTime)reader["NGSINH"];
                                }
                                if (reader["NGDK"] != DBNull.Value)
                                {
                                    dtpNgayDK.Value = (DateTime)reader["NGDK"];
                                }
                                txtDiaChi.Text = reader["DIACHI"].ToString();
                                cbxTinh.SelectedItem = reader["TINH"].ToString();
                                cbxHuyenQuan.SelectedItem = reader["HUYEN"].ToString();
                                cbxPhuongXa.SelectedItem = reader["XA"].ToString();
                                if (reader["LOAIKH"].ToString() == "Cá Nhân")
                                {
                                    rbtnCaNhan.Checked = true;
                                }
                                else
                                {
                                    rbtnCongTy.Checked = true;
                                }
                                txtEmail.Text = reader["EMAIL"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public event EventHandler KhachHangUpdated;

        // Phương thức lưu thông tin khách hàng
        private void LuuThongTinKhachHang()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cstr))
                {
                    connection.Open();
                    string query = KiemTraTonTaiKH(txtMaKH.Text) ?
                        @"UPDATE KHACHHANG 
                      SET HOTEN = @TenKH, SODT = @SoDienThoai, NGSINH = @NgaySinh, DIACHI = @DiaChi, 
                          TINH = @Tinh, HUYEN = @Huyen, XA = @Xa, LOAIKH = @LoaiKhachHang, EMAIL = @Email ,NGDK =@NgayDK
                      WHERE MAKH = @MaKH" :
                        @"INSERT INTO KHACHHANG 
                      (MAKH, HOTEN, SODT, NGSINH,NGDK, DIACHI, TINH, HUYEN, XA, LOAIKH, EMAIL) 
                      VALUES 
                      (@MaKH, @TenKH, @SoDienThoai, @NgaySinh, @DiaChi, @Tinh, @Huyen, @Xa, @LoaiKhachHang, @Email,@NgayDK)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                        command.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                        command.Parameters.AddWithValue("@SoDienThoai", txtDienThoai.Text);
                        command.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        command.Parameters.AddWithValue("@NgayDK", dtpNgayDK.Value);
                        command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        command.Parameters.AddWithValue("@Tinh", cbxTinh.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Huyen", cbxHuyenQuan.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Xa", cbxPhuongXa.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@LoaiKhachHang", rbtnCaNhan.Checked ? rbtnCaNhan.Text : rbtnCongTy.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Lưu thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhachHangUpdated?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức kiểm tra tồn tại khách hàng
        private bool KiemTraTonTaiKH(string maKhachHang)
        {
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM KHACHHANG WHERE MAKH = @MaKH";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKH", maKhachHang);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        private string selectedImagePath;
        private string maKhachHang;

        // Sự kiện khi nhấn nút chọn ảnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(filePath);
                    selectedImagePath = filePath;
                }
            }
        }

    }
}
