using System.Drawing;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung.HangHoa
{
    partial class frm_KiemKho
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
            this.dgv_kiemkho = new System.Windows.Forms.DataGridView();
            this.gr_timkiem = new System.Windows.Forms.GroupBox();
            this.lbl_nhapma = new System.Windows.Forms.Label();
            this.lbl_nhomsp = new System.Windows.Forms.Label();
            this.txt_ngaynhap = new System.Windows.Forms.TextBox();
            this.txt_nhapmapk = new System.Windows.Forms.TextBox();
            this.gr_congcu = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.gr_thongtin = new System.Windows.Forms.GroupBox();
            this.lbl_nguoitao = new System.Windows.Forms.Label();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.txt_nguoitao = new System.Windows.Forms.TextBox();
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kiemkho)).BeginInit();
            this.gr_timkiem.SuspendLayout();
            this.gr_congcu.SuspendLayout();
            this.gr_thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_kiemkho
            // 
            this.dgv_kiemkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kiemkho.Location = new System.Drawing.Point(12, 122);
            this.dgv_kiemkho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_kiemkho.Name = "dgv_kiemkho";
            this.dgv_kiemkho.RowHeadersWidth = 51;
            this.dgv_kiemkho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kiemkho.Size = new System.Drawing.Size(978, 229);
            this.dgv_kiemkho.TabIndex = 9;
            this.dgv_kiemkho.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_kiemkho_CellFormatting);
            this.dgv_kiemkho.Click += new System.EventHandler(this.dgv_kiemkho_Click);
            // 
            // gr_timkiem
            // 
            this.gr_timkiem.Controls.Add(this.lbl_nhapma);
            this.gr_timkiem.Controls.Add(this.lbl_nhomsp);
            this.gr_timkiem.Controls.Add(this.txt_ngaynhap);
            this.gr_timkiem.Controls.Add(this.txt_nhapmapk);
            this.gr_timkiem.Location = new System.Drawing.Point(12, 10);
            this.gr_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_timkiem.Name = "gr_timkiem";
            this.gr_timkiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_timkiem.Size = new System.Drawing.Size(250, 100);
            this.gr_timkiem.TabIndex = 11;
            this.gr_timkiem.TabStop = false;
            this.gr_timkiem.Text = "Tìm kiếm";
            // 
            // lbl_nhapma
            // 
            this.lbl_nhapma.AutoSize = true;
            this.lbl_nhapma.Location = new System.Drawing.Point(28, 16);
            this.lbl_nhapma.Name = "lbl_nhapma";
            this.lbl_nhapma.Size = new System.Drawing.Size(119, 16);
            this.lbl_nhapma.TabIndex = 7;
            this.lbl_nhapma.Text = "Nhập mã kiểm kho";
            // 
            // lbl_nhomsp
            // 
            this.lbl_nhomsp.AutoSize = true;
            this.lbl_nhomsp.Location = new System.Drawing.Point(28, 58);
            this.lbl_nhomsp.Name = "lbl_nhomsp";
            this.lbl_nhomsp.Size = new System.Drawing.Size(73, 16);
            this.lbl_nhomsp.TabIndex = 8;
            this.lbl_nhomsp.Text = "Ngày nhập";
            // 
            // txt_ngaynhap
            // 
            this.txt_ngaynhap.Location = new System.Drawing.Point(28, 78);
            this.txt_ngaynhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ngaynhap.Name = "txt_ngaynhap";
            this.txt_ngaynhap.Size = new System.Drawing.Size(169, 22);
            this.txt_ngaynhap.TabIndex = 5;
            // 
            // txt_nhapmapk
            // 
            this.txt_nhapmapk.Location = new System.Drawing.Point(28, 34);
            this.txt_nhapmapk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nhapmapk.Name = "txt_nhapmapk";
            this.txt_nhapmapk.Size = new System.Drawing.Size(169, 22);
            this.txt_nhapmapk.TabIndex = 5;
            // 
            // gr_congcu
            // 
            this.gr_congcu.Controls.Add(this.btn_lammoi);
            this.gr_congcu.Controls.Add(this.btn_them);
            this.gr_congcu.Controls.Add(this.btn_xoa);
            this.gr_congcu.Controls.Add(this.btn_sua);
            this.gr_congcu.Location = new System.Drawing.Point(319, 10);
            this.gr_congcu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_congcu.Name = "gr_congcu";
            this.gr_congcu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_congcu.Size = new System.Drawing.Size(323, 100);
            this.gr_congcu.TabIndex = 10;
            this.gr_congcu.TabStop = false;
            this.gr_congcu.Text = "Công cụ";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(116, 69);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(94, 26);
            this.btn_lammoi.TabIndex = 13;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(16, 23);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 41);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(116, 23);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 41);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(216, 23);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 41);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // gr_thongtin
            // 
            this.gr_thongtin.Controls.Add(this.lbl_nguoitao);
            this.gr_thongtin.Controls.Add(this.lbl_trangthai);
            this.gr_thongtin.Controls.Add(this.txt_nguoitao);
            this.gr_thongtin.Controls.Add(this.txt_trangthai);
            this.gr_thongtin.Location = new System.Drawing.Point(684, 10);
            this.gr_thongtin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_thongtin.Name = "gr_thongtin";
            this.gr_thongtin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_thongtin.Size = new System.Drawing.Size(306, 100);
            this.gr_thongtin.TabIndex = 12;
            this.gr_thongtin.TabStop = false;
            this.gr_thongtin.Text = "Thông tin";
            // 
            // lbl_nguoitao
            // 
            this.lbl_nguoitao.AutoSize = true;
            this.lbl_nguoitao.Location = new System.Drawing.Point(21, 58);
            this.lbl_nguoitao.Name = "lbl_nguoitao";
            this.lbl_nguoitao.Size = new System.Drawing.Size(68, 16);
            this.lbl_nguoitao.TabIndex = 7;
            this.lbl_nguoitao.Text = "Người tạo:";
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Location = new System.Drawing.Point(21, 23);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(73, 16);
            this.lbl_trangthai.TabIndex = 7;
            this.lbl_trangthai.Text = "Trạng thái: ";
            // 
            // txt_nguoitao
            // 
            this.txt_nguoitao.Location = new System.Drawing.Point(107, 56);
            this.txt_nguoitao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nguoitao.Name = "txt_nguoitao";
            this.txt_nguoitao.Size = new System.Drawing.Size(169, 22);
            this.txt_nguoitao.TabIndex = 5;
            this.txt_nguoitao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trangthai.ForeColor = System.Drawing.Color.Red;
            this.txt_trangthai.Location = new System.Drawing.Point(109, 21);
            this.txt_trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_trangthai.Size = new System.Drawing.Size(169, 28);
            this.txt_trangthai.TabIndex = 5;
            this.txt_trangthai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_KiemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 360);
            this.Controls.Add(this.gr_thongtin);
            this.Controls.Add(this.gr_timkiem);
            this.Controls.Add(this.gr_congcu);
            this.Controls.Add(this.dgv_kiemkho);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_KiemKho";
            this.Text = "Kiểm Kho";
            this.Load += new System.EventHandler(this.frm_KiemKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kiemkho)).EndInit();
            this.gr_timkiem.ResumeLayout(false);
            this.gr_timkiem.PerformLayout();
            this.gr_congcu.ResumeLayout(false);
            this.gr_thongtin.ResumeLayout(false);
            this.gr_thongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgv_kiemkho;
        private GroupBox gr_timkiem;
        private Label lbl_nhapma;
        private Label lbl_nhomsp;
        private TextBox txt_nhapmapk;
        private GroupBox gr_congcu;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private GroupBox gr_thongtin;
        private Label lbl_trangthai;
        private Label lbl_nguoitao;
        private TextBox txt_nguoitao;
        private TextBox txt_trangthai;
        private TextBox txt_ngaynhap;
        private Button btn_lammoi;
    }
}