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
    public partial class inmasanpham : Form
    {
        string maSP;
        string tenSP;
        string giaSP;

        public inmasanpham(string maSP, string tenSP, string giaSP)
        {
            InitializeComponent();
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.giaSP = giaSP;
        }
        SqlConnection cn = new SqlConnection(@"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;");
        protected SqlCommand cm;
        public DataTable dt;
        public BindingSource bd;
        public inmasanpham()
        {
            InitializeComponent();
        }

        private void inmasanpham_Load(object sender, EventArgs e)
        {
            lbl_tensp.Text = "Tên sản phẩm: " + tenSP;
            lbl_masp.Text = "Mã sản phẩm: " + maSP;
            lbl_gia.Text = giaSP + " VND";
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
