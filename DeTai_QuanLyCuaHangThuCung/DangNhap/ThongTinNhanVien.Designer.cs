using System.Drawing;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung
{
    partial class frm_thongtinnv
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
            dgvTTNV = new DataGridView();
            pbHinhanh = new PictureBox();
            label8 = new Label();
            txtManv = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtHoten = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSodienthoai = new TextBox();
            txtDiachi = new TextBox();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            dtpNgaysinh = new DateTimePicker();
            dtpNgayvaolam = new DateTimePicker();
            label9 = new Label();
            label = new Label();
            txtGhichu = new TextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            txtTimkiem = new TextBox();
            btnTimkienmanv = new Button();
            label11 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            txtMatkhau = new TextBox();
            cmbQuyen = new ComboBox();
            btnHienthi = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvTTNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHinhanh).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTTNV
            // 
            dgvTTNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTTNV.Location = new Point(1, 446);
            dgvTTNV.Name = "dgvTTNV";
            dgvTTNV.ReadOnly = true;
            dgvTTNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTTNV.Size = new Size(819, 173);
            dgvTTNV.TabIndex = 0;
            dgvTTNV.CellContentClick += dgvTTNV_CellContentClick;
            // 
            // pbHinhanh
            // 
            pbHinhanh.BackgroundImageLayout = ImageLayout.Stretch;
            pbHinhanh.Location = new Point(22, 34);
            pbHinhanh.Name = "pbHinhanh";
            pbHinhanh.Size = new Size(144, 176);
            pbHinhanh.TabIndex = 2;
            pbHinhanh.TabStop = false;
            pbHinhanh.Click += pbHinhanh_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 192, 128);
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(280, 9);
            label8.Name = "label8";
            label8.Size = new Size(257, 30);
            label8.TabIndex = 3;
            label8.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // txtManv
            // 
            txtManv.Location = new Point(308, 21);
            txtManv.Name = "txtManv";
            txtManv.Size = new Size(191, 23);
            txtManv.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(6, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 45);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(115, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 45);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(6, 65);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(219, 45);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button1_Click;
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(308, 52);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(191, 23);
            txtHoten.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(192, 58);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(192, 87);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 1;
            label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(193, 125);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 1;
            label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(193, 189);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 1;
            label5.Text = "Giới Tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(193, 225);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 1;
            label6.Text = "Ngày Sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(193, 262);
            label7.Name = "label7";
            label7.Size = new Size(97, 17);
            label7.TabIndex = 1;
            label7.Text = "Ngày Vào Làm";
            // 
            // txtSodienthoai
            // 
            txtSodienthoai.Location = new Point(308, 87);
            txtSodienthoai.Name = "txtSodienthoai";
            txtSodienthoai.Size = new Size(191, 23);
            txtSodienthoai.TabIndex = 4;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(308, 119);
            txtDiachi.Multiline = true;
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(191, 62);
            txtDiachi.TabIndex = 4;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(6, 4);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(51, 19);
            rdbNam.TabIndex = 6;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(63, 4);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(41, 19);
            rdbNu.TabIndex = 6;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaysinh
            // 
            dtpNgaysinh.Location = new Point(308, 221);
            dtpNgaysinh.Name = "dtpNgaysinh";
            dtpNgaysinh.Size = new Size(191, 23);
            dtpNgaysinh.TabIndex = 7;
            // 
            // dtpNgayvaolam
            // 
            dtpNgayvaolam.Location = new Point(308, 256);
            dtpNgayvaolam.Name = "dtpNgayvaolam";
            dtpNgayvaolam.Size = new Size(191, 23);
            dtpNgayvaolam.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 222);
            label9.Name = "label9";
            label9.Size = new Size(48, 17);
            label9.TabIndex = 1;
            label9.Text = "Quyền";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(574, 207);
            label.Name = "label";
            label.Size = new Size(57, 17);
            label.TabIndex = 1;
            label.Text = "Ghi Chú";
            label.Click += txtGhichu_Click;
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(574, 227);
            txtGhichu.Multiline = true;
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(234, 151);
            txtGhichu.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(193, 299);
            label10.Name = "label10";
            label10.Size = new Size(42, 17);
            label10.TabIndex = 1;
            label10.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(308, 293);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(6, 22);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(127, 23);
            txtTimkiem.TabIndex = 4;
            // 
            // btnTimkienmanv
            // 
            btnTimkienmanv.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimkienmanv.Location = new Point(139, 20);
            btnTimkienmanv.Name = "btnTimkienmanv";
            btnTimkienmanv.Size = new Size(45, 25);
            btnTimkienmanv.TabIndex = 5;
            btnTimkienmanv.Text = "Tìm";
            btnTimkienmanv.UseVisualStyleBackColor = true;
            btnTimkienmanv.Click += btnTimkienmanv_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(194, 27);
            label11.Name = "label11";
            label11.Size = new Size(96, 17);
            label11.TabIndex = 1;
            label11.Text = "Mã Nhân Viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNu);
            groupBox1.Controls.Add(rdbNam);
            groupBox1.Location = new Point(308, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(109, 23);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(192, 322);
            label12.Name = "label12";
            label12.Size = new Size(66, 17);
            label12.TabIndex = 1;
            label12.Text = "Mật khẩu";
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(308, 321);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(191, 23);
            txtMatkhau.TabIndex = 4;
            // 
            // cmbQuyen
            // 
            cmbQuyen.FormattingEnabled = true;
            cmbQuyen.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cmbQuyen.Location = new Point(72, 221);
            cmbQuyen.Name = "cmbQuyen";
            cmbQuyen.Size = new Size(94, 23);
            cmbQuyen.TabIndex = 10;
            // 
            // btnHienthi
            // 
            btnHienthi.Location = new Point(1, 417);
            btnHienthi.Name = "btnHienthi";
            btnHienthi.Size = new Size(98, 23);
            btnHienthi.TabIndex = 11;
            btnHienthi.Text = "Hiển thị tất cả";
            btnHienthi.UseVisualStyleBackColor = true;
            btnHienthi.Click += button1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(cmbQuyen);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dtpNgayvaolam);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(pbHinhanh);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtpNgaysinh);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtManv);
            groupBox2.Controls.Add(txtHoten);
            groupBox2.Controls.Add(txtSodienthoai);
            groupBox2.Controls.Add(txtDiachi);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtMatkhau);
            groupBox2.Location = new Point(16, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(521, 350);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Location = new Point(574, 61);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(234, 120);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Công Cụ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(821, 47);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dgvTTNV_CellContentClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTimkiem);
            groupBox4.Controls.Add(btnTimkienmanv);
            groupBox4.Location = new Point(598, 384);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(189, 56);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // frm_thongtinnv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 621);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnHienthi);
            Controls.Add(label8);
            Controls.Add(txtGhichu);
            Controls.Add(label);
            Controls.Add(dataGridView1);
            Controls.Add(dgvTTNV);
            Name = "frm_thongtinnv";
            Text = "ThongTinNhanVien";
            Load += frm_thongtinnv_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTTNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHinhanh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTTNV;
        private PictureBox pbHinhanh;
        private Label label8;
        private TextBox txtManv;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtHoten;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtSodienthoai;
        private TextBox txtDiachi;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private DateTimePicker dtpNgaysinh;
        private DateTimePicker dtpNgayvaolam;
        private Label label9;
        private Label label;
        private TextBox txtGhichu;
        private Label label10;
        private TextBox txtEmail;
        private TextBox txtTimkiem;
        private Button btnTimkienmanv;
        private Label label11;
        private GroupBox groupBox1;
        private Label label12;
        private TextBox txtMatkhau;
        private ComboBox cmbQuyen;
        private Button btnHienthi;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
    }
}