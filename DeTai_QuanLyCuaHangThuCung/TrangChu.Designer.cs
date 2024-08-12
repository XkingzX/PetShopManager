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
            mn_tongquan = new ToolStripMenuItem();
            mn_hanghoa = new ToolStripMenuItem();
            mn_danhmuc = new ToolStripMenuItem();
            mn_kiemkho = new ToolStripMenuItem();
            mn_giaodich = new ToolStripMenuItem();
            mn_hoadon = new ToolStripMenuItem();
            mn_nhaphang = new ToolStripMenuItem();
            mn_trahang = new ToolStripMenuItem();
            mn_chuyenhang = new ToolStripMenuItem();
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            mn_khachhang = new ToolStripMenuItem();
            mn_thongtinkhachhang = new ToolStripMenuItem();
            mn_baocao = new ToolStripMenuItem();
            mn_banonline = new ToolStripMenuItem();
            mn_nhanvien = new ToolStripMenuItem();
            mn_thongtinnv = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            mnTen = new ToolStripMenuItem();
            mnTTCN = new ToolStripMenuItem();
            mnDangXuat = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            mn_hanghoa.DropDownItems.AddRange(new ToolStripItem[] { mn_danhmuc, mn_kiemkho });
            mn_hanghoa.Name = "mn_hanghoa";
            mn_hanghoa.Size = new Size(91, 24);
            mn_hanghoa.Text = "Hàng Hóa";
            // 
            // mn_danhmuc
            // 
            mn_danhmuc.Name = "mn_danhmuc";
            mn_danhmuc.Size = new Size(159, 26);
            mn_danhmuc.Text = "Danh Mục";
            mn_danhmuc.Click += mn_danhmuc_Click;
            // 
            // mn_kiemkho
            // 
            mn_kiemkho.Name = "mn_kiemkho";
            mn_kiemkho.Size = new Size(159, 26);
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
            mn_hoadon.Click += mn_hoadon_Click;
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
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(91, 24);
            đơnHàngToolStripMenuItem.Text = "Đơn Hàng";
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
            mn_thongtinkhachhang.Click += mn_thongtinkhachhang_Click;
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
            mn_nhanvien.DropDownItems.AddRange(new ToolStripItem[] { mn_thongtinnv });
            mn_nhanvien.Name = "mn_nhanvien";
            mn_nhanvien.Size = new Size(91, 24);
            mn_nhanvien.Text = "Nhân Viên";
            mn_nhanvien.Click += mn_nhanvien_Click;
            // 
            // mn_thongtinnv
            // 
            mn_thongtinnv.Name = "mn_thongtinnv";
            mn_thongtinnv.Size = new Size(230, 26);
            mn_thongtinnv.Text = "Thông Tin Nhân Viên";
            mn_thongtinnv.Click += mn_thongtinnv_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mn_tongquan, mn_hanghoa, mn_giaodich, đơnHàngToolStripMenuItem, mn_khachhang, mn_banonline, mn_baocao, mn_nhanvien, mnTen });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1018, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mnTen
            // 
            mnTen.Alignment = ToolStripItemAlignment.Right;
            mnTen.DropDownItems.AddRange(new ToolStripItem[] { mnTTCN, mnDangXuat });
            mnTen.Name = "mnTen";
            mnTen.Size = new Size(67, 24);
            mnTen.Text = "mnTen";
            mnTen.TextAlign = ContentAlignment.MiddleRight;
            mnTen.Click += toolStripMenuItem1_Click;
            // 
            // mnTTCN
            // 
            mnTTCN.Name = "mnTTCN";
            mnTTCN.Size = new Size(224, 26);
            mnTTCN.Text = "Thông Tin Cá Nhân";
            mnTTCN.Click += mn_TTCNMenuItem_Click;
            // 
            // mnDangXuat
            // 
            mnDangXuat.Name = "mnDangXuat";
            mnDangXuat.Size = new Size(224, 26);
            mnDangXuat.Text = "Đăng Xuất";
            mnDangXuat.Click += mnDangXuat_Click;
            // 
            // frm_trangchu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1018, 533);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frm_trangchu";
            RightToLeft = RightToLeft.No;
            Text = "Cừa Hàng Thú Cưng - Pet Shop";
            FormClosing += Trangchu_FormClosing;
            Load += frm_trangchu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem mn_tongquan;
        private ToolStripMenuItem mn_hanghoa;
        private ToolStripMenuItem mn_danhmuc;
        private ToolStripMenuItem mn_kiemkho;
        private ToolStripMenuItem mn_giaodich;
        private ToolStripMenuItem mn_hoadon;
        private ToolStripMenuItem mn_nhaphang;
        private ToolStripMenuItem mn_trahang;
        private ToolStripMenuItem mn_chuyenhang;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private ToolStripMenuItem mn_khachhang;
        private ToolStripMenuItem mn_thongtinkhachhang;
        private ToolStripMenuItem mn_baocao;
        private ToolStripMenuItem mn_banonline;
        private ToolStripMenuItem mn_nhanvien;
        private ToolStripMenuItem mn_thongtinnv;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnTen;
        private ToolStripMenuItem mnDangXuat;
        private ToolStripMenuItem mnTTCN;
    }
}
