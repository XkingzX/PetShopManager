using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung.GiaoDich
{
    public partial class frm_hoadon : Form
    {
        
        public frm_hoadon()
        {
            InitializeComponent();
            dgv_danhmucsp.AutoSizeColumnsMode =  DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
