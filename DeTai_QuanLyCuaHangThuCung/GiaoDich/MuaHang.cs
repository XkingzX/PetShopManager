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
    public partial class MuaHang : Form
    {
        protected string cnstr = @"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";
        protected SqlConnection cn;
        protected SqlCommand cm;
        public DataTable dt;
        public MuaHang()
        {
            InitializeComponent();
            this.Load += MuaHang_Load;
            this.txt_nhapmasp.KeyDown += Txt_nhapmasp_KeyDown;
        }

        private void Txt_nhapmasp_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                timkiemmasp();
            }
        }

        private void MuaHang_Load(object? sender, EventArgs e)
        {
            ketnoicsdl();
            timkiemmasp();
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
        private void laydulieu()
        {
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from HOADON,SANPHAM,KHACHHANG WHERE HOADON.MASP = SANPHAM.MASP AND HOADON.MAKH = KHACHHANG.MAKH";
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
        }
        private void timkiemmasp()
        {
            string maSP = txt_nhapmasp.Text.Trim();
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm để tìm kiếm.");
                dgv_giohang.DataSource = null;
                return;
            }
            try
            {
                string tukhoa = txt_nhapmasp.Text;
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from SANPHAM";
                //SqlCommand cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@MASP", maSP);
                SqlDataReader reader = cm.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                cn.Close();

                if (dt.Rows.Count > 0)
                {
                    dgv_giohang.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm với mã: " + maSP);
                }
            }
            catch (Exception) { }
        }
    }
}
