using System.Drawing;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung.GiaoDich
{
    partial class frm_hoadon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_xemchitiet = new System.Windows.Forms.Button();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.col_sohd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ptthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpb_thoigian = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_nam = new System.Windows.Forms.ComboBox();
            this.cmb_thang = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_xemdshd = new System.Windows.Forms.Button();
            this.btn_xemdscthd = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_all = new System.Windows.Forms.RadioButton();
            this.rd_dahuy = new System.Windows.Forms.RadioButton();
            this.rd_dathanhtoan = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.grpb_thoigian.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_xemchitiet);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(317, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(168, 34);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(132, 41);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xemchitiet
            // 
            this.btn_xemchitiet.Location = new System.Drawing.Point(16, 34);
            this.btn_xemchitiet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_xemchitiet.Name = "btn_xemchitiet";
            this.btn_xemchitiet.Size = new System.Drawing.Size(125, 41);
            this.btn_xemchitiet.TabIndex = 1;
            this.btn_xemchitiet.Text = "Xem chi tiết";
            this.btn_xemchitiet.UseVisualStyleBackColor = true;
            this.btn_xemchitiet.Click += new System.EventHandler(this.btn_xemhd_Click);
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_sohd,
            this.col_thoigian,
            this.col_tenkh,
            this.col_nhanvien,
            this.col_tongtien,
            this.col_trangthai,
            this.col_ptthanhtoan});
            this.dgv_hoadon.Location = new System.Drawing.Point(341, 23);
            this.dgv_hoadon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersWidth = 51;
            this.dgv_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoadon.Size = new System.Drawing.Size(787, 281);
            this.dgv_hoadon.TabIndex = 9;
            // 
            // col_sohd
            // 
            this.col_sohd.DataPropertyName = "SOHD";
            this.col_sohd.HeaderText = "Số HD";
            this.col_sohd.MinimumWidth = 6;
            this.col_sohd.Name = "col_sohd";
            // 
            // col_thoigian
            // 
            this.col_thoigian.DataPropertyName = "THOIGIAN";
            this.col_thoigian.HeaderText = "Thời gian";
            this.col_thoigian.MinimumWidth = 6;
            this.col_thoigian.Name = "col_thoigian";
            // 
            // col_tenkh
            // 
            this.col_tenkh.DataPropertyName = "HOTEN";
            this.col_tenkh.HeaderText = "Tên khách hàng";
            this.col_tenkh.MinimumWidth = 6;
            this.col_tenkh.Name = "col_tenkh";
            // 
            // col_nhanvien
            // 
            this.col_nhanvien.DataPropertyName = "HOTEN1";
            this.col_nhanvien.HeaderText = "Người bán";
            this.col_nhanvien.MinimumWidth = 6;
            this.col_nhanvien.Name = "col_nhanvien";
            // 
            // col_tongtien
            // 
            this.col_tongtien.DataPropertyName = "TONGTIEN";
            this.col_tongtien.HeaderText = "Tổng tiền";
            this.col_tongtien.MinimumWidth = 6;
            this.col_tongtien.Name = "col_tongtien";
            // 
            // col_trangthai
            // 
            this.col_trangthai.DataPropertyName = "TRANGTHAI";
            this.col_trangthai.HeaderText = "Trạng thái";
            this.col_trangthai.MinimumWidth = 6;
            this.col_trangthai.Name = "col_trangthai";
            // 
            // col_ptthanhtoan
            // 
            this.col_ptthanhtoan.DataPropertyName = "PTTHANHTOAN";
            this.col_ptthanhtoan.HeaderText = "Phương thức thanh toán";
            this.col_ptthanhtoan.MinimumWidth = 6;
            this.col_ptthanhtoan.Name = "col_ptthanhtoan";
            // 
            // grpb_thoigian
            // 
            this.grpb_thoigian.Controls.Add(this.btn_cancel);
            this.grpb_thoigian.Controls.Add(this.label2);
            this.grpb_thoigian.Controls.Add(this.label1);
            this.grpb_thoigian.Controls.Add(this.cmb_nam);
            this.grpb_thoigian.Controls.Add(this.cmb_thang);
            this.grpb_thoigian.Location = new System.Drawing.Point(16, 138);
            this.grpb_thoigian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpb_thoigian.Name = "grpb_thoigian";
            this.grpb_thoigian.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpb_thoigian.Size = new System.Drawing.Size(311, 127);
            this.grpb_thoigian.TabIndex = 12;
            this.grpb_thoigian.TabStop = false;
            this.grpb_thoigian.Text = "Thời gian";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(200, 101);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Bỏ chọn";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theo năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theo tháng";
            // 
            // cmb_nam
            // 
            this.cmb_nam.FormattingEnabled = true;
            this.cmb_nam.Location = new System.Drawing.Point(108, 68);
            this.cmb_nam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_nam.Name = "cmb_nam";
            this.cmb_nam.Size = new System.Drawing.Size(193, 24);
            this.cmb_nam.TabIndex = 0;
            this.cmb_nam.SelectedIndexChanged += new System.EventHandler(this.cmb_nam_SelectedIndexChanged);
            // 
            // cmb_thang
            // 
            this.cmb_thang.FormattingEnabled = true;
            this.cmb_thang.Location = new System.Drawing.Point(108, 23);
            this.cmb_thang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_thang.Name = "cmb_thang";
            this.cmb_thang.Size = new System.Drawing.Size(193, 24);
            this.cmb_thang.TabIndex = 0;
            this.cmb_thang.SelectedIndexChanged += new System.EventHandler(this.cmb_thang_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_xemdshd);
            this.groupBox3.Controls.Add(this.btn_xemdscthd);
            this.groupBox3.Location = new System.Drawing.Point(417, 309);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(632, 112);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xuất báo cáo";
            // 
            // btn_xemdshd
            // 
            this.btn_xemdshd.Location = new System.Drawing.Point(68, 34);
            this.btn_xemdshd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xemdshd.Name = "btn_xemdshd";
            this.btn_xemdshd.Size = new System.Drawing.Size(228, 41);
            this.btn_xemdshd.TabIndex = 2;
            this.btn_xemdshd.Text = "Xem danh sách hoá đơn";
            this.btn_xemdshd.UseVisualStyleBackColor = true;
            this.btn_xemdshd.Click += new System.EventHandler(this.btn_xemdshd_Click);
            // 
            // btn_xemdscthd
            // 
            this.btn_xemdscthd.Location = new System.Drawing.Point(341, 34);
            this.btn_xemdscthd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_xemdscthd.Name = "btn_xemdscthd";
            this.btn_xemdscthd.Size = new System.Drawing.Size(228, 41);
            this.btn_xemdscthd.TabIndex = 1;
            this.btn_xemdscthd.Text = "Xen danh sách chi tiết hoá đơn";
            this.btn_xemdscthd.UseVisualStyleBackColor = true;
            this.btn_xemdscthd.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_all);
            this.groupBox4.Controls.Add(this.rd_dahuy);
            this.groupBox4.Controls.Add(this.rd_dathanhtoan);
            this.groupBox4.Location = new System.Drawing.Point(16, 272);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(252, 149);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trạng thái";
            // 
            // rd_all
            // 
            this.rd_all.AutoSize = true;
            this.rd_all.Checked = true;
            this.rd_all.Location = new System.Drawing.Point(16, 25);
            this.rd_all.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_all.Name = "rd_all";
            this.rd_all.Size = new System.Drawing.Size(66, 20);
            this.rd_all.TabIndex = 1;
            this.rd_all.TabStop = true;
            this.rd_all.Text = "Tất cả";
            this.rd_all.UseVisualStyleBackColor = true;
            // 
            // rd_dahuy
            // 
            this.rd_dahuy.AutoSize = true;
            this.rd_dahuy.Location = new System.Drawing.Point(16, 121);
            this.rd_dahuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_dahuy.Name = "rd_dahuy";
            this.rd_dahuy.Size = new System.Drawing.Size(69, 20);
            this.rd_dahuy.TabIndex = 0;
            this.rd_dahuy.Text = "Đã huỷ";
            this.rd_dahuy.UseVisualStyleBackColor = true;
            this.rd_dahuy.CheckedChanged += new System.EventHandler(this.rd_dahuy_CheckedChanged);
            // 
            // rd_dathanhtoan
            // 
            this.rd_dathanhtoan.AutoSize = true;
            this.rd_dathanhtoan.Location = new System.Drawing.Point(16, 71);
            this.rd_dathanhtoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd_dathanhtoan.Name = "rd_dathanhtoan";
            this.rd_dathanhtoan.Size = new System.Drawing.Size(109, 20);
            this.rd_dathanhtoan.TabIndex = 0;
            this.rd_dathanhtoan.Text = "Đã thanh toán";
            this.rd_dathanhtoan.UseVisualStyleBackColor = true;
            this.rd_dathanhtoan.CheckedChanged += new System.EventHandler(this.rd_dathanhtoan_CheckedChanged);
            // 
            // frm_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 434);
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpb_thoigian);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frm_hoadon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frm_hoadon_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.grpb_thoigian.ResumeLayout(false);
            this.grpb_thoigian.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Button btn_xoa;
        private DataGridView dgv_hoadon;
        private GroupBox grpb_thoigian;
        private ComboBox cmb_thang;
        private ComboBox cmb_nam;
        private Button btn_xemchitiet;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btn_xemdscthd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox4;
        private RadioButton rd_dahuy;
        private RadioButton rd_dathanhtoan;
        private Button btn_xemdshd;
        private DataGridViewTextBoxColumn col_sohd;
        private DataGridViewTextBoxColumn col_thoigian;
        private DataGridViewTextBoxColumn col_tenkh;
        private DataGridViewTextBoxColumn col_nhanvien;
        private DataGridViewTextBoxColumn col_tongtien;
        private DataGridViewTextBoxColumn col_trangthai;
        private DataGridViewTextBoxColumn col_ptthanhtoan;
        private RadioButton rd_all;
        private Button btn_cancel;
    }
}