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
            dgv_kiemkho = new DataGridView();
            gr_timkiem = new GroupBox();
            lbl_nhapma = new Label();
            lbl_nhomsp = new Label();
            txt_ngaynhap = new TextBox();
            txt_nhapmapk = new TextBox();
            gr_congcu = new GroupBox();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            gr_thongtin = new GroupBox();
            lbl_nguoitao = new Label();
            lbl_trangthai = new Label();
            txt_nguoitao = new TextBox();
            txt_trangthai = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_kiemkho).BeginInit();
            gr_timkiem.SuspendLayout();
            gr_congcu.SuspendLayout();
            gr_thongtin.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_kiemkho
            // 
            dgv_kiemkho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_kiemkho.Location = new Point(12, 152);
            dgv_kiemkho.Name = "dgv_kiemkho";
            dgv_kiemkho.RowHeadersWidth = 51;
            dgv_kiemkho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_kiemkho.Size = new Size(978, 286);
            dgv_kiemkho.TabIndex = 9;
            dgv_kiemkho.Click += dgv_kiemkho_Click;
            // 
            // gr_timkiem
            // 
            gr_timkiem.Controls.Add(lbl_nhapma);
            gr_timkiem.Controls.Add(lbl_nhomsp);
            gr_timkiem.Controls.Add(txt_ngaynhap);
            gr_timkiem.Controls.Add(txt_nhapmapk);
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
            lbl_nhapma.Size = new Size(134, 20);
            lbl_nhapma.TabIndex = 7;
            lbl_nhapma.Text = "Nhập mã kiểm kho";
            // 
            // lbl_nhomsp
            // 
            lbl_nhomsp.AutoSize = true;
            lbl_nhomsp.Location = new Point(28, 73);
            lbl_nhomsp.Name = "lbl_nhomsp";
            lbl_nhomsp.Size = new Size(81, 20);
            lbl_nhomsp.TabIndex = 8;
            lbl_nhomsp.Text = "Ngày nhập";
            // 
            // txt_ngaynhap
            // 
            txt_ngaynhap.Location = new Point(28, 98);
            txt_ngaynhap.Name = "txt_ngaynhap";
            txt_ngaynhap.Size = new Size(169, 27);
            txt_ngaynhap.TabIndex = 5;
            // 
            // txt_nhapmapk
            // 
            txt_nhapmapk.Location = new Point(28, 43);
            txt_nhapmapk.Name = "txt_nhapmapk";
            txt_nhapmapk.Size = new Size(169, 27);
            txt_nhapmapk.TabIndex = 5;
            // 
            // gr_congcu
            // 
            gr_congcu.Controls.Add(btn_them);
            gr_congcu.Controls.Add(btn_xoa);
            gr_congcu.Controls.Add(btn_sua);
            gr_congcu.Location = new Point(319, 12);
            gr_congcu.Name = "gr_congcu";
            gr_congcu.Size = new Size(323, 125);
            gr_congcu.TabIndex = 10;
            gr_congcu.TabStop = false;
            gr_congcu.Text = "Công cụ";
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
            // gr_thongtin
            // 
            gr_thongtin.Controls.Add(lbl_nguoitao);
            gr_thongtin.Controls.Add(lbl_trangthai);
            gr_thongtin.Controls.Add(txt_nguoitao);
            gr_thongtin.Controls.Add(txt_trangthai);
            gr_thongtin.Location = new Point(684, 12);
            gr_thongtin.Name = "gr_thongtin";
            gr_thongtin.Size = new Size(306, 125);
            gr_thongtin.TabIndex = 12;
            gr_thongtin.TabStop = false;
            gr_thongtin.Text = "Thông tin";
            // 
            // lbl_nguoitao
            // 
            lbl_nguoitao.AutoSize = true;
            lbl_nguoitao.Location = new Point(21, 73);
            lbl_nguoitao.Name = "lbl_nguoitao";
            lbl_nguoitao.Size = new Size(80, 20);
            lbl_nguoitao.TabIndex = 7;
            lbl_nguoitao.Text = "Người tạo:";
            // 
            // lbl_trangthai
            // 
            lbl_trangthai.AutoSize = true;
            lbl_trangthai.Location = new Point(21, 29);
            lbl_trangthai.Name = "lbl_trangthai";
            lbl_trangthai.Size = new Size(82, 20);
            lbl_trangthai.TabIndex = 7;
            lbl_trangthai.Text = "Trạng thái: ";
            // 
            // txt_nguoitao
            // 
            txt_nguoitao.Location = new Point(109, 66);
            txt_nguoitao.Name = "txt_nguoitao";
            txt_nguoitao.Size = new Size(169, 27);
            txt_nguoitao.TabIndex = 5;
            // 
            // txt_trangthai
            // 
            txt_trangthai.Location = new Point(109, 22);
            txt_trangthai.Name = "txt_trangthai";
            txt_trangthai.Size = new Size(169, 27);
            txt_trangthai.TabIndex = 5;
            // 
            // frm_KiemKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 450);
            Controls.Add(gr_thongtin);
            Controls.Add(gr_timkiem);
            Controls.Add(gr_congcu);
            Controls.Add(dgv_kiemkho);
            Name = "frm_KiemKho";
            Text = "Kiểm Kho";
            Load += frm_KiemKho_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_kiemkho).EndInit();
            gr_timkiem.ResumeLayout(false);
            gr_timkiem.PerformLayout();
            gr_congcu.ResumeLayout(false);
            gr_thongtin.ResumeLayout(false);
            gr_thongtin.PerformLayout();
            ResumeLayout(false);
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
    }
}