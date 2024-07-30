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
            lbl_nhapma = new Label();
            lbl_nhomsp = new Label();
            cmb_tencsdl = new ComboBox();
            txt_nhapmasp = new TextBox();
            dgv_thietlapgia = new DataGridView();
            makho = new DataGridViewTextBoxColumn();
            masp = new DataGridViewTextBoxColumn();
            tensp = new DataGridViewTextBoxColumn();
            ngaynhap = new DataGridViewTextBoxColumn();
            slhethong = new DataGridViewTextBoxColumn();
            slthucte = new DataGridViewTextBoxColumn();
            ghichu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_thietlapgia).BeginInit();
            SuspendLayout();
            // 
            // lbl_nhapma
            // 
            lbl_nhapma.AutoSize = true;
            lbl_nhapma.Location = new Point(12, 9);
            lbl_nhapma.Name = "lbl_nhapma";
            lbl_nhapma.Size = new Size(169, 20);
            lbl_nhapma.TabIndex = 12;
            lbl_nhapma.Text = "Nhập mã/ tên sản phẩm";
            // 
            // lbl_nhomsp
            // 
            lbl_nhomsp.AutoSize = true;
            lbl_nhomsp.Location = new Point(12, 74);
            lbl_nhomsp.Name = "lbl_nhomsp";
            lbl_nhomsp.Size = new Size(118, 20);
            lbl_nhomsp.TabIndex = 13;
            lbl_nhomsp.Text = "Nhóm sản phẩm";
            // 
            // cmb_tencsdl
            // 
            cmb_tencsdl.FormattingEnabled = true;
            cmb_tencsdl.Location = new Point(12, 96);
            cmb_tencsdl.Name = "cmb_tencsdl";
            cmb_tencsdl.Size = new Size(169, 28);
            cmb_tencsdl.TabIndex = 11;
            // 
            // txt_nhapmasp
            // 
            txt_nhapmasp.Location = new Point(12, 32);
            txt_nhapmasp.Name = "txt_nhapmasp";
            txt_nhapmasp.Size = new Size(169, 27);
            txt_nhapmasp.TabIndex = 10;
            // 
            // dgv_thietlapgia
            // 
            dgv_thietlapgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thietlapgia.Columns.AddRange(new DataGridViewColumn[] { makho, masp, tensp, ngaynhap, slhethong, slthucte, ghichu });
            dgv_thietlapgia.Location = new Point(12, 152);
            dgv_thietlapgia.Name = "dgv_thietlapgia";
            dgv_thietlapgia.RowHeadersWidth = 51;
            dgv_thietlapgia.Size = new Size(929, 286);
            dgv_thietlapgia.TabIndex = 9;
            // 
            // makho
            // 
            makho.HeaderText = "Mã Kiểm Kho";
            makho.MinimumWidth = 6;
            makho.Name = "makho";
            makho.Width = 125;
            // 
            // masp
            // 
            masp.HeaderText = "Mã Sản Phâm";
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
            // ngaynhap
            // 
            ngaynhap.HeaderText = "Ngày Nhập";
            ngaynhap.MinimumWidth = 6;
            ngaynhap.Name = "ngaynhap";
            ngaynhap.Width = 125;
            // 
            // slhethong
            // 
            slhethong.HeaderText = "SL Hệ Thống";
            slhethong.MinimumWidth = 6;
            slhethong.Name = "slhethong";
            slhethong.Width = 125;
            // 
            // slthucte
            // 
            slthucte.HeaderText = "SL Thực Tế";
            slthucte.MinimumWidth = 6;
            slthucte.Name = "slthucte";
            slthucte.Width = 125;
            // 
            // ghichu
            // 
            ghichu.HeaderText = "Ghi Chú";
            ghichu.MinimumWidth = 6;
            ghichu.Name = "ghichu";
            ghichu.Width = 125;
            // 
            // frm_KiemKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 450);
            Controls.Add(lbl_nhapma);
            Controls.Add(lbl_nhomsp);
            Controls.Add(cmb_tencsdl);
            Controls.Add(txt_nhapmasp);
            Controls.Add(dgv_thietlapgia);
            Name = "frm_KiemKho";
            Text = "Kiểm Kho";
            ((System.ComponentModel.ISupportInitialize)dgv_thietlapgia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nhapma;
        private Label lbl_nhomsp;
        private ComboBox cmb_tencsdl;
        private TextBox txt_nhapmasp;
        private DataGridView dgv_thietlapgia;
        private DataGridViewTextBoxColumn makho;
        private DataGridViewTextBoxColumn masp;
        private DataGridViewTextBoxColumn tensp;
        private DataGridViewTextBoxColumn ngaynhap;
        private DataGridViewTextBoxColumn slhethong;
        private DataGridViewTextBoxColumn slthucte;
        private DataGridViewTextBoxColumn ghichu;
    }
}