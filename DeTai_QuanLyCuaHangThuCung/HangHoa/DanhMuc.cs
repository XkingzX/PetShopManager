﻿using System;
using System.Collections;
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
    public partial class frm_danhmuc : Form
    {
        public frm_danhmuc()
        {
            InitializeComponent();
            this.txt_nhapmasp.KeyDown += new KeyEventHandler(this.txt_nhapmasp_KeyDown);
        }
        SqlConnection cn = new SqlConnection(@"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;");
        private void ketnoicsdl()
        {
            cn.Open();
            string sql = "select * from SANPHAM";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            dgv_danhmucsp.DataSource = dt;
            dgv_danhmucsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frm_danhmuc_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            ketnoicsdl();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            using (frm_NhapLieu frm = new frm_NhapLieu("Thêm Sản Phẩm", "Lưu"))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string maSP = frm.maSP;
                    string tenSP = frm.tenSP;
                    string giaSP = frm.giaSP;
                    string loaiSP = frm.loaiSP;
                    try
                    {
                        cn.Open();
                        string query = "INSERT INTO SANPHAM (MASP, TENSP, GIA, LOAI) VALUES (@maSP, @tenSP, @giaSP, @loaiSP)";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@maSP", maSP);
                            cmd.Parameters.AddWithValue("@tenSP", tenSP);
                            cmd.Parameters.AddWithValue("@giaSP", giaSP);
                            cmd.Parameters.AddWithValue("@loaiSP", loaiSP);

                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();

                        ketnoicsdl();

                        MessageBox.Show("=== Thêm thông tin ===","Mã sản phẩm: " + maSP +
                            "\nTên sản phẩm: " + tenSP +
                            "\nGiá sản phẩm: " + giaSP +
                            "\nLoại sản phẩm: " + loaiSP);
                    }
                    catch (Exception) { }
                }
            }
        }
        private void txt_nhapmasp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                timkiemmasp();
            }
        }
        private void timkiemmasp()
        {
            string maSP = txt_nhapmasp.Text.Trim();
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm để tìm kiếm.");
                dgv_danhmucsp.DataSource = null;
                return;
            }
            try
            {
                cn.Open();
                string tukhoa = txt_nhapmasp.Text;
                string query = $"SELECT * FROM SANPHAM WHERE MASP = '{tukhoa}'";
                SqlCommand cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@MASP", maSP);

                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cn.Close();

                if (dt.Rows.Count > 0)
                {
                    dgv_danhmucsp.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm với mã: " + maSP);
                }
            }
            catch (Exception) { }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_danhmucsp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string maSP = dgv_danhmucsp.SelectedRows[0].Cells["MASP"].Value.ToString();
                cn.Open();
                string query = "DELETE SANPHAM WHERE MASP = @maSP";
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    cmd.ExecuteNonQuery();
                }
                cn.Close();

                ketnoicsdl();

                MessageBox.Show("Sản phẩm đã được xóa.");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_danhmucsp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
                return;
            }
            DataGridViewRow row = dgv_danhmucsp.SelectedRows[0];
            string maSP = row.Cells["MASP"].Value.ToString();
            string tenSP = row.Cells["TENSP"].Value.ToString();
            string giaSP = row.Cells["GIA"].Value.ToString();
            string loaiSP = row.Cells["LOAI"].Value.ToString();
            using (frm_NhapLieu frm = new frm_NhapLieu("Sửa Sản Phẩm", "Lưu", "Edit", maSP, tenSP, giaSP, loaiSP))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string newMaSP = frm.maSP;
                    string newTenSP = frm.tenSP;
                    string newGiaSP = frm.giaSP;
                    string newLoaiSP = frm.loaiSP;

                    try
                    {
                        cn.Open();
                        string query = "UPDATE SANPHAM SET TENSP = @tenSP, GIA = @giaSP, LOAI = @loaiSP WHERE MASP = @maSP";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@maSP", newMaSP);
                            cmd.Parameters.AddWithValue("@tenSP", newTenSP);
                            cmd.Parameters.AddWithValue("@giaSP", newGiaSP);
                            cmd.Parameters.AddWithValue("@loaiSP", newLoaiSP);

                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();

                        ketnoicsdl();

                        MessageBox.Show("Sản phẩm đã được cập nhật.");
                    }
                    catch (Exception){}
                }
            }
        }
    }
}
