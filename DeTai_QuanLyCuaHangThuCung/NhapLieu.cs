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
    public partial class frm_NhapLieu : Form
    {

        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string giaSP { get; set; }
        public string loaiSP { get; set; }
        public string mota { get; set; }
        public string mode;


        //Truyền vào 1 số tham số
        public frm_NhapLieu(string title, string buttonText, string mode = "Add", string maSP = "", string tenSP = "", string giaSP = "", string loaiSP = "", string mota = "")
        {
            InitializeComponent();
            this.Text = title;
            btn_luu.Text = buttonText;
            this.mode = mode;
            rtxt_mota.Text = mota;

            if (mode == "Edit")
            {
                txt_maSP.Text = maSP;
                txt_tensp.Text = tenSP;
                txt_giasp.Text = giaSP;
                txt_loaisp.Text = loaiSP;
                rtxt_mota.Text = mota;
            }
        }
        private string imagePath = null;
        private void ketnoicsdl()
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
            {
                string query = "SELECT * FROM SANPHAM";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
        }
        private void btn_chonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog layhinh = new OpenFileDialog();
            layhinh.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (layhinh.ShowDialog() == DialogResult.OK)
            {
                imagePath = layhinh.FileName;
                ptr_chonhinh.ImageLocation = imagePath;
                ptr_chonhinh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_maSP.Text) ||
                string.IsNullOrWhiteSpace(txt_tensp.Text) ||
                string.IsNullOrWhiteSpace(txt_giasp.Text) ||
                string.IsNullOrWhiteSpace(txt_loaisp.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (imagePath == null)
            {
                MessageBox.Show("Vui lòng chọn một hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            maSP = txt_maSP.Text;
            tenSP = txt_tensp.Text;
            giaSP = txt_giasp.Text;
            loaiSP = txt_loaisp.Text;
            mota = rtxt_mota.Text;
            try
            {
                byte[] imageData;
                using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    imageData = reader.ReadBytes((int)stream.Length);
                }
                using (SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;"))
                {
                    cn.Open();
                    string query;
                    if (mode == "Edit")
                    {
                        query = "UPDATE SANPHAM SET TENSP = @TENSP, GIA = @GIA, LOAI = @LOAI, Hinh = @Image, MOTA = @MOTA WHERE MASP = @MASP";
                    }
                    else
                    {
                        query = "INSERT INTO SANPHAM (MASP, TENSP, GIA, LOAI, Hinh, MOTA) VALUES (@MASP, @TENSP, @GIA, @LOAI, @Image, @MOTA)";
                    }
                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@MASP", maSP);
                        cmd.Parameters.AddWithValue("@TENSP", tenSP);
                        cmd.Parameters.AddWithValue("@GIA", giaSP);
                        cmd.Parameters.AddWithValue("@LOAI", loaiSP);
                        cmd.Parameters.AddWithValue("@Image", imageData);
                        cmd.Parameters.AddWithValue("@MOTA", mota);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoicsdl();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NhapLieu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
