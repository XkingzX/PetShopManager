using System.Drawing;
using System.Windows.Forms;

namespace DeTai_QuanLyCuaHangThuCung
{
    partial class frm_danhmuc
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
            this.dgv_danhmucsp = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gr_timkiem = new System.Windows.Forms.GroupBox();
            this.lbl_nhapma = new System.Windows.Forms.Label();
            this.lbl_nhomsp = new System.Windows.Forms.Label();
            this.cmb_nhomsp = new System.Windows.Forms.ComboBox();
            this.txt_nhapmasp = new System.Windows.Forms.TextBox();
            this.gr_hinhsp = new System.Windows.Forms.GroupBox();
            this.lbl_mota = new System.Windows.Forms.Label();
            this.lbl_motasp = new System.Windows.Forms.Label();
            this.ptr_hinhsanpham = new System.Windows.Forms.PictureBox();
            this.btn_insp = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.lbl_tongkho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhmucsp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gr_timkiem.SuspendLayout();
            this.gr_hinhsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_hinhsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_danhmucsp
            // 
            this.dgv_danhmucsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhmucsp.Location = new System.Drawing.Point(12, 122);
            this.dgv_danhmucsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_danhmucsp.Name = "dgv_danhmucsp";
            this.dgv_danhmucsp.RowHeadersWidth = 51;
            this.dgv_danhmucsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhmucsp.Size = new System.Drawing.Size(630, 229);
            this.dgv_danhmucsp.TabIndex = 0;
            this.dgv_danhmucsp.Click += new System.EventHandler(this.dgv_danhmucsp_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(116, 34);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 41);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(16, 34);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 41);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(216, 34);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 41);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Location = new System.Drawing.Point(319, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(323, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // gr_timkiem
            // 
            this.gr_timkiem.Controls.Add(this.lbl_nhapma);
            this.gr_timkiem.Controls.Add(this.lbl_nhomsp);
            this.gr_timkiem.Controls.Add(this.cmb_nhomsp);
            this.gr_timkiem.Controls.Add(this.txt_nhapmasp);
            this.gr_timkiem.Location = new System.Drawing.Point(12, 10);
            this.gr_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_timkiem.Name = "gr_timkiem";
            this.gr_timkiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_timkiem.Size = new System.Drawing.Size(250, 100);
            this.gr_timkiem.TabIndex = 8;
            this.gr_timkiem.TabStop = false;
            this.gr_timkiem.Text = "Tìm kiếm";
            // 
            // lbl_nhapma
            // 
            this.lbl_nhapma.AutoSize = true;
            this.lbl_nhapma.Location = new System.Drawing.Point(28, 16);
            this.lbl_nhapma.Name = "lbl_nhapma";
            this.lbl_nhapma.Size = new System.Drawing.Size(149, 16);
            this.lbl_nhapma.TabIndex = 7;
            this.lbl_nhapma.Text = "Nhập mã/ tên sản phẩm";
            // 
            // lbl_nhomsp
            // 
            this.lbl_nhomsp.AutoSize = true;
            this.lbl_nhomsp.Location = new System.Drawing.Point(28, 58);
            this.lbl_nhomsp.Name = "lbl_nhomsp";
            this.lbl_nhomsp.Size = new System.Drawing.Size(105, 16);
            this.lbl_nhomsp.TabIndex = 8;
            this.lbl_nhomsp.Text = "Nhóm sản phẩm";
            // 
            // cmb_nhomsp
            // 
            this.cmb_nhomsp.FormattingEnabled = true;
            this.cmb_nhomsp.Location = new System.Drawing.Point(28, 76);
            this.cmb_nhomsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_nhomsp.Name = "cmb_nhomsp";
            this.cmb_nhomsp.Size = new System.Drawing.Size(169, 24);
            this.cmb_nhomsp.TabIndex = 6;
            this.cmb_nhomsp.SelectedIndexChanged += new System.EventHandler(this.cmb_nhomsp_SelectedIndexChanged);
            // 
            // txt_nhapmasp
            // 
            this.txt_nhapmasp.Location = new System.Drawing.Point(28, 34);
            this.txt_nhapmasp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nhapmasp.Name = "txt_nhapmasp";
            this.txt_nhapmasp.Size = new System.Drawing.Size(169, 22);
            this.txt_nhapmasp.TabIndex = 5;
            this.txt_nhapmasp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nhapmasp_KeyDown);
            // 
            // gr_hinhsp
            // 
            this.gr_hinhsp.Controls.Add(this.lbl_mota);
            this.gr_hinhsp.Controls.Add(this.lbl_motasp);
            this.gr_hinhsp.Controls.Add(this.ptr_hinhsanpham);
            this.gr_hinhsp.Location = new System.Drawing.Point(659, 10);
            this.gr_hinhsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_hinhsp.Name = "gr_hinhsp";
            this.gr_hinhsp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gr_hinhsp.Size = new System.Drawing.Size(332, 269);
            this.gr_hinhsp.TabIndex = 9;
            this.gr_hinhsp.TabStop = false;
            this.gr_hinhsp.Text = "Hình ảnh sản phẩm";
            // 
            // lbl_mota
            // 
            this.lbl_mota.AutoSize = true;
            this.lbl_mota.Enabled = false;
            this.lbl_mota.Location = new System.Drawing.Point(69, 195);
            this.lbl_mota.Name = "lbl_mota";
            this.lbl_mota.Size = new System.Drawing.Size(0, 16);
            this.lbl_mota.TabIndex = 9;
            // 
            // lbl_motasp
            // 
            this.lbl_motasp.AutoSize = true;
            this.lbl_motasp.Location = new System.Drawing.Point(18, 195);
            this.lbl_motasp.Name = "lbl_motasp";
            this.lbl_motasp.Size = new System.Drawing.Size(46, 16);
            this.lbl_motasp.TabIndex = 8;
            this.lbl_motasp.Text = "Mô tả: ";
            // 
            // ptr_hinhsanpham
            // 
            this.ptr_hinhsanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptr_hinhsanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptr_hinhsanpham.Location = new System.Drawing.Point(18, 29);
            this.ptr_hinhsanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptr_hinhsanpham.Name = "ptr_hinhsanpham";
            this.ptr_hinhsanpham.Size = new System.Drawing.Size(295, 156);
            this.ptr_hinhsanpham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptr_hinhsanpham.TabIndex = 7;
            this.ptr_hinhsanpham.TabStop = false;
            // 
            // btn_insp
            // 
            this.btn_insp.Location = new System.Drawing.Point(836, 310);
            this.btn_insp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_insp.Name = "btn_insp";
            this.btn_insp.Size = new System.Drawing.Size(155, 41);
            this.btn_insp.TabIndex = 2;
            this.btn_insp.Text = "In mã sản phẩm";
            this.btn_insp.UseVisualStyleBackColor = true;
            this.btn_insp.Click += new System.EventHandler(this.btn_insp_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(659, 310);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(155, 41);
            this.btn_lammoi.TabIndex = 2;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Location = new System.Drawing.Point(659, 286);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(66, 16);
            this.lbl_soluong.TabIndex = 7;
            this.lbl_soluong.Text = "Số lượng: ";
            // 
            // lbl_tongkho
            // 
            this.lbl_tongkho.AutoSize = true;
            this.lbl_tongkho.Location = new System.Drawing.Point(836, 286);
            this.lbl_tongkho.Name = "lbl_tongkho";
            this.lbl_tongkho.Size = new System.Drawing.Size(70, 16);
            this.lbl_tongkho.TabIndex = 7;
            this.lbl_tongkho.Text = "Tổng kho: ";
            // 
            // frm_danhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 360);
            this.Controls.Add(this.lbl_tongkho);
            this.Controls.Add(this.lbl_soluong);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_insp);
            this.Controls.Add(this.gr_hinhsp);
            this.Controls.Add(this.gr_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_danhmucsp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_danhmuc";
            this.Text = "Danh Mục Sản Phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_danhmuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhmucsp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gr_timkiem.ResumeLayout(false);
            this.gr_timkiem.PerformLayout();
            this.gr_hinhsp.ResumeLayout(false);
            this.gr_hinhsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_hinhsanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_danhmucsp;
        private Button btn_xoa;
        private Button btn_them;
        private Button btn_sua;
        private GroupBox groupBox1;
        private GroupBox gr_timkiem;
        private Label lbl_nhapma;
        private Label lbl_nhomsp;
        private ComboBox cmb_nhomsp;
        private TextBox txt_nhapmasp;
        private GroupBox gr_hinhsp;
        private Label lbl_motasp;
        private PictureBox ptr_hinhsanpham;
        private Button btn_insp;
        private Label lbl_mota;
        private Button btn_lammoi;
        private Label lbl_soluong;
        private Label lbl_tongkho;
    }
}