namespace DeTai_QuanLyCuaHangThuCung
{
    partial class inmasanpham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptr_mavach = new System.Windows.Forms.PictureBox();
            this.lbl_gia = new System.Windows.Forms.Label();
            this.lbl_masp = new System.Windows.Forms.Label();
            this.lbl_tensp = new System.Windows.Forms.Label();
            this.btn_inma = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.cmb_thietbiin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_mavach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ptr_mavach);
            this.panel1.Controls.Add(this.lbl_gia);
            this.panel1.Controls.Add(this.lbl_masp);
            this.panel1.Controls.Add(this.lbl_tensp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 212);
            this.panel1.TabIndex = 0;
            // 
            // ptr_mavach
            // 
            this.ptr_mavach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptr_mavach.Image = global::DeTai_QuanLyCuaHangThuCung.Properties.Resources.mavachsp;
            this.ptr_mavach.Location = new System.Drawing.Point(14, 47);
            this.ptr_mavach.Name = "ptr_mavach";
            this.ptr_mavach.Size = new System.Drawing.Size(268, 95);
            this.ptr_mavach.TabIndex = 5;
            this.ptr_mavach.TabStop = false;
            // 
            // lbl_gia
            // 
            this.lbl_gia.AutoSize = true;
            this.lbl_gia.Location = new System.Drawing.Point(11, 179);
            this.lbl_gia.Name = "lbl_gia";
            this.lbl_gia.Size = new System.Drawing.Size(28, 16);
            this.lbl_gia.TabIndex = 2;
            this.lbl_gia.Text = "Giá";
            // 
            // lbl_masp
            // 
            this.lbl_masp.AutoSize = true;
            this.lbl_masp.Location = new System.Drawing.Point(68, 156);
            this.lbl_masp.Name = "lbl_masp";
            this.lbl_masp.Size = new System.Drawing.Size(44, 16);
            this.lbl_masp.TabIndex = 3;
            this.lbl_masp.Text = "Mã sp";
            // 
            // lbl_tensp
            // 
            this.lbl_tensp.AutoSize = true;
            this.lbl_tensp.Location = new System.Drawing.Point(11, 15);
            this.lbl_tensp.Name = "lbl_tensp";
            this.lbl_tensp.Size = new System.Drawing.Size(49, 16);
            this.lbl_tensp.TabIndex = 4;
            this.lbl_tensp.Text = "Tên sp";
            // 
            // btn_inma
            // 
            this.btn_inma.Location = new System.Drawing.Point(335, 169);
            this.btn_inma.Name = "btn_inma";
            this.btn_inma.Size = new System.Drawing.Size(96, 57);
            this.btn_inma.TabIndex = 1;
            this.btn_inma.Text = "In mã";
            this.btn_inma.UseVisualStyleBackColor = true;
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(464, 169);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(96, 57);
            this.btn_huy.TabIndex = 1;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // cmb_thietbiin
            // 
            this.cmb_thietbiin.FormattingEnabled = true;
            this.cmb_thietbiin.Items.AddRange(new object[] {
            "Máy in hóa đơn nhiệt",
            "Máy in hóa đơn kim",
            "Máy in hóa đơn khổ rộng",
            "Máy in hóa đơn di động"});
            this.cmb_thietbiin.Location = new System.Drawing.Point(335, 49);
            this.cmb_thietbiin.Name = "cmb_thietbiin";
            this.cmb_thietbiin.Size = new System.Drawing.Size(225, 24);
            this.cmb_thietbiin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn thiết bị in";
            // 
            // inmasanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 237);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_thietbiin);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_inma);
            this.Controls.Add(this.panel1);
            this.Name = "inmasanpham";
            this.Text = "In mã sản phẩm";
            this.Load += new System.EventHandler(this.inmasanpham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_mavach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptr_mavach;
        private System.Windows.Forms.Label lbl_gia;
        private System.Windows.Forms.Label lbl_masp;
        private System.Windows.Forms.Label lbl_tensp;
        private System.Windows.Forms.Button btn_inma;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.ComboBox cmb_thietbiin;
        private System.Windows.Forms.Label label1;
    }
}