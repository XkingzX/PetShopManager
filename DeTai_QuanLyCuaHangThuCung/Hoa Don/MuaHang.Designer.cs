using System.Drawing;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung
{
    partial class MuaHang
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lbl_mahd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_manv = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rd_ksd = new System.Windows.Forms.RadioButton();
            this.rd_sd = new System.Windows.Forms.RadioButton();
            this.btn_taomoi = new System.Windows.Forms.Button();
            this.lbl_tongthanhtoan = new System.Windows.Forms.Label();
            this.lbl_giamgia = new System.Windows.Forms.Label();
            this.lbl_tongtienhang = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.RichTextBox();
            this.btn_xoagiohang = new System.Windows.Forms.Button();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_giohang = new System.Windows.Forms.DataGridView();
            this.col_masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_thoigian = new System.Windows.Forms.DateTimePicker();
            this.cmb_loaikh = new System.Windows.Forms.ComboBox();
            this.cmb_tenkh = new System.Windows.Forms.ComboBox();
            this.cmb_makh = new System.Windows.Forms.ComboBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_sl = new System.Windows.Forms.NumericUpDown();
            this.cmb_tensp = new System.Windows.Forms.ComboBox();
            this.cmb_masp = new System.Windows.Forms.ComboBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_loaisp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giohang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.lbl_mahd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 51);
            this.panel1.TabIndex = 0;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(579, 16);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(106, 25);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(691, 16);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(106, 25);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(802, 16);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(108, 25);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // lbl_mahd
            // 
            this.lbl_mahd.AutoSize = true;
            this.lbl_mahd.Location = new System.Drawing.Point(100, 25);
            this.lbl_mahd.Name = "lbl_mahd";
            this.lbl_mahd.Size = new System.Drawing.Size(77, 13);
            this.lbl_mahd.TabIndex = 0;
            this.lbl_mahd.Text = "Mã đơn hàng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng: ";
            // 
            // cmb_manv
            // 
            this.cmb_manv.FormattingEnabled = true;
            this.cmb_manv.Location = new System.Drawing.Point(92, 103);
            this.cmb_manv.Name = "cmb_manv";
            this.cmb_manv.Size = new System.Drawing.Size(174, 21);
            this.cmb_manv.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 47);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(413, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giỏ Hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.rd_ksd);
            this.panel3.Controls.Add(this.rd_sd);
            this.panel3.Controls.Add(this.btn_taomoi);
            this.panel3.Controls.Add(this.lbl_tongthanhtoan);
            this.panel3.Controls.Add(this.lbl_giamgia);
            this.panel3.Controls.Add(this.lbl_tongtienhang);
            this.panel3.Controls.Add(this.txt_ghichu);
            this.panel3.Controls.Add(this.btn_xoagiohang);
            this.panel3.Controls.Add(this.btn_thanhtoan);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(724, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 406);
            this.panel3.TabIndex = 3;
            // 
            // rd_ksd
            // 
            this.rd_ksd.AutoSize = true;
            this.rd_ksd.Location = new System.Drawing.Point(16, 88);
            this.rd_ksd.Name = "rd_ksd";
            this.rd_ksd.Size = new System.Drawing.Size(123, 17);
            this.rd_ksd.TabIndex = 12;
            this.rd_ksd.TabStop = true;
            this.rd_ksd.Text = "Không sử dụng điểm";
            this.rd_ksd.UseVisualStyleBackColor = true;
            this.rd_ksd.CheckedChanged += new System.EventHandler(this.rd_ksd_CheckedChanged);
            // 
            // rd_sd
            // 
            this.rd_sd.AutoSize = true;
            this.rd_sd.Location = new System.Drawing.Point(19, 51);
            this.rd_sd.Name = "rd_sd";
            this.rd_sd.Size = new System.Drawing.Size(91, 17);
            this.rd_sd.TabIndex = 11;
            this.rd_sd.TabStop = true;
            this.rd_sd.Text = "Sử dụng điểm";
            this.rd_sd.UseVisualStyleBackColor = true;
            this.rd_sd.CheckedChanged += new System.EventHandler(this.rd_sd_CheckedChanged);
            // 
            // btn_taomoi
            // 
            this.btn_taomoi.Location = new System.Drawing.Point(16, 284);
            this.btn_taomoi.Name = "btn_taomoi";
            this.btn_taomoi.Size = new System.Drawing.Size(169, 36);
            this.btn_taomoi.TabIndex = 9;
            this.btn_taomoi.Text = "Tạo mới";
            this.btn_taomoi.UseVisualStyleBackColor = true;
            this.btn_taomoi.Click += new System.EventHandler(this.btn_taomoi_Click);
            // 
            // lbl_tongthanhtoan
            // 
            this.lbl_tongthanhtoan.AutoSize = true;
            this.lbl_tongthanhtoan.Location = new System.Drawing.Point(141, 168);
            this.lbl_tongthanhtoan.Name = "lbl_tongthanhtoan";
            this.lbl_tongthanhtoan.Size = new System.Drawing.Size(13, 13);
            this.lbl_tongthanhtoan.TabIndex = 6;
            this.lbl_tongthanhtoan.Text = "0";
            // 
            // lbl_giamgia
            // 
            this.lbl_giamgia.AutoSize = true;
            this.lbl_giamgia.Location = new System.Drawing.Point(141, 122);
            this.lbl_giamgia.Name = "lbl_giamgia";
            this.lbl_giamgia.Size = new System.Drawing.Size(13, 13);
            this.lbl_giamgia.TabIndex = 6;
            this.lbl_giamgia.Text = "0";
            // 
            // lbl_tongtienhang
            // 
            this.lbl_tongtienhang.AutoSize = true;
            this.lbl_tongtienhang.Location = new System.Drawing.Point(141, 25);
            this.lbl_tongtienhang.Name = "lbl_tongtienhang";
            this.lbl_tongtienhang.Size = new System.Drawing.Size(13, 13);
            this.lbl_tongtienhang.TabIndex = 6;
            this.lbl_tongtienhang.Text = "0";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(16, 194);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(170, 75);
            this.txt_ghichu.TabIndex = 5;
            this.txt_ghichu.Text = "Ghi chú";
            // 
            // btn_xoagiohang
            // 
            this.btn_xoagiohang.Location = new System.Drawing.Point(16, 326);
            this.btn_xoagiohang.Name = "btn_xoagiohang";
            this.btn_xoagiohang.Size = new System.Drawing.Size(170, 36);
            this.btn_xoagiohang.TabIndex = 4;
            this.btn_xoagiohang.Text = "Xoá toàn bộ giỏ hàng";
            this.btn_xoagiohang.UseVisualStyleBackColor = true;
            this.btn_xoagiohang.Click += new System.EventHandler(this.btn_lammoi_Click_1);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(16, 367);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(170, 36);
            this.btn_thanhtoan.TabIndex = 4;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(16, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tổng thanh toán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(13, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Giảm giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tổng tiền hàng";
            // 
            // dgv_giohang
            // 
            this.dgv_giohang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_giohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_giohang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_masp,
            this.col_tensp,
            this.col_dongia,
            this.col_sl,
            this.col_thanhtien});
            this.dgv_giohang.Location = new System.Drawing.Point(0, 297);
            this.dgv_giohang.Name = "dgv_giohang";
            this.dgv_giohang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_giohang.Size = new System.Drawing.Size(719, 204);
            this.dgv_giohang.TabIndex = 4;
            // 
            // col_masp
            // 
            this.col_masp.DataPropertyName = "MASP";
            this.col_masp.HeaderText = "Mã sản phẩm";
            this.col_masp.Name = "col_masp";
            // 
            // col_tensp
            // 
            this.col_tensp.DataPropertyName = "TenSP";
            this.col_tensp.HeaderText = "Tên sản phẩm";
            this.col_tensp.Name = "col_tensp";
            // 
            // col_dongia
            // 
            this.col_dongia.DataPropertyName = "GIA";
            this.col_dongia.HeaderText = "Đơn giá";
            this.col_dongia.Name = "col_dongia";
            // 
            // col_sl
            // 
            this.col_sl.DataPropertyName = "SL";
            this.col_sl.HeaderText = "Số lượng";
            this.col_sl.Name = "col_sl";
            // 
            // col_thanhtien
            // 
            this.col_thanhtien.DataPropertyName = "TONGTIEN";
            this.col_thanhtien.HeaderText = "Thành tiền";
            this.col_thanhtien.Name = "col_thanhtien";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_manv);
            this.groupBox1.Controls.Add(this.dtp_thoigian);
            this.groupBox1.Controls.Add(this.cmb_loaikh);
            this.groupBox1.Controls.Add(this.cmb_tenkh);
            this.groupBox1.Controls.Add(this.cmb_makh);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.txt_diem);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(202, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 192);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // dtp_thoigian
            // 
            this.dtp_thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_thoigian.Location = new System.Drawing.Point(92, 60);
            this.dtp_thoigian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_thoigian.Name = "dtp_thoigian";
            this.dtp_thoigian.Size = new System.Drawing.Size(174, 20);
            this.dtp_thoigian.TabIndex = 17;
            // 
            // cmb_loaikh
            // 
            this.cmb_loaikh.FormattingEnabled = true;
            this.cmb_loaikh.Location = new System.Drawing.Point(377, 13);
            this.cmb_loaikh.Name = "cmb_loaikh";
            this.cmb_loaikh.Size = new System.Drawing.Size(131, 21);
            this.cmb_loaikh.TabIndex = 2;
            this.cmb_loaikh.SelectedIndexChanged += new System.EventHandler(this.cmb_loaikh_SelectedIndexChanged);
            // 
            // cmb_tenkh
            // 
            this.cmb_tenkh.FormattingEnabled = true;
            this.cmb_tenkh.Location = new System.Drawing.Point(377, 47);
            this.cmb_tenkh.Name = "cmb_tenkh";
            this.cmb_tenkh.Size = new System.Drawing.Size(131, 21);
            this.cmb_tenkh.TabIndex = 2;
            // 
            // cmb_makh
            // 
            this.cmb_makh.FormattingEnabled = true;
            this.cmb_makh.Location = new System.Drawing.Point(92, 16);
            this.cmb_makh.Name = "cmb_makh";
            this.cmb_makh.Size = new System.Drawing.Size(172, 21);
            this.cmb_makh.TabIndex = 2;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(92, 149);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(174, 20);
            this.txt_tennv.TabIndex = 1;
            // 
            // txt_diem
            // 
            this.txt_diem.Location = new System.Drawing.Point(377, 154);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(131, 20);
            this.txt_diem.TabIndex = 1;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(377, 85);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(131, 20);
            this.txt_sdt.TabIndex = 1;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(377, 119);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(131, 20);
            this.txt_diachi.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(285, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Điểm thưởng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên khách hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Loại khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Mã nhân viên";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(0, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Ngày tạo hoá đơn";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(2, 153);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_sl);
            this.groupBox2.Controls.Add(this.cmb_tensp);
            this.groupBox2.Controls.Add(this.cmb_masp);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.txt_loaisp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(2, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 192);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // num_sl
            // 
            this.num_sl.Location = new System.Drawing.Point(82, 166);
            this.num_sl.Name = "num_sl";
            this.num_sl.Size = new System.Drawing.Size(111, 20);
            this.num_sl.TabIndex = 3;
            // 
            // cmb_tensp
            // 
            this.cmb_tensp.FormattingEnabled = true;
            this.cmb_tensp.Location = new System.Drawing.Point(81, 96);
            this.cmb_tensp.Name = "cmb_tensp";
            this.cmb_tensp.Size = new System.Drawing.Size(111, 21);
            this.cmb_tensp.TabIndex = 2;
            // 
            // cmb_masp
            // 
            this.cmb_masp.FormattingEnabled = true;
            this.cmb_masp.Location = new System.Drawing.Point(81, 23);
            this.cmb_masp.Name = "cmb_masp";
            this.cmb_masp.Size = new System.Drawing.Size(111, 21);
            this.cmb_masp.TabIndex = 2;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(81, 133);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(111, 20);
            this.txt_dongia.TabIndex = 1;
            // 
            // txt_loaisp
            // 
            this.txt_loaisp.Location = new System.Drawing.Point(81, 60);
            this.txt_loaisp.Name = "txt_loaisp";
            this.txt_loaisp.Size = new System.Drawing.Size(111, 20);
            this.txt_loaisp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại sản phẩm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(0, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Số lượng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã sản phẩm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Đơn giá";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tên sản phẩm";
            // 
            // MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_giohang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MuaHang";
            this.Text = "MuaHang";
            this.Load += new System.EventHandler(this.MuaHang_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giohang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_mahd;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label8;
        private Button btn_thanhtoan;
        private Label label11;
        private Label label10;
        private Button btn_xoa;
        private GroupBox groupBox1;
        private ComboBox cmb_makh;
        private TextBox txt_diem;
        private TextBox txt_sdt;
        private TextBox txt_diachi;
        private Label label13;
        private Label label7;
        private Label label5;
        private Label label12;
        private Label label6;
        private Label label4;
        private RichTextBox txt_ghichu;
        private Label lbl_tongthanhtoan;
        private Label lbl_giamgia;
        private Label lbl_tongtienhang;
        private ComboBox cmb_manv;
        private GroupBox groupBox2;
        private ComboBox cmb_masp;
        private Label label15;
        private Label label16;
        private Label label18;
        private DateTimePicker dtp_thoigian;
        private Label label20;
        private Label label19;
        private Label label21;
        private NumericUpDown num_sl;
        private Label label2;
        private TextBox txt_dongia;
        private Label label14;
        private Button btn_sua;
        private Button btn_xoagiohang;
        private BindingSource bindingSource1;
        private TextBox txt_tennv;
        private TextBox txt_loaisp;
        private Button btn_them;
        private DataGridView dgv_giohang;
        private DataGridViewTextBoxColumn col_masp;
        private DataGridViewTextBoxColumn col_tensp;
        private DataGridViewTextBoxColumn col_dongia;
        private DataGridViewTextBoxColumn col_sl;
        private DataGridViewTextBoxColumn col_thanhtien;
        private ComboBox cmb_tensp;
        private ComboBox cmb_tenkh;
        private ComboBox cmb_loaikh;
        private Button btn_taomoi;
        private RadioButton rd_ksd;
        private RadioButton rd_sd;
    }
}