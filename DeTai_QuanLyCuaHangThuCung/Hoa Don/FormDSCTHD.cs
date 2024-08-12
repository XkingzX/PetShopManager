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
            reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.DSCTHD.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DatasetCTHD";
            string querry = "select * from CTHD";
            reportDataSource.Value = DataProvider.LoadCSDL(querry);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();

        }
    }
}
