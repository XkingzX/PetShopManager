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

namespace DeTai_QuanLyCuaHangThuCung.HangHoa
{
    public partial class frm_KiemKho : Form
    {
        public frm_KiemKho()
        {
            InitializeComponent();
            dgv_kiemkho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.txt_nhapmapk.KeyDown += new KeyEventHandler(this.txt_nhapmapk_KeyDown);

        }
        SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;");
        private void ketnoicsdl()
        {
            cn.Open();
            string sql = @"SELECT K.MAPK AS N'Mã phiếu kho', 
                   K.MASP AS N'Mã sản phẩm', 
                   K.NGAYNHAP AS N'Ngày nhập', 
                   ISNULL(S.SLHETHONG, 0) AS N'Số lượng hệ thống', 
                   K.SLTHUCTE AS N'Số lượng thực tế', 
                   CASE 
                       WHEN ISNULL(S.SLHETHONG, 0) = 0 THEN 0
                       ELSE (K.SLTHUCTE - ISNULL(S.SLHETHONG, 0))
                   END AS N'Số lượng chênh lệch', 
                   CASE 
                       WHEN ISNULL(S.SLHETHONG, 0) = 0 THEN N'Chưa có dữ liệu'
                       WHEN (K.SLTHUCTE - ISNULL(S.SLHETHONG, 0)) > 0 THEN N'Dư sản phẩm'
                       WHEN (K.SLTHUCTE - ISNULL(S.SLHETHONG, 0)) = 0 THEN N'Đủ'
                       ELSE N'Thiếu'
                   END AS N'Tình trạng', 
                   K.GHICHU AS N'Ghi chú', 
                   K.MANV AS N'Người tạo', 
                   K.DAXOA AS N'Đã xóa'
                    FROM KHO K
                    LEFT JOIN SANPHAM S ON K.MASP = S.MASP";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_kiemkho.DataSource = dt;
            dgv_kiemkho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_trangthai.Enabled = false;
            txt_nguoitao.Enabled = false;
            txt_ngaynhap.Enabled = false;
            dgv_kiemkho.Columns["Người tạo"].Visible = false;
            dgv_kiemkho.Columns["Tình trạng"].Visible = false;
            //dgv_kiemkho.Columns["Đã xóa"].Visible = false;
            cn.Close();
        }

