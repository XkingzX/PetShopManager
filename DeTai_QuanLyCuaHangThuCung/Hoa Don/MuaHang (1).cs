using DeTai_QuanLyCuaHangThuCung;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class MuaHang : Form
    {
        protected string cnstr = @"Data Source=HOAGGMINH\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";
        protected SqlConnection cn;
        protected SqlCommand cm;
        public DataTable dt;
        public BindingSource bd;
        //SqlConnection cn = new SqlConnection(@"Data Source=HOAGGMINH\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");


        public MuaHang()
        {
            InitializeComponent();
            //this.txt_sdt.KeyDown += new KeyEventHandler(Txt_sdt_KeyDown);
        }


        //private void Txt_sdt_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        e.Handled = true;
        //        e.SuppressKeyPress = true;
        //        timkiemsdt();
        //    }
        //}
        //private void timkiemsdt()
        //{
        //    string tukhoa = txt_sdt.Text;
        //    string querry = $"select * from KHACHHANG WHERE SODT LIKE N'%{tukhoa}%'";
        //    dt = DataProvider.LoadCSDL(querry);
        //    bd = new BindingSource();
        //    bd.DataSource = dt;
        //    cmb_makh.DataSource = bd;
        //    cmb_makh.DisplayMember = "MAKH";
        //    cmb_makh.ValueMember = "MAKH";
        //    cmb_tenkh.DataBindings.Add("Text", bd, "HOTEN");
        //    txt_sdt.DataBindings.Add("Text", bd, "SODT");
        //    txt_diachi.DataBindings.Add("Text", bd, "DCHI");
        //    cmb_loaikh.DataBindings.Add("Text", bd, "LOAI");
        //    txt_diem.DataBindings.Add("TEXT", bd, "DIEMTHUONG");

        //}

        private void lammoigiohang()
        {
            capnhatsoluongsaukhixoa();
            xoadulieucthd();
            xoadulieuhd();
            tinhtongtienhang();
            tinhtongthanhtoan();
            if (dgv_giohang.DataSource != null)
            {
                MessageBox.Show("Xoá toàn bộ giỏ hàng thành công");
                laydulieugiohang();
                cmb_makh.Enabled = true;
                cmb_manv.Enabled = true;
                cmb_makh.Enabled = true;
                cmb_loaikh.Enabled = true;
                cmb_tenkh.Enabled = true;
            }
            else
            {
                MessageBox.Show("Giỏ hàng hiện đang rỗng");
            }
        }
        private void MuaHang_Load_1(object sender, EventArgs e)
        {
            txt_diachi.Enabled = false;
            txt_diem.Enabled = false;
            ketnoicsdl();
            loadnhanvien();
            loadloaikh();
            TaoMaHoaDon();
            loadsanpham();
            btn_taomoi.Enabled = false;
            txt_diem.Text = "0";
            rd_ksd.Checked = true;
        }
        private void xoadulieuhd()
        {
            float tong = float.Parse(txt_dongia.Text) * (int)num_sl.Value;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "DELETE FROM HOADON WHERE SOHD = @SOHD";
            cm.Parameters.AddWithValue("SOHD", lbl_mahd.Text);
            cm.Parameters.AddWithValue("MASP", cmb_masp.Text);
            cm.Parameters.AddWithValue("SL", num_sl.Value);
            cm.Parameters.AddWithValue("GIAMGIA", lbl_giamgia.Text);
            cm.Parameters.AddWithValue("TONGTIEN", tong);
            cm.Parameters.AddWithValue("THOIGIAN", dtp_thoigian.Value);
            cm.Parameters.AddWithValue("MAKH", cmb_makh.Text);
            cm.Parameters.AddWithValue("MANV", cmb_manv.Text);
            int row = cm.ExecuteNonQuery();
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
        }
        private void xoadulieucthd()
        {
            float tong = float.Parse(txt_dongia.Text) * (int)num_sl.Value;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "DELETE FROM CTHD WHERE SOHD = @SOHD";
            cm.Parameters.AddWithValue("SOHD", lbl_mahd.Text);
            int row = cm.ExecuteNonQuery();
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
        }




        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ketnoicsdl()
        {
            cn = new SqlConnection();
            cn.ConnectionString = cnstr;
            cn.Open();
        }
        private void dongketnoi()
        {
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();
            }
        }


        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void cmb_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void loaddulieukhachang()
        {
            cmb_makh.DataBindings.Clear();
            cmb_tenkh.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_sdt.DataBindings.Clear();
            txt_diem.DataBindings.Clear();
            string loaikh = cmb_loaikh.Text.Trim();
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from KHACHHANG WHERE LOAIKH = @loaikh";
            cm.Parameters.AddWithValue("loaikh", loaikh);
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            bd = new BindingSource();
            bd.DataSource = dt;
            cmb_makh.DataSource = bd;
            cmb_makh.DisplayMember = "MAKH";
            cmb_makh.ValueMember = "MAKH";
            cmb_tenkh.DataSource = bd;
            cmb_tenkh.DisplayMember = "HOTEN";
            cmb_tenkh.ValueMember = "HOTEN";
            txt_sdt.DataBindings.Add("Text", bd, "SODT");
            txt_diachi.DataBindings.Add("Text", bd, "DCHI");
            txt_diem.DataBindings.Add("TEXT", bd, "DIEMTHUONG");
            txt_sdt.Enabled = false;
            txt_diachi.Enabled = false;
            txt_diem.Enabled = false;
            if (string.IsNullOrEmpty(txt_diem.Text))
            {
                txt_diem.Text = "0";
            }
        }
        private void loadnhanvien()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from NHANVIEN";
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            bd = new BindingSource();
            bd.DataSource = dt;
            cmb_manv.DataSource = bd;
            cmb_manv.DisplayMember = "MANV";
            cmb_manv.ValueMember = "MANV";
            txt_tennv.DataBindings.Add("Text", bd, "HOTEN");
            txt_tennv.Enabled = false;
        }
        private void loadsanpham()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from SANPHAM";
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            bd = new BindingSource();
            bd.DataSource = dt;
            cmb_masp.DataSource = bd;
            cmb_masp.DisplayMember = "MASP";
            cmb_masp.ValueMember = "MASP";
            txt_loaisp.DataBindings.Add("TEXT", bd, "LOAI");
            txt_loaisp.Enabled = false;
            cmb_tensp.DataSource = bd;
            cmb_tensp.DisplayMember = "TENSP";
            cmb_tensp.ValueMember = "TENSP";
            txt_dongia.DataBindings.Add("Text", bd, "GIA");
            txt_dongia.Enabled = false;
        }
        private void loadloaikh()
        {
            string[] dsloai = { "Khách lẻ", "Khách quen", "Nhân viên" };
            cmb_loaikh.Items.AddRange(dsloai);

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        //private void themsanpham()
        //{
        //        DataTable datatalbe = (DataTable)dgv_giohang.DataSource;
        //        DataRow dr = datatalbe.NewRow();
        //        float tong = float.Parse(txt_dongia.Text) * (int)num_sl.Value;
        //        datatalbe.Rows.Add(cmb_masp.Text, txt_tensp.Text, txt_dongia.Text, num_sl.Value, tong);
        //}

        private void pushsqlcthd()
        {
            float tong = float.Parse(txt_dongia.Text) * (int)num_sl.Value;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = @"INSERT INTO CTHD VALUES (@SOHD,@MASP,@SL,@GIAMGIA,@TONGTIEN,@THOIGIAN,@MAKH,@MANV,@CHINHANH,@TRANGTHAI,@PTTHANHTOAN,@KHACHTRA,@TIENTHOI)";
            cm.Parameters.AddWithValue("@SOHD", lbl_mahd.Text);
            cm.Parameters.AddWithValue("@MASP", cmb_masp.Text);
            cm.Parameters.AddWithValue("@SL", num_sl.Value);
            cm.Parameters.AddWithValue("@GIAMGIA", lbl_giamgia.Text);
            cm.Parameters.AddWithValue("@TONGTIEN", 0);
            cm.Parameters.AddWithValue("THOIGIAN", dtp_thoigian.Value);
            cm.Parameters.AddWithValue("MAKH", cmb_makh.Text);
            cm.Parameters.AddWithValue("MANV", cmb_manv.Text);
            cm.Parameters.AddWithValue("CHINHANH", " ");
            cm.Parameters.AddWithValue("TRANGTHAI", " ");
            cm.Parameters.AddWithValue("PTTHANHTOAN", " ");
            cm.Parameters.AddWithValue("KHACHTRA", 0);
            cm.Parameters.AddWithValue("TIENTHOI", 0);
            if (num_sl.Value > 0)
            {
                int row = cm.ExecuteNonQuery();
            }

        }
        private void pushsqlhd()
        {
            float tong = float.Parse(txt_dongia.Text) * (int)num_sl.Value;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = @"INSERT INTO HOADON VALUES (@SOHD,@NGHD,@MAKH,@MASP,@SL,@TONGTIEN)";
            cm.Parameters.AddWithValue("@SOHD", lbl_mahd.Text);
            cm.Parameters.AddWithValue("@MASP", cmb_masp.Text);
            cm.Parameters.AddWithValue("@SL", num_sl.Value);
            cm.Parameters.AddWithValue("@TONGTIEN", tong);
            cm.Parameters.AddWithValue("NGHD", dtp_thoigian.Value);
            cm.Parameters.AddWithValue("MAKH", cmb_makh.Text);
            if (num_sl.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng khi thêm sản phẩm");
            }
            else
            {
                int row = cm.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Thêm sản phẩm vào giỏ hàng thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm dữ liêu, vui lòng thử lại");
                }
            }
        }
        private void laydulieudangchon()
        {
            cmb_masp.Text = dgv_giohang.CurrentRow.Cells["col_masp"].Value.ToString();
            cmb_tensp.Text = dgv_giohang.CurrentRow.Cells["col_tensp"].Value.ToString();
            txt_dongia.Text = dgv_giohang.CurrentRow.Cells["col_dongia"].Value.ToString();
            num_sl.Value = (decimal)dgv_giohang.CurrentRow.Cells["col_sl"].Value;
        }
        private void cthd()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from CTHD";
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
        }
        private void TaoMaHoaDon()
        {
            // Tạo mã khách hàng theo định dạng KH******
            string MAHD = GenerateRandomNumberString(4);
            lbl_mahd.Text = MAHD;
        }

        // Phương thức tạo chuỗi số ngẫu nhiên
        private string GenerateRandomNumberString(int length)
        {
            Random random = new Random();
            char[] stringChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = (char)('0' + random.Next(10));
            }

            return new string(stringChars);
        }
        private void tinhtongtienhang()
        {
            decimal tong = 0;
            decimal giamgia = 0;
            for (int i = 0; i < dgv_giohang.Rows.Count - 1; i++)
            {
                tong += (decimal)dgv_giohang.Rows[i].Cells["col_thanhtien"].Value;
            }
            if (cmb_loaikh.Text == "Khách quen")
            {
                giamgia = tong * 5 / 100;
            }
            else if (cmb_loaikh.Text == "Nhân viên")
            {
                giamgia = tong * 10 / 100;
            }
            lbl_tongtienhang.Text = tong.ToString();
            lbl_giamgia.Text = giamgia.ToString();

        }
        private void tinhtongthanhtoan()
        {
            float tong = float.Parse(lbl_tongtienhang.Text) - float.Parse(lbl_giamgia.Text);
            lbl_tongthanhtoan.Text = tong.ToString();
        }
        private void cmb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_makh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_masp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dgv_giohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            laydulieudangchon();
        }

        private void laydulieugiohang()
        {
            float tong = float.Parse(txt_dongia.Text) * (int)num_sl.Value;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "Select SANPHAM.TENSP,SANPHAM.GIA,SANPHAM.MASP,SL,TONGTIEN from HOADON,SANPHAM WHERE SOHD = @SOHD AND HOADON.MASP = SANPHAM.MASP";
            cm.Parameters.AddWithValue("SOHD", lbl_mahd.Text);
            cm.Parameters.AddWithValue("MASP", cmb_masp.Text);
            cm.Parameters.AddWithValue("TENSP", cmb_tensp.Text);
            cm.Parameters.AddWithValue("GIA", txt_dongia.Text);
            cm.Parameters.AddWithValue("SL", num_sl.Value);
            cm.Parameters.AddWithValue("TONGTIEN", tong);
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            dgv_giohang.DataSource = dt;
        }
        private void suadulieu()
        {
            float tong = float.Parse(txt_dongia.Text) * (int)num_sl.Value;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "UPDATE HOADON SET SOHD = @SOHD, MASP = @MASP, SL = @SL,TONGTIEN=@TONGTIEN,NGHD = @THOIGIAN,MAKH = @MAKH WHERE MASP = @MASP AND SOHD = @SOHD";
            cm.Parameters.AddWithValue("SOHD", lbl_mahd.Text);
            cm.Parameters.AddWithValue("MASP", dgv_giohang.CurrentRow.Cells["col_masp"].Value);
            cm.Parameters.AddWithValue("SL", num_sl.Value);
            cm.Parameters.AddWithValue("TONGTIEN", tong);
            cm.Parameters.AddWithValue("THOIGIAN", dtp_thoigian.Value);
            cm.Parameters.AddWithValue("MAKH", cmb_makh.Text);
            int row = cm.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Cập nhật sản phẩm thành công");
                laydulieugiohang();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật, vui lòng thử lại");
            }
        }
        private void suadulieucthd()
        {
            float tong = float.Parse(txt_dongia.Text) * (int)num_sl.Value;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "UPDATE CTHD SET SOHD = @SOHD, MASP = @MASP, SL = @SL,GIAMGIA = @GIAMGIA,TONGTIEN=@TONGTIEN,THOIGIAN = @THOIGIAN,MAKH = @MAKH,MANV = @MANV WHERE MASP = @MASP AND SOHD = @SOHD";
            cm.Parameters.AddWithValue("SOHD", lbl_mahd.Text);
            cm.Parameters.AddWithValue("MASP", dgv_giohang.CurrentRow.Cells["col_masp"].Value);
            cm.Parameters.AddWithValue("SL", num_sl.Value);
            cm.Parameters.AddWithValue("TONGTIEN", 0);
            cm.Parameters.AddWithValue("GIAMGIA", lbl_giamgia.Text);
            cm.Parameters.AddWithValue("MANV", cmb_manv.Text);
            cm.Parameters.AddWithValue("THOIGIAN", dtp_thoigian.Value);
            cm.Parameters.AddWithValue("MAKH", cmb_makh.Text);
            int row = cm.ExecuteNonQuery();
        }
        private void xoa1donghoadon()
        {
            float tong = float.Parse(txt_dongia.Text) * (int)num_sl.Value;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "DELETE FROM HOADON WHERE SOHD = @SOHD AND MASP = @MASP";
            cm.Parameters.AddWithValue("SOHD", lbl_mahd.Text);
            cm.Parameters.AddWithValue("MASP", dgv_giohang.CurrentRow.Cells["col_masp"].Value);
            int row = cm.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Xoá sản phẩm khỏi giỏ hàng thành công");
                laydulieugiohang();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi xoá sản phẩm, vui lòng thử lại");
            }
        }
        private void xoa1dongcthd()
        {
            float tong = float.Parse(txt_dongia.Text) * (int)num_sl.Value;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "DELETE FROM CTHD WHERE SOHD = @SOHD AND MASP = @MASP";
            cm.Parameters.AddWithValue("SOHD", lbl_mahd.Text);
            cm.Parameters.AddWithValue("MASP", dgv_giohang.CurrentRow.Cells["col_masp"].Value);
            int row = cm.ExecuteNonQuery();
        }

        private void btn_thanhtoan_Click_1(object sender, EventArgs e)
        {
            if (dgv_giohang.Rows.Count == 1)
            {
                MessageBox.Show("Giỏ hàng rỗng, vui lòng thêm sản phẩm");
            }
            else
            {
                int diemsudung;
                if (rd_ksd.Checked == true)
                {
                    diemsudung = 0;
                }
                else
                {
                    diemsudung = int.Parse(txt_diem.Text);
                }
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(lbl_mahd.Text, lbl_tongthanhtoan.Text, int.Parse(txt_diem.Text), diemsudung);
                chiTietHoaDon.Show();
                btn_taomoi.Enabled = true;

            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text.Equals("Sửa"))
            {
                btn_sua.Text = "Lưu";
                btn_them.Enabled = false;
                cmb_masp.Enabled = false;
            }
            else
            {
                cmb_masp.Text = dgv_giohang.CurrentRow.Cells["col_masp"].Value.ToString();
                btn_sua.Text = "Sửa";
                cmb_masp.Enabled = true;
                btn_them.Enabled = true;
                test();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            if (string.IsNullOrEmpty(cmb_loaikh.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
            }
            else
            {
                test();
                laydulieugiohang();
                tinhtongtienhang();
                tinhtongthanhtoan();
                cmb_makh.Enabled = false;
                cmb_manv.Enabled = false;
                cmb_makh.Enabled = false;
                cmb_loaikh.Enabled = false;
                cmb_tenkh.Enabled = false;
            }
        }


        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            capnhatsoluongsaukhixoa();
            xoa1dongcthd();
            xoa1donghoadon();
            tinhtongtienhang();
            tinhtongthanhtoan();
            if (dgv_giohang.Rows.Count == 0)
            {
                cmb_makh.Enabled = true;
                cmb_manv.Enabled = true;
                cmb_makh.Enabled = true;
                cmb_loaikh.Enabled = true;
                cmb_tenkh.Enabled = true;
            }
        }

        private void cmb_loaikh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_loaikh.SelectedIndex == 0)
            {
                cmb_makh.Text = " ";
                cmb_makh.Enabled = false;
                cmb_tenkh.Text = " ";
                cmb_tenkh.Enabled = false;
                txt_sdt.Text = " ";
                txt_sdt.Enabled = false;
                txt_diachi.Text = " ";
                txt_diachi.Enabled = false;
                txt_diem.Text = "0";
                txt_diem.Enabled = false;
            }
            else
            {
                cmb_makh.Enabled = true;
                cmb_tenkh.Enabled = true;
                txt_sdt.Enabled = true;
                txt_diachi.Enabled = true;
                txt_diem.Enabled = true;
                cmb_makh.DataSource = null;
                cmb_tenkh.DataSource = null;
                loaddulieukhachang();
                if (string.IsNullOrEmpty(cmb_makh.Text))
                {
                    cmb_makh.Text = " ";
                    cmb_tenkh.Text = " ";
                    txt_sdt.Text = " ";
                    txt_diachi.Text = " ";
                    txt_diem.Text = "0";
                }
            }
        }

        private void btn_lammoi_Click_1(object sender, EventArgs e)
        {
            lammoigiohang();
            TaoMaHoaDon();
        }
        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            TaoMaHoaDon();
            laydulieugiohang();
            MessageBox.Show("Làm mới thành công");
            cmb_loaikh.Enabled = true;
            cmb_tenkh.Enabled = true;
            cmb_makh.Enabled = true;
            cmb_manv.Enabled = true;
            btn_taomoi.Enabled = false;
            lbl_giamgia.Text = "0";
            lbl_tongthanhtoan.Text = "0";
            lbl_tongtienhang.Text = "0";
        }

        private void rd_sd_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_makh.Text == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước");
            }
            else
            {
                decimal giamgia = decimal.Parse(lbl_giamgia.Text);
                int diemgiamgia = int.Parse(txt_diem.Text) * 1000;
                decimal tonggiam;
                if (rd_sd.Checked == true)
                {
                    tonggiam = giamgia + diemgiamgia;
                    lbl_giamgia.Text = tonggiam.ToString();
                }
                else if (rd_sd.Checked == false)
                {
                    lbl_giamgia.Text = giamgia.ToString();
                }
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "UPDATE CTHD SET GIAMGIA = @GIAMGIA WHERE SOHD = @SOHD";
                cm.Parameters.AddWithValue("SOHD", lbl_mahd.Text);
                cm.Parameters.AddWithValue("GIAMGIA", lbl_giamgia.Text);
                int row = cm.ExecuteNonQuery();
                if (float.Parse(lbl_giamgia.Text) > float.Parse(lbl_tongthanhtoan.Text))
                {
                    float maxgiamgia = float.Parse(lbl_tongtienhang.Text);
                    lbl_giamgia.Text = maxgiamgia.ToString();
                    lbl_tongthanhtoan.Text = "0";
                }
                else
                {
                    tinhtongthanhtoan();
                }
            }
        }

        private void rd_ksd_CheckedChanged(object sender, EventArgs e)
        {
            decimal giamgia = decimal.Parse(lbl_giamgia.Text);
            int diemgiamgia = int.Parse(txt_diem.Text) * 1000;
            decimal tonggiam;
            if (rd_ksd.Checked == true)
            {
                tonggiam = giamgia - diemgiamgia;
                lbl_giamgia.Text = tonggiam.ToString();
            }
            else if (rd_ksd.Checked == false)
            {
                lbl_giamgia.Text = giamgia.ToString();
            }
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "UPDATE CTHD SET GIAMGIA = @GIAMGIA WHERE SOHD = @SOHD";
            cm.Parameters.AddWithValue("SOHD", lbl_mahd.Text);
            cm.Parameters.AddWithValue("GIAMGIA", lbl_giamgia.Text);
            int row = cm.ExecuteNonQuery();
            if (float.Parse(lbl_giamgia.Text) > float.Parse(lbl_tongthanhtoan.Text))
            {
                float maxgiamgia = float.Parse(lbl_tongtienhang.Text);
                lbl_giamgia.Text = maxgiamgia.ToString();
                lbl_tongthanhtoan.Text = "0";
            }
            else
            {
                tinhtongthanhtoan();
            }
        }
        private void capnhatslkho()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "UPDATE SLHETHONG SET SLHETHONG = SLHETHONG - @SL WHERE MASP = @MASP";
            cm.Parameters.AddWithValue("SL", num_sl.Value);
            cm.Parameters.AddWithValue("MASP", cmb_masp.Text);
            SqlDataReader reader = cm.ExecuteReader();
            int soLuongTon = (int)reader["SLHETHONG"];

        }
        private void test()
        {
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            int soluongban = int.Parse(num_sl.Value.ToString());
            string query = "SELECT * FROM SANPHAM WHERE MASP = @MASP";
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                command.Parameters.AddWithValue("@MASP", cmb_masp.Text);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if
         (reader.Read())
                    {
                        int soLuongTon = (int)reader["SLHETHONG"];
                        reader.Close();
                        if (soLuongTon >= soluongban)
                        {
                            // Cập nhật số lượng
                            int soLuongMoi = soLuongTon - soluongban;
                            query = "UPDATE SanPham SET SLHETHONG = @soLuongMoi WHERE MASP = @MASP";
                            command.CommandText = query;
                            command.Parameters.AddWithValue("@soLuongMoi", soLuongMoi);
                            command.ExecuteNonQuery(); 
                            pushsqlhd();
                            pushsqlcthd();
                        }
                        else
                        {
                            MessageBox.Show("Số lượng tồn kho không đủ!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm không tồn tại!");
                    }
                }
            }
        }
        private void capnhatsoluongsaukhisua()
        {
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            int soluongban = int.Parse(num_sl.Value.ToString());
            string query = "SELECT * FROM SANPHAM WHERE MASP = @MASP";
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                command.Parameters.AddWithValue("@MASP", cmb_masp.Text);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if
         (reader.Read())
                    {
                        int soLuongTon = (int)reader["SLHETHONG"];
                        reader.Close();
                        if (soLuongTon >= soluongban)
                        {
                            // Cập nhật số lượng
                            int soLuongMoi = soLuongTon - soluongban;
                            query = "UPDATE SanPham SET SLHETHONG = @soLuongMoi WHERE MASP = @MASP";
                            command.CommandText = query;
                            command.Parameters.AddWithValue("@soLuongMoi", soLuongMoi);
                            command.ExecuteNonQuery();
                            suadulieu();
                            suadulieucthd();
                        }
                        else
                        {
                            MessageBox.Show("Số lượng tồn kho không đủ!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm không tồn tại!");
                    }
                }
            }
        }
        private void capnhatsoluongsaukhixoa()
        {
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            int soluongban = int.Parse(dgv_giohang.CurrentRow.Cells["col_sl"].Value.ToString());
            string query = "SELECT * FROM SANPHAM WHERE MASP = @MASP";
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                command.Parameters.AddWithValue("@MASP", dgv_giohang.CurrentRow.Cells["col_masp"].Value.ToString());
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if
         (reader.Read())
                    {
                        int soLuongTon = (int)reader["SLHETHONG"];
                        reader.Close();
                        // Cập nhật số lượng
                        int soLuongMoi = soLuongTon + soluongban;
                        query = "UPDATE SanPham SET SLHETHONG = @soLuongMoi WHERE MASP = @MASP";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@soLuongMoi", soLuongMoi);
                        command.ExecuteNonQuery(); 

                    }
                }
            }
        }
    }
}
    
