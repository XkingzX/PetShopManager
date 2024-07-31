﻿namespace DeTai_QuanLyCuaHangThuCung.GiaoDich
{
    partial class frm_hoadon
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
            gr_timkiem = new GroupBox();
            lbl_nhapma = new Label();
            lbl_nhomsp = new Label();
            cmb_tencsdl = new ComboBox();
            txt_nhapmasp = new TextBox();
            groupBox1 = new GroupBox();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            dgv_danhmucsp = new DataGridView();
            masp = new DataGridViewTextBoxColumn();
            tensp = new DataGridViewTextBoxColumn();
            gia = new DataGridViewTextBoxColumn();
            soluong = new DataGridViewTextBoxColumn();
            loai = new DataGridViewTextBoxColumn();
            gr_timkiem.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhmucsp).BeginInit();
            SuspendLayout();
            // 
            // gr_timkiem
            // 
            gr_timkiem.Controls.Add(lbl_nhapma);
            gr_timkiem.Controls.Add(lbl_nhomsp);
            gr_timkiem.Controls.Add(cmb_tencsdl);
            gr_timkiem.Controls.Add(txt_nhapmasp);
            gr_timkiem.Location = new Point(12, 12);
            gr_timkiem.Name = "gr_timkiem";
            gr_timkiem.Size = new Size(250, 125);
            gr_timkiem.TabIndex = 11;
            gr_timkiem.TabStop = false;
            gr_timkiem.Text = "Tìm kiếm";
            // 
            // lbl_nhapma
            // 
            lbl_nhapma.AutoSize = true;
            lbl_nhapma.Location = new Point(28, 20);
            lbl_nhapma.Name = "lbl_nhapma";
            lbl_nhapma.Size = new Size(169, 20);
            lbl_nhapma.TabIndex = 7;
            lbl_nhapma.Text = "Nhập mã/ tên sản phẩm";
            // 
            // lbl_nhomsp
            // 
            lbl_nhomsp.AutoSize = true;
            lbl_nhomsp.Location = new Point(28, 73);
            lbl_nhomsp.Name = "lbl_nhomsp";
            lbl_nhomsp.Size = new Size(118, 20);
            lbl_nhomsp.TabIndex = 8;
            lbl_nhomsp.Text = "Nhóm sản phẩm";
            // 
            // cmb_tencsdl
            // 
            cmb_tencsdl.FormattingEnabled = true;
            cmb_tencsdl.Location = new Point(28, 95);
            cmb_tencsdl.Name = "cmb_tencsdl";
            cmb_tencsdl.Size = new Size(169, 28);
            cmb_tencsdl.TabIndex = 6;
            // 
            // txt_nhapmasp
            // 
            txt_nhapmasp.Location = new Point(28, 43);
            txt_nhapmasp.Name = "txt_nhapmasp";
            txt_nhapmasp.Size = new Size(169, 27);
            txt_nhapmasp.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(btn_xoa);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Location = new Point(319, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 125);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Công cụ";
            // 
            // btn_them
            // 
            btn_them.Location = new Point(16, 42);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 51);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(116, 42);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 51);
            btn_xoa.TabIndex = 1;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(216, 42);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 51);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // dgv_danhmucsp
            // 
            dgv_danhmucsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhmucsp.Columns.AddRange(new DataGridViewColumn[] { masp, tensp, gia, soluong, loai });
            dgv_danhmucsp.Location = new Point(12, 152);
            dgv_danhmucsp.Name = "dgv_danhmucsp";
            dgv_danhmucsp.RowHeadersWidth = 51;
            dgv_danhmucsp.Size = new Size(776, 286);
            dgv_danhmucsp.TabIndex = 9;
            // 
            // masp
            // 
            masp.HeaderText = "Mã Sản Phẩm";
            masp.MinimumWidth = 6;
            masp.Name = "masp";
            masp.Width = 125;
            // 
            // tensp
            // 
            tensp.HeaderText = "Tên Sản Phẩm";
            tensp.MinimumWidth = 6;
            tensp.Name = "tensp";
            tensp.Width = 125;
            // 
            // gia
            // 
            gia.HeaderText = "Giá";
            gia.MinimumWidth = 6;
            gia.Name = "gia";
            gia.Width = 125;
            // 
            // soluong
            // 
            soluong.HeaderText = "Số lượng";
            soluong.MinimumWidth = 6;
            soluong.Name = "soluong";
            soluong.Width = 125;
            // 
            // loai
            // 
            loai.HeaderText = "Loại Sản Phẩm";
            loai.MinimumWidth = 6;
            loai.Name = "loai";
            loai.Width = 125;
            // 
            // frm_hoadon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gr_timkiem);
            Controls.Add(groupBox1);
            Controls.Add(dgv_danhmucsp);
            Name = "frm_hoadon";
            Text = "Hóa Đơn";
            gr_timkiem.ResumeLayout(false);
            gr_timkiem.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_danhmucsp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gr_timkiem;
        private Label lbl_nhapma;
        private Label lbl_nhomsp;
        private ComboBox cmb_tencsdl;
        private TextBox txt_nhapmasp;
        private GroupBox groupBox1;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private DataGridView dgv_danhmucsp;
        private DataGridViewTextBoxColumn masp;
        private DataGridViewTextBoxColumn tensp;
        private DataGridViewTextBoxColumn gia;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn loai;
    }
}