        private void frm_KiemKho_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            ketnoicsdl();
        }
        private void txt_nhapmapk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                timkiemmapk()                                                                                                                                        ;
            }
        }
        private void timkiemmapk()
        {
            string maPK = txt_nhapmapk.Text.Trim();
            if (string.IsNullOrEmpty(maPK))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm để tìm kiếm.");
                ketnoicsdl();
                dgv_kiemkho.DataSource = null;
                return;
            }
            try
            {
                cn.Open();
                string tukhoa = txt_nhapmapk.Text;
                // Dấu $ để định dạng chuỗi là chuỗi định dạng SELECT * FROM SANPHAM WHERE MASP = 'tukhoa'
                string query = @"SELECT K.MAPK AS N'Mã phiếu kho', 
                      K.MASP AS N'Mã sản phẩm', 
                      K.NGAYNHAP AS N'Ngày nhập', 
                      S.SLHETHONG AS N'Số lượng hệ thống', 
                      K.SLTHUCTE AS N'Số lượng thực tế', 
                      (K.SLTHUCTE - S.SLHETHONG) AS N'Số lượng chênh lệch', 
                      CASE 
                          WHEN (K.SLTHUCTE - S.SLHETHONG) > 0 THEN N'Dư sản phẩm'
                          WHEN (K.SLTHUCTE - S.SLHETHONG) = 0 THEN N'Đủ'
                          ELSE N'Thiếu'
                      END AS N'Tình trạng', 
                      K.GHICHU AS N'Ghi chú', 
                      K.MANV AS N'Người tạo', 
                      K.DAXOA AS N'Đã xóa'
            FROM KHO K
            INNER JOIN SANPHAM S ON K.MASP = S.MASP AND MAPK = '{tukhoa}'";
                SqlCommand cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@MAPK", maPK);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                if (dt.Rows.Count > 0)
                {
                    dgv_kiemkho.DataSource = dt;
                    txt_trangthai.Text = dgv_kiemkho.SelectedRows[0].Cells[6].Value.ToString();
                    txt_nguoitao.Text = dgv_kiemkho.SelectedRows[0].Cells[8].Value.ToString();
                    txt_ngaynhap.Text = dgv_kiemkho.SelectedRows[0].Cells[2].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã phiếu kho: " + maPK);
                    ketnoicsdl();
                    txt_nhapmapk.Clear();
                    txt_nhapmapk.Focus();
                }
            }
            catch (Exception) { }
        }

        private void dgv_kiemkho_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_kiemkho.SelectedRows.Count > 0)
                {
                    txt_trangthai.Text = dgv_kiemkho.SelectedRows[0].Cells[6].Value.ToString();
                    txt_nguoitao.Text = dgv_kiemkho.SelectedRows[0].Cells[8].Value.ToString();
                    txt_ngaynhap.Text = dgv_kiemkho.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
            catch { }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            using (frm_NhapKho frm = new frm_NhapKho("Thêm Sản Phẩm", "Lưu"))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string maPK = frm.maPK;
                    string maSP = frm.maSP;
                    string ngaynhap = frm.ngayNhap;
                    string slthucte = frm.soluongtt;
                    string ghichu = frm.ghichu;
                    try
                    {
                        cn.Open();
                        string query = "INSERT INTO KHO (MAPK, MASP, NGAYNHAP, SLTHUCTE, GHICHU) VALUES (@MAPK, @MASP, @NGAYNHAP, @SLTHUCTE, @GHICHU)";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@MAPK", maPK);
                            cmd.Parameters.AddWithValue("@MASP", maSP);
                            cmd.Parameters.AddWithValue("@NGAYNHAP", ngaynhap);
                            cmd.Parameters.AddWithValue("@SLTHUCTE", slthucte);
                            cmd.Parameters.AddWithValue("@GHICHU", ghichu);

                            cmd.ExecuteNonQuery();
                        }
                        ketnoicsdl();
                        cn.Close();
                    }
                    catch (Exception) { }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_kiemkho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string maPK = dgv_kiemkho.SelectedRows[0].Cells["Mã phiếu kho"].Value.ToString();
                cn.Open();
                string query = "DELETE KHO WHERE MAPK = @maPK";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@maPK", maPK);
                    cmd.ExecuteNonQuery();
                }
                cn.Close();

                ketnoicsdl();

                MessageBox.Show("Sản phẩm đã được xóa.");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_kiemkho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
                return;
            }
            DataGridViewRow row = dgv_kiemkho.SelectedRows[0];
            string maPK = row.Cells["Mã phiếu kho"].Value?.ToString() ?? string.Empty;
            string maSP = row.Cells["Mã sản phẩm"].Value?.ToString() ?? string.Empty;
            string ngayNhap = row.Cells["Ngày nhập"].Value?.ToString() ?? string.Empty;
            string SLthucte = row.Cells["Số lượng thực tế"].Value?.ToString() ?? string.Empty;
            string Ghichu = row.Cells["Ghi chú"].Value?.ToString() ?? string.Empty;
            string manv = row.Cells["Người tạo"].Value?.ToString() ?? string.Empty;

            using (frm_NhapKho frm = new frm_NhapKho("Sửa Sản Phẩm", "Lưu", "Edit", maPK, maSP, ngayNhap, SLthucte, Ghichu, manv))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string newmaPK = frm.maPK;
                    string newmaSP = frm.maSP;
                    string newngayNhap = frm.ngayNhap;
                    string newSLthucte = frm.soluongtt;
                    string newghichu = frm.ghichu;
                    string newmanv = frm.manv;

                    try
                    {
                        cn.Open();
                        string query = "UPDATE SANPHAM SET TENSP = @tenSP, GIA = @giaSP, LOAI = @loaiSP WHERE MASP = @maSP";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@MAPK", maPK);
                            cmd.Parameters.AddWithValue("@MASP", maSP);
                            cmd.Parameters.AddWithValue("@NGAYNHAP", ngayNhap);
                            cmd.Parameters.AddWithValue("@SLTHUCTE", SLthucte);
                            cmd.Parameters.AddWithValue("@GHICHU", Ghichu);
                            cmd.Parameters.AddWithValue("@MANV", manv);

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
        private void dgv_kiemkho_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int cotdaxoa = dgv_kiemkho.Columns["Đã xóa"].Index;
            if (e.ColumnIndex == cotdaxoa)
            {
                // chuyển kiểu cột daxoa thành (boolean) true hoặc false so sánh giá trị với DBNull
                bool daXoa = e.Value != DBNull.Value && Convert.ToBoolean(e.Value);
                //dgv_kiemkho.Rows[e.RowIndex].Cells["Mã sản phẩm"].Style.BackColor = daXoa ? Color.Red : Color.White; Thêm màu ô
                dgv_kiemkho.Rows[e.RowIndex].Cells["Mã sản phẩm"].Style.ForeColor = daXoa ? Color.Red : Color.Black; //Thêm màu font chữ
                if (daXoa)
                {
                    dgv_kiemkho.Rows[e.RowIndex].Cells["Mã sản phẩm"].Value = "Mã đã bị xóa";
                }
            }
        }


        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                {
                    cn.Open();
                    string sql = @"SELECT K.MAPK AS N'Mã phiếu kho', 
                   K.MASP AS N'Mã sản phẩm', 
                   K.NGAYNHAP AS N'Ngày nhập', 
                   ISNULL(S.SLHETHONG, 0) AS N'Số lượng hệ thống', 
                   K.SLTHUCTE AS N'Số lượng thực tế', 
                   CASE 
                       WHEN ISNULL(S.SLHETHONG, 0) = 0 THEN 0
                       ELSE (K.SLTHUCTE - ISNULL(S.SLHETHONG, 0))
                   END AS N'Số lượng chênh lệch', 
                   CASE 
                       WHEN ISNULL(S.SLHETHONG, 0) = 0 THEN N'Chưa có dữ liệu'
                       WHEN (K.SLTHUCTE - ISNULL(S.SLHETHONG, 0)) > 0 THEN N'Dư sản phẩm'
                       WHEN (K.SLTHUCTE - ISNULL(S.SLHETHONG, 0)) = 0 THEN N'Đủ'
                       ELSE N'Thiếu'
                   END AS N'Tình trạng', 
                   K.GHICHU AS N'Ghi chú', 
                   K.MANV AS N'Người tạo', 
                   K.DAXOA AS N'Đã xóa'
                    FROM KHO K
                    LEFT JOIN SANPHAM S ON K.MASP = S.MASP";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_kiemkho.DataSource = dt;
                    dgv_kiemkho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    txt_trangthai.Enabled = false;
                    txt_nguoitao.Enabled = false;
                    txt_ngaynhap.Enabled = false;
                    dgv_kiemkho.Columns["Người tạo"].Visible = false;
                    //dgv_kiemkho.Columns["Đã xóa"].Visible = false;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
