using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeTai_QuanLyCuaHangThuCung.DangNhap.frm_DangNhap;

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class frmTTCN : Form
    {
        private string maNV;
        public frmTTCN()
        {
            InitializeComponent();
            LoadThongTinCaNhan();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadThongTinCaNhan()
        {

            string maNV = UserSession.MaNV; // Lấy mã nhân viên từ UserSession

            string sql = @"SELECT * FROM NHANVIEN WHERE MANV = @MANV";

            using (SqlConnection ketnoi = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
            {
                try
                {
                    ketnoi.Open();
                    SqlCommand cm = new SqlCommand(sql, ketnoi);
                    cm.Parameters.AddWithValue("@MANV", maNV);

                    SqlDataReader read = cm.ExecuteReader();

                    if (read.Read())
                    {
                        txtManv.Text = read["MANV"].ToString();
                        txtHoten.Text = read["HOTEN"].ToString();
                        txtSodienthoai.Text = read["SODT"].ToString();
                        txtDiachi.Text = read["DIACHI"].ToString();
                        txtEmail.Text = read["EMAIL"].ToString();
                        dtpNgsinh.Value = (DateTime)read["NGSINH"];
                        dtpNgvl.Value = (DateTime)read["NGVL"];
                        rdbNam.Checked = read["GIOITINH"].ToString() == "Nam";
                        rdbNu.Checked = read["GIOITINH"].ToString() == "Nữ";
                        lbQuyen.Text = read["QUYEN"].ToString();


                        if (read["HINH"] != DBNull.Value)
                        {
                            byte[] Hinh = (byte[])read["HINH"];
                            using (MemoryStream ms = new MemoryStream(Hinh))
                            {
                                pbHinhanh.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }
        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {

            pbHinhanh.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pbHinhanh_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
