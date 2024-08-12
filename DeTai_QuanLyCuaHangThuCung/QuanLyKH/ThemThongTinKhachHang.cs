using DeTai_QuanLyCuaHangThuCung.QuanLyKH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class ThemThongTinKhachHang : Form
    {

        private string maKhachHang;
        public delegate void KhachHangAddedEventHandler(object sender, EventArgs e);
        public event KhachHangAddedEventHandler KhachHangAdded;
        public string MaKhachHang { get; set; }
        public ThemThongTinKhachHang(string maKhachHang)
        {
            InitializeComponent();
            LoadTinh();
            TaoMaKhachHang();
            LoadKhachHang(maKhachHang);
            this.maKhachHang = maKhachHang;
            dtpNgayDK.Value = DateTime.Now;
            MaKhachHang = maKhachHang;
 

            cbxTinh.SelectedIndexChanged += CbxTinh_SelectedIndexChanged;
            cbxHuyenQuan.SelectedIndexChanged += CbxHuyenQuan_SelectedIndexChanged;

            cbxTinh.DropDown += CbxTinh_DropDown;
            cbxHuyenQuan.DropDown += CbxHuyenQuan_DropDown;
            cbxPhuongXa.DropDown += CbxPhuongXa_DropDown;
        }

        private void CbxPhuongXa_DropDown(object sender, EventArgs e)
        {
            if (cbxHuyenQuan.DataSource == null || cbxHuyenQuan.Items.Count <= 1)
            {
                int maTinh = Convert.ToInt32(cbxTinh.SelectedValue);
                if (maTinh != 0)
                {
                    LoadHuyen(maTinh);
                }
            }
        }

        private void CbxHuyenQuan_DropDown(object sender, EventArgs e)
        {
            if (cbxPhuongXa.DataSource == null || cbxPhuongXa.Items.Count <= 1)
            {
                int maHuyen = Convert.ToInt32(cbxHuyenQuan.SelectedValue);
                if (maHuyen != 0)
                {
                    LoadXa(maHuyen);
                }
            }
        }

        private void CbxTinh_DropDown(object sender, EventArgs e)
        {
            if (cbxTinh.DataSource == null) 
            {
                LoadTinh();
            }
        }

        private void CbxTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTinh.SelectedValue != null)
            {
                if (cbxTinh.SelectedValue is DataRowView rowView)
                {
                    int maTinh = Convert.ToInt32(rowView["MATINH"]);
                    LoadHuyen(maTinh); 
                }
                else if (cbxTinh.SelectedValue is int maTinh)
                {
                    LoadHuyen(maTinh); 
                }
            }
        }
        private void CbxHuyenQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxHuyenQuan.SelectedValue != null)
            {
                if (cbxHuyenQuan.SelectedValue is DataRowView rowView)
                {
                    int maHuyen = Convert.ToInt32(rowView["MAHUYEN"]); 
                    LoadXa(maHuyen); 
                }
                else if (cbxHuyenQuan.SelectedValue is int maHuyen)
                {
                    LoadXa(maHuyen); 
                }
            }
        }


        // Chuỗi kết nối cơ sở dữ liệu
        private string cstr = @"Data Source=TIENTOI;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True";

        private void LoadTinh()
        {
            using (SqlConnection conn = new SqlConnection(cstr))
            {
                string query = "SELECT MATINH, TENTINH FROM TINH";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["MATINH"] = 0;
                defaultRow["TENTINH"] = "Chọn Tỉnh";
                dt.Rows.InsertAt(defaultRow, 0);

                cbxTinh.DataSource = dt;
                cbxTinh.DisplayMember = "TENTINH";
                cbxTinh.ValueMember = "MATINH";
            }
        }

        private void LoadHuyen(int tinhId)
        {
            using (SqlConnection conn = new SqlConnection(cstr))
            {
                string query = "SELECT MAHUYEN, TENHUYEN FROM HUYEN WHERE MATINH = @maTinh";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@maTinh", tinhId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["MAHUYEN"] = 0;
                defaultRow["TENHUYEN"] = "Chọn Huyện";
                dt.Rows.InsertAt(defaultRow, 0);

                cbxHuyenQuan.DataSource = dt;
                cbxHuyenQuan.DisplayMember = "TENHUYEN";
                cbxHuyenQuan.ValueMember = "MAHUYEN";
            }
        }


        private void LoadXa(int maHuyen)
        {
            using (SqlConnection conn = new SqlConnection(cstr))
            {
                string query = "SELECT MAXA, TENXA FROM XA WHERE MAHUYEN = @maHuyen";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@maHuyen", maHuyen);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow defaultRow = dt.NewRow();
                defaultRow["MAXA"] = 0;
                defaultRow["TENXA"] = "Chọn Xã";
                dt.Rows.InsertAt(defaultRow, 0);

                cbxPhuongXa.DataSource = dt;
                cbxPhuongXa.DisplayMember = "TENXA";
                cbxPhuongXa.ValueMember = "MAXA";
            }
        }

        private void TaoMaKhachHang()
        {
            txtMaKH.Text = "KH" + ChuoiSoNgauNhienMaKH(2);
        }

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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private bool KiemTraForm()
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
            string.IsNullOrWhiteSpace(txtTenKH.Text) ||
            string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
            cbxTinh.SelectedItem == null ||
            cbxHuyenQuan.SelectedItem == null /*||*/
            /*cbxPhuongXa.SelectedItem == null*/)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }




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

                                string gioiTinh = reader["GioiTinh"].ToString();
                                if (gioiTinh == "Nam")
                                {
                                    rbtnNam.Checked = true;
                                }
                                else if (gioiTinh == "Nữ")
                                {
                                    rbtnNu.Checked = true;
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

        private bool KiemTraTonTaiKH(string maKhachHang)
        {
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM KHACHHANG WHERE MAKH = @MAKH";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MAKH", maKhachHang);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void LuuThongTinKhachHang(string maKhachHang, string hoTen, string diaChi, string sdt, DateTime ngaySinh, DateTime ngayDK, string email, int tinhId, int huyenId, int xaId, string gioiTinh)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cstr))
                {
                    connection.Open();

                    // Kiểm tra xem khách hàng có tồn tại không
                    string query = KiemTraTonTaiKH(maKhachHang) ?
                        @"UPDATE KHACHHANG 
                SET HOTEN = @HOTEN, DIACHI = @DIACHI, SODT = @SODT, NGSINH = @NGSINH, NGDK = @NGDK, 
                    EMAIL = @EMAIL, MATINH = @TINHID, MAHUYEN = @HUYENID, MAXA = @XAID, GIOITINH = @GIOITINH
                WHERE MAKH = @MAKH" :
                        @"INSERT INTO KHACHHANG 
                (MAKH, HOTEN, DIACHI, SODT, NGSINH, NGDK, EMAIL, MATINH, MAHUYEN, MAXA, GIOITINH) 
                VALUES 
                (@MAKH, @HOTEN, @DIACHI, @SODT, @NGSINH, @NGDK, @EMAIL, @TINHID, @HUYENID, @XAID, @GIOITINH)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MAKH", maKhachHang);
                        command.Parameters.AddWithValue("@HOTEN", hoTen);
                        command.Parameters.AddWithValue("@DIACHI", diaChi);
                        command.Parameters.AddWithValue("@SODT", sdt);
                        command.Parameters.AddWithValue("@NGSINH", ngaySinh == DateTime.MinValue ? (object)DBNull.Value : ngaySinh);
                        command.Parameters.AddWithValue("@NGDK", ngayDK == DateTime.MinValue ? (object)DBNull.Value : ngayDK);
                        command.Parameters.AddWithValue("@EMAIL", email);
                        command.Parameters.AddWithValue("@MAXA", xaId);
                        command.Parameters.AddWithValue("@MAHUYEN", huyenId);
                        command.Parameters.AddWithValue("@MATINH", tinhId);
                        command.Parameters.AddWithValue("@GIOITINH", gioiTinh);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Lưu thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KhachHangAdded?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("Không có bản ghi nào được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private string selectedImagePath;

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
                    pbHinhAnh.Image = Image.FromFile(filePath);
                    selectedImagePath = filePath;  
                }
            }
        }

        private void LoadComboBoxData()
        {
            // Nạp dữ liệu vào cbxTinh
            using (SqlConnection conn = new SqlConnection(cstr))
            {
                string query = "SELECT MATINH, TENTINH FROM TINH";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbxTinh.DisplayMember = "TENTINH";
                cbxTinh.ValueMember = "MATINH";
                cbxTinh.DataSource = dt;
            }
        }


        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLua_Click_1(object sender, EventArgs e)
        {

            if (KiemTraForm())
            {
                string maKhachHang = txtMaKH.Text.Trim();
                string hoTen = txtTenKH.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string sdt = txtDienThoai.Text.Trim();
                DateTime ngaySinh = dtpNgaySinh.Value.Date;
                DateTime ngayDK = dtpNgayDK.Value.Date;
                string email = txtEmail.Text.Trim();
                int xaId = Convert.ToInt32(cbxPhuongXa.SelectedValue);
                int tinhId = Convert.ToInt32(cbxTinh.SelectedValue);
                int huyenId = Convert.ToInt32(cbxHuyenQuan.SelectedValue);
                string gioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";

                try
                {
                    LuuThongTinKhachHang(maKhachHang, hoTen, diaChi, sdt, ngaySinh, ngayDK, email, tinhId, huyenId, xaId, gioiTinh);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
