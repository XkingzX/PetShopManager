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
        public ChiTietHoaDon( string mahd1)
        {
            InitializeComponent();
            this.mahd1 = mahd1;
        }
        protected string sqlhoadon = @"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";
        protected SqlConnection cn;
        protected SqlCommand cm;
        public DataTable dt;
        public BindingSource bd;
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void ChiTietHoaDon_Load_1(object sender, EventArgs e)
        {
            ketnoicsdl();
            txt_mahd.Text = mahd1;
            laydulieu();
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
            cm.CommandText = "select * from HOADON,SANPHAM,KHACHHANG WHERE HOADON.MASP = SANPHAM.MASP AND HOADON.MAKH = KHACHHANG.MAKH";
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            bd.DataSource = dt;
            txt_makh.DataBindings.Add("Text", bd, "HOTEN");
            txt_loaikh.DataBindings.Add("Text", bd, "LOAI");
            txt_sdt.DataBindings.Add("Text", bd, "SDT");
        }

    }
}
