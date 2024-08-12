using System.Drawing;
using System.Windows.Forms;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_danhmucsp = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ghichu = new System.Windows.Forms.RichTextBox();
            this.cmb_nguoiban = new System.Windows.Forms.ComboBox();
            this.cmb_nguoitao = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_inhoadon = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.grpthongtin = new System.Windows.Forms.GroupBox();
            this.dtp_thoigian = new System.Windows.Forms.DateTimePicker();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_loaikh = new System.Windows.Forms.TextBox();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.rdb_chuyenkhoan = new System.Windows.Forms.RadioButton();
            this.rdb_tienmat = new System.Windows.Forms.RadioButton();
            this.cmb_chinhanh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_khachtra = new System.Windows.Forms.TextBox();
            this.txt_tienthoi = new System.Windows.Forms.TextBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhmucsp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpthongtin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(5, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "SDT Khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(369, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giảm giá: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(369, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Người tạo hoá đơn: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(369, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hình thức thanh toán: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(369, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chi nhánh: ";
            // 
            // dgv_danhmucsp
            // 
            this.dgv_danhmucsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_danhmucsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhmucsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluong,
            this.col_dongia,
            this.gia});
            this.dgv_danhmucsp.Location = new System.Drawing.Point(0, 284);
            this.dgv_danhmucsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_danhmucsp.Name = "dgv_danhmucsp";
            this.dgv_danhmucsp.RowHeadersWidth = 51;
            this.dgv_danhmucsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhmucsp.Size = new System.Drawing.Size(837, 185);
            this.dgv_danhmucsp.TabIndex = 10;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MASP";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "TENSP";
            this.tensp.HeaderText = "Tên Sản Phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SL";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            // 
            // col_dongia
            // 
            this.col_dongia.DataPropertyName = "GIA";
            this.col_dongia.HeaderText = "Đơn giá";
            this.col_dongia.Name = "col_dongia";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "TONGTIEN";
            this.gia.HeaderText = "Tổng tiền";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(659, 45);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(169, 210);
            this.txt_ghichu.TabIndex = 11;
            this.txt_ghichu.Text = "Ghi chú";
            // 
            // cmb_nguoiban
            // 
            this.cmb_nguoiban.FormattingEnabled = true;
            this.cmb_nguoiban.Location = new System.Drawing.Point(500, 10);
            this.cmb_nguoiban.Name = "cmb_nguoiban";
            this.cmb_nguoiban.Size = new System.Drawing.Size(137, 21);
            this.cmb_nguoiban.TabIndex = 4;
            // 
            // cmb_nguoitao
            // 
            this.cmb_nguoitao.FormattingEnabled = true;
            this.cmb_nguoitao.Location = new System.Drawing.Point(500, 53);
            this.cmb_nguoitao.Name = "cmb_nguoitao";
            this.cmb_nguoitao.Size = new System.Drawing.Size(137, 21);
            this.cmb_nguoitao.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(595, 476);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 21);
            this.label16.TabIndex = 12;
            this.label16.Text = "Thành tiền";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(595, 522);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 21);
            this.label20.TabIndex = 12;
            this.label20.Text = "Khách trả";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(595, 571);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 21);
            this.label18.TabIndex = 12;
            this.label18.Text = "Tiền thối";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_inhoadon);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Location = new System.Drawing.Point(18, 490);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(347, 91);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // btn_inhoadon
            // 
            this.btn_inhoadon.Location = new System.Drawing.Point(12, 28);
            this.btn_inhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inhoadon.Name = "btn_inhoadon";
            this.btn_inhoadon.Size = new System.Drawing.Size(101, 33);
            this.btn_inhoadon.TabIndex = 1;
            this.btn_inhoadon.Text = "In hoá đơn";
            this.btn_inhoadon.UseVisualStyleBackColor = true;
            this.btn_inhoadon.Click += new System.EventHandler(this.btn_inhoadon_Click_1);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(227, 28);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(104, 33);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(118, 28);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(104, 33);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Lưu hoá đơn";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // grpthongtin
            // 
            this.grpthongtin.Controls.Add(this.dtp_thoigian);
            this.grpthongtin.Controls.Add(this.txt_giamgia);
            this.grpthongtin.Controls.Add(this.txt_sdt);
            this.grpthongtin.Controls.Add(this.txt_makh);
            this.grpthongtin.Controls.Add(this.txt_loaikh);
            this.grpthongtin.Controls.Add(this.txt_mahd);
            this.grpthongtin.Controls.Add(this.rdb_chuyenkhoan);
            this.grpthongtin.Controls.Add(this.rdb_tienmat);
            this.grpthongtin.Controls.Add(this.cmb_chinhanh);
            this.grpthongtin.Controls.Add(this.cmb_nguoitao);
            this.grpthongtin.Controls.Add(this.cmb_nguoiban);
            this.grpthongtin.Controls.Add(this.label7);
            this.grpthongtin.Controls.Add(this.label5);
            this.grpthongtin.Controls.Add(this.label4);
            this.grpthongtin.Controls.Add(this.label3);
            this.grpthongtin.Controls.Add(this.label10);
            this.grpthongtin.Controls.Add(this.label9);
            this.grpthongtin.Controls.Add(this.label6);
            this.grpthongtin.Controls.Add(this.label8);
            this.grpthongtin.Controls.Add(this.label2);
            this.grpthongtin.Controls.Add(this.label1);
            this.grpthongtin.Location = new System.Drawing.Point(4, 35);
            this.grpthongtin.Name = "grpthongtin";
            this.grpthongtin.Size = new System.Drawing.Size(645, 220);
            this.grpthongtin.TabIndex = 14;
            this.grpthongtin.TabStop = false;
            this.grpthongtin.Text = "Thông tin";
            // 
            // dtp_thoigian
            // 
            this.dtp_thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_thoigian.Location = new System.Drawing.Point(127, 55);
            this.dtp_thoigian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_thoigian.Name = "dtp_thoigian";
            this.dtp_thoigian.Size = new System.Drawing.Size(172, 20);
            this.dtp_thoigian.TabIndex = 16;
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Location = new System.Drawing.Point(465, 192);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(172, 20);
            this.txt_giamgia.TabIndex = 7;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Enabled = false;
            this.txt_sdt.Location = new System.Drawing.Point(127, 187);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(172, 20);
            this.txt_sdt.TabIndex = 7;
            // 
            // txt_makh
            // 
            this.txt_makh.Enabled = false;
            this.txt_makh.Location = new System.Drawing.Point(127, 142);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(172, 20);
            this.txt_makh.TabIndex = 7;
            // 
            // txt_loaikh
            // 
            this.txt_loaikh.Enabled = false;
            this.txt_loaikh.Location = new System.Drawing.Point(127, 97);
            this.txt_loaikh.Name = "txt_loaikh";
            this.txt_loaikh.Size = new System.Drawing.Size(172, 20);
            this.txt_loaikh.TabIndex = 7;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Enabled = false;
            this.txt_mahd.Location = new System.Drawing.Point(127, 15);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(172, 20);
            this.txt_mahd.TabIndex = 7;
            // 
            // rdb_chuyenkhoan
            // 
            this.rdb_chuyenkhoan.AutoSize = true;
            this.rdb_chuyenkhoan.Location = new System.Drawing.Point(557, 98);
            this.rdb_chuyenkhoan.Name = "rdb_chuyenkhoan";
            this.rdb_chuyenkhoan.Size = new System.Drawing.Size(94, 17);
            this.rdb_chuyenkhoan.TabIndex = 6;
            this.rdb_chuyenkhoan.TabStop = true;
            this.rdb_chuyenkhoan.Text = "Chuyển khoản";
            this.rdb_chuyenkhoan.UseVisualStyleBackColor = true;
            // 
            // rdb_tienmat
            // 
            this.rdb_tienmat.AutoSize = true;
            this.rdb_tienmat.Location = new System.Drawing.Point(497, 98);
            this.rdb_tienmat.Name = "rdb_tienmat";
            this.rdb_tienmat.Size = new System.Drawing.Size(66, 17);
            this.rdb_tienmat.TabIndex = 5;
            this.rdb_tienmat.TabStop = true;
            this.rdb_tienmat.Text = "Tiền mặt";
            this.rdb_tienmat.UseVisualStyleBackColor = true;
            this.rdb_tienmat.CheckedChanged += new System.EventHandler(this.rdb_tienmat_CheckedChanged_1);
            // 
            // cmb_chinhanh
            // 
            this.cmb_chinhanh.FormattingEnabled = true;
            this.cmb_chinhanh.Location = new System.Drawing.Point(465, 142);
            this.cmb_chinhanh.Name = "cmb_chinhanh";
            this.cmb_chinhanh.Size = new System.Drawing.Size(172, 21);
            this.cmb_chinhanh.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(369, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 29);
            this.panel1.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(348, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Chi Tiet Hoa Don";
            // 
            // txt_khachtra
            // 
            this.txt_khachtra.Location = new System.Drawing.Point(698, 523);
            this.txt_khachtra.Name = "txt_khachtra";
            this.txt_khachtra.Size = new System.Drawing.Size(129, 20);
            this.txt_khachtra.TabIndex = 16;
            this.txt_khachtra.TextChanged += new System.EventHandler(this.txt_khachtra_TextChanged_1);
            // 
            // txt_tienthoi
            // 
            this.txt_tienthoi.Location = new System.Drawing.Point(698, 571);
            this.txt_tienthoi.Name = "txt_tienthoi";
            this.txt_tienthoi.Size = new System.Drawing.Size(129, 20);
            this.txt_tienthoi.TabIndex = 16;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(698, 474);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(129, 20);
            this.txt_thanhtien.TabIndex = 16;
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 612);
            this.Controls.Add(this.txt_tienthoi);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.txt_khachtra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpthongtin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.dgv_danhmucsp);
            this.Name = "ChiTietHoaDon";
            this.Text = "ChiTietHoaDon";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhmucsp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grpthongtin.ResumeLayout(false);
            this.grpthongtin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private RichTextBox txt_ghichu;
        private ComboBox cmb_nguoiban;
        private ComboBox cmb_nguoitao;
        private Label label16;
        private Label label20;
        private Label label18;
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
        private DataGridViewTextBoxColumn masp;
        private DataGridViewTextBoxColumn tensp;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn col_dongia;
        private DataGridViewTextBoxColumn gia;
        private TextBox txt_khachtra;
        private TextBox txt_tienthoi;
        private TextBox txt_thanhtien;
    }
}