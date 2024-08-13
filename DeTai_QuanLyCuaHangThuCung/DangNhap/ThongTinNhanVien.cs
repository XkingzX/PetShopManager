using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DeTai_QuanLyCuaHangThuCung.DangNhap;
using static DeTai_QuanLyCuaHangThuCung.DangNhap.frm_DangNhap;

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class frm_thongtinnv : Form
    {
        public frm_thongtinnv()
        {
            InitializeComponent();
            dgvTTNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTTNV.CellClick += DgvTTNV_CellClick;
        }


        private void DgvTTNV_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTTNV.Rows[e.RowIndex];

                txtManv.Text = row.Cells["MANV"].Value.ToString();
                txtHoten.Text = row.Cells["HOTEN"].Value.ToString();
                txtSodienthoai.Text = row.Cells["SODT"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtGhichu.Text = row.Cells["GHICHU"].Value.ToString();
                txtDiachi.Text = row.Cells["DIACHI"].Value.ToString();
                txtMatkhau.Text = row.Cells["MATKHAU"].Value.ToString();
                if (row.Cells["NGSINH"].Value != DBNull.Value)
                {
                    dtpNgaysinh.Value = Convert.ToDateTime(row.Cells["NGSINH"].Value);
                }

                if (row.Cells["NGVL"].Value != DBNull.Value)
                {
                    dtpNgayvaolam.Value = Convert.ToDateTime(row.Cells["NGVL"].Value);
                }
                string gioiTinh = row.Cells["GIOITINH"].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rdbNam.Checked = true;
                    rdbNu.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    rdbNam.Checked = false;
                    rdbNu.Checked = true;
                }

                string quyen = row.Cells["QUYEN"].Value.ToString();
                cmbQuyen.SelectedItem = quyen;

                if (row.Cells["HINH"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["HINH"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbHinhanh.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbHinhanh.Image = null;
                }
            }
        }

        SqlConnection cn = new SqlConnection(@"Data Source=ADMIN-PC\MSSQLSERVER01;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;");
        private void ketnoicsdl()
        {
            cn.Open();
            /*string sql = @"SELECT MANV as N'Mã Nhân Viên', 
                      HOTEN as N'Họ Tên', 
                      SODT as N'Số Điện Thoại',
                      NGVL as N'Ngày vào làm', 
                      MATKHAU as N'Mật Khẩu', 
                      QUYEN as N'Quyền', 
                      DIACHI as N'Địa chỉ',
                      EMAIL as N'Email', 
                      NGSINH as N'Ngày Sinh', 
                      GIOITINH as N'Giới Tính', 
                      GHICHU as N'Ghi Chú', 
                      HINH as N'Hình'
               FROM NHANVIEN"; */
            string sql = @"select * from NHANVIEN";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            dgvTTNV.DataSource = dt;
            dgvTTNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvTTNV.Columns["Ghi Chú"].Visible = false;
            //dgvTTNV.Columns["Hình"].Visible=false;
            dgvTTNV.Columns["GHICHU"].Visible = false;
            dgvTTNV.Columns["HINH"].Visible = false;

        }
        private void frm_thongtinnv_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            ketnoicsdl();
            pbHinhanh.SizeMode = PictureBoxSizeMode.Zoom;
            this.Width = 855;
            this.Height = 740;

        }

        private void btnTimkienmanv_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimkiem.Text.Trim();

            if (string.IsNullOrEmpty(timkiem))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để tìm kiếm.");
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=ADMIN-PC\MSSQLSERVER01;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                {
                    cn.Open();
                    string query = "SELECT * FROM NHANVIEN WHERE MANV = @MANV";
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@MANV", timkiem);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvTTNV.DataSource = dt;
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmThemNV frm = new frmThemNV())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ketnoicsdl();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTTNV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }
            string maNV = dgvTTNV.SelectedRows[0].Cells["MANV"].Value.ToString();

            string sqlQuyen = "SELECT QUYEN FROM NHANVIEN WHERE MANV = @MANV";
            string quyen;
            using (SqlConnection cn = new SqlConnection(@"Data Source=ADMIN-PC\MSSQLSERVER01;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuyen, cn))
                {
                    cmd.Parameters.AddWithValue("@MANV", maNV);
                    quyen = (string)cmd.ExecuteScalar();
                }
                cn.Close();
            }

            if (quyen == "Quản lý")
            {
                MessageBox.Show("Nhân viên có quyền quản lý thì không được xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=ADMIN-PC\MSSQLSERVER01;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                {
                    cn.Open();
                    string query = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
                    using (SqlCommand cm = new SqlCommand(query, cn))
                    {
                        cm.Parameters.AddWithValue("@MANV", maNV);
                        cm.ExecuteNonQuery();
                    }
                    cn.Close();
                }

                ketnoicsdl();

                MessageBox.Show("Thông tin nhân viên đã được xóa.");
            }
        }

        private void LoadLaiThongTin()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=ADMIN-PC\MSSQLSERVER01;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                {
                    cn.Open();
                    string sql = "SELECT * FROM NHANVIEN";
                    SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTTNV.DataSource = dt;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (dgvTTNV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin nhân viên cần sửa.");
                return;
            }

            DataGridViewRow row = dgvTTNV.SelectedRows[0];
            string maNV = row.Cells["MANV"].Value.ToString();
            string hoten = row.Cells["HOTEN"].Value.ToString();
            string matkhau = row.Cells["MATKHAU"].Value.ToString();
            string sodt = row.Cells["SODT"].Value.ToString();
            DateTime ngvl = (DateTime)row.Cells["NGVL"].Value;
            string diachi = row.Cells["DIACHI"].Value.ToString();
            string email = row.Cells["EMAIL"].Value.ToString();
            DateTime ngsinh = (DateTime)row.Cells["NGSINH"].Value;
            string gioitinh = row.Cells["GIOITINH"].Value.ToString();
            string ghichu = row.Cells["GHICHU"].Value.ToString();
            byte[] hinh = row.Cells["HINH"].Value as byte[];
            string quyen = row.Cells["QUYEN"].Value.ToString();

            using (frmSuaTTNV frm = new frmSuaTTNV(maNV, hoten, matkhau, sodt, ngvl, diachi, email, ngsinh, gioitinh, ghichu, hinh, quyen))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadLaiThongTin(); // Làm mới DataGridView
                }
            }
        }


        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            txtTimkiem.Text = txtTimkiem.Text.ToUpper();
            txtTimkiem.SelectionStart = txtTimkiem.Text.Length;
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "NHẬP MÃ NHÂN VIÊN")
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = Color.Black;
            }
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimkiem.Text))
            {
                txtTimkiem.Text = "NHẬP MÃ NHÂN VIÊN";
                txtTimkiem.ForeColor = Color.Silver;
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=ADMIN-PC\MSSQLSERVER01;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                {
                    cn.Open();
                    string sql = "SELECT * FROM NHANVIEN";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvTTNV.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void txtGhichu_Click(object sender, EventArgs e)
        {

        }

        private void dgvTTNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void pbHinhanh_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


        }
    }
}
