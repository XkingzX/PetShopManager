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
    public partial class FormDSCTHD : Form
    {
        public FormDSCTHD()
        {
            InitializeComponent();
        }

        private void FormDSCTHD_Load(object sender, EventArgs e)
        {
            reportViewer2.LocalReport.ReportEmbeddedResource = "DeTai_QuanLyCuaHangThuCung.DSCTHD.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet2";
            string querry = "select * from CTHD";
            reportDataSource.Value = DataProvider.LoadCSDL(querry);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer2.RefreshReport();
        }
    }
}
