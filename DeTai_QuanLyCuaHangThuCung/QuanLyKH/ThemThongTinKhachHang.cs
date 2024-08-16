using DeTai_QuanLyCuaHangThuCung.QuanLyKH;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
            dtpNgayDK.Enabled = false;
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
                LoadHuyen();
            }
        }

        private void CbxHuyenQuan_DropDown(object sender, EventArgs e)
        {
            if (cbxHuyenQuan.SelectedValue != null)
            {
                LoadXa();
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
                LoadHuyen();
                cbxPhuongXa.DataSource = null;
                cbxPhuongXa.Items.Clear();
            }
        }
        private void CbxHuyenQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTinh.SelectedValue != null)
            {
                LoadXa();
            }
        }


        // Chuỗi kết nối cơ sở dữ liệu
        private string cstr = @"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";

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
                cbxHuyenQuan.Enabled = false;
                cbxPhuongXa.Enabled = false;
            }
        }

        private void LoadHuyen()
        {
            int maTinh = Convert.ToInt32(cbxTinh.SelectedValue);
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                string query = "SELECT MAHUYEN, TENHUYEN FROM HUYEN WHERE MATINH = @MaTinh";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaTinh", maTinh);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtHuyen = new DataTable();
                adapter.Fill(dtHuyen);
                cbxHuyenQuan.DisplayMember = "TENHUYEN";
                cbxHuyenQuan.ValueMember = "MAHUYEN";
                cbxHuyenQuan.DataSource = dtHuyen;
                cbxHuyenQuan.Enabled = true;
                cbxPhuongXa.Enabled = false;
            }
        }


        private void LoadXa()
        {
            int maHuyen = Convert.ToInt32(cbxHuyenQuan.SelectedValue);
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                string query = "SELECT MAXA, TENXA FROM XA WHERE MAHUYEN = @MaHuyen";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHuyen", maHuyen);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtXa = new DataTable();
                adapter.Fill(dtXa);
                cbxPhuongXa.DisplayMember = "TENXA";
                cbxPhuongXa.ValueMember = "MAXA";
                cbxPhuongXa.DataSource = dtXa;
                cbxHuyenQuan.Enabled = true;
                cbxPhuongXa.Enabled = true;
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


        private bool KiemTraForm()
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
            string.IsNullOrWhiteSpace(txtTenKH.Text) ||
            string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
            cbxTinh.SelectedItem == null ||
            cbxHuyenQuan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadKhachHang(string maKhachHang)
        {
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                connection.Open();
                string query = "SELECT * FROM KHACHHANG WHERE MAKH = @MaKH";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKH", maKhachHang);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtMaKH.Text = reader["MAKH"].ToString();
                    txtTenKH.Text = reader["HOTEN"].ToString();
                    txtDienThoai.Text = reader["SODT"].ToString();
                    txtEmail.Text = reader["EMAIL"].ToString();
                    txtDiaChi.Text = reader["DCHI"].ToString();
                    dtpNgayDK.Value = Convert.ToDateTime(reader["NGDK"]);
                    dtpNgayDK.Enabled = false;

                    cbxTinh.SelectedValue = reader["MATINH"];
                    LoadHuyen();
                    cbxHuyenQuan.SelectedValue = reader["MAHUYEN"];
                    LoadXa();
                    cbxPhuongXa.SelectedValue = reader["MAXA"];
                }
            }
        }

        private bool KiemTraTonTaiKH(string maKhachHang)
        {
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM KHACHHANG WHERE MAKH = @MAKH";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MAKH", maKhachHang);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void LuuDuLieu()
        {
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                connection.Open();
                string maKhachHang = txtMaKH.Text;

                if (KiemTraTonTaiKH(maKhachHang))
                {
                    // Cập nhật khách hàng (Không cập nhật ngày tạo)
                    string updateQuery = @"
            UPDATE KHACHHANG 
            SET HOTEN = @Hoten, 
                SODT = @Sodt, 
                DCHI = @DCHI, 
                EMAIL = @Email, 
                MATINH = @Matinh, 
                MAHUYEN = @Mahuyen, 
                MAXA = @Maxa 
            WHERE MAKH = @MaKH";

                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@MaKH", maKhachHang);
                    updateCommand.Parameters.AddWithValue("@Hoten", txtTenKH.Text);
                    updateCommand.Parameters.AddWithValue("@Sodt", txtDienThoai.Text);
                    updateCommand.Parameters.AddWithValue("@DCHI", txtDiaChi.Text);
                    updateCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                    updateCommand.Parameters.AddWithValue("@Matinh", cbxTinh.SelectedValue);
                    updateCommand.Parameters.AddWithValue("@Mahuyen", cbxHuyenQuan.SelectedValue);
                    updateCommand.Parameters.AddWithValue("@Maxa", cbxPhuongXa.SelectedValue);

                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Thêm mới khách hàng
                    string insertQuery = @"
            INSERT INTO KHACHHANG (MAKH, HOTEN, SODT, DCHI, EMAIL, NGDK, MATINH, MAHUYEN, MAXA)
            VALUES (@MaKH, @Hoten, @Sodt, @DCHI, @Email, @NgDK, @Matinh, @Mahuyen, @Maxa)";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@MaKH", maKhachHang);
                    insertCommand.Parameters.AddWithValue("@Hoten", txtTenKH.Text);
                    insertCommand.Parameters.AddWithValue("@Sodt", txtDienThoai.Text);
                    insertCommand.Parameters.AddWithValue("@DCHI", txtDiaChi.Text);
                    insertCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                    insertCommand.Parameters.AddWithValue("@NgDK", dtpNgayDK.Value);
                    insertCommand.Parameters.AddWithValue("@Matinh", cbxTinh.SelectedValue);
                    insertCommand.Parameters.AddWithValue("@Mahuyen", cbxHuyenQuan.SelectedValue);
                    insertCommand.Parameters.AddWithValue("@Maxa", cbxPhuongXa.SelectedValue);

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                KhachHangAdded?.Invoke(this, EventArgs.Empty);
            }
        }


        private void btnLua_Click(object sender, EventArgs e)
        {
            if (KiemTraForm())
            {
                LuuDuLieu();
            }

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
