using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung
{
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
            cmbQuyen.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManv.Text) ||
                string.IsNullOrEmpty(txtHoten.Text) ||
                string.IsNullOrEmpty(txtMatkhau.Text) ||
                string.IsNullOrEmpty(txtSoDienThoai.Text) ||
                string.IsNullOrEmpty(txtDiachi.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                cmbQuyen.SelectedItem == null ||
                (rdbNam.Checked == false && rdbNu.Checked == false))

            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            string quyen = cmbQuyen.SelectedItem.ToString();
            string manv = txtManv.Text;
            if ((quyen == "Quản lý" && !manv.StartsWith("QL")) || (quyen == "Nhân viên" && !manv.StartsWith("NV")))
            {
                MessageBox.Show($"Mã nhân viên phải bắt đầu bằng \"{(quyen == "Quản lý" ? "QL" : "NV")}\".");
                return;
            }
            bool maNVtontai = false;
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                {
                    cn.Open();
                    string KiemtraQuery = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @MANV";
                    using (SqlCommand KiemtraCmd = new SqlCommand(KiemtraQuery, cn))
                    {
                        KiemtraCmd.Parameters.AddWithValue("@MANV", txtManv.Text);
                        int count = (int)KiemtraCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            maNVtontai = true;
                        }
                    }
                    cn.Close();
                }

                if (maNVtontai)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.");
                    return;
                }

                byte[] Hinhanh = null;
                if (pbHinhanh.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbHinhanh.Image.Save(ms, pbHinhanh.Image.RawFormat);
                        Hinhanh = ms.ToArray();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần phải thêm hình ảnh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                    {
                        cn.Open();
                        string sql = @"INSERT INTO NHANVIEN (MANV, HOTEN, SODT, NGVL, MATKHAU, QUYEN, DIACHI, EMAIL, NGSINH, GIOITINH, GHICHU, HINH)
                                VALUES (@MANV, @HOTEN, @SODT, @NGVL, @MATKHAU, @QUYEN, @DIACHI, @EMAIL, @NGSINH, @GIOITINH, @GHICHU, @HINH)";
                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@MANV", txtManv.Text);
                            cmd.Parameters.AddWithValue("@HOTEN", txtHoten.Text);
                            cmd.Parameters.AddWithValue("@SODT", txtSoDienThoai.Text);
                            cmd.Parameters.AddWithValue("@NGVL", dtpNgayvaolam.Value);
                            cmd.Parameters.AddWithValue("@MATKHAU", txtMatkhau.Text);
                            cmd.Parameters.AddWithValue("@QUYEN", cmbQuyen.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@DIACHI", txtDiachi.Text);
                            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@NGSINH", dtpNgaysinh.Value);
                            cmd.Parameters.AddWithValue("@GIOITINH", rdbNam.Checked ? "Nam" : "Nữ");
                            cmd.Parameters.AddWithValue("@GHICHU", txtGhichu.Text);

                            if (Hinhanh != null)
                            {
                                cmd.Parameters.Add("@HINH", SqlDbType.VarBinary).Value = Hinhanh;
                            }
                            else
                            {
                                cmd.Parameters.Add("@HINH", SqlDbType.VarBinary).Value = DBNull.Value;
                            }

                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();

                        MessageBox.Show("Nhân viên đã được thêm.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog  Layhinh = new OpenFileDialog())
            {
                Layhinh.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
                Layhinh.Title = "Chọn hình ảnh";

                if (Layhinh.ShowDialog() == DialogResult.OK)
                {
                    pbHinhanh.Image = Image.FromFile(Layhinh.FileName);
                    pbHinhanh.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpNgayvaolam.Value = DateTime.Now;
        }
    }
}
