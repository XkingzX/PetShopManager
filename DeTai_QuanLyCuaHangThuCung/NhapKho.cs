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
    public partial class frm_NhapKho : Form
    {
        public string maPK { get; set; }
        public string maSP { get; set; }
        public string ngayNhap { get; set; }
        public string soluongtt { get; set; }
        public string ghichu { get; set; }
        public string manv { get; set; }
        public string mode;


        //Truyền vào 1 số tham số
        public frm_NhapKho(string title, string buttonText, string mode = "Add", string maPK = "", string maSP = "", string ngayNhap = "", string soluongtt = "", string ghichu = "", string manv = "")
        {
            InitializeComponent();
            this.Text = title;
            btn_luu.Text = buttonText;
            this.mode = mode;
            rtxt_ghichu.Text = ghichu;
            cmb_nguoitao.Text = manv;

            if (mode == "Edit")
            {
                txt_maPK.Text = maPK;
                txt_masp.Text = maSP;
                dtp_ngaynhap.Text = ngayNhap;
                txt_soluongtt.Text = soluongtt;
                rtxt_ghichu.Text = ghichu;
            }

            this.manv = manv;
            loadnhanvien();
            TaoMaPhieuKho();
        }
        private void ketnoicsdl()
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
            {
                string query = "SELECT * FROM KHO";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_maPK.Text) ||
                string.IsNullOrWhiteSpace(txt_masp.Text) ||
                string.IsNullOrWhiteSpace(dtp_ngaynhap.Text) ||
                string.IsNullOrWhiteSpace(txt_soluongtt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            maPK = txt_maPK.Text;
            maSP = txt_masp.Text;
            ngayNhap = dtp_ngaynhap.Text;
            soluongtt = txt_soluongtt.Text;
            ghichu = rtxt_ghichu.Text;
            manv = cmb_nguoitao.Text;

            using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
            {
                cn.Open();
                string ktraMaSP = "SELECT COUNT(*) FROM SANPHAM WHERE MASP = @MASP";
                using (SqlCommand cmd = new SqlCommand(ktraMaSP, cn))
                {
                    cmd.Parameters.AddWithValue("@MASP", maSP);
                    int dem = (int)cmd.ExecuteScalar();

                    if (dem == 0)
                    {
                        MessageBox.Show("Mã sản phẩm không tồn tại trong bảng SANPHAM.", "Phát Hiện Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string query;
                if (mode == "Edit")
                {
                    query = "UPDATE KHO SET MAPK = @MAPK, MASP = @MASP, NGAYNHAP = @NGAYNHAP, SLTHUCTE = @SLTHUCTE, GHICHU = @GHICHU, MANV = @MANV WHERE MAPK = @MAPK";
                }
                else
                {
                    query = "INSERT INTO KHO (MAPK, MASP, NGAYNHAP, SLTHUCTE, GHICHU, MANV) VALUES (@MAPK, @MASP, @NGAYNHAP, @SLTHUCTE, @GHICHU, @MANV)";
                }

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    dtp_ngaynhap.Format = DateTimePickerFormat.Custom;
                    dtp_ngaynhap.CustomFormat = "dd-MM-yyyy";
                    DateTime ngayNhap;
                    if (DateTime.TryParse(dtp_ngaynhap.Text, out ngayNhap))
                    {
                        cmd.Parameters.AddWithValue("@NGAYNHAP", ngayNhap);
                    }
                    else
                    {
                        MessageBox.Show("Ngày nhập không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cmd.Parameters.AddWithValue("@MAPK", maPK);
                    cmd.Parameters.AddWithValue("@MASP", maSP);
                    cmd.Parameters.AddWithValue("@SLTHUCTE", soluongtt);
                    cmd.Parameters.AddWithValue("@GHICHU", string.IsNullOrEmpty(ghichu) ? (object)DBNull.Value : ghichu);
                    cmd.Parameters.AddWithValue("@MANV", manv);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ketnoicsdl();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NhapKho_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txt_ngaynhaptudong.Text = currentTime.ToString("dd-MM-yyyy HH:mm:ss");
            txt_ngaynhaptudong.Enabled = false;
        }

        private void ckb_layngay_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_layngay.Checked == true)
            {
                DateTime currentTime = DateTime.Now;
                dtp_ngaynhap.Text = currentTime.ToString("dd-MM-yyyy");
                dtp_ngaynhap.Enabled = false;
            }
            else
            {
                dtp_ngaynhap.Enabled = true;
            }
        }

        private void cmb_nguoitao_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;");
            cn.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "SELECT * FROM NHANVIEN";
            DataTable dt = new DataTable();
            SqlDataReader reader = cm.ExecuteReader();
            dt.Load(reader);
            cmb_nguoitao.DataSource = dt;
            cmb_nguoitao.DisplayMember = "MANV";
            cmb_nguoitao.ValueMember = "MANV";
            cn.Close();
        }
        private void loadnhanvien()
        {
            
            SqlConnection cn = new SqlConnection(@"Data Source=TIENTOI\SQLEXPRESS;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;");
            cn.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "SELECT * FROM NHANVIEN";
            SqlDataReader reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            BindingSource bd = new BindingSource();
            bd.DataSource = dt;
            cmb_nguoitao.DataSource = bd;
            cmb_nguoitao.DisplayMember = "MANV";
            cmb_nguoitao.ValueMember = "MANV";
            cn.Close();
        }
        private void TaoMaPhieuKho()
        {
            if(mode != "Edit")
            {
                txt_maPK.Text = "PK" + ChuoiSoNgauNhien(2);
            }
        }
        private string ChuoiSoNgauNhien(int length)
        {
            Random random = new Random();
            char[] stringChars = new char[length];
            for (int i = 0; i < length; i++)
            {
                stringChars[i] = (char)('0' + random.Next(10));
            }
            return new string(stringChars);
        }
    }
}
