using DeTai_QuanLyCuaHangThuCung;
using Microsoft.Reporting.WinForms;
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

namespace WindowsFormsApp1
{
    public partial class FormDSHoaDon : Form
    {
        public FormDSHoaDon()
        {
            InitializeComponent();
        }

        private void FormDSHoaDon_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=TIENTOI;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True";
            SqlConnection ketnoi = new SqlConnection(chuoiketnoi);
            reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.FormDSHD.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            ketnoi.Open();
            string querry = "select * from HOADON";
            reportDataSource.Value = DataProvider.LoadCSDL(querry);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
