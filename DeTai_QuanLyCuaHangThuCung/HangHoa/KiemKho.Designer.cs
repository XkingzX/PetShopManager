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
            txt_nhapmasp = new TextBox();
            groupBox1 = new GroupBox();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_kiemkho).BeginInit();
            gr_timkiem.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // 
            // gr_timkiem
            // 
            gr_timkiem.Controls.Add(lbl_nhapma);
            gr_timkiem.Controls.Add(lbl_nhomsp);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(684, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 125);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 73);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "Người tạo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 7;
            label1.Text = "Trạng thái: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 5;
            // 
            // frm_KiemKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 450);
            Controls.Add(groupBox2);
            Controls.Add(gr_timkiem);
            Controls.Add(groupBox1);
            Controls.Add(dgv_kiemkho);
            Name = "frm_KiemKho";
            Text = "Kiểm Kho";
            Load += frm_KiemKho_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_kiemkho).EndInit();
            gr_timkiem.ResumeLayout(false);
            gr_timkiem.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_kiemkho;
        private GroupBox gr_timkiem;
        private Label lbl_nhapma;
        private Label lbl_nhomsp;
        private TextBox txt_nhapmasp;
        private GroupBox groupBox1;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}