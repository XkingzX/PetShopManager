using System.Drawing;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung.QuanLyKH
{
    partial class frmKhachHang
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
            lblKH = new Label();
            grbNhomKH = new GroupBox();
            cbxNhomKhachHang = new ComboBox();
            groupBox1 = new GroupBox();
            btnLoc = new Button();
            lblDenNgay = new Label();
            lblTuNgay = new Label();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            grbNguoiTao = new GroupBox();
            cbxNguoiTao = new ComboBox();
            dgvThongTinKhachHang = new DataGridView();
            btnThemKhachHang = new Button();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            txtTimKiem = new TextBox();
            grbNhomKH.SuspendLayout();
            groupBox1.SuspendLayout();
            grbNguoiTao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinKhachHang).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblKH
            // 
            lblKH.AutoSize = true;
            lblKH.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblKH.Location = new Point(10, 23);
            lblKH.Name = "lblKH";
            lblKH.Size = new Size(147, 32);
            lblKH.TabIndex = 0;
            lblKH.Text = "Khách Hàng";
            // 
            // grbNhomKH
            // 
            grbNhomKH.BackColor = SystemColors.ControlLightLight;
            grbNhomKH.Controls.Add(cbxNhomKhachHang);
            grbNhomKH.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grbNhomKH.Location = new Point(16, 68);
            grbNhomKH.Margin = new Padding(3, 4, 3, 4);
            grbNhomKH.Name = "grbNhomKH";
            grbNhomKH.Padding = new Padding(3, 4, 3, 4);
            grbNhomKH.Size = new Size(229, 119);
            grbNhomKH.TabIndex = 1;
            grbNhomKH.TabStop = false;
            grbNhomKH.Text = "Nhóm Khách Hàng";
            // 
            // cbxNhomKhachHang
            // 
            cbxNhomKhachHang.FormattingEnabled = true;
            cbxNhomKhachHang.Location = new Point(13, 47);
            cbxNhomKhachHang.Margin = new Padding(3, 4, 3, 4);
            cbxNhomKhachHang.Name = "cbxNhomKhachHang";
            cbxNhomKhachHang.Size = new Size(209, 27);
            cbxNhomKhachHang.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(lblDenNgay);
            groupBox1.Controls.Add(lblTuNgay);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(17, 215);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 135);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngày Tạo";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(12, 95);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(191, 29);
            btnLoc.TabIndex = 3;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new Point(12, 68);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(76, 19);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày:";
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Location = new Point(23, 34);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(67, 19);
            lblTuNgay.TabIndex = 2;
            lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(96, 62);
            dtpDenNgay.Margin = new Padding(3, 4, 3, 4);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(111, 26);
            dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(96, 28);
            dtpTuNgay.Margin = new Padding(3, 4, 3, 4);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(111, 26);
            dtpTuNgay.TabIndex = 1;
            // 
            // grbNguoiTao
            // 
            grbNguoiTao.BackColor = SystemColors.ControlLightLight;
            grbNguoiTao.Controls.Add(cbxNguoiTao);
            grbNguoiTao.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grbNguoiTao.Location = new Point(21, 377);
            grbNguoiTao.Margin = new Padding(3, 4, 3, 4);
            grbNguoiTao.Name = "grbNguoiTao";
            grbNguoiTao.Padding = new Padding(3, 4, 3, 4);
            grbNguoiTao.Size = new Size(229, 83);
            grbNguoiTao.TabIndex = 3;
            grbNguoiTao.TabStop = false;
            grbNguoiTao.Text = "Người tạo";
            // 
            // cbxNguoiTao
            // 
            cbxNguoiTao.FormattingEnabled = true;
            cbxNguoiTao.Location = new Point(11, 28);
            cbxNguoiTao.Margin = new Padding(3, 4, 3, 4);
            cbxNguoiTao.Name = "cbxNguoiTao";
            cbxNguoiTao.Size = new Size(209, 27);
            cbxNguoiTao.TabIndex = 1;
            // 
            // dgvThongTinKhachHang
            // 
            dgvThongTinKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongTinKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTinKhachHang.Location = new Point(266, 68);
            dgvThongTinKhachHang.Name = "dgvThongTinKhachHang";
            dgvThongTinKhachHang.RowHeadersWidth = 51;
            dgvThongTinKhachHang.Size = new Size(1132, 605);
            dgvThongTinKhachHang.TabIndex = 6;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.BackColor = Color.Green;
            btnThemKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThemKhachHang.ForeColor = SystemColors.ControlLightLight;
            btnThemKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemKhachHang.Location = new Point(1220, 20);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(178, 29);
            btnThemKhachHang.TabIndex = 7;
            btnThemKhachHang.Text = "Thêm Khách Hàng";
            btnThemKhachHang.TextAlign = ContentAlignment.MiddleRight;
            btnThemKhachHang.UseVisualStyleBackColor = false;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(21, 467);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 107);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(109, 24);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(9, 59);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(194, 29);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(9, 24);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(266, 20);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(430, 27);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.Text = "Tìm kiếm";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // frmKhachHang
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1426, 779);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox2);
            Controls.Add(btnThemKhachHang);
            Controls.Add(dgvThongTinKhachHang);
            Controls.Add(grbNguoiTao);
            Controls.Add(groupBox1);
            Controls.Add(grbNhomKH);
            Controls.Add(lblKH);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhachHang";
            grbNhomKH.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbNguoiTao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongTinKhachHang).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKH;
        private GroupBox grbNhomKH;
        private ComboBox cbxNhomKhachHang;
        private GroupBox groupBox1;
        private DateTimePicker dtpTuNgay;
        private GroupBox grbNguoiTao;
        private ComboBox cbxNguoiTao;
        private ComboBox cbxTimKiem;
        private DataGridView dgvThongTinKhachHang;
        private Button btnThemKhachHang;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtTimKiem;
        private Button btnThoat;
        private Label lblDenNgay;
        private Label lblTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnLoc;
    }
}