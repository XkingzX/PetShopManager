namespace DeTai_QuanLyCuaHangThuCung
{
    partial class frmThemNV
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
            label = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtManv = new TextBox();
            txtHoten = new TextBox();
            txtSoDienThoai = new TextBox();
            txtMatkhau = new TextBox();
            btnLuu = new Button();
            btnThoat = new Button();
            label5 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            txtDiachi = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            dtpNgaysinh = new DateTimePicker();
            label9 = new Label();
            txtGhichu = new TextBox();
            pbHinhanh = new PictureBox();
            btnChonhinh = new Button();
            label10 = new Label();
            dtpNgayvaolam = new DateTimePicker();
            cmbQuyen = new ComboBox();
            btnToday = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhanh).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(21, 9);
            label.Name = "label";
            label.Size = new Size(82, 15);
            label.TabIndex = 0;
            label.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 45);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 76);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 348);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Quyền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 314);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu";
            // 
            // txtManv
            // 
            txtManv.Location = new Point(118, 6);
            txtManv.Name = "txtManv";
            txtManv.Size = new Size(197, 23);
            txtManv.TabIndex = 1;
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(118, 35);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(197, 23);
            txtHoten.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(115, 68);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(197, 23);
            txtSoDienThoai.TabIndex = 1;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(109, 311);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(203, 23);
            txtMatkhau.TabIndex = 1;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(165, 452);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 32);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(272, 452);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 32);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 107);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 0;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 164);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "Giới tính";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbNam);
            groupBox2.Controls.Add(rdbNu);
            groupBox2.Location = new Point(112, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(163, 29);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(6, 7);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(51, 19);
            rdbNam.TabIndex = 3;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(78, 7);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(41, 19);
            rdbNu.TabIndex = 3;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(115, 104);
            txtDiachi.Multiline = true;
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(197, 45);
            txtDiachi.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 197);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 0;
            label7.Text = "Ngày Sinh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 279);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 0;
            label8.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 279);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 23);
            txtEmail.TabIndex = 1;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Location = new Point(112, 197);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(200, 23);
            dtpNgaysinh.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 379);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 0;
            label9.Text = "Ghi Chú";
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(109, 376);
            txtGhichu.Multiline = true;
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(203, 67);
            txtGhichu.TabIndex = 1;
            // 
            // pbHinhanh
            // 
            pbHinhanh.BackgroundImageLayout = ImageLayout.Zoom;
            pbHinhanh.Location = new Point(377, 36);
            pbHinhanh.Name = "pbHinhanh";
            pbHinhanh.Size = new Size(149, 143);
            pbHinhanh.TabIndex = 6;
            pbHinhanh.TabStop = false;
            // 
            // btnChonhinh
            // 
            btnChonhinh.Location = new Point(411, 189);
            btnChonhinh.Name = "btnChonhinh";
            btnChonhinh.Size = new Size(75, 23);
            btnChonhinh.TabIndex = 7;
            btnChonhinh.Text = "Chọn Hình";
            btnChonhinh.UseVisualStyleBackColor = true;
            btnChonhinh.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 251);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 0;
            label10.Text = "Ngày vào làm";
            // 
            // dtpNgayvaolam
            // 
            dtpNgayvaolam.Location = new Point(109, 243);
            dtpNgayvaolam.Name = "dtpNgayvaolam";
            dtpNgayvaolam.Size = new Size(203, 23);
            dtpNgayvaolam.TabIndex = 5;
            // 
            // cmbQuyen
            // 
            cmbQuyen.FormattingEnabled = true;
            cmbQuyen.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cmbQuyen.Location = new Point(109, 345);
            cmbQuyen.Name = "cmbQuyen";
            cmbQuyen.Size = new Size(203, 23);
            cmbQuyen.TabIndex = 8;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(318, 243);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(53, 23);
            btnToday.TabIndex = 9;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Click += btnToday_Click;
            // 
            // frmThemNV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 486);
            Controls.Add(btnToday);
            Controls.Add(cmbQuyen);
            Controls.Add(btnChonhinh);
            Controls.Add(pbHinhanh);
            Controls.Add(dtpNgayvaolam);
            Controls.Add(dtpNgaysinh);
            Controls.Add(groupBox2);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(txtEmail);
            Controls.Add(txtMatkhau);
            Controls.Add(txtGhichu);
            Controls.Add(txtDiachi);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtHoten);
            Controls.Add(txtManv);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label);
            Name = "frmThemNV";
            Text = "Thêm Nhân Viên";
            Load += frmThemNV_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhanh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtManv;
        private TextBox txtHoten;
        private TextBox txtSoDienThoai;
        private TextBox txtMatkhau;
        private Button btnLuu;
        private Button btnThoat;
        private Label label5;
        private Label label6;
        private GroupBox groupBox2;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private TextBox txtDiachi;
        private Label label7;
        private Label label8;
        private TextBox txtEmail;
        private DateTimePicker dtpNgaysinh;
        private Label label9;
        private TextBox txtGhichu;
        private PictureBox pbHinhanh;
        private Button btnChonhinh;
        private Label label10;
        private DateTimePicker dtpNgayvaolam;
        private ComboBox cmbQuyen;
        private Button btnToday;
    }
}