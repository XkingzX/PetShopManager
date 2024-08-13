using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class frm_danhmuc : Form
    {
        public frm_danhmuc()
        {
            InitializeComponent();
            this.txt_nhapmasp.KeyDown += new KeyEventHandler(this.txt_nhapmasp_KeyDown);
        }
        SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;");
        private void ketnoicsdl()
        {
            cn.Open();
            string sql = "select MASP as N'Mã Sản Phẩm', TENSP as N'Tên Sản Phẩm', GIA as N'Giá', SLHETHONG, LOAI as N'Loại', HINH as N'Hình Sản Phẩm', MOTA from SANPHAM";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            dgv_danhmucsp.DataSource = dt;
            dgv_danhmucsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_danhmucsp.Columns["Hình Sản Phẩm"].Visible = false;
            dgv_danhmucsp.Columns["MOTA"].Visible = false;
            dgv_danhmucsp.Columns["SLHETHONG"].Visible = false;
        }

        private void frm_danhmuc_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            ketnoicsdl();
            timkiemloaisp();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            using (frm_NhapLieu frm = new frm_NhapLieu("Thêm Sản Phẩm", "Lưu"))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string maSP = frm.maSP;
                    string tenSP = frm.tenSP;
                    int slhethong = frm.slhethong;
                    string giaSP = frm.giaSP;
                    string loaiSP = frm.loaiSP;
                    try
                    {
                        cn.Open();
                        string query = "INSERT INTO SANPHAM (MASP, TENSP, SLHETHONG, GIA, LOAI) VALUES (@maSP, @tenSP, @SLHETHONG, @giaSP, @loaiSP)";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@maSP", maSP);
                            cmd.Parameters.AddWithValue("@tenSP", tenSP);
                            cmd.Parameters.AddWithValue("@SLHETHONG", slhethong);
                            cmd.Parameters.AddWithValue("@giaSP", giaSP);
                            cmd.Parameters.AddWithValue("@loaiSP", loaiSP);

                            cmd.ExecuteNonQuery();
                        }
                        ketnoicsdl();
                        cn.Close();
                    }
                    catch (Exception) { }
                }
            }
        }
        private void txt_nhapmasp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                timkiemmasp();
            }
        }
        private void timkiemmasp()
        {
            string maSP = txt_nhapmasp.Text.Trim();
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm để tìm kiếm.");
                ketnoicsdl();
                dgv_danhmucsp.DataSource = null;
                return;
            }
            try
            {
                cn.Open();
                string tukhoa = txt_nhapmasp.Text;
                // Dấu $ để định dạng chuỗi là chuỗi định dạng SELECT * FROM SANPHAM WHERE MASP = 'tukhoa'
                string query = $"select MASP as N'Mã Sản Phẩm', TENSP as N'Tên Sản Phẩm', GIA as N'Giá', SLHETHONG, LOAI as N'Loại', HINH as N'Hình Sản Phẩm', MOTA from SANPHAM WHERE MASP = '{tukhoa}'";
                SqlCommand cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@MASP", maSP);

                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cn.Close();

                if (dt.Rows.Count > 0)
                {
                    dgv_danhmucsp.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm với mã: " + maSP);
                    ketnoicsdl();
                    txt_nhapmasp.Clear();
                    txt_nhapmasp.Focus();
                }
            }
            catch (Exception) { }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_danhmucsp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string maSP = dgv_danhmucsp.SelectedRows[0].Cells["Mã Sản Phẩm"].Value.ToString();
                cn.Open();
                string query = @"UPDATE KHO SET DaXoa = 1 WHERE MASP = @maSP";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    cmd.ExecuteNonQuery();
                }
                string queryxoa = @"DELETE FROM SANPHAM WHERE MASP = @maSP";
                using (SqlCommand deleteCmd = new SqlCommand(queryxoa, cn))
                {
                    deleteCmd.Parameters.AddWithValue("@maSP", maSP);
                    deleteCmd.ExecuteNonQuery();
                }
                cn.Close();

                ketnoicsdl();

                MessageBox.Show("Sản phẩm đã được xóa.");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_danhmucsp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
                return;
            }
            DataGridViewRow row = dgv_danhmucsp.SelectedRows[0];

            //?.ToString() sẽ trả về null nếu row.Cells["MASP"].Value là null
            //?? string.Empty sẽ thay thế giá trị null bằng chuỗi rỗng
            string maSP = row.Cells["Mã Sản Phẩm"].Value?.ToString() ?? string.Empty;
            string tenSP = row.Cells["Tên Sản Phẩm"].Value?.ToString() ?? string.Empty;
            string slhethongString = row.Cells["SLHETHONG"].Value?.ToString() ?? "0";
            int slhethong = int.TryParse(slhethongString, out int result) ? result : 0;
            string giaSP = row.Cells["Giá"].Value?.ToString() ?? string.Empty;
            string loaiSP = row.Cells["Loại"].Value?.ToString() ?? string.Empty;

            using (frm_NhapLieu frm = new frm_NhapLieu("Sửa Sản Phẩm", "Lưu", "Edit", maSP, tenSP, slhethong, giaSP, loaiSP))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string newMaSP = frm.maSP;
                    string newTenSP = frm.tenSP;
                    int newslhethong = frm.slhethong;
                    string newGiaSP = frm.giaSP;
                    string newLoaiSP = frm.loaiSP;

                    try
                    {
                        cn.Open();
                        string query = "UPDATE SANPHAM SET TENSP = @tenSP, GIA = @giaSP, LOAI = @loaiSP WHERE MASP = @maSP";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@maSP", newMaSP);
                            cmd.Parameters.AddWithValue("@tenSP", newTenSP);
                            cmd.Parameters.AddWithValue("@giaSP", newGiaSP);
                            cmd.Parameters.AddWithValue("@loaiSP", newLoaiSP);

                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();

                        ketnoicsdl();

                        MessageBox.Show("Sản phẩm đã được cập nhật.");
                    }
                    catch (Exception) { }
                }
            }
        }
        private void dgv_danhmucsp_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_danhmucsp.SelectedRows.Count > 0)
                {
                    cmb_nhomsp.Text = dgv_danhmucsp.SelectedRows[0].Cells[4].Value.ToString();
                    lbl_motasp.Text = "Mô tả: " + dgv_danhmucsp.SelectedRows[0].Cells[5].Value.ToString();
                    lbl_soluong.Text = "Số lượng: " + dgv_danhmucsp.SelectedRows[0].Cells[3].Value.ToString();
                    lbl_tongkho.Text = "Tồn kho: " + LayTongSoLuong();
                    DataGridViewRow selectedRow = dgv_danhmucsp.SelectedRows[0];
                    byte[] image = selectedRow.Cells[4].Value as byte[];

                    if (image == null || image.Length == 0)
                    {
                        ptr_hinhsanpham.Image = null;
                    }
                    else
                    {
                        using (var stream = new MemoryStream(image))
                        {
                            ptr_hinhsanpham.Image = Image.FromStream(stream);
                        }
                    }
                }
            }
            catch { }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                {
                    cn.Open();
                    string sql = "select MASP as N'Mã Sản Phẩm', TENSP as N'Tên Sản Phẩm', GIA as N'Giá',SLHETHONG, LOAI as N'Loại', HINH as N'Hình Sản Phẩm', MOTA from SANPHAM";
                    SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_danhmucsp.DataSource = dt;
                    dgv_danhmucsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv_danhmucsp.Columns["Hình Sản Phẩm"].Visible = false;
                    dgv_danhmucsp.Columns["MOTA"].Visible = false;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private int LayTongSoLuong()
        {
            int tongSoLuong = 0;
            string sql = "SELECT SUM(SLHETHONG) FROM SANPHAM";

            using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    object result = cmd.ExecuteScalar(); //Trả về 1 giá trị duy nhất
                    if (result != DBNull.Value) // Kiểm tra có null ko
                    {
                        tongSoLuong = Convert.ToInt32(result);
                    }
                }
            }
            return tongSoLuong;
        }
        private void timkiemloaisp()
        {
            string[] dsloai = { "Cát", "Đồ Chơi", "Thức Ăn" };
            cmb_nhomsp.Items.AddRange(dsloai);
        }

        private void cmb_nhomsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LOAISP = cmb_nhomsp.Text.Trim();
            cn.Open();
            string query = $"SELECT MASP as N'Mã Sản Phẩm', TENSP as N'Tên Sản Phẩm', GIA as N'Giá', SLHETHONG, LOAI as N'Loại', HINH as N'Hình Sản Phẩm', MOTA FROM SANPHAM WHERE LOAI = @LOAI";
            SqlCommand cm = new SqlCommand(query, cn);
            cm.Parameters.AddWithValue("@LOAI", LOAISP);

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            dgv_danhmucsp.DataSource = dt;
        }

        private void btn_insp_Click(object sender, EventArgs e)
        {
            inmasanpham frm = new inmasanpham(dgv_danhmucsp.CurrentRow.Cells[0].Value.ToString(), dgv_danhmucsp.CurrentRow.Cells[1].Value.ToString(), dgv_danhmucsp.CurrentRow.Cells[2].Value.ToString());
            frm.Show();
        }
    }
}
