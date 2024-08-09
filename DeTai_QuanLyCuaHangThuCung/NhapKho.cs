using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
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
            txt_nguoitao.Text = manv;

            if (mode == "Edit")
            {
                txt_maPK.Text = maPK;
                txt_masp.Text = maSP;
                dtp_ngaynhap.Text = ngayNhap;
                txt_soluongtt.Text = soluongtt;
                rtxt_ghichu.Text = ghichu;
            }

            this.manv = manv;
        }
        private void ketnoicsdl()
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
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
            maSP = txt_maPK.Text;
            ngayNhap = dtp_ngaynhap.Text;
            soluongtt = txt_soluongtt.Text;
            ghichu = rtxt_ghichu.Text;
            manv = txt_nguoitao.Text;

            using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
            {
                cn.Open();
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
                        MessageBox.Show("Ngày nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmd.Parameters.AddWithValue("@MAPK", maPK);
                    cmd.Parameters.AddWithValue("@MASP", maSP);
                    cmd.Parameters.AddWithValue("@SLTHUCTE", soluongtt);
                    cmd.Parameters.AddWithValue("@GHICHU", ghichu);
                    cmd.Parameters.AddWithValue("@MANV", manv);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoicsdl();
            this.DialogResult = DialogResult.OK;
            this.Close();
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
    }
}
