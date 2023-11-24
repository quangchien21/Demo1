namespace bai6_tuan10
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tdc = new System.Windows.Forms.TextBox();
            this.txt_ltw = new System.Windows.Forms.TextBox();
            this.txt_ctdl = new System.Windows.Forms.TextBox();
            this.txt_csdl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_hienthi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(128, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "XẾP LOẠI HỌC LỰC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_ten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 60);
            this.panel1.TabIndex = 1;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(154, 24);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(239, 22);
            this.txt_ten.TabIndex = 1;
            this.txt_ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ten_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sinh viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tdc);
            this.groupBox1.Controls.Add(this.txt_ltw);
            this.groupBox1.Controls.Add(this.txt_ctdl);
            this.groupBox1.Controls.Add(this.txt_csdl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập điểm";
            // 
            // txt_tdc
            // 
            this.txt_tdc.Location = new System.Drawing.Point(415, 86);
            this.txt_tdc.Name = "txt_tdc";
            this.txt_tdc.Size = new System.Drawing.Size(77, 22);
            this.txt_tdc.TabIndex = 1;
            // 
            // txt_ltw
            // 
            this.txt_ltw.Location = new System.Drawing.Point(415, 40);
            this.txt_ltw.Name = "txt_ltw";
            this.txt_ltw.Size = new System.Drawing.Size(77, 22);
            this.txt_ltw.TabIndex = 1;
            // 
            // txt_ctdl
            // 
            this.txt_ctdl.Location = new System.Drawing.Point(154, 86);
            this.txt_ctdl.Name = "txt_ctdl";
            this.txt_ctdl.Size = new System.Drawing.Size(92, 22);
            this.txt_ctdl.TabIndex = 1;
            // 
            // txt_csdl
            // 
            this.txt_csdl.Location = new System.Drawing.Point(154, 40);
            this.txt_csdl.Name = "txt_csdl";
            this.txt_csdl.Size = new System.Drawing.Size(92, 22);
            this.txt_csdl.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tin học đại cương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lâp trình Windows";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cấu trúc dữ liệu 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cơ sở dữ liệu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_thoat);
            this.panel2.Controls.Add(this.btn_tinh);
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Location = new System.Drawing.Point(12, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 59);
            this.panel2.TabIndex = 3;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(385, 12);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(90, 44);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(194, 12);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(90, 44);
            this.btn_tinh.TabIndex = 0;
            this.btn_tinh.Text = "Tính";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(23, 15);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(90, 44);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_hienthi
            // 
            this.txt_hienthi.Location = new System.Drawing.Point(12, 367);
            this.txt_hienthi.Multiline = true;
            this.txt_hienthi.Name = "txt_hienthi";
            this.txt_hienthi.Size = new System.Drawing.Size(498, 155);
            this.txt_hienthi.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 527);
            this.Controls.Add(this.txt_hienthi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tdc;
        private System.Windows.Forms.TextBox txt_ltw;
        private System.Windows.Forms.TextBox txt_ctdl;
        private System.Windows.Forms.TextBox txt_csdl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_hienthi;
    }
}

