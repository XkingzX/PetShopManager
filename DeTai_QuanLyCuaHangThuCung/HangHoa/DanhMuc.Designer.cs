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
            dgv_danhmucsp = new DataGridView();
            btn_xoa = new Button();
            btn_them = new Button();
            btn_sua = new Button();
            groupBox1 = new GroupBox();
            gr_timkiem = new GroupBox();
            lbl_nhapma = new Label();
            lbl_nhomsp = new Label();
            cmb_nhomsp = new ComboBox();
            txt_nhapmasp = new TextBox();
            gr_hinhsp = new GroupBox();
            lbl_motasp = new Label();
            ptr_hinhsanpham = new PictureBox();
            btn_insp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_danhmucsp).BeginInit();
            groupBox1.SuspendLayout();
            gr_timkiem.SuspendLayout();
            gr_hinhsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptr_hinhsanpham).BeginInit();
            SuspendLayout();
            // 
            // dgv_danhmucsp
            // 
            dgv_danhmucsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhmucsp.Location = new Point(12, 152);
            dgv_danhmucsp.Name = "dgv_danhmucsp";
            dgv_danhmucsp.RowHeadersWidth = 51;
            dgv_danhmucsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_danhmucsp.Size = new Size(630, 286);
            dgv_danhmucsp.TabIndex = 0;
            dgv_danhmucsp.Click += dgv_danhmucsp_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(116, 42);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 51);
            btn_xoa.TabIndex = 1;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(16, 42);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 51);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(216, 42);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 51);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(btn_xoa);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Location = new Point(319, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 125);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Công cụ";
            // 
            // gr_timkiem
            // 
            gr_timkiem.Controls.Add(lbl_nhapma);
            gr_timkiem.Controls.Add(lbl_nhomsp);
            gr_timkiem.Controls.Add(cmb_nhomsp);
            gr_timkiem.Controls.Add(txt_nhapmasp);
            gr_timkiem.Location = new Point(12, 12);
            gr_timkiem.Name = "gr_timkiem";
            gr_timkiem.Size = new Size(250, 125);
            gr_timkiem.TabIndex = 8;
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
            // cmb_nhomsp
            // 
            cmb_nhomsp.FormattingEnabled = true;
            cmb_nhomsp.Location = new Point(28, 95);
            cmb_nhomsp.Name = "cmb_nhomsp";
            cmb_nhomsp.Size = new Size(169, 28);
            cmb_nhomsp.TabIndex = 6;
            // 
            // txt_nhapmasp
            // 
            txt_nhapmasp.Location = new Point(28, 43);
            txt_nhapmasp.Name = "txt_nhapmasp";
            txt_nhapmasp.Size = new Size(169, 27);
            txt_nhapmasp.TabIndex = 5;
            // 
            // gr_hinhsp
            // 
            gr_hinhsp.Controls.Add(lbl_motasp);
            gr_hinhsp.Controls.Add(ptr_hinhsanpham);
            gr_hinhsp.Location = new Point(659, 12);
            gr_hinhsp.Name = "gr_hinhsp";
            gr_hinhsp.Size = new Size(332, 344);
            gr_hinhsp.TabIndex = 9;
            gr_hinhsp.TabStop = false;
            gr_hinhsp.Text = "Hình ảnh sản phẩm";
            // 
            // lbl_motasp
            // 
            lbl_motasp.AutoSize = true;
            lbl_motasp.Location = new Point(18, 244);
            lbl_motasp.Name = "lbl_motasp";
            lbl_motasp.Size = new Size(55, 20);
            lbl_motasp.TabIndex = 8;
            lbl_motasp.Text = "Mô tả: ";
            // 
            // ptr_hinhsanpham
            // 
            ptr_hinhsanpham.BackgroundImageLayout = ImageLayout.None;
            ptr_hinhsanpham.BorderStyle = BorderStyle.FixedSingle;
            ptr_hinhsanpham.Location = new Point(18, 36);
            ptr_hinhsanpham.Name = "ptr_hinhsanpham";
            ptr_hinhsanpham.Size = new Size(295, 195);
            ptr_hinhsanpham.SizeMode = PictureBoxSizeMode.Zoom;
            ptr_hinhsanpham.TabIndex = 7;
            ptr_hinhsanpham.TabStop = false;
            // 
            // btn_insp
            // 
            btn_insp.Location = new Point(743, 377);
            btn_insp.Name = "btn_insp";
            btn_insp.Size = new Size(155, 51);
            btn_insp.TabIndex = 2;
            btn_insp.Text = "In mã sản phẩm";
            btn_insp.UseVisualStyleBackColor = true;
            // 
            // frm_danhmuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1018, 450);
            Controls.Add(btn_insp);
            Controls.Add(gr_hinhsp);
            Controls.Add(gr_timkiem);
            Controls.Add(groupBox1);
            Controls.Add(dgv_danhmucsp);
            Name = "frm_danhmuc";
            Text = "Danh Mục Sản Phẩm";
            WindowState = FormWindowState.Maximized;
            Load += frm_danhmuc_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_danhmucsp).EndInit();
            groupBox1.ResumeLayout(false);
            gr_timkiem.ResumeLayout(false);
            gr_timkiem.PerformLayout();
            gr_hinhsp.ResumeLayout(false);
            gr_hinhsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptr_hinhsanpham).EndInit();
            ResumeLayout(false);
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
    }
}