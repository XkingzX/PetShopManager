﻿namespace DeTai_QuanLyCuaHangThuCung
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
            menuStrip1 = new MenuStrip();
            mn_tongquan = new ToolStripMenuItem();
            mn_hanghoa = new ToolStripMenuItem();
            mn_danhmuc = new ToolStripMenuItem();
            mn_thietlapgia = new ToolStripMenuItem();
            mn_kiemkho = new ToolStripMenuItem();
            mn_giaodich = new ToolStripMenuItem();
            mn_hoadon = new ToolStripMenuItem();
            mn_nhaphang = new ToolStripMenuItem();
            mn_trahang = new ToolStripMenuItem();
            mn_chuyenhang = new ToolStripMenuItem();
            mn_khachhang = new ToolStripMenuItem();
            mn_thongtinkhachhang = new ToolStripMenuItem();
            mn_baocao = new ToolStripMenuItem();
            mn_banonline = new ToolStripMenuItem();
            mn_nhanvien = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mn_tongquan, mn_hanghoa, mn_giaodich, mn_khachhang, mn_baocao, mn_banonline, mn_nhanvien });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1018, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mn_tongquan
            // 
            mn_tongquan.Name = "mn_tongquan";
            mn_tongquan.Size = new Size(96, 24);
            mn_tongquan.Text = "Tổng Quan";
            mn_tongquan.Click += mn_tongquan_Click;
            // 
            // mn_hanghoa
            // 
            mn_hanghoa.DropDownItems.AddRange(new ToolStripItem[] { mn_danhmuc, mn_thietlapgia, mn_kiemkho });
            mn_hanghoa.Name = "mn_hanghoa";
            mn_hanghoa.Size = new Size(91, 24);
            mn_hanghoa.Text = "Hàng Hóa";
            // 
            // mn_danhmuc
            // 
            mn_danhmuc.Name = "mn_danhmuc";
            mn_danhmuc.Size = new Size(224, 26);
            mn_danhmuc.Text = "Danh Mục";
            mn_danhmuc.Click += mn_danhmuc_Click;
            // 
            // mn_thietlapgia
            // 
            mn_thietlapgia.Name = "mn_thietlapgia";
            mn_thietlapgia.Size = new Size(224, 26);
            mn_thietlapgia.Text = "Thiết Lập Giá";
            mn_thietlapgia.Click += mn_thietlapgia_Click;
            // 
            // mn_kiemkho
            // 
            mn_kiemkho.Name = "mn_kiemkho";
            mn_kiemkho.Size = new Size(224, 26);
            mn_kiemkho.Text = "Kiểm Kho";
            mn_kiemkho.Click += mn_kiemkho_Click;
            // 
            // mn_giaodich
            // 
            mn_giaodich.DropDownItems.AddRange(new ToolStripItem[] { mn_hoadon, mn_nhaphang, mn_trahang, mn_chuyenhang });
            mn_giaodich.Name = "mn_giaodich";
            mn_giaodich.Size = new Size(88, 24);
            mn_giaodich.Text = "Giao Dịch";
            // 
            // mn_hoadon
            // 
            mn_hoadon.Name = "mn_hoadon";
            mn_hoadon.Size = new Size(180, 26);
            mn_hoadon.Text = "Hóa Đơn";
            // 
            // mn_nhaphang
            // 
            mn_nhaphang.Name = "mn_nhaphang";
            mn_nhaphang.Size = new Size(180, 26);
            mn_nhaphang.Text = "Nhập Hàng";
            // 
            // mn_trahang
            // 
            mn_trahang.Name = "mn_trahang";
            mn_trahang.Size = new Size(180, 26);
            mn_trahang.Text = "Trả Hàng";
            // 
            // mn_chuyenhang
            // 
            mn_chuyenhang.Name = "mn_chuyenhang";
            mn_chuyenhang.Size = new Size(180, 26);
            mn_chuyenhang.Text = "Chuyển Hàng";
            // 
            // mn_khachhang
            // 
            mn_khachhang.DropDownItems.AddRange(new ToolStripItem[] { mn_thongtinkhachhang });
            mn_khachhang.Name = "mn_khachhang";
            mn_khachhang.Size = new Size(103, 24);
            mn_khachhang.Text = "Khách Hàng";
            // 
            // mn_thongtinkhachhang
            // 
            mn_thongtinkhachhang.Name = "mn_thongtinkhachhang";
            mn_thongtinkhachhang.Size = new Size(242, 26);
            mn_thongtinkhachhang.Text = "Thông Tin Khách Hàng";
            // 
            // mn_baocao
            // 
            mn_baocao.Name = "mn_baocao";
            mn_baocao.Size = new Size(79, 24);
            mn_baocao.Text = "Báo Cáo";
            // 
            // mn_banonline
            // 
            mn_banonline.Name = "mn_banonline";
            mn_banonline.Size = new Size(95, 24);
            mn_banonline.Text = "Bán Online";
            // 
            // mn_nhanvien
            // 
            mn_nhanvien.Name = "mn_nhanvien";
            mn_nhanvien.Size = new Size(91, 24);
            mn_nhanvien.Text = "Nhân Viên";
            // 
            // frm_trangchu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 534);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frm_trangchu";
            Text = "Cừa Hàng Thú Cưng - Pet Shop";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mn_tongquan;
        private ToolStripMenuItem mn_hanghoa;
        private ToolStripMenuItem mn_giaodich;
        private ToolStripMenuItem mn_khachhang;
        private ToolStripMenuItem mn_banonline;
        private ToolStripMenuItem mn_nhanvien;
        private ToolStripMenuItem mn_danhmuc;
        private ToolStripMenuItem mn_thietlapgia;
        private ToolStripMenuItem mn_kiemkho;
        private ToolStripMenuItem mn_hoadon;
        private ToolStripMenuItem mn_nhaphang;
        private ToolStripMenuItem mn_trahang;
        private ToolStripMenuItem mn_chuyenhang;
        private ToolStripMenuItem mn_thongtinkhachhang;
        private ToolStripMenuItem mn_baocao;
    }
}
