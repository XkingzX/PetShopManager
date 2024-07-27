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
    public partial class frm_danhmuc : Form
    {
        public frm_danhmuc()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=TIENTOI;Initial Catalog=QLBH;Integrated Security=True;");
        private void ketnoicsdl()
        {
            cn.Open();
            string sql = "select * from HANGHOA";
            SqlCommand cm = new SqlCommand(sql, cn);
            cm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            dgv_danhmucsp.DataSource = dt;
        }

        private void frm_danhmuc_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            ketnoicsdl();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            using (frm_NhapLieu frm = new frm_NhapLieu("Thêm Sản Phẩm", "Thêm"))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string maSP = frm.maSP;
                    string tenSP = frm.tenSP;
                    // Xử lý logic khi nhận được dữ liệu từ form nhập liệu
                    MessageBox.Show("Mã sản phẩm: " + maSP + "\n" + "Tên sản phẩm: " + tenSP);
                }
            }
        }

    }
}
