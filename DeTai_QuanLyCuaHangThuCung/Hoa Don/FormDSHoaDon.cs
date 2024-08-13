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
            reportViewer2.LocalReport.ReportEmbeddedResource = "DeTai_QuanLyCuaHangThuCung.ReportDSHD.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            string querry = "select * from HOADON";
            reportDataSource.Value = DataProvider.LoadCSDL(querry);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer2.RefreshReport();
        }
    }
}
