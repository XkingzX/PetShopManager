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
        public frm_NhapLieu(string title, string buttonText)
        {
            InitializeComponent();
            this.Text = title;
            btn_hoanthanh.Text = buttonText;
        }

        private void btn_hoanthanh_Click(object sender, EventArgs e)
        {
            maSP = txt_maSP.Text;
            tenSP = textBox3.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
