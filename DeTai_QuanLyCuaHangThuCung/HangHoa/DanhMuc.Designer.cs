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
            txt_nhapmasp = new TextBox();
            cmb_tencsdl = new ComboBox();
            lbl_nhomsp = new Label();
            lbl_tensp = new Label();
            lbl_nhapma = new Label();
            ptr_hinhsanpham = new PictureBox();
            lbl_motasp = new Label();
            masp = new DataGridViewTextBoxColumn();
            tensp = new DataGridViewTextBoxColumn();
            gia = new DataGridViewTextBoxColumn();
            soluong = new DataGridViewTextBoxColumn();
            loai = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_danhmucsp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptr_hinhsanpham).BeginInit();
            SuspendLayout();
            // 
            // dgv_danhmucsp
            // 
            dgv_danhmucsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhmucsp.Columns.AddRange(new DataGridViewColumn[] { masp, tensp, gia, soluong, loai });
            dgv_danhmucsp.Location = new Point(12, 152);
            dgv_danhmucsp.Name = "dgv_danhmucsp";
            dgv_danhmucsp.RowHeadersWidth = 51;
            dgv_danhmucsp.Size = new Size(630, 286);
            dgv_danhmucsp.TabIndex = 0;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(774, 390);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(110, 48);
            btn_xoa.TabIndex = 1;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(658, 390);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(110, 48);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(890, 390);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(110, 48);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // txt_nhapmasp
            // 
            txt_nhapmasp.Location = new Point(31, 32);
            txt_nhapmasp.Name = "txt_nhapmasp";
            txt_nhapmasp.Size = new Size(202, 27);
            txt_nhapmasp.TabIndex = 2;
            // 
            // cmb_tencsdl
            // 
            cmb_tencsdl.FormattingEnabled = true;
            cmb_tencsdl.Location = new Point(31, 96);
            cmb_tencsdl.Name = "cmb_tencsdl";
            cmb_tencsdl.Size = new Size(151, 28);
            cmb_tencsdl.TabIndex = 3;
            // 
            // lbl_nhomsp
            // 
            lbl_nhomsp.AutoSize = true;
            lbl_nhomsp.Location = new Point(31, 74);
            lbl_nhomsp.Name = "lbl_nhomsp";
            lbl_nhomsp.Size = new Size(105, 20);
            lbl_nhomsp.TabIndex = 4;
            lbl_nhomsp.Text = "Loại sản phẩm";
            // 
            // lbl_tensp
            // 
            lbl_tensp.AutoSize = true;
            lbl_tensp.Location = new Point(658, 32);
            lbl_tensp.Name = "lbl_tensp";
            lbl_tensp.Size = new Size(101, 20);
            lbl_tensp.TabIndex = 4;
            lbl_tensp.Text = "Tên Sản Phẩm";
            // 
            // lbl_nhapma
            // 
            lbl_nhapma.AutoSize = true;
            lbl_nhapma.Location = new Point(31, 9);
            lbl_nhapma.Name = "lbl_nhapma";
            lbl_nhapma.Size = new Size(169, 20);
            lbl_nhapma.TabIndex = 4;
            lbl_nhapma.Text = "Nhập mã/ tên sản phẩm";
            // 
            // ptr_hinhsanpham
            // 
            ptr_hinhsanpham.Location = new Point(658, 65);
            ptr_hinhsanpham.Name = "ptr_hinhsanpham";
            ptr_hinhsanpham.Size = new Size(342, 225);
            ptr_hinhsanpham.TabIndex = 5;
            ptr_hinhsanpham.TabStop = false;
            // 
            // lbl_motasp
            // 
            lbl_motasp.AutoSize = true;
            lbl_motasp.Location = new Point(659, 304);
            lbl_motasp.Name = "lbl_motasp";
            lbl_motasp.Size = new Size(55, 20);
            lbl_motasp.TabIndex = 6;
            lbl_motasp.Text = "Mô tả: ";
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
            // frm_danhmuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1018, 450);
            Controls.Add(lbl_motasp);
            Controls.Add(ptr_hinhsanpham);
            Controls.Add(lbl_tensp);
            Controls.Add(lbl_nhapma);
            Controls.Add(lbl_nhomsp);
            Controls.Add(cmb_tencsdl);
            Controls.Add(txt_nhapmasp);
            Controls.Add(btn_them);
            Controls.Add(btn_sua);
            Controls.Add(btn_xoa);
            Controls.Add(dgv_danhmucsp);
            Name = "frm_danhmuc";
            Text = "Danh Mục Sản Phẩm";
            WindowState = FormWindowState.Maximized;
            Load += frm_danhmuc_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_danhmucsp).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptr_hinhsanpham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_danhmucsp;
        private Button btn_xoa;
        private Button btn_them;
        private Button btn_sua;
        private TextBox txt_nhapmasp;
        private ComboBox cmb_tencsdl;
        private Label lbl_nhomsp;
        private Label lbl_tensp;
        private Label lbl_nhapma;
        private PictureBox ptr_hinhsanpham;
        private Label lbl_motasp;
        private DataGridViewTextBoxColumn masp;
        private DataGridViewTextBoxColumn tensp;
        private DataGridViewTextBoxColumn gia;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn loai;
    }
}