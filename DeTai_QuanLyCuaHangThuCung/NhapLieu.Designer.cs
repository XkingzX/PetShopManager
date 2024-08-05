namespace DeTai_QuanLyCuaHangThuCung
{
    partial class frm_NhapLieu
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
            txt_maSP = new TextBox();
            label2 = new Label();
            txt_giasp = new TextBox();
            label3 = new Label();
            txt_tensp = new TextBox();
            label4 = new Label();
            txt_loaisp = new TextBox();
            button1 = new Button();
            btn_luu = new Button();
            pictureBox1 = new PictureBox();
            btn_chonhinh = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // txt_maSP
            // 
            txt_maSP.Location = new Point(116, 6);
            txt_maSP.Name = "txt_maSP";
            txt_maSP.Size = new Size(206, 27);
            txt_maSP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 0;
            label2.Text = "Giá";
            // 
            // txt_giasp
            // 
            txt_giasp.Location = new Point(116, 104);
            txt_giasp.Name = "txt_giasp";
            txt_giasp.Size = new Size(206, 27);
            txt_giasp.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên sản phẩm";
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(116, 53);
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(206, 27);
            txt_tensp.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 0;
            label4.Text = "Loại";
            // 
            // txt_loaisp
            // 
            txt_loaisp.Location = new Point(116, 151);
            txt_loaisp.Name = "txt_loaisp";
            txt_loaisp.Size = new Size(206, 27);
            txt_loaisp.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(190, 203);
            button1.Name = "button1";
            button1.Size = new Size(104, 53);
            button1.TabIndex = 2;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(57, 203);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(104, 53);
            btn_luu.TabIndex = 2;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(359, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 172);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btn_chonhinh
            // 
            btn_chonhinh.Location = new Point(411, 203);
            btn_chonhinh.Name = "btn_chonhinh";
            btn_chonhinh.Size = new Size(94, 53);
            btn_chonhinh.TabIndex = 4;
            btn_chonhinh.Text = "Chọn hình";
            btn_chonhinh.UseVisualStyleBackColor = true;
            btn_chonhinh.Click += btn_chonhinh_Click;
            // 
            // frm_NhapLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 268);
            Controls.Add(btn_chonhinh);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btn_luu);
            Controls.Add(txt_loaisp);
            Controls.Add(label4);
            Controls.Add(txt_tensp);
            Controls.Add(label3);
            Controls.Add(txt_giasp);
            Controls.Add(label2);
            Controls.Add(txt_maSP);
            Controls.Add(label1);
            Name = "frm_NhapLieu";
            Text = "Nhập Dữ Liệu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_maSP;
        private Label label2;
        private TextBox txt_giasp;
        private Label label3;
        private TextBox txt_tensp;
        private Label label4;
        private TextBox txt_loaisp;
        private Button button1;
        private Button btn_luu;
        private PictureBox pictureBox1;
        private Button btn_chonhinh;
    }
}