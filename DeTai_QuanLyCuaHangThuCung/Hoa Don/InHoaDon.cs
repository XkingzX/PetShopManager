using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class InHoaDon : Form
    {
        protected string cnstr = @"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";
        protected SqlConnection cn;
        protected SqlCommand cm;
        public DataTable dt;
        public BindingSource bd;
        string mahd1;
        string tongtien;
        public InHoaDon(string mahd1,string tongtien)
        {
            InitializeComponent();
            this.mahd1 = mahd1;
            this.tongtien = tongtien;
        }
        public InHoaDon()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            cn = new SqlConnection();
            cn.ConnectionString = cnstr;
            cn.Open();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            laydulieu();
        }
        private void laydulieu()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select SANPHAM.TENSP,CTHD.SL,CTHD.SL * SANPHAM.GIA AS TONGTIEN FROM SANPHAM,CTHD WHERE CTHD.SOHD = @SOHD AND CTHD.MASP = SANPHAM.MASP";
            cm.Parameters.AddWithValue("SOHD", mahd1);
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            dgv_hoadon.DataSource = dt;
        }
    }
}
