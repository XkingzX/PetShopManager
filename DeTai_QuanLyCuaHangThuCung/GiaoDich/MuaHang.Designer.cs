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
            panel1 = new Panel();
            btn_xoa = new Button();
            btn_them = new Button();
            lbl_mahd = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            txt_ghichu = new RichTextBox();
            btn_thanhtoan = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dgv_giohang = new DataGridView();
            col_tensp = new DataGridViewTextBoxColumn();
            col_soluong = new DataGridViewTextBoxColumn();
            col_dongia = new DataGridViewTextBoxColumn();
            col_thanhtien = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            cmb_loai = new ComboBox();
            cmb_ma = new ComboBox();
            txt_diem = new TextBox();
            txt_hoten = new TextBox();
            txt_sdt = new TextBox();
            txt_diachi = new TextBox();
            label13 = new Label();
            label7 = new Label();
            label5 = new Label();
            label12 = new Label();
            label6 = new Label();
            label4 = new Label();
            txt_nhapmasp = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_giohang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txt_nhapmasp);
            panel1.Controls.Add(btn_xoa);
            panel1.Controls.Add(btn_them);
            panel1.Controls.Add(lbl_mahd);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 59);
            panel1.TabIndex = 0;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(804, 22);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(75, 23);
            btn_xoa.TabIndex = 5;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(714, 22);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(75, 23);
            btn_them.TabIndex = 5;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // lbl_mahd
            // 
            lbl_mahd.AutoSize = true;
            lbl_mahd.Location = new Point(101, 26);
            lbl_mahd.Name = "lbl_mahd";
            lbl_mahd.Size = new Size(84, 15);
            lbl_mahd.TabIndex = 0;
            lbl_mahd.Text = "Mã đơn hàng: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã đơn hàng: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(924, 54);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(330, 9);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 0;
            label3.Text = "Giỏ Hàng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(txt_ghichu);
            panel3.Controls.Add(btn_thanhtoan);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(695, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 346);
            panel3.TabIndex = 3;
            // 
            // txt_ghichu
            // 
            txt_ghichu.Location = new Point(19, 228);
            txt_ghichu.Name = "txt_ghichu";
            txt_ghichu.Size = new Size(198, 59);
            txt_ghichu.TabIndex = 5;
            txt_ghichu.Text = "Ghi chú";
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Location = new Point(19, 293);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(198, 42);
            btn_thanhtoan.TabIndex = 4;
            btn_thanhtoan.Text = "Thanh toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 192);
            label11.Name = "label11";
            label11.Size = new Size(95, 15);
            label11.TabIndex = 2;
            label11.Text = "Tổng thanh toán";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 133);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 2;
            label10.Text = "Giảm giá";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 78);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 2;
            label9.Text = "Thuế";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 27);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 2;
            label8.Text = "Tổng tiền hàng";
            // 
            // dgv_giohang
            // 
            dgv_giohang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_giohang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_giohang.Columns.AddRange(new DataGridViewColumn[] { col_tensp, col_soluong, col_dongia, col_thanhtien });
            dgv_giohang.Location = new Point(12, 214);
            dgv_giohang.Name = "dgv_giohang";
            dgv_giohang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_giohang.Size = new Size(677, 235);
            dgv_giohang.TabIndex = 4;
            // 
            // col_tensp
            // 
            col_tensp.HeaderText = "Tên sản phẩm";
            col_tensp.Name = "col_tensp";
            // 
            // col_soluong
            // 
            col_soluong.HeaderText = "Số lượng";
            col_soluong.Name = "col_soluong";
            // 
            // col_dongia
            // 
            col_dongia.HeaderText = "Đơn giá";
            col_dongia.Name = "col_dongia";
            // 
            // col_thanhtien
            // 
            col_thanhtien.HeaderText = "Thành tiền";
            col_thanhtien.Name = "col_thanhtien";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmb_loai);
            groupBox1.Controls.Add(cmb_ma);
            groupBox1.Controls.Add(txt_diem);
            groupBox1.Controls.Add(txt_hoten);
            groupBox1.Controls.Add(txt_sdt);
            groupBox1.Controls.Add(txt_diachi);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // cmb_loai
            // 
            cmb_loai.FormattingEnabled = true;
            cmb_loai.Location = new Point(95, 29);
            cmb_loai.Name = "cmb_loai";
            cmb_loai.Size = new Size(129, 23);
            cmb_loai.TabIndex = 2;
            // 
            // cmb_ma
            // 
            cmb_ma.FormattingEnabled = true;
            cmb_ma.Location = new Point(95, 66);
            cmb_ma.Name = "cmb_ma";
            cmb_ma.Size = new Size(129, 23);
            cmb_ma.TabIndex = 2;
            // 
            // txt_diem
            // 
            txt_diem.Location = new Point(518, 69);
            txt_diem.Name = "txt_diem";
            txt_diem.Size = new Size(152, 23);
            txt_diem.TabIndex = 1;
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(318, 29);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(117, 23);
            txt_hoten.TabIndex = 1;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(318, 69);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(117, 23);
            txt_sdt.TabIndex = 1;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(518, 24);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(152, 23);
            txt_diachi.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(441, 73);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 0;
            label13.Text = "Điểm thưởng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(441, 32);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 0;
            label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 32);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 0;
            label5.Text = "Tên khách hàng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1, 32);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 0;
            label12.Text = "Loại khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 72);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 0;
            label6.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 69);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 0;
            label4.Text = "Mã khách hàng";
            // 
            // txt_nhapmasp
            // 
            txt_nhapmasp.Location = new Point(453, 18);
            txt_nhapmasp.Name = "txt_nhapmasp";
            txt_nhapmasp.Size = new Size(100, 23);
            txt_nhapmasp.TabIndex = 6;
            // 
            // MuaHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgv_giohang);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MuaHang";
            Text = "MuaHang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_giohang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private Label label9;
        private DataGridView dgv_giohang;
        private DataGridViewTextBoxColumn col_tensp;
        private DataGridViewTextBoxColumn col_soluong;
        private DataGridViewTextBoxColumn col_dongia;
        private DataGridViewTextBoxColumn col_thanhtien;
        private Button btn_xoa;
        private Button btn_them;
        private GroupBox groupBox1;
        private ComboBox cmb_loai;
        private ComboBox cmb_ma;
        private TextBox txt_diem;
        private TextBox txt_hoten;
        private TextBox txt_sdt;
        private TextBox txt_diachi;
        private Label label13;
        private Label label7;
        private Label label5;
        private Label label12;
        private Label label6;
        private Label label4;
        private RichTextBox txt_ghichu;
        private TextBox txt_nhapmasp;
    }
}