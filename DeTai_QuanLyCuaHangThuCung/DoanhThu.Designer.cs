namespace DeTai_QuanLyCuaHangThuCung
{
    partial class DoanhThu
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
            this.grpb_thoigian = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_nam = new System.Windows.Forms.ComboBox();
            this.cmb_thang = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ngaynhaptudong = new System.Windows.Forms.TextBox();
            this.dgv_doanhthu = new System.Windows.Forms.DataGridView();
            this.txt_chinhanh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpb_thoigian.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpb_thoigian
            // 
            this.grpb_thoigian.Controls.Add(this.btn_cancel);
            this.grpb_thoigian.Controls.Add(this.label2);
            this.grpb_thoigian.Controls.Add(this.label1);
            this.grpb_thoigian.Controls.Add(this.cmb_nam);
            this.grpb_thoigian.Controls.Add(this.cmb_thang);
            this.grpb_thoigian.Location = new System.Drawing.Point(13, 13);
            this.grpb_thoigian.Margin = new System.Windows.Forms.Padding(4);
            this.grpb_thoigian.Name = "grpb_thoigian";
            this.grpb_thoigian.Padding = new System.Windows.Forms.Padding(4);
            this.grpb_thoigian.Size = new System.Drawing.Size(249, 162);
            this.grpb_thoigian.TabIndex = 13;
            this.grpb_thoigian.TabStop = false;
            this.grpb_thoigian.Text = "Thời gian";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(54, 111);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Bỏ chọn";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theo năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theo tháng";
            // 
            // cmb_nam
            // 
            this.cmb_nam.FormattingEnabled = true;
            this.cmb_nam.Location = new System.Drawing.Point(108, 68);
            this.cmb_nam.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_nam.Name = "cmb_nam";
            this.cmb_nam.Size = new System.Drawing.Size(120, 24);
            this.cmb_nam.TabIndex = 0;
            this.cmb_nam.SelectedIndexChanged += new System.EventHandler(this.cmb_nam_SelectedIndexChanged);
            // 
            // cmb_thang
            // 
            this.cmb_thang.FormattingEnabled = true;
            this.cmb_thang.Location = new System.Drawing.Point(108, 23);
            this.cmb_thang.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_thang.Name = "cmb_thang";
            this.cmb_thang.Size = new System.Drawing.Size(120, 24);
            this.cmb_thang.TabIndex = 0;
            this.cmb_thang.SelectedIndexChanged += new System.EventHandler(this.cmb_thang_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_ngaynhaptudong);
            this.panel1.Controls.Add(this.dgv_doanhthu);
            this.panel1.Controls.Add(this.txt_chinhanh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(316, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 369);
            this.panel1.TabIndex = 15;
            // 
            // txt_ngaynhaptudong
            // 
            this.txt_ngaynhaptudong.Location = new System.Drawing.Point(15, 10);
            this.txt_ngaynhaptudong.Name = "txt_ngaynhaptudong";
            this.txt_ngaynhaptudong.Size = new System.Drawing.Size(156, 22);
            this.txt_ngaynhaptudong.TabIndex = 18;
            // 
            // dgv_doanhthu
            // 
            this.dgv_doanhthu.AllowUserToAddRows = false;
            this.dgv_doanhthu.AllowUserToDeleteRows = false;
            this.dgv_doanhthu.AllowUserToResizeColumns = false;
            this.dgv_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhthu.Location = new System.Drawing.Point(15, 100);
            this.dgv_doanhthu.Name = "dgv_doanhthu";
            this.dgv_doanhthu.ReadOnly = true;
            this.dgv_doanhthu.RowHeadersWidth = 51;
            this.dgv_doanhthu.RowTemplate.Height = 24;
            this.dgv_doanhthu.Size = new System.Drawing.Size(696, 58);
            this.dgv_doanhthu.TabIndex = 17;
            // 
            // txt_chinhanh
            // 
            this.txt_chinhanh.AutoSize = true;
            this.txt_chinhanh.Location = new System.Drawing.Point(262, 57);
            this.txt_chinhanh.Name = "txt_chinhanh";
            this.txt_chinhanh.Size = new System.Drawing.Size(68, 16);
            this.txt_chinhanh.TabIndex = 16;
            this.txt_chinhanh.Text = "Chi nhánh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Báo cáo doanh thu";
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpb_thoigian);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.grpb_thoigian.ResumeLayout(false);
            this.grpb_thoigian.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpb_thoigian;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_nam;
        private System.Windows.Forms.ComboBox cmb_thang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_chinhanh;
        private System.Windows.Forms.DataGridView dgv_doanhthu;
        private System.Windows.Forms.TextBox txt_ngaynhaptudong;
    }
}