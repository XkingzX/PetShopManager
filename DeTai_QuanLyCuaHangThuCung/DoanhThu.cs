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
    public partial class DoanhThu : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;");
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
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txt_ngaynhaptudong.Text = currentTime.ToString("dd/MM/yyyy HH:mm:ss");
            txt_ngaynhaptudong.Enabled = false;
            txt_chinhanh.Text = "Chi nhánh: Cửa hàng thú cưng - PetShop";
            ketnoicsdl();
            cmb_thang.Items.AddRange(dsthang);
            cmb_nam.Items.AddRange(dsnam);
        }
        private void ketnoicsdl()
        {
            cn.Open();
            string sql = @"SELECT CONVERT(DATE, CTHD.THOIGIAN) AS N'Thời gian',
                           SUM(CTHD.TONGTIEN) AS N'Doanh thu',
                           SUM(CTHD.SL) AS N'Số lượng',
                           SUM(CTHD.GIAMGIA) AS N'Giảm giá',
                           SUM(CTHD.TONGTIEN - ISNULL(CTHD.GIAMGIA, 0)) AS N'Thực thu'
                           FROM CTHD
                           WHERE CTHD.TRANGTHAI = N'Đã thanh toán'
                           GROUP BY CONVERT(DATE, CTHD.THOIGIAN)
                           ORDER BY CONVERT(DATE, CTHD.THOIGIAN);";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            dgv_doanhthu.DataSource = dt;
            dgv_doanhthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            string thang = cmb_thang.Text;
            string nam = cmb_nam.Text;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = $@"SELECT CONVERT(DATE, CTHD.THOIGIAN) AS N'Thời gian',
                           SUM(CTHD.TONGTIEN) AS N'Doanh thu',
                           SUM(CTHD.SL) AS N'Số lượng',
                           SUM(CTHD.GIAMGIA) AS N'Giảm giá',
                           SUM(CTHD.TONGTIEN - ISNULL(CTHD.GIAMGIA, 0)) AS N'Thực thu'
                           FROM CTHD
                           WHERE CTHD.TRANGTHAI = N'Đã thanh toán AND YEAR(CTHD.THOIGIAN) = '{nam}''
                           GROUP BY CONVERT(DATE, CTHD.THOIGIAN)
                           ORDER BY CONVERT(DATE, CTHD.THOIGIAN);";
            cm.Parameters.AddWithValue("thang", thang);
            cm.Parameters.AddWithValue("nam", nam);
            cm.ExecuteNonQuery();
            int row = cm.ExecuteNonQuery();
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            cn.Close();
            dgv_doanhthu.DataSource = dt;
        }

        private void cmb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            string thang = cmb_thang.Text;
            string nam = cmb_nam.Text;
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = $@"SELECT CONVERT(DATE, CTHD.THOIGIAN) AS N'Thời gian',
                           SUM(CTHD.TONGTIEN) AS N'Doanh thu',
                           SUM(CTHD.SL) AS N'Số lượng',
                           SUM(CTHD.GIAMGIA) AS N'Giảm giá',
                           SUM(CTHD.TONGTIEN - ISNULL(CTHD.GIAMGIA, 0)) AS N'Thực thu'
                           FROM CTHD
                           WHERE CTHD.TRANGTHAI = N'Đã thanh toán AND YEAR(CTHD.THOIGIAN) = '{thang}''
                           GROUP BY CONVERT(DATE, CTHD.THOIGIAN)
                           ORDER BY CONVERT(DATE, CTHD.THOIGIAN);";
            cm.Parameters.AddWithValue("thang", thang);
            cm.Parameters.AddWithValue("nam", nam);
            cm.ExecuteNonQuery();
            int row = cm.ExecuteNonQuery();
            SqlDataReader reader = cm.ExecuteReader();
            dt = new DataTable();
            dt.Load(reader);
            cn.Close();
            dgv_doanhthu.DataSource = dt;
        }
        private void laydulieusp()
        {
            cn.Open();
            string sql = @"SELECT CTHD.THOIGIAN AS N'Thời gian',
                   SUM(CTHD.TONGTIEN) AS N'Doanh thu',
                   SUM(CTHD.SL) AS N'Số lượng',
                   SUM(CTHD.GIAMGIA) AS N'Giảm giá',
                   SUM(CTHD.TONGTIEN - ISNULL(CTHD.GIAMGIA, 0)) AS N'Thực thu'
                   FROM CTHD
                   WHERE CTHD.TRANGTHAI = N'Đã thanh toán'
                   GROUP BY CTHD.THOIGIAN
                   ORDER BY CTHD.THOIGIAN";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            dgv_doanhthu.DataSource = dt;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cmb_nam.Text = string.Empty;
            cmb_thang.Text = string.Empty;
            laydulieusp();
        }
    }
}
