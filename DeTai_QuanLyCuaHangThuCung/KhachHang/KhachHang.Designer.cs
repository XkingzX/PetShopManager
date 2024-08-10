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
            txtTimKiem = new TextBox();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            button1 = new Button();
            dgvThongTinKhachHang = new DataGridView();
            grbNguoiTao = new GroupBox();
            cbxNguoiTao = new ComboBox();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            grbNhomKH = new GroupBox();
            cbxNhomKhachHang = new ComboBox();
            lblKH = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinKhachHang).BeginInit();
            grbNguoiTao.SuspendLayout();
            groupBox1.SuspendLayout();
            grbNhomKH.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(267, 10);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(430, 27);
            txtTimKiem.TabIndex = 25;
            txtTimKiem.Text = "Nhập mã khách hàng";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(17, 382);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 66);
            groupBox2.TabIndex = 24;
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
            // 
            // btnSua
            // 
            btnSua.Location = new Point(9, 24);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(785, 8);
            button1.Name = "button1";
            button1.Size = new Size(178, 29);
            button1.TabIndex = 23;
            button1.Text = "Thêm Khách Hàng";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvThongTinKhachHang
            // 
            dgvThongTinKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongTinKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTinKhachHang.Location = new Point(267, 58);
            dgvThongTinKhachHang.Name = "dgvThongTinKhachHang";
            dgvThongTinKhachHang.RowHeadersWidth = 51;
            dgvThongTinKhachHang.Size = new Size(696, 390);
            dgvThongTinKhachHang.TabIndex = 22;
            // 
            // grbNguoiTao
            // 
            grbNguoiTao.BackColor = SystemColors.ControlLightLight;
            grbNguoiTao.Controls.Add(cbxNguoiTao);
            grbNguoiTao.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grbNguoiTao.Location = new Point(17, 282);
            grbNguoiTao.Margin = new Padding(3, 4, 3, 4);
            grbNguoiTao.Name = "grbNguoiTao";
            grbNguoiTao.Padding = new Padding(3, 4, 3, 4);
            grbNguoiTao.Size = new Size(229, 83);
            grbNguoiTao.TabIndex = 21;
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
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(17, 168);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 99);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngày Tạo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(8, 43);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 26);
            dateTimePicker1.TabIndex = 1;
            // 
            // grbNhomKH
            // 
            grbNhomKH.BackColor = SystemColors.ControlLightLight;
            grbNhomKH.Controls.Add(cbxNhomKhachHang);
            grbNhomKH.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grbNhomKH.Location = new Point(17, 58);
            grbNhomKH.Margin = new Padding(3, 4, 3, 4);
            grbNhomKH.Name = "grbNhomKH";
            grbNhomKH.Padding = new Padding(3, 4, 3, 4);
            grbNhomKH.Size = new Size(229, 92);
            grbNhomKH.TabIndex = 19;
            grbNhomKH.TabStop = false;
            grbNhomKH.Text = "Nhóm Khách Hàng";
            // 
            // cbxNhomKhachHang
            // 
            cbxNhomKhachHang.FormattingEnabled = true;
            cbxNhomKhachHang.Location = new Point(9, 39);
            cbxNhomKhachHang.Margin = new Padding(3, 4, 3, 4);
            cbxNhomKhachHang.Name = "cbxNhomKhachHang";
            cbxNhomKhachHang.Size = new Size(209, 27);
            cbxNhomKhachHang.TabIndex = 0;
            // 
            // lblKH
            // 
            lblKH.AutoSize = true;
            lblKH.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblKH.Location = new Point(11, 13);
            lblKH.Name = "lblKH";
            lblKH.Size = new Size(147, 32);
            lblKH.TabIndex = 18;
            lblKH.Text = "Khách Hàng";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(985, 455);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(dgvThongTinKhachHang);
            Controls.Add(grbNguoiTao);
            Controls.Add(groupBox1);
            Controls.Add(grbNhomKH);
            Controls.Add(lblKH);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmKhachHang";
            Text = "KhachHang";
            Load += KhachHang_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongTinKhachHang).EndInit();
            grbNguoiTao.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            grbNhomKH.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbxTimKiem;
        private TextBox txtTimKiem;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnSua;
        private Button button1;
        private DataGridView dgvThongTinKhachHang;
        private GroupBox grbNguoiTao;
        private ComboBox cbxNguoiTao;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox grbNhomKH;
        private ComboBox cbxNhomKhachHang;
        private Label lblKH;
    }
}