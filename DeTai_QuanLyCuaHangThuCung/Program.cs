using DeTai_QuanLyCuaHangThuCung.DangNhap;
using DeTai_QuanLyCuaHangThuCung.GiaoDich;
using DeTai_QuanLyCuaHangThuCung.HangHoa;
using DeTai_QuanLyCuaHangThuCung.QuanLyKH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_DangNhap());//frm_trangchu("@HOTEN")
        }
    }
}
