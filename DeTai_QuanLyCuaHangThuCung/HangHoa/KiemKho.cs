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
            this.txt_nhapmapk.KeyDown += new KeyEventHandler(this.txt_nhapmasp_KeyDown);
        }
        SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;");
        private void ketnoicsdl()
        {
            cn.Open();
            string sql = @"select MAPK as N'Mã Phiếu Kho', MASP as N'Mã Phiếu Nhập', NGAYNHAP as N'Ngày Nhập', 
                        SLHETHONG as N'Số lượng hệ thống', SLTHUCTE as N'Số lượng thực tế', 
                        (SLTHUCTE - SLHETHONG) as N'Số lượng chênh lệch', GHICHU as N'Ghi chú',
                        TRANGTHAI as N'Trạng thái', MANV as N'Người tạo'
                        from KHO";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            dgv_kiemkho.DataSource = dt;
            dgv_kiemkho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_trangthai.Enabled = false;
            txt_nguoitao.Enabled = false;
            txt_ngaynhap.Enabled = false;
            dgv_kiemkho.Columns["Trạng thái"].Visible = false;
            dgv_kiemkho.Columns["Người tạo"].Visible = false;
        }

        private void frm_KiemKho_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            ketnoicsdl();
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
                string query = @$"SELECT MAPK as N'Mã Phiếu Kho', MASP as N'Mã Phiếu Nhập', NGAYNHAP as N'Ngày Nhập',
                                SLHETHONG as N'Số lượng hệ thống', SLTHUCTE as N'Số lượng thực tế',
                                (SLTHUCTE - SLHETHONG) as N'Số lượng chênh lệch', GHICHU as N'Ghi chú',
                                TRANGTHAI as N'Trạng thái', MANV as N'Người tạo' FROM KHO WHERE MAPK = '{tukhoa}'";
                SqlCommand cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@MAPK", maPK);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                if (dt.Rows.Count > 0)
                {
                    dgv_kiemkho.DataSource = dt;
                    txt_trangthai.Text = dgv_kiemkho.SelectedRows[0].Cells[7].Value.ToString();
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
                    txt_trangthai.Text = dgv_kiemkho.SelectedRows[0].Cells[7].Value.ToString();
                    txt_nguoitao.Text = dgv_kiemkho.SelectedRows[0].Cells[8].Value.ToString();
                    txt_ngaynhap.Text = dgv_kiemkho.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
            catch { }
        }
    }
}
