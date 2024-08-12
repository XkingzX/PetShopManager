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
    public partial class frmSuaTTNV : Form
    {
        public string Manv { get; set; }
        public string Hoten { get; set; }
        public string Matkhau { get; set; }
        public string Sodt { get; set; }
        public DateTime Ngvl { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public DateTime Ngsinh { get; set; }
        public string Gioitinh { get; set; }
        public string Ghichu { get; set; }
        public byte[] Hinh { get; set; }
        public string Quyen { get; set; }
        private string oldManv;

        public frmSuaTTNV(string maNV, string hoten, string matkhau, string sodt, DateTime ngvl, string diachi, string email, DateTime ngsinh, string gioitinh, string ghichu, byte[] hinh, string quyen)
        {
            InitializeComponent();
            oldManv = maNV; // Lưu mã nhân viên cũ để kiểm tra
            LoadLaiThongTin(maNV, hoten, matkhau, sodt, ngvl, diachi, email, ngsinh, gioitinh, ghichu, hinh, quyen);
        }
        private void LoadLaiThongTin(string maNV, string hoten, string matkhau, string sodt, DateTime ngvl, string diachi, string email, DateTime ngsinh, string gioitinh, string ghichu, byte[] hinh, string quyen)
        {
            // Gán dữ liệu vào các điều khiển trên form
            txtManv.Text = maNV;
            txtHoten.Text = hoten;
            txtMatkhau.Text = matkhau;
            txtSoDienThoai.Text = sodt;
            dtpNgayvaolam.Value = ngvl;
            txtDiachi.Text = diachi;
            txtEmail.Text = email;
            dtpNgaysinh.Value = ngsinh;
            rdbNam.Checked = gioitinh == "Nam";
            rdbNu.Checked = gioitinh == "Nữ";
            txtGhichu.Text = ghichu;
            cmbQuyen.SelectedItem = quyen;

            // Hiển thị hình ảnh
            if (hinh != null)
            {
                using (MemoryStream ms = new MemoryStream(hinh))
                {
                    pbHinhanh.Image = Image.FromStream(ms);
                    pbHinhanh.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                pbHinhanh.Image = null;
            }
        }
        public frmSuaTTNV()
        {
            InitializeComponent();
        }

        private void frmsuattnv_Load(object sender, EventArgs e)
        {
            txtManv.Text = Manv;
            txtHoten.Text = Hoten;
            txtMatkhau.Text = Matkhau;
            txtSoDienThoai.Text = Sodt;
            dtpNgayvaolam.Value = Ngvl;
            txtDiachi.Text = Diachi;
            txtEmail.Text = Email;
            dtpNgaysinh.Value = Ngsinh;
            txtGhichu.Text = Ghichu;
            cmbQuyen.SelectedItem = Quyen;

            if (Gioitinh == "Nam")
                rdbNam.Checked = true;
            else if (Gioitinh == "Nữ")
                rdbNu.Checked = true;

            if (Hinh != null)
            {
                using (MemoryStream ms = new MemoryStream(Hinh))
                {
                    pbHinhanh.Image = Image.FromStream(ms);
                    pbHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManv.Text) ||
            string.IsNullOrEmpty(txtHoten.Text) ||
            string.IsNullOrEmpty(txtMatkhau.Text) ||
            string.IsNullOrEmpty(txtSoDienThoai.Text) ||
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
                    string KiemtraQuery = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @MANV AND MANV != @OldMANV";
                    using (SqlCommand Kiemtracmd = new SqlCommand(KiemtraQuery, cn))
                    {
                        Kiemtracmd.Parameters.AddWithValue("@MANV", manv);
                        Kiemtracmd.Parameters.AddWithValue("@OldMANV", oldManv);
                        int count = (int)Kiemtracmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.");
                            return;
                        }
                    }
                    string sql = @"UPDATE NHANVIEN
                                SET MANV = @MANV, HOTEN = @HOTEN, SODT = @SODT, NGVL = @NGVL, MATKHAU = @MATKHAU, QUYEN = @QUYEN, DIACHI = @DIACHI, EMAIL = @EMAIL, NGSINH = @NGSINH, GIOITINH = @GIOITINH, GHICHU = @GHICHU, HINH = @HINH
                                WHERE MANV = @OldMANV";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@MANV", manv);
                        cmd.Parameters.AddWithValue("@OldMANV", oldManv);
                        cmd.Parameters.AddWithValue("@HOTEN", txtHoten.Text);
                        cmd.Parameters.AddWithValue("@SODT", txtSoDienThoai.Text);
                        cmd.Parameters.AddWithValue("@NGVL", dtpNgayvaolam.Value);
                        cmd.Parameters.AddWithValue("@MATKHAU", txtMatkhau.Text);
                        cmd.Parameters.AddWithValue("@QUYEN", quyen);
                        cmd.Parameters.AddWithValue("@DIACHI", txtDiachi.Text);
                        cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@NGSINH", dtpNgaysinh.Value);
                        cmd.Parameters.AddWithValue("@GIOITINH", rdbNam.Checked ? "Nam" : "Nữ");
                        cmd.Parameters.AddWithValue("@GHICHU", txtGhichu.Text);

                        if (Hinhanh != null)
                        {
                            cmd.Parameters.AddWithValue("@HINH", Hinhanh);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@HINH", DBNull.Value);
                        }

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();

                    MessageBox.Show("Thông tin nhân viên đã được cập nhật.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpNgayvaolam.Value = DateTime.Now;
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

        private void frmSuaTTNV_Load_1(object sender, EventArgs e)
        {

        }
    }
}
