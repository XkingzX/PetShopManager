namespace DeTai_QuanLyCuaHangThuCung
{
    partial class ChiTietHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dgv_danhmucsp = new DataGridView();
            masp = new DataGridViewTextBoxColumn();
            tensp = new DataGridViewTextBoxColumn();
            soluong = new DataGridViewTextBoxColumn();
            col_dongia = new DataGridViewTextBoxColumn();
            col_giamgia = new DataGridViewTextBoxColumn();
            gia = new DataGridViewTextBoxColumn();
            txt_ghichu = new RichTextBox();
            cmb_nguoiban = new ComboBox();
            cmb_nguoitao = new ComboBox();
            label16 = new Label();
            label19 = new Label();
            label20 = new Label();
            label18 = new Label();
            lbl_thanhtien = new Label();
            lbl_thue = new Label();
            lbl_tienkhachtra = new Label();
            lbl_tienthoi = new Label();
            groupBox1 = new GroupBox();
            btn_inhoadon = new Button();
            btn_thoat = new Button();
            btn_sua = new Button();
            grpthongtin = new GroupBox();
            dtp_thoigian = new DateTimePicker();
            txt_giamgia = new TextBox();
            txt_sdt = new TextBox();
            txt_makh = new TextBox();
            txt_loaikh = new TextBox();
            txt_mahd = new TextBox();
            rdb_chuyenkhoan = new RadioButton();
            rdb_tienmat = new RadioButton();
            cmb_chinhanh = new ComboBox();
            panel1 = new Panel();
            label11 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_danhmucsp).BeginInit();
            groupBox1.SuspendLayout();
            grpthongtin.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(7, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã hoá đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Thời gian";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 0;
            label3.Text = "Loại khách hàng";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(6, 167);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 0;
            label4.Text = "Mã khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(6, 224);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 0;
            label5.Text = "SDT Khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(430, 224);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 0;
            label7.Text = "Giảm giá: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(430, 17);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 0;
            label8.Text = "Người tạo hoá đơn: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(430, 115);
            label9.Name = "label9";
            label9.Size = new Size(127, 15);
            label9.TabIndex = 0;
            label9.Text = "Hình thức thanh toán: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(430, 167);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 0;
            label10.Text = "Chi nhánh: ";
            // 
            // dgv_danhmucsp
            // 
            dgv_danhmucsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_danhmucsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhmucsp.Columns.AddRange(new DataGridViewColumn[] { masp, tensp, soluong, col_dongia, col_giamgia, gia });
            dgv_danhmucsp.Location = new Point(0, 328);
            dgv_danhmucsp.Margin = new Padding(3, 2, 3, 2);
            dgv_danhmucsp.Name = "dgv_danhmucsp";
            dgv_danhmucsp.RowHeadersWidth = 51;
            dgv_danhmucsp.Size = new Size(976, 214);
            dgv_danhmucsp.TabIndex = 10;
            // 
            // masp
            // 
            masp.HeaderText = "Mã Sản Phẩm";
            masp.MinimumWidth = 6;
            masp.Name = "masp";
            // 
            // tensp
            // 
            tensp.HeaderText = "Tên Sản Phẩm";
            tensp.MinimumWidth = 6;
            tensp.Name = "tensp";
            // 
            // soluong
            // 
            soluong.HeaderText = "Số lượng";
            soluong.MinimumWidth = 6;
            soluong.Name = "soluong";
            // 
            // col_dongia
            // 
            col_dongia.HeaderText = "Đơn giá";
            col_dongia.Name = "col_dongia";
            // 
            // col_giamgia
            // 
            col_giamgia.HeaderText = "Giảm giá";
            col_giamgia.Name = "col_giamgia";
            // 
            // gia
            // 
            gia.HeaderText = "Tổng tiền";
            gia.MinimumWidth = 6;
            gia.Name = "gia";
            // 
            // txt_ghichu
            // 
            txt_ghichu.Location = new Point(769, 52);
            txt_ghichu.Name = "txt_ghichu";
            txt_ghichu.Size = new Size(196, 242);
            txt_ghichu.TabIndex = 11;
            txt_ghichu.Text = "Ghi chú";
            // 
            // cmb_nguoiban
            // 
            cmb_nguoiban.FormattingEnabled = true;
            cmb_nguoiban.Location = new Point(583, 12);
            cmb_nguoiban.Name = "cmb_nguoiban";
            cmb_nguoiban.Size = new Size(159, 23);
            cmb_nguoiban.TabIndex = 4;
            // 
            // cmb_nguoitao
            // 
            cmb_nguoitao.FormattingEnabled = true;
            cmb_nguoitao.Location = new Point(583, 61);
            cmb_nguoitao.Name = "cmb_nguoitao";
            cmb_nguoitao.Size = new Size(159, 23);
            cmb_nguoitao.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label16.Location = new Point(694, 549);
            label16.Name = "label16";
            label16.Size = new Size(86, 21);
            label16.TabIndex = 12;
            label16.Text = "Thành tiền";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label19.Location = new Point(694, 586);
            label19.Name = "label19";
            label19.Size = new Size(46, 21);
            label19.TabIndex = 12;
            label19.Text = "Thuế";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label20.Location = new Point(694, 626);
            label20.Name = "label20";
            label20.Size = new Size(78, 21);
            label20.TabIndex = 12;
            label20.Text = "Khách trả";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label18.Location = new Point(694, 664);
            label18.Name = "label18";
            label18.Size = new Size(74, 21);
            label18.TabIndex = 12;
            label18.Text = "Tiền thối";
            // 
            // lbl_thanhtien
            // 
            lbl_thanhtien.AutoSize = true;
            lbl_thanhtien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_thanhtien.Location = new Point(895, 549);
            lbl_thanhtien.Name = "lbl_thanhtien";
            lbl_thanhtien.RightToLeft = RightToLeft.Yes;
            lbl_thanhtien.Size = new Size(19, 21);
            lbl_thanhtien.TabIndex = 12;
            lbl_thanhtien.Text = "0";
            // 
            // lbl_thue
            // 
            lbl_thue.AutoSize = true;
            lbl_thue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_thue.Location = new Point(895, 586);
            lbl_thue.Name = "lbl_thue";
            lbl_thue.RightToLeft = RightToLeft.Yes;
            lbl_thue.Size = new Size(19, 21);
            lbl_thue.TabIndex = 12;
            lbl_thue.Text = "0";
            // 
            // lbl_tienkhachtra
            // 
            lbl_tienkhachtra.AutoSize = true;
            lbl_tienkhachtra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_tienkhachtra.Location = new Point(895, 626);
            lbl_tienkhachtra.Name = "lbl_tienkhachtra";
            lbl_tienkhachtra.RightToLeft = RightToLeft.Yes;
            lbl_tienkhachtra.Size = new Size(19, 21);
            lbl_tienkhachtra.TabIndex = 12;
            lbl_tienkhachtra.Text = "0";
            // 
            // lbl_tienthoi
            // 
            lbl_tienthoi.AutoSize = true;
            lbl_tienthoi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_tienthoi.Location = new Point(895, 664);
            lbl_tienthoi.Name = "lbl_tienthoi";
            lbl_tienthoi.RightToLeft = RightToLeft.Yes;
            lbl_tienthoi.Size = new Size(19, 21);
            lbl_tienthoi.TabIndex = 12;
            lbl_tienthoi.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_inhoadon);
            groupBox1.Controls.Add(btn_thoat);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Location = new Point(21, 565);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(405, 105);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Công cụ";
            // 
            // btn_inhoadon
            // 
            btn_inhoadon.Location = new Point(14, 32);
            btn_inhoadon.Margin = new Padding(3, 2, 3, 2);
            btn_inhoadon.Name = "btn_inhoadon";
            btn_inhoadon.Size = new Size(118, 38);
            btn_inhoadon.TabIndex = 1;
            btn_inhoadon.Text = "In hoá đơn";
            btn_inhoadon.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(265, 32);
            btn_thoat.Margin = new Padding(3, 2, 3, 2);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(121, 38);
            btn_thoat.TabIndex = 1;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(138, 32);
            btn_sua.Margin = new Padding(3, 2, 3, 2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(121, 38);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // grpthongtin
            // 
            grpthongtin.Controls.Add(dtp_thoigian);
            grpthongtin.Controls.Add(txt_giamgia);
            grpthongtin.Controls.Add(txt_sdt);
            grpthongtin.Controls.Add(txt_makh);
            grpthongtin.Controls.Add(txt_loaikh);
            grpthongtin.Controls.Add(txt_mahd);
            grpthongtin.Controls.Add(rdb_chuyenkhoan);
            grpthongtin.Controls.Add(rdb_tienmat);
            grpthongtin.Controls.Add(cmb_chinhanh);
            grpthongtin.Controls.Add(cmb_nguoitao);
            grpthongtin.Controls.Add(cmb_nguoiban);
            grpthongtin.Controls.Add(label7);
            grpthongtin.Controls.Add(label5);
            grpthongtin.Controls.Add(label4);
            grpthongtin.Controls.Add(label3);
            grpthongtin.Controls.Add(label10);
            grpthongtin.Controls.Add(label9);
            grpthongtin.Controls.Add(label6);
            grpthongtin.Controls.Add(label8);
            grpthongtin.Controls.Add(label2);
            grpthongtin.Controls.Add(label1);
            grpthongtin.Location = new Point(5, 40);
            grpthongtin.Name = "grpthongtin";
            grpthongtin.Size = new Size(752, 254);
            grpthongtin.TabIndex = 14;
            grpthongtin.TabStop = false;
            grpthongtin.Text = "Thông tin";
            // 
            // dtp_thoigian
            // 
            dtp_thoigian.Format = DateTimePickerFormat.Short;
            dtp_thoigian.Location = new Point(148, 64);
            dtp_thoigian.Margin = new Padding(3, 2, 3, 2);
            dtp_thoigian.Name = "dtp_thoigian";
            dtp_thoigian.Size = new Size(200, 23);
            dtp_thoigian.TabIndex = 16;
            // 
            // txt_giamgia
            // 
            txt_giamgia.Location = new Point(542, 221);
            txt_giamgia.Name = "txt_giamgia";
            txt_giamgia.Size = new Size(200, 23);
            txt_giamgia.TabIndex = 7;
            // 
            // txt_sdt
            // 
            txt_sdt.Enabled = false;
            txt_sdt.Location = new Point(148, 216);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(200, 23);
            txt_sdt.TabIndex = 7;
            // 
            // txt_makh
            // 
            txt_makh.Enabled = false;
            txt_makh.Location = new Point(148, 164);
            txt_makh.Name = "txt_makh";
            txt_makh.Size = new Size(200, 23);
            txt_makh.TabIndex = 7;
            // 
            // txt_loaikh
            // 
            txt_loaikh.Enabled = false;
            txt_loaikh.Location = new Point(148, 112);
            txt_loaikh.Name = "txt_loaikh";
            txt_loaikh.Size = new Size(200, 23);
            txt_loaikh.TabIndex = 7;
            // 
            // txt_mahd
            // 
            txt_mahd.Enabled = false;
            txt_mahd.Location = new Point(148, 17);
            txt_mahd.Name = "txt_mahd";
            txt_mahd.Size = new Size(200, 23);
            txt_mahd.TabIndex = 7;
            // 
            // rdb_chuyenkhoan
            // 
            rdb_chuyenkhoan.AutoSize = true;
            rdb_chuyenkhoan.Location = new Point(650, 113);
            rdb_chuyenkhoan.Name = "rdb_chuyenkhoan";
            rdb_chuyenkhoan.Size = new Size(102, 19);
            rdb_chuyenkhoan.TabIndex = 6;
            rdb_chuyenkhoan.TabStop = true;
            rdb_chuyenkhoan.Text = "Chuyển khoản";
            rdb_chuyenkhoan.UseVisualStyleBackColor = true;
            // 
            // rdb_tienmat
            // 
            rdb_tienmat.AutoSize = true;
            rdb_tienmat.Location = new Point(580, 113);
            rdb_tienmat.Name = "rdb_tienmat";
            rdb_tienmat.Size = new Size(71, 19);
            rdb_tienmat.TabIndex = 5;
            rdb_tienmat.TabStop = true;
            rdb_tienmat.Text = "Tiền mặt";
            rdb_tienmat.UseVisualStyleBackColor = true;
            // 
            // cmb_chinhanh
            // 
            cmb_chinhanh.FormattingEnabled = true;
            cmb_chinhanh.Location = new Point(542, 164);
            cmb_chinhanh.Name = "cmb_chinhanh";
            cmb_chinhanh.Size = new Size(200, 23);
            cmb_chinhanh.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 34);
            panel1.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(406, 4);
            label11.Name = "label11";
            label11.Size = new Size(181, 30);
            label11.TabIndex = 0;
            label11.Text = "Chi Tiet Hoa Don";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(430, 64);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 0;
            label6.Text = "Mã nhân viên";
            // 
            // ChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 706);
            Controls.Add(panel1);
            Controls.Add(grpthongtin);
            Controls.Add(groupBox1);
            Controls.Add(label18);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(lbl_tienthoi);
            Controls.Add(lbl_tienkhachtra);
            Controls.Add(lbl_thue);
            Controls.Add(lbl_thanhtien);
            Controls.Add(label16);
            Controls.Add(txt_ghichu);
            Controls.Add(dgv_danhmucsp);
            Name = "ChiTietHoaDon";
            Text = "ChiTietHoaDon";
            Load += ChiTietHoaDon_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgv_danhmucsp).EndInit();
            groupBox1.ResumeLayout(false);
            grpthongtin.ResumeLayout(false);
            grpthongtin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dgv_danhmucsp;
        private DataGridViewTextBoxColumn masp;
        private DataGridViewTextBoxColumn tensp;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn col_dongia;
        private DataGridViewTextBoxColumn col_giamgia;
        private DataGridViewTextBoxColumn gia;
        private RichTextBox txt_ghichu;
        private ComboBox cmb_nguoiban;
        private ComboBox cmb_nguoitao;
        private Label label16;
        private Label label19;
        private Label label20;
        private Label label18;
        private Label lbl_thanhtien;
        private Label lbl_thue;
        private Label lbl_tienkhachtra;
        private Label lbl_tienthoi;
        private GroupBox groupBox1;
        private Button btn_inhoadon;
        private Button btn_sua;
        private GroupBox grpthongtin;
        private RadioButton rdb_chuyenkhoan;
        private RadioButton rdb_tienmat;
        private TextBox txt_giamgia;
        private TextBox txt_sdt;
        private TextBox txt_makh;
        private TextBox txt_loaikh;
        private TextBox txt_mahd;
        private Panel panel1;
        private Label label11;
        private Button btn_thoat;
        private ComboBox cmb_chinhanh;
        private DateTimePicker dtp_thoigian;
        private Label label6;
    }
}