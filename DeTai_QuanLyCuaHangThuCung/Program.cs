using DeTai_QuanLyCuaHangThuCung.DangNhap;
using DeTai_QuanLyCuaHangThuCung.HangHoa;
using DeTai_QuanLyCuaHangThuCung.QuanLyKH;

namespace DeTai_QuanLyCuaHangThuCung
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_trangchu("@HOTEN"));
        }
    }
}