namespace DeTai_QuanLyCuaHangThuCung.HangHoa
{
    partial class frm_ThietLapGia
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
            dgv_thietlapgia = new DataGridView();
            masp = new DataGridViewTextBoxColumn();
            tensp = new DataGridViewTextBoxColumn();
            gia = new DataGridViewTextBoxColumn();
            lbl_nhapma = new Label();
            lbl_nhomsp = new Label();
            cmb_tencsdl = new ComboBox();
            txt_nhapmasp = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_thietlapgia).BeginInit();
            SuspendLayout();
            // 
            // dgv_thietlapgia
            // 
            dgv_thietlapgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thietlapgia.Columns.AddRange(new DataGridViewColumn[] { masp, tensp, gia });
            dgv_thietlapgia.Location = new Point(12, 152);
            dgv_thietlapgia.Name = "dgv_thietlapgia";
            dgv_thietlapgia.RowHeadersWidth = 51;
            dgv_thietlapgia.Size = new Size(630, 286);
            dgv_thietlapgia.TabIndex = 1;
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
            // lbl_nhapma
            // 
            lbl_nhapma.AutoSize = true;
            lbl_nhapma.Location = new Point(12, 9);
            lbl_nhapma.Name = "lbl_nhapma";
            lbl_nhapma.Size = new Size(169, 20);
            lbl_nhapma.TabIndex = 7;
            lbl_nhapma.Text = "Nhập mã/ tên sản phẩm";
            // 
            // lbl_nhomsp
            // 
            lbl_nhomsp.AutoSize = true;
            lbl_nhomsp.Location = new Point(12, 74);
            lbl_nhomsp.Name = "lbl_nhomsp";
            lbl_nhomsp.Size = new Size(118, 20);
            lbl_nhomsp.TabIndex = 8;
            lbl_nhomsp.Text = "Nhóm sản phẩm";
            // 
            // cmb_tencsdl
            // 
            cmb_tencsdl.FormattingEnabled = true;
            cmb_tencsdl.Location = new Point(12, 96);
            cmb_tencsdl.Name = "cmb_tencsdl";
            cmb_tencsdl.Size = new Size(169, 28);
            cmb_tencsdl.TabIndex = 6;
            // 
            // txt_nhapmasp
            // 
            txt_nhapmasp.Location = new Point(12, 32);
            txt_nhapmasp.Name = "txt_nhapmasp";
            txt_nhapmasp.Size = new Size(169, 27);
            txt_nhapmasp.TabIndex = 5;
            // 
            // frm_ThietLapGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 450);
            Controls.Add(lbl_nhapma);
            Controls.Add(lbl_nhomsp);
            Controls.Add(cmb_tencsdl);
            Controls.Add(txt_nhapmasp);
            Controls.Add(dgv_thietlapgia);
            Name = "frm_ThietLapGia";
            Text = "Thiết Lập Giá";
            ((System.ComponentModel.ISupportInitialize)dgv_thietlapgia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_thietlapgia;
        private Label lbl_nhapma;
        private Label lbl_nhomsp;
        private ComboBox cmb_tencsdl;
        private TextBox txt_nhapmasp;
        private DataGridViewTextBoxColumn masp;
        private DataGridViewTextBoxColumn tensp;
        private DataGridViewTextBoxColumn gia;
    }
}