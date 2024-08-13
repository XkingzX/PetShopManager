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
        public frmSuaTTNV()
        {
            InitializeComponent();
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
            {
                rdbNam.Checked = true;
            }
            else if (Gioitinh == "Nữ")
            {
                rdbNu.Checked = true;
            }

            if (Hinh != null)
            {
                using (MemoryStream ms = new MemoryStream(Hinh))
                {
                    pbHinhanh.Image = Image.FromStream(ms);
                    pbHinhanh.SizeMode = PictureBoxSizeMode.Zoom;
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
                using (SqlConnection cn = new SqlConnection(@"Data Source=ADMIN-PC\MSSQLSERVER01;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
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
                    using (SqlCommand cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.AddWithValue("@MANV", manv);
                        cm.Parameters.AddWithValue("@OldMANV", oldManv);
                        cm.Parameters.AddWithValue("@HOTEN", txtHoten.Text);
                        cm.Parameters.AddWithValue("@SODT", txtSoDienThoai.Text);
                        cm.Parameters.AddWithValue("@NGVL", dtpNgayvaolam.Value);
                        cm.Parameters.AddWithValue("@MATKHAU", txtMatkhau.Text);
                        cm.Parameters.AddWithValue("@QUYEN", quyen);
                        cm.Parameters.AddWithValue("@DIACHI", txtDiachi.Text);
                        cm.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                        cm.Parameters.AddWithValue("@NGSINH", dtpNgaysinh.Value);
                        cm.Parameters.AddWithValue("@GIOITINH", rdbNam.Checked ? "Nam" : "Nữ");
                        cm.Parameters.AddWithValue("@GHICHU", txtGhichu.Text);

                        if (Hinhanh != null)
                        {
                            cm.Parameters.AddWithValue("@HINH", Hinhanh);
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("@HINH", DBNull.Value);
                        }

                        cm.ExecuteNonQuery();
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
        private void btnChonhinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Layhinh = new OpenFileDialog())
            {
                Layhinh.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
                Layhinh.Title = "Chọn hình ảnh";

                if (Layhinh.ShowDialog() == DialogResult.OK)
                {
                    //Nếu có ảnh cũ thì nó sẽ được giải phòng
                    if (pbHinhanh.Image != null)
                    {
                        pbHinhanh.Image.Dispose();
                    }
                    //Lấy hình
                    pbHinhanh.Image = Image.FromFile(Layhinh.FileName);
                    pbHinhanh.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void frmSuaTTNV_Load_1(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                txtManv.Focus();
            }));
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
            this.Close();
        }
    }
}
