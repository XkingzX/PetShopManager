using System.Drawing;
using System.Windows.Forms;

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
            label3 = new Label();
            txt_masp = new TextBox();
            label4 = new Label();
            txt_soluongtt = new TextBox();
            button1 = new Button();
            btn_luu = new Button();
            lbl_mota = new Label();
            rtxt_ghichu = new RichTextBox();
            label5 = new Label();
            ckb_layngay = new CheckBox();
            label6 = new Label();
            txt_ngaynhaptudong = new TextBox();
            dtp_ngaynhap = new DateTimePicker();
            cmb_nguoitao = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu kho";
            // 
            // txt_maPK
            // 
            txt_maPK.Location = new Point(120, 8);
            txt_maPK.Margin = new Padding(3, 2, 3, 2);
            txt_maPK.Name = "txt_maPK";
            txt_maPK.Size = new Size(181, 23);
            txt_maPK.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 80);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "Ngày nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 45);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 0;
            label3.Text = "Mã sản phẩm";
            // 
            // txt_masp
            // 
            txt_masp.Location = new Point(120, 40);
            txt_masp.Margin = new Padding(3, 2, 3, 2);
            txt_masp.Name = "txt_masp";
            txt_masp.Size = new Size(181, 23);
            txt_masp.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 118);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 0;
            label4.Text = "Số lượng thực tế";
            // 
            // txt_soluongtt
            // 
            txt_soluongtt.Location = new Point(120, 113);
            txt_soluongtt.Margin = new Padding(3, 2, 3, 2);
            txt_soluongtt.Name = "txt_soluongtt";
            txt_soluongtt.Size = new Size(181, 23);
            txt_soluongtt.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(209, 248);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(91, 40);
            button1.TabIndex = 2;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(113, 248);
            btn_luu.Margin = new Padding(3, 2, 3, 2);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(91, 40);
            btn_luu.TabIndex = 2;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // lbl_mota
            // 
            lbl_mota.AutoSize = true;
            lbl_mota.Location = new Point(10, 153);
            lbl_mota.Name = "lbl_mota";
            lbl_mota.Size = new Size(51, 15);
            lbl_mota.TabIndex = 5;
            lbl_mota.Text = "Ghi chú:";
            // 
            // rtxt_ghichu
            // 
            rtxt_ghichu.Location = new Point(120, 151);
            rtxt_ghichu.Margin = new Padding(3, 2, 3, 2);
            rtxt_ghichu.Name = "rtxt_ghichu";
            rtxt_ghichu.Size = new Size(181, 80);
            rtxt_ghichu.TabIndex = 6;
            rtxt_ghichu.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(313, 10);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 0;
            label5.Text = "Người tạo";
            // 
            // ckb_layngay
            // 
            ckb_layngay.AutoSize = true;
            ckb_layngay.Location = new Point(276, 82);
            ckb_layngay.Margin = new Padding(3, 2, 3, 2);
            ckb_layngay.Name = "ckb_layngay";
            ckb_layngay.Size = new Size(15, 14);
            ckb_layngay.TabIndex = 7;
            ckb_layngay.UseVisualStyleBackColor = true;
            ckb_layngay.CheckedChanged += ckb_layngay_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(313, 45);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 0;
            label6.Text = "Ngày tạo";
            // 
            // txt_ngaynhaptudong
            // 
            txt_ngaynhaptudong.Location = new Point(383, 43);
            txt_ngaynhaptudong.Margin = new Padding(3, 2, 3, 2);
            txt_ngaynhaptudong.Name = "txt_ngaynhaptudong";
            txt_ngaynhaptudong.Size = new Size(149, 23);
            txt_ngaynhaptudong.TabIndex = 1;
            // 
            // dtp_ngaynhap
            // 
            dtp_ngaynhap.Location = new Point(120, 76);
            dtp_ngaynhap.Name = "dtp_ngaynhap";
            dtp_ngaynhap.Size = new Size(152, 23);
            dtp_ngaynhap.TabIndex = 8;
            // 
            // cmb_nguoitao
            // 
            cmb_nguoitao.FormattingEnabled = true;
            cmb_nguoitao.Location = new Point(383, 8);
            cmb_nguoitao.Margin = new Padding(3, 2, 3, 2);
            cmb_nguoitao.Name = "cmb_nguoitao";
            cmb_nguoitao.Size = new Size(149, 23);
            cmb_nguoitao.TabIndex = 9;
            cmb_nguoitao.SelectedIndexChanged += cmb_nguoitao_SelectedIndexChanged;
            // 
            // frm_NhapKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 297);
            Controls.Add(cmb_nguoitao);
            Controls.Add(dtp_ngaynhap);
            Controls.Add(ckb_layngay);
            Controls.Add(rtxt_ghichu);
            Controls.Add(lbl_mota);
            Controls.Add(button1);
            Controls.Add(btn_luu);
            Controls.Add(txt_soluongtt);
            Controls.Add(label4);
            Controls.Add(txt_masp);
            Controls.Add(label3);
            Controls.Add(txt_ngaynhaptudong);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txt_maPK);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label3;
        private TextBox txt_masp;
        private Label label4;
        private TextBox txt_soluongtt;
        private Button button1;
        private Button btn_luu;
        private Label lbl_mota;
        private RichTextBox rtxt_ghichu;
        private Label label5;
        private CheckBox ckb_layngay;
        private Label label6;
        private TextBox txt_ngaynhaptudong;
        private DateTimePicker dtp_ngaynhap;
        private ComboBox cmb_nguoitao;
    }
}