using System.Drawing;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung
{
    partial class frmTTCN
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
            dataGridView1 = new DataGridView();
            dtpNgvl = new DateTimePicker();
            pbHinhanh = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtManv = new TextBox();
            txtHoten = new TextBox();
            txtSodienthoai = new TextBox();
            txtDiachi = new TextBox();
            txtEmail = new TextBox();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dtpNgsinh = new DateTimePicker();
            label9 = new Label();
            lbQuyen = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHinhanh).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 47);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 89);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 0;
            label2.Text = "Họ Tên";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1020, 72);
            dataGridView1.TabIndex = 1;
            // 
            // dtpNgvl
            // 
            dtpNgvl.Enabled = false;
            dtpNgvl.Location = new Point(157, 259);
            dtpNgvl.Margin = new Padding(3, 4, 3, 4);
            dtpNgvl.Name = "dtpNgvl";
            dtpNgvl.Size = new Size(228, 27);
            dtpNgvl.TabIndex = 2;
            // 
            // pbHinhanh
            // 
            pbHinhanh.BorderStyle = BorderStyle.FixedSingle;
            pbHinhanh.Location = new Point(775, 134);
            pbHinhanh.Margin = new Padding(3, 4, 3, 4);
            pbHinhanh.Name = "pbHinhanh";
            pbHinhanh.Size = new Size(216, 292);
            pbHinhanh.TabIndex = 3;
            pbHinhanh.TabStop = false;
            pbHinhanh.Click += pbHinhanh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 127);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 0;
            label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 172);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 0;
            label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 218);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 0;
            label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 263);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 0;
            label6.Text = "Ngày vào làm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(407, 45);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(407, 91);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 0;
            label8.Text = "Giới Tính";
            // 
            // txtManv
            // 
            txtManv.Enabled = false;
            txtManv.Location = new Point(157, 39);
            txtManv.Margin = new Padding(3, 4, 3, 4);
            txtManv.Name = "txtManv";
            txtManv.Size = new Size(228, 27);
            txtManv.TabIndex = 4;
            // 
            // txtHoten
            // 
            txtHoten.Enabled = false;
            txtHoten.Location = new Point(157, 84);
            txtHoten.Margin = new Padding(3, 4, 3, 4);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(228, 27);
            txtHoten.TabIndex = 4;
            // 
            // txtSodienthoai
            // 
            txtSodienthoai.Enabled = false;
            txtSodienthoai.Location = new Point(157, 125);
            txtSodienthoai.Margin = new Padding(3, 4, 3, 4);
            txtSodienthoai.Name = "txtSodienthoai";
            txtSodienthoai.Size = new Size(228, 27);
            txtSodienthoai.TabIndex = 4;
            // 
            // txtDiachi
            // 
            txtDiachi.Enabled = false;
            txtDiachi.Location = new Point(157, 171);
            txtDiachi.Margin = new Padding(3, 4, 3, 4);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(228, 27);
            txtDiachi.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(531, 39);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 27);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Enabled = false;
            rdbNam.Location = new Point(8, 16);
            rdbNam.Margin = new Padding(3, 4, 3, 4);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(62, 24);
            rdbNam.TabIndex = 5;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Enabled = false;
            rdbNu.Location = new Point(73, 16);
            rdbNu.Margin = new Padding(3, 4, 3, 4);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(50, 24);
            rdbNu.TabIndex = 5;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtHoten);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSodienthoai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtManv);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgsinh);
            groupBox1.Controls.Add(dtpNgvl);
            groupBox1.Location = new Point(14, 95);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(740, 331);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbNam);
            groupBox2.Controls.Add(rdbNu);
            groupBox2.Location = new Point(531, 74);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(135, 44);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // dtpNgsinh
            // 
            dtpNgsinh.Enabled = false;
            dtpNgsinh.Location = new Point(157, 218);
            dtpNgsinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgsinh.Name = "dtpNgsinh";
            dtpNgsinh.Size = new Size(228, 27);
            dtpNgsinh.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 192, 128);
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(408, 19);
            label9.Name = "label9";
            label9.Size = new Size(267, 32);
            label9.TabIndex = 0;
            label9.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // lbQuyen
            // 
            lbQuyen.AutoSize = true;
            lbQuyen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQuyen.Location = new Point(775, 107);
            lbQuyen.Name = "lbQuyen";
            lbQuyen.Size = new Size(92, 23);
            lbQuyen.TabIndex = 0;
            lbQuyen.Text = "Nhân Viên";
            // 
            // frmTTCN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 460);
            Controls.Add(pbHinhanh);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lbQuyen);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTTCN";
            Text = "ThongTinCaNhan";
            Load += ThongTinCaNhan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHinhanh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DateTimePicker dtpNgvl;
        private PictureBox pbHinhanh;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtManv;
        private TextBox txtHoten;
        private TextBox txtSodienthoai;
        private TextBox txtDiachi;
        private TextBox txtEmail;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private GroupBox groupBox1;
        private DateTimePicker dtpNgsinh;
        private GroupBox groupBox2;
        private Label label9;
        private Label lbQuyen;
    }
}