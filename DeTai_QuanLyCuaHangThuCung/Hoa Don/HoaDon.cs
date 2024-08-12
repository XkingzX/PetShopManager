using Microsoft.Reporting.WinForms;
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
using WindowsFormsApp1;

namespace DeTai_QuanLyCuaHangThuCung.GiaoDich
{
    public partial class frm_hoadon : Form
    {
        protected string sqlhoadon = @"Data Source=TIENTOI;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True";
        protected SqlConnection cn;
        protected SqlCommand cm;
        public DataTable dt;
        public BindingSource bd;
        string[] dsthang =
        {
            "1", "2", "3", "4", "5", "6",
            "7", "8", "9", "10", "11", "12"
        };
        string[] dsnam =
        {
            "2024","2023","2022","2021"
        };
        public frm_hoadon()
        {
            InitializeComponent();
            dgv_hoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ketnoicsdl()
        {
            cn = new SqlConnection();
            cn.ConnectionString = sqlhoadon;
            cn.Open();
        }

        private void laydulieu()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select SOHD,THOIGIAN,KHACHHANG.HOTEN,NHANVIEN.HOTEN,TONGTIEN,TRANGTHAI,PTTHANHTOAN from CTHD,KHACHHANG,NHANVIEN WHERE CTHD.MAKH = KHACHHANG.MAKH AND NHANVIEN.MANV = CTHD.MANV";
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            dgv_hoadon.DataSource = dt;
        }
        private void laydulieukh()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from KHACHHANG";
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
        }
        private void laydulieusp()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from SANPHAM";
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
        }

        private void frm_hoadon_Load_1(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            ketnoicsdl();
            cmb_thang.Items.AddRange(dsthang);
            cmb_nam.Items.AddRange(dsnam);
            laydulieu();
            laydulieukh();
            laydulieusp();
        }

        private void btn_xemhd_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(dgv_hoadon.CurrentRow.Cells[0].Value.ToString(), dgv_hoadon.CurrentRow.Cells[4].Value.ToString(),0,0);
            chiTietHoaDon.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDSCTHD formDSCTHoaDon = new FormDSCTHD();
            formDSCTHoaDon.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            xoadulieucthd();
            xoadulieuhd();
            laydulieu();
        }
        private void xoadulieuhd()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "DELETE FROM HOADON WHERE SOHD = @SOHD";
            cm.Parameters.AddWithValue("SOHD", dgv_hoadon.CurrentRow.Cells[0].Value);
            int row = cm.ExecuteNonQuery();
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
        }
        private void xoadulieucthd()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "DELETE FROM CTHD WHERE SOHD = @SOHD";
            cm.Parameters.AddWithValue("SOHD", dgv_hoadon.CurrentRow.Cells[0].Value);
            int row = cm.ExecuteNonQuery();
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
        }

        private void btn_xemdshd_Click(object sender, EventArgs e)
        {
            FormDSHoaDon formDSHoaDon = new FormDSHoaDon();
            formDSHoaDon.Show();
        }


        private void rd_dathanhtoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_dathanhtoan.Checked)
            {
                string tukhoa = rd_dathanhtoan.Text.Trim();
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = $"select SOHD,THOIGIAN,KHACHHANG.HOTEN,NHANVIEN.HOTEN,TONGTIEN,TRANGTHAI,PTTHANHTOAN FROM CTHD,KHACHHANG,NHANVIEN WHERE CTHD.MAKH = KHACHHANG.MAKH AND CTHD.MANV = NHANVIEN.MANV AND CTHD.TRANGTHAI = '{tukhoa}'";
                cm.Parameters.AddWithValue("tukhoa", tukhoa);
                cm.ExecuteNonQuery();
                int row = cm.ExecuteNonQuery();
                SqlDataReader reader = cm.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                dgv_hoadon.DataSource = dt;
            }
            else if (rd_dahuy.Checked)
            {
                string tukhoa = "Đã huỷ";
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = $"select SOHD,THOIGIAN,KHACHHANG.HOTEN,NHANVIEN.HOTEN,TONGTIEN,TRANGTHAI,PTTHANHTOAN FROM CTHD,KHACHHANG,NHANVIEN WHERE CTHD.MAKH = KHACHHANG.MAKH AND CTHD.MANV = NHANVIEN.MANV AND CTHD.TRANGTHAI = '{tukhoa}'";
                cm.Parameters.AddWithValue("tukhoa", tukhoa);
                cm.ExecuteNonQuery();
                int row = cm.ExecuteNonQuery();
                SqlDataReader reader = cm.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                dt.Clear();
                dgv_hoadon.DataSource = dt;
            }
            else
            {
                laydulieu();
            }    
        }

        private void rd_dahuy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thang = cmb_thang.Text;
            string nam = cmb_nam.Text;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = $"select SOHD,THOIGIAN,KHACHHANG.HOTEN,NHANVIEN.HOTEN,TONGTIEN,TRANGTHAI,PTTHANHTOAN FROM CTHD,KHACHHANG,NHANVIEN WHERE CTHD.MAKH = KHACHHANG.MAKH AND CTHD.MANV = NHANVIEN.MANV AND MONTH(CTHD.THOIGIAN) = '{thang}' AND YEAR(CTHD.THOIGIAN) = '{nam}'";
            cm.Parameters.AddWithValue("thang", thang);
            cm.Parameters.AddWithValue("nam", nam);
            cm.ExecuteNonQuery();
            int row = cm.ExecuteNonQuery();
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            dgv_hoadon.DataSource = dt;
        }

        private void cmb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thang = cmb_thang.Text;
            string nam = cmb_nam.Text;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = $"select SOHD,THOIGIAN,KHACHHANG.HOTEN,NHANVIEN.HOTEN,TONGTIEN,TRANGTHAI,PTTHANHTOAN FROM CTHD,KHACHHANG,NHANVIEN WHERE CTHD.MAKH = KHACHHANG.MAKH AND CTHD.MANV = NHANVIEN.MANV AND YEAR(CTHD.THOIGIAN) = '{nam}' AND MONTH(CTHD.THOIGIAN) = '{thang}'";
            cm.Parameters.AddWithValue("thang", thang);
            cm.Parameters.AddWithValue("nam", nam);
            cm.ExecuteNonQuery();
            int row = cm.ExecuteNonQuery();
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            dgv_hoadon.DataSource = dt;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cmb_nam.Text = string.Empty;
            cmb_thang.Text = string.Empty;
            laydulieu();
        }
    }
}
