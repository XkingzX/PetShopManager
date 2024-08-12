using System.Drawing;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung
{
    partial class ThemThongTinKhachHang
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
            RadioButton rbtnNam;
            btnChonAnh = new Button();
            lblThemKH = new Label();
            pbHinhAnh = new PictureBox();
            lblMaKH = new Label();
            lblTenKH = new Label();
            lblDT = new Label();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            txtDienThoai = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            ckbNam = new CheckBox();
            label1 = new Label();
            rbtnNu = new RadioButton();
            cbxTinh = new ComboBox();
            label2 = new Label();
            cbxHuyenQuan = new ComboBox();
            cbxPhuongXa = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtGhiChu = new TextBox();
            btnLua = new Button();
            btnBoQua = new Button();
            label7 = new Label();
            label8 = new Label();
            lblNhanVien = new Label();
            textBox1 = new TextBox();
            dtpNgayDK = new DateTimePicker();
            rbtnNam = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // btnChonAnh
            // 
            btnChonAnh.AutoSize = true;
            btnChonAnh.BackColor = Color.LimeGreen;
            btnChonAnh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnChonAnh.ForeColor = SystemColors.ControlLightLight;
            btnChonAnh.Location = new Point(30, 241);
            btnChonAnh.Margin = new Padding(3, 4, 3, 4);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.RightToLeft = RightToLeft.No;
            btnChonAnh.Size = new Size(86, 33);
            btnChonAnh.TabIndex = 2;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = false;
            // 
            // lblThemKH
            // 
            lblThemKH.AutoSize = true;
            lblThemKH.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblThemKH.ForeColor = SystemColors.ControlText;
            lblThemKH.Location = new Point(10, 11);
            lblThemKH.Name = "lblThemKH";
            lblThemKH.Size = new Size(136, 19);
            lblThemKH.TabIndex = 0;
            lblThemKH.Text = "Thêm khách hàng";
            // 
            // pbHinhAnh
            // 
            pbHinhAnh.Location = new Point(14, 67);
            pbHinhAnh.Margin = new Padding(3, 4, 3, 4);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new Size(114, 153);
            pbHinhAnh.TabIndex = 1;
            pbHinhAnh.TabStop = false;
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblMaKH.ForeColor = SystemColors.ControlText;
            lblMaKH.Location = new Point(160, 111);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(119, 19);
            lblMaKH.TabIndex = 3;
            lblMaKH.Text = "Mã khách hàng";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTenKH.ForeColor = SystemColors.ControlText;
            lblTenKH.Location = new Point(160, 157);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(122, 19);
            lblTenKH.TabIndex = 4;
            lblTenKH.Text = "Tên khách hàng";
            // 
            // lblDT
            // 
            lblDT.AutoSize = true;
            lblDT.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDT.ForeColor = SystemColors.ControlText;
            lblDT.Location = new Point(160, 201);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(86, 19);
            lblDT.TabIndex = 4;
            lblDT.Text = "Điện thoại";
            // 
            // txtMaKH
            // 
            txtMaKH.BorderStyle = BorderStyle.FixedSingle;
            txtMaKH.ForeColor = SystemColors.Info;
            txtMaKH.Location = new Point(288, 107);
            txtMaKH.Margin = new Padding(3, 4, 3, 4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(266, 22);
            txtMaKH.TabIndex = 5;
            txtMaKH.Text = "Mã mặc định";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(288, 153);
            txtTenKH.Margin = new Padding(3, 4, 3, 4);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(266, 22);
            txtTenKH.TabIndex = 5;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(288, 197);
            txtDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(266, 22);
            txtDienThoai.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNgaySinh.ForeColor = SystemColors.ControlText;
            lblNgaySinh.Location = new Point(160, 245);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(83, 19);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(290, 242);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(121, 22);
            dtpNgaySinh.TabIndex = 6;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDiaChi.ForeColor = SystemColors.ControlText;
            lblDiaChi.Location = new Point(163, 285);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(62, 19);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(288, 281);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(266, 69);
            txtDiaChi.TabIndex = 5;
            // 
            // ckbNam
            // 
            ckbNam.Appearance = Appearance.Button;
            ckbNam.AutoSize = true;
            ckbNam.BackgroundImageLayout = ImageLayout.None;
            ckbNam.Location = new Point(431, 241);
            ckbNam.Name = "ckbNam";
            ckbNam.Size = new Size(6, 6);
            ckbNam.TabIndex = 7;
            ckbNam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(160, 374);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 4;
            label1.Text = "Tỉnh";
            // 
            // rbtnNam
            // 
            rbtnNam.Appearance = Appearance.Button;
            rbtnNam.AutoSize = true;
            rbtnNam.Location = new Point(431, 241);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(41, 25);
            rbtnNam.TabIndex = 9;
            rbtnNam.Text = "Nam";
            rbtnNam.UseVisualStyleBackColor = false;
            // 
            // rbtnNu
            // 
            rbtnNu.Appearance = Appearance.Button;
            rbtnNu.AutoCheck = false;
            rbtnNu.AutoSize = true;
            rbtnNu.Location = new Point(497, 242);
            rbtnNu.Name = "rbtnNu";
            rbtnNu.RightToLeft = RightToLeft.No;
            rbtnNu.Size = new Size(33, 25);
            rbtnNu.TabIndex = 10;
            rbtnNu.Text = "Nữ";
            rbtnNu.UseVisualStyleBackColor = true;
            // 
            // cbxTinh
            // 
            cbxTinh.FormattingEnabled = true;
            cbxTinh.Location = new Point(288, 369);
            cbxTinh.Name = "cbxTinh";
            cbxTinh.Size = new Size(266, 23);
            cbxTinh.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(163, 422);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 4;
            label2.Text = "Huyện / Quận";
            // 
            // cbxHuyenQuan
            // 
            cbxHuyenQuan.FormattingEnabled = true;
            cbxHuyenQuan.Location = new Point(288, 418);
            cbxHuyenQuan.Name = "cbxHuyenQuan";
            cbxHuyenQuan.Size = new Size(266, 23);
            cbxHuyenQuan.TabIndex = 11;
            // 
            // cbxPhuongXa
            // 
            cbxPhuongXa.FormattingEnabled = true;
            cbxPhuongXa.Location = new Point(288, 467);
            cbxPhuongXa.Name = "cbxPhuongXa";
            cbxPhuongXa.Size = new Size(266, 23);
            cbxPhuongXa.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(163, 471);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 4;
            label3.Text = "Phường / Xã";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(619, 68);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(779, 68);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 22);
            txtEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(619, 149);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 3;
            label5.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(779, 146);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(242, 120);
            txtGhiChu.TabIndex = 5;
            // 
            // btnLua
            // 
            btnLua.BackColor = Color.LimeGreen;
            btnLua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLua.ForeColor = Color.Cornsilk;
            btnLua.Location = new Point(801, 553);
            btnLua.Name = "btnLua";
            btnLua.Size = new Size(94, 43);
            btnLua.TabIndex = 12;
            btnLua.Text = "Lưu (F9)";
            btnLua.UseVisualStyleBackColor = false;
            btnLua.Click += btnLua_Click_1;
            // 
            // btnBoQua
            // 
            btnBoQua.BackColor = Color.Silver;
            btnBoQua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnBoQua.ForeColor = Color.Cornsilk;
            btnBoQua.Location = new Point(901, 553);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 43);
            btnBoQua.TabIndex = 12;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = false;
            btnBoQua.Click += btnBoQua_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(619, 108);
            label7.Name = "label7";
            label7.Size = new Size(106, 19);
            label7.TabIndex = 3;
            label7.Text = "Ngày đăng ký";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(779, 108);
            label8.Name = "label8";
            label8.Size = new Size(0, 19);
            label8.TabIndex = 3;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNhanVien.ForeColor = SystemColors.ControlText;
            lblNhanVien.Location = new Point(160, 69);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(112, 19);
            lblNhanVien.TabIndex = 3;
            lblNhanVien.Text = "Mã Nhân Viên";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(288, 65);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(266, 22);
            textBox1.TabIndex = 5;
            textBox1.Text = "Mã mặc định";
            // 
            // dtpNgayDK
            // 
            dtpNgayDK.Location = new Point(781, 106);
            dtpNgayDK.Name = "dtpNgayDK";
            dtpNgayDK.Size = new Size(240, 22);
            dtpNgayDK.TabIndex = 13;
            // 
            // ThemThongTinKhachHang
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1093, 656);
            Controls.Add(dtpNgayDK);
            Controls.Add(btnBoQua);
            Controls.Add(btnLua);
            Controls.Add(cbxPhuongXa);
            Controls.Add(cbxHuyenQuan);
            Controls.Add(cbxTinh);
            Controls.Add(rbtnNu);
            Controls.Add(rbtnNam);
            Controls.Add(ckbNam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtDiaChi);
            Controls.Add(txtDienThoai);
            Controls.Add(txtGhiChu);
            Controls.Add(txtEmail);
            Controls.Add(txtTenKH);
            Controls.Add(textBox1);
            Controls.Add(txtMaKH);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDiaChi);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblDT);
            Controls.Add(lblTenKH);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(lblNhanVien);
            Controls.Add(lblMaKH);
            Controls.Add(btnChonAnh);
            Controls.Add(pbHinhAnh);
            Controls.Add(lblThemKH);
            Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ThemThongTinKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThongTinKhachHang";
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThemKH;
        private PictureBox pbHinhAnh;
        private Button btnChonAnh;
        private Label lblMaKH;
        private Label lblTenKH;
        private Label lblDT;
        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private TextBox txtDienThoai;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private CheckBox ckbNam;
        private Label label1;
        private RadioButton rbtnNam;
        private RadioButton rbtnNu;
        private ComboBox cbxTinh;
        private Label label2;
        private ComboBox cbxHuyenQuan;
        private ComboBox cbxPhuongXa;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtGhiChu;
        private Button btnLua;
        private Button btnBoQua;
        private Label label7;
        private Label label8;
        private Label lblNhanVien;
        private TextBox textBox1;
        private DateTimePicker dtpNgayDK;
    }
}