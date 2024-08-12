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

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class ChiTietHoaDon : Form
    {
        string mahd1;
        //string hoten;
        //string sdt;
        //string dchi;
        //string makh;
        //string loai;
        //string nhanvien;
        //string manv;
        //string giamgia;
        string tongthanhtoan;
        int diemthuong;
        int diemsudung;


        public ChiTietHoaDon(string mahd1,/*, string hoten, string sdt, string dchi, string makh, string loai, string nhanvien, string manv, string giamgia,*/ string tongthanhtoan, int diemthuong, int diemsudung)
        {
            InitializeComponent();
            this.mahd1 = mahd1;
            //    this.hoten = hoten;
            //    this.sdt = sdt;
            //    this.dchi = dchi;
            //    this.makh = makh;
            //    this.loai = loai;
            //    this.nhanvien = nhanvien;
            //    this.manv = manv;
            //    this.giamgia = giamgia;
            this.tongthanhtoan = tongthanhtoan;
            this.diemthuong = diemthuong;
            this.diemsudung = diemsudung;
        }
        protected string sqlhoadon = @"Data Source=TIENTOI;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True";
        protected SqlConnection cn;
        protected SqlCommand cm;
        public DataTable dt;
        public BindingSource bd;
        string[] dschinhanh = { "Pet Shop 1 chi nhánh 81 Trương Văn Bang" };
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }



        private void ketnoicsdl()
        {
            cn = new SqlConnection();
            cn.ConnectionString = sqlhoadon;
            cn.Open();
        }
        private void laydulieuthongtin()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            string Mahd = txt_mahd.Text;
            cm.Parameters.AddWithValue("@MAHD", Mahd);
            cm.CommandText = "select KHACHHANG.MAKH,KHACHHANG.LOAIKH,KHACHHANG.SODT,NHANVIEN.MANV,NHANVIEN.HOTEN,CTHD.MASP,CTHD.GIAMGIA,CTHD.KHACHTRA,CTHD.TIENTHOI,SANPHAM.TENSP,SANPHAM.GIA,SL,TONGTIEN from CTHD,SANPHAM,KHACHHANG,NHANVIEN WHERE CTHD.MASP = SANPHAM.MASP AND CTHD.SOHD = @Mahd AND CTHD.MAKH = KHACHHANG.MAKH AND CTHD.MANV = NHANVIEN.MANV";
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            bd = new BindingSource();
            bd.DataSource = dt;
            txt_makh.DataBindings.Add("Text", bd, "MAKH");
            if(string.IsNullOrEmpty(txt_loaikh.Text))
            {
                txt_loaikh.Text = "Khách lẻ";
            }
            else
            {
                txt_loaikh.DataBindings.Add("Text", bd, "LOAIKH");
            }    
            txt_sdt.DataBindings.Add("Text", bd, "SODT");
            if(txt_loaikh.Text == "Khách lẻ")
            {
                txt_giamgia.Text = "0";
            }
            else
            {
                txt_giamgia.DataBindings.Add("Text", bd, "GIAMGIA");
            }
            txt_khachtra.DataBindings.Add("Text", bd, "KHACHTRA");
            txt_tienthoi.DataBindings.Add("Text", bd, "TIENTHOI");
            cmb_nguoiban.DataSource = bd;
            cmb_nguoiban.DisplayMember = "HOTEN";
            cmb_nguoiban.ValueMember = "HOTEN";
            cmb_nguoitao.DataSource = bd;
            cmb_nguoitao.DisplayMember = "MANV";
            cmb_nguoitao.ValueMember = "MANV";
        }
        private void laydulieugiohang()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            string Mahd = txt_mahd.Text;
            cm.Parameters.AddWithValue("@MAHD", Mahd);
            cmb_nguoiban.Enabled = false;
            cmb_nguoitao.Enabled = false;
            cm.CommandText = "select CTHD.MASP,SANPHAM.TENSP,SANPHAM.GIA,CTHD.SL,SANPHAM.GIA*CTHD.SL AS TONGTIEN from CTHD,SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND CTHD.SOHD = @Mahd";
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            dgv_danhmucsp.DataSource = dt;
        }




        private void capnhatsqlcthd()
        {
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "UPDATE CTHD SET TONGTIEN = @TONGTIEN, CHINHANH = @CHINHANH, TRANGTHAI = @TRANGTHAI,KHACHTRA = @KHACHTRA,TIENTHOI = @TIENTHOI, PTTHANHTOAN = @PTTHANHTOAN WHERE SOHD = @SOHD";
            cm.Parameters.AddWithValue("TONGTIEN", txt_thanhtien.Text);
            cm.Parameters.AddWithValue("CHINHANH", cmb_chinhanh.Text);
            cm.Parameters.AddWithValue("TRANGTHAI", "Đã thanh toán");
            cm.Parameters.AddWithValue("SOHD", txt_mahd.Text);
            cm.Parameters.AddWithValue("KHACHTRA", txt_khachtra.Text);
            cm.Parameters.AddWithValue("TIENTHOI", txt_tienthoi.Text);
            if (rdb_tienmat.Checked == true)
            {
                cm.Parameters.AddWithValue("PTTHANHTOAN", "Tiền mặt");
            }
            else
            {
                cm.Parameters.AddWithValue("PTTHANHTOAN", "Chuyển khoản");
            }
            int row = cm.ExecuteNonQuery();

        }
        private void capnhatdiemkhachhang()
        {
            int diemsaucung = 0;
            if (txt_giamgia.Text == null)
            {
                txt_giamgia.Text = "0";
            }
            else if (txt_loaikh.Text == "Khách lẻ")
            {
                txt_loaikh.Text = "0";
            }    
            else
            {
                cm = new SqlCommand();
                int diemcongthem;
                if (int.Parse(txt_thanhtien.Text) > 100000)
                {
                    diemcongthem = int.Parse(txt_thanhtien.Text) / 100000;
                }
                else if (int.Parse(txt_thanhtien.Text) == 100000)
                {
                    diemcongthem = 1;
                }
                else diemcongthem = 0;
                cm.Connection = cn;
                diemsaucung = diemthuong - diemsudung + diemcongthem;    
                cm.CommandType = CommandType.Text;
                cm.CommandText = "UPDATE KHACHHANG SET DIEMTHUONG = @DIEMTHUONG WHERE MAKH = @MAKH";
                cm.Parameters.AddWithValue("DIEMTHUONG", diemsaucung);
                cm.Parameters.AddWithValue("MAKH", txt_makh.Text);
                int row = cm.ExecuteNonQuery();
            }
        }
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            txt_mahd.Text = mahd1;
            //txt_makh.Text = makh;
            //txt_loaikh.Text = loai;
            //txt_sdt.Text = sdt;
            //cmb_nguoiban.Text = nhanvien;
            //cmb_nguoitao.Text = manv;
            txt_thanhtien.Text = tongthanhtoan.ToString();
            //txt_giamgia.Text = giamgia.ToString();
            cmb_chinhanh.Items.AddRange(dschinhanh);
            rdb_tienmat.Checked = true;
            cmb_chinhanh.SelectedIndex = 0; 
            dtp_thoigian.Enabled = false;
            laydulieuthongtin();
            laydulieugiohang();
            if (txt_loaikh.Text == "Khách lẻ")
            {
                txt_giamgia.Text = "0";
            }    

        }

        private void rdb_tienmat_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void txt_khachtra_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_khachtra.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền khách trả");
                return; // Dừng thực thi hàm và cho phép người dùng nhập tiếp
            }

            decimal khachTra;
            if (!decimal.TryParse(txt_khachtra.Text, out khachTra))
            {
                MessageBox.Show("Số tiền khách trả không hợp lệ");
                return; // Dừng thực thi hàm và cho phép người dùng nhập tiếp
            }


            decimal thanhTien;
            if (!decimal.TryParse(txt_thanhtien.Text, out thanhTien))
            {
                MessageBox.Show("Số tiền thanh toán không hợp lệ");
                return; // Dừng thực thi hàm và cho phép người dùng nhập tiếp
            }

            // Tính toán tiền thừa
            decimal thua = khachTra - thanhTien;
            txt_tienthoi.Text = thua.ToString();

        }

        private void btn_inhoadon_Click_1(object sender, EventArgs e)
        {
            InHoaDon inHoaDon = new InHoaDon(txt_mahd.Text,txt_thanhtien.Text);
            inHoaDon.Show();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(dgv_danhmucsp.Rows == null)
            {
                MessageBox.Show("Chưa có sản phẩm trong giỏ hàng");
            }
            else
            {
                capnhatsqlcthd();
                capnhatdiemkhachhang();
                MessageBox.Show("Lưu hoá đơn thành công");
                this.Close();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "UPDATE CTHD SET CHINHANH = @CHINHANH, TRANGTHAI = @TRANGTHAI, PTTHANHTOAN =@PTTHANHTOAN,KHACHTRA = @KHACHTRA,TIENTHOI = @TIENTHOI WHERE SOHD = @SOHD";
            cm.Parameters.AddWithValue("CHINHANH", cmb_chinhanh.Text);
            cm.Parameters.AddWithValue("TRANGTHAI", "Đã huỷ");
            cm.Parameters.AddWithValue("SOHD", txt_mahd.Text);
            cm.Parameters.AddWithValue("KHACHTRA", 0);
            cm.Parameters.AddWithValue("TIENTHOI",  0);
            if (rdb_tienmat.Checked == true)
            {
                cm.Parameters.AddWithValue("PTTHANHTOAN", "Tiền mặt");
            }
            else
            {
                cm.Parameters.AddWithValue("PTTHANHTOAN", "Chuyển khoản");
            }
            int row = cm.ExecuteNonQuery();
            this.Close();
        }
    }
}
