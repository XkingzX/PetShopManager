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
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
            cmbQuyen.SelectedIndex = 0;
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
            if (dtpNgayvaolam.Value.Date <= dtpNgaysinh.Value.Date)
            {
                MessageBox.Show("Ngày vào làm không được trước ngày sinh.");
                return;
            }

            int tuoi = dtpNgayvaolam.Value.Year - dtpNgaysinh.Value.Year;
            if (dtpNgayvaolam.Value < dtpNgaysinh.Value.AddYears(tuoi)) //Xét nếu chưa qua ngày sinh trong năm hiện tại thì tuổi sẽ trừ đi 1 tuổi
            {
                tuoi--;
            }

            if (tuoi < 16)
            {
                MessageBox.Show("Nhân viên chưa đủ 16 tuổi! Kiểm tra lại");
                return;
            }
            bool maNVtontai = false;
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=ADMIN-PC\MSSQLSERVER01;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
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

                byte[] Hinhanh = null; // đưa dữ liệu Hình ảnh thành dạng byte để lưu vào csdl
                if (pbHinhanh.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream()) //lưu trữ dữ liệu trong bộ nhớ thay vì các loại tệp hay đĩa
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
                    using (SqlConnection cn = new SqlConnection(@"Data Source=ADMIN-PC\MSSQLSERVER01;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                    {
                        cn.Open();
                        string sql = @"INSERT INTO NHANVIEN (MANV, HOTEN, SODT, NGVL, MATKHAU, QUYEN, DIACHI, EMAIL, NGSINH, GIOITINH, GHICHU, HINH)
                                VALUES (@MANV, @HOTEN, @SODT, @NGVL, @MATKHAU, @QUYEN, @DIACHI, @EMAIL, @NGSINH, @GIOITINH, @GHICHU, @HINH)";
                        using (SqlCommand cm = new SqlCommand(sql, cn))
                        {
                            cm.Parameters.AddWithValue("@MANV", txtManv.Text);
                            cm.Parameters.AddWithValue("@HOTEN", txtHoten.Text);
                            cm.Parameters.AddWithValue("@SODT", txtSoDienThoai.Text);
                            cm.Parameters.AddWithValue("@NGVL", dtpNgayvaolam.Value);
                            cm.Parameters.AddWithValue("@MATKHAU", txtMatkhau.Text);
                            cm.Parameters.AddWithValue("@QUYEN", cmbQuyen.SelectedItem.ToString());
                            cm.Parameters.AddWithValue("@DIACHI", txtDiachi.Text);
                            cm.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                            cm.Parameters.AddWithValue("@NGSINH", dtpNgaysinh.Value);
                            cm.Parameters.AddWithValue("@GIOITINH", rdbNam.Checked ? "Nam" : "Nữ");
                            cm.Parameters.AddWithValue("@GHICHU", txtGhichu.Text);

                            if (Hinhanh != null)
                            {
                                cm.Parameters.Add("@HINH", SqlDbType.VarBinary).Value = Hinhanh;
                            }
                            else
                            {
                                cm.Parameters.Add("@HINH", SqlDbType.VarBinary).Value = DBNull.Value;
                            }

                            cm.ExecuteNonQuery();
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

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            txtManv.Text = txtManv.Text.ToUpper();
            txtManv.SelectionStart = txtManv.Text.Length;
            if (txtManv.Text.Length > 6)
            {
                MessageBox.Show("Mã nhân viên không được quá 6 kí tự!", "Thông báo", MessageBoxButtons.OK);
                txtManv.Text = txtManv.Text.Substring(0, 6);
                txtManv.SelectionStart = txtManv.Text.Length;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChonhinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Layhinh = new OpenFileDialog())
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
            this.BeginInvoke((Action)(() =>
            {
                txtManv.Focus();
            }));
        }

    }
}
