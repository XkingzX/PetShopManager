﻿using System.Drawing;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung
{
    partial class frm_trangchu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mn_tongquan = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_hanghoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_danhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_kiemkho = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_giaodich = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_xemhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_thongtinkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_thongtinnv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnTen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTTCN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_chitiethoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_dshoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_dscthd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mn_tongquan
            // 
            this.mn_tongquan.Name = "mn_tongquan";
            this.mn_tongquan.Size = new System.Drawing.Size(96, 24);
            this.mn_tongquan.Text = "Tổng Quan";
            this.mn_tongquan.Click += new System.EventHandler(this.mn_tongquan_Click);
            // 
            // mn_hanghoa
            // 
            this.mn_hanghoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_danhmuc,
            this.mn_kiemkho});
            this.mn_hanghoa.Name = "mn_hanghoa";
            this.mn_hanghoa.Size = new System.Drawing.Size(91, 24);
            this.mn_hanghoa.Text = "Hàng Hóa";
            // 
            // mn_danhmuc
            // 
            this.mn_danhmuc.Name = "mn_danhmuc";
            this.mn_danhmuc.Size = new System.Drawing.Size(224, 26);
            this.mn_danhmuc.Text = "Danh Mục";
            this.mn_danhmuc.Click += new System.EventHandler(this.mn_danhmuc_Click);
            // 
            // mn_kiemkho
            // 
            this.mn_kiemkho.Name = "mn_kiemkho";
            this.mn_kiemkho.Size = new System.Drawing.Size(224, 26);
            this.mn_kiemkho.Text = "Kiểm Kho";
            this.mn_kiemkho.Click += new System.EventHandler(this.mn_kiemkho_Click);
            // 
            // mn_giaodich
            // 
            this.mn_giaodich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_xemhoadon});
            this.mn_giaodich.Name = "mn_giaodich";
            this.mn_giaodich.Size = new System.Drawing.Size(88, 24);
            this.mn_giaodich.Text = "Giao Dịch";
            // 
            // mn_xemhoadon
            // 
            this.mn_xemhoadon.Name = "mn_xemhoadon";
            this.mn_xemhoadon.Size = new System.Drawing.Size(237, 26);
            this.mn_xemhoadon.Text = "Xem Lịch Sử Hóa Đơn";
            this.mn_xemhoadon.Click += new System.EventHandler(this.mn_xemhoadon_Click);
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem,
            this.mn_chitiethoadon,
            this.mn_dshoadon,
            this.mn_dscthd});
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đơnHàngToolStripMenuItem.Text = "Đơn Hàng";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // mn_khachhang
            // 
            this.mn_khachhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_thongtinkhachhang});
            this.mn_khachhang.Name = "mn_khachhang";
            this.mn_khachhang.Size = new System.Drawing.Size(103, 24);
            this.mn_khachhang.Text = "Khách Hàng";
            // 
            // mn_thongtinkhachhang
            // 
            this.mn_thongtinkhachhang.Name = "mn_thongtinkhachhang";
            this.mn_thongtinkhachhang.Size = new System.Drawing.Size(242, 26);
            this.mn_thongtinkhachhang.Text = "Thông Tin Khách Hàng";
            this.mn_thongtinkhachhang.Click += new System.EventHandler(this.mn_thongtinkhachhang_Click);
            // 
            // mn_baocao
            // 
            this.mn_baocao.Name = "mn_baocao";
            this.mn_baocao.Size = new System.Drawing.Size(79, 24);
            this.mn_baocao.Text = "Báo Cáo";
            // 
            // mn_nhanvien
            // 
            this.mn_nhanvien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_thongtinnv});
            this.mn_nhanvien.Name = "mn_nhanvien";
            this.mn_nhanvien.Size = new System.Drawing.Size(91, 24);
            this.mn_nhanvien.Text = "Nhân Viên";
            // 
            // mn_thongtinnv
            // 
            this.mn_thongtinnv.Name = "mn_thongtinnv";
            this.mn_thongtinnv.Size = new System.Drawing.Size(230, 26);
            this.mn_thongtinnv.Text = "Thông Tin Nhân Viên";
            this.mn_thongtinnv.Click += new System.EventHandler(this.mn_thongtinnv_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_tongquan,
            this.mn_hanghoa,
            this.mn_giaodich,
            this.đơnHàngToolStripMenuItem,
            this.mn_khachhang,
            this.mn_baocao,
            this.mn_nhanvien,
            this.mnTen});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnTen
            // 
            this.mnTen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnTen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTTCN,
            this.mnDangXuat});
            this.mnTen.Name = "mnTen";
            this.mnTen.Size = new System.Drawing.Size(67, 24);
            this.mnTen.Text = "mnTen";
            this.mnTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnTTCN
            // 
            this.mnTTCN.Name = "mnTTCN";
            this.mnTTCN.Size = new System.Drawing.Size(218, 26);
            this.mnTTCN.Text = "Thông Tin Cá Nhân";
            this.mnTTCN.Click += new System.EventHandler(this.mnTTCN_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(218, 26);
            this.mnDangXuat.Text = "Đăng Xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // mn_chitiethoadon
            // 
            this.mn_chitiethoadon.Name = "mn_chitiethoadon";
            this.mn_chitiethoadon.Size = new System.Drawing.Size(226, 26);
            this.mn_chitiethoadon.Text = "Chi Tiết Hóa Đơn ";
            this.mn_chitiethoadon.Click += new System.EventHandler(this.mn_chitiethoadon_Click);
            // 
            // mn_dshoadon
            // 
            this.mn_dshoadon.Name = "mn_dshoadon";
            this.mn_dshoadon.Size = new System.Drawing.Size(226, 26);
            this.mn_dshoadon.Text = "Danh Sách Hóa Đơn";
            this.mn_dshoadon.Click += new System.EventHandler(this.mn_dshoadon_Click);
            // 
            // mn_dscthd
            // 
            this.mn_dscthd.Name = "mn_dscthd";
            this.mn_dscthd.Size = new System.Drawing.Size(226, 26);
            this.mn_dscthd.Text = "Danh Sách CTHD";
            this.mn_dscthd.Click += new System.EventHandler(this.mn_dscthd_Click);
            // 
            // frm_trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 426);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_trangchu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "                ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripMenuItem mn_tongquan;
        private ToolStripMenuItem mn_hanghoa;
        private ToolStripMenuItem mn_danhmuc;
        private ToolStripMenuItem mn_kiemkho;
        private ToolStripMenuItem mn_giaodich;
        private ToolStripMenuItem mn_xemhoadon;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private ToolStripMenuItem mn_khachhang;
        private ToolStripMenuItem mn_thongtinkhachhang;
        private ToolStripMenuItem mn_baocao;
        private ToolStripMenuItem mn_nhanvien;
        private ToolStripMenuItem mn_thongtinnv;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnTen;
        private ToolStripMenuItem mnDangXuat;
        private ToolStripMenuItem mnTTCN;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem mn_chitiethoadon;
        private ToolStripMenuItem mn_dshoadon;
        private ToolStripMenuItem mn_dscthd;
    }
}
