namespace DeTai_QuanLyCuaHangThuCung
{
    partial class frm_NhapKho
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
            txt_maPK = new TextBox();
            label2 = new Label();
            txt_ngaynhap = new TextBox();
            label3 = new Label();
            txt_masp = new TextBox();
            label4 = new Label();
            txt_loaisp = new TextBox();
            button1 = new Button();
            btn_luu = new Button();
            lbl_mota = new Label();
            rtxt_mota = new RichTextBox();
            label5 = new Label();
            ckb_layngay = new CheckBox();
            label6 = new Label();
            txt_ngaynhaptudong = new TextBox();
            txt_nguoitao = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu kho";
            // 
            // txt_maPK
            // 
            txt_maPK.Location = new Point(137, 10);
            txt_maPK.Name = "txt_maPK";
            txt_maPK.Size = new Size(206, 27);
            txt_maPK.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 0;
            label2.Text = "Ngày nhập";
            // 
            // txt_ngaynhap
            // 
            txt_ngaynhap.Location = new Point(137, 104);
            txt_ngaynhap.Name = "txt_ngaynhap";
            txt_ngaynhap.Size = new Size(170, 27);
            txt_ngaynhap.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã sản phẩm";
            // 
            // txt_masp
            // 
            txt_masp.Location = new Point(137, 53);
            txt_masp.Name = "txt_masp";
            txt_masp.Size = new Size(206, 27);
            txt_masp.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 0;
            label4.Text = "Số lượng thực tế";
            // 
            // txt_loaisp
            // 
            txt_loaisp.Location = new Point(137, 151);
            txt_loaisp.Name = "txt_loaisp";
            txt_loaisp.Size = new Size(206, 27);
            txt_loaisp.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(239, 331);
            button1.Name = "button1";
            button1.Size = new Size(104, 53);
            button1.TabIndex = 2;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(129, 331);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(104, 53);
            btn_luu.TabIndex = 2;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // lbl_mota
            // 
            lbl_mota.AutoSize = true;
            lbl_mota.Location = new Point(12, 204);
            lbl_mota.Name = "lbl_mota";
            lbl_mota.Size = new Size(61, 20);
            lbl_mota.TabIndex = 5;
            lbl_mota.Text = "Ghi chú:";
            // 
            // rtxt_mota
            // 
            rtxt_mota.Location = new Point(137, 201);
            rtxt_mota.Name = "rtxt_mota";
            rtxt_mota.Size = new Size(206, 105);
            rtxt_mota.TabIndex = 6;
            rtxt_mota.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 13);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 0;
            label5.Text = "Người tạo";
            // 
            // ckb_layngay
            // 
            ckb_layngay.AutoSize = true;
            ckb_layngay.Location = new Point(316, 110);
            ckb_layngay.Name = "ckb_layngay";
            ckb_layngay.Size = new Size(18, 17);
            ckb_layngay.TabIndex = 7;
            ckb_layngay.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 60);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 0;
            label6.Text = "Ngày tạo";
            // 
            // txt_ngaynhaptudong
            // 
            txt_ngaynhaptudong.Location = new Point(438, 57);
            txt_ngaynhaptudong.Name = "txt_ngaynhaptudong";
            txt_ngaynhaptudong.Size = new Size(170, 27);
            txt_ngaynhaptudong.TabIndex = 1;
            // 
            // txt_nguoitao
            // 
            txt_nguoitao.Location = new Point(438, 10);
            txt_nguoitao.Name = "txt_nguoitao";
            txt_nguoitao.Size = new Size(170, 27);
            txt_nguoitao.TabIndex = 1;
            // 
            // frm_NhapKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 396);
            Controls.Add(ckb_layngay);
            Controls.Add(rtxt_mota);
            Controls.Add(lbl_mota);
            Controls.Add(button1);
            Controls.Add(btn_luu);
            Controls.Add(txt_loaisp);
            Controls.Add(label4);
            Controls.Add(txt_masp);
            Controls.Add(label3);
            Controls.Add(txt_nguoitao);
            Controls.Add(txt_ngaynhaptudong);
            Controls.Add(txt_ngaynhap);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txt_maPK);
            Controls.Add(label1);
            Name = "frm_NhapKho";
            Text = "Nhập Dữ Liệu";
            Load += frm_NhapKho_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_maPK;
        private Label label2;
        private TextBox txt_ngaynhap;
        private Label label3;
        private TextBox txt_masp;
        private Label label4;
        private TextBox txt_loaisp;
        private Button button1;
        private Button btn_luu;
        private Label lbl_mota;
        private RichTextBox rtxt_mota;
        private Label label5;
        private CheckBox ckb_layngay;
        private Label label6;
        private TextBox txt_ngaynhaptudong;
        private TextBox txt_nguoitao;
    }
}