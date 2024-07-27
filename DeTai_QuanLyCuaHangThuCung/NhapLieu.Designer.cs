namespace DeTai_QuanLyCuaHangThuCung
{
    partial class frm_NhapLieu
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
            label1 = new Label();
            txt_maSP = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            btn_hoanthanh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txt_maSP
            // 
            txt_maSP.Location = new Point(68, 6);
            txt_maSP.Name = "txt_maSP";
            txt_maSP.Size = new Size(206, 27);
            txt_maSP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "label1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(68, 53);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 27);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "label1";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(68, 151);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 27);
            textBox4.TabIndex = 1;
            // 
            // btn_hoanthanh
            // 
            btn_hoanthanh.Location = new Point(95, 203);
            btn_hoanthanh.Name = "btn_hoanthanh";
            btn_hoanthanh.Size = new Size(104, 53);
            btn_hoanthanh.TabIndex = 2;
            btn_hoanthanh.Text = "button1";
            btn_hoanthanh.UseVisualStyleBackColor = true;
            btn_hoanthanh.Click += btn_hoanthanh_Click;
            // 
            // frm_NhapLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 268);
            Controls.Add(btn_hoanthanh);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(txt_maSP);
            Controls.Add(label1);
            Name = "frm_NhapLieu";
            Text = "Nhập Dữ Liệu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_maSP;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button btn_hoanthanh;
    }
}