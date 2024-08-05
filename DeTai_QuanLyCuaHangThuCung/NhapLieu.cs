using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public string mode;
        public frm_NhapLieu(string title, string buttonText, string mode = "Add", string maSP = "", string tenSP = "", string giaSP = "", string loaiSP = "")
        {
            InitializeComponent();
            this.Text = title;
            btn_luu.Text = buttonText;
            this.mode = mode;


            if (mode == "Edit")
            {
                txt_maSP.Text = maSP;
                txt_tensp.Text = tenSP;
                txt_giasp.Text = giaSP;
                txt_loaisp.Text = loaiSP;
            }
        }

        private void btn_chonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog layhinh = new OpenFileDialog();
            layhinh.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (layhinh.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = layhinh.FileName;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            maSP = txt_maSP.Text;
            tenSP = txt_tensp.Text;
            giaSP = txt_giasp.Text;
            loaiSP = txt_loaisp.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
