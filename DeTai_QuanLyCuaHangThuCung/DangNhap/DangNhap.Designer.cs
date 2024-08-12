namespace DeTai_QuanLyCuaHangThuCung.DangNhap
{
    partial class frm_DangNhap
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
            label3 = new Label();
            txtTendn = new TextBox();
            cmbQuyen = new ComboBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            listView1 = new ListView();
            txtMatkhau = new TextBox();
            btn_DangNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 129);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 0;
            label1.Text = "Quyền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(272, 186);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(322, 245);
            label3.Name = "label3";
            label3.Size = new Size(101, 30);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // txtTendn
            // 
            txtTendn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTendn.Location = new Point(447, 183);
            txtTendn.Name = "txtTendn";
            txtTendn.Size = new Size(185, 33);
            txtTendn.TabIndex = 2;
            // 
            // cmbQuyen
            // 
            cmbQuyen.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbQuyen.FormattingEnabled = true;
            cmbQuyen.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cmbQuyen.Location = new Point(447, 126);
            cmbQuyen.Name = "cmbQuyen";
            cmbQuyen.Size = new Size(185, 33);
            cmbQuyen.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 9);
            label4.Name = "label4";
            label4.Size = new Size(352, 40);
            label4.TabIndex = 0;
            label4.Text = "CỬA HÀNG MEOWSHOP";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ActiveCaption;
            listView1.Location = new Point(-2, -4);
            listView1.Name = "listView1";
            listView1.Size = new Size(702, 65);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatkhau.Location = new Point(447, 242);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '*';
            txtMatkhau.Size = new Size(185, 33);
            txtMatkhau.TabIndex = 2;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_DangNhap.Location = new Point(397, 299);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(156, 36);
            btn_DangNhap.TabIndex = 6;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // frm_DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(702, 353);
            Controls.Add(btn_DangNhap);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Controls.Add(cmbQuyen);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTendn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_DangNhap";
            Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTendn;
        private ComboBox cmbQuyen;
        private PictureBox pictureBox1;
        private Label label4;
        private ListView listView1;
        private TextBox txtMatkhau;
        private Button btn_DangNhap;
    }
}