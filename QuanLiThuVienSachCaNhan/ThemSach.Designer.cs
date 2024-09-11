namespace QuanLiThuVienSachCaNhan
{
    partial class ThemSach
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
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bnt_themsach = new System.Windows.Forms.Button();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.cbbChuDe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaChuDe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(193, 51);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(160, 20);
            this.txtMaSach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sách:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(193, 83);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(160, 20);
            this.txtTenSach.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tác giả:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(193, 123);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(160, 20);
            this.txtTacGia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chủ đề:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vị trí:";
            // 
            // bnt_themsach
            // 
            this.bnt_themsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_themsach.Location = new System.Drawing.Point(212, 260);
            this.bnt_themsach.Name = "bnt_themsach";
            this.bnt_themsach.Size = new System.Drawing.Size(99, 48);
            this.bnt_themsach.TabIndex = 12;
            this.bnt_themsach.Text = "Thêm sách";
            this.bnt_themsach.UseVisualStyleBackColor = true;
            this.bnt_themsach.Click += new System.EventHandler(this.bnt_themsach_Click);
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(193, 200);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(163, 20);
            this.txtViTri.TabIndex = 14;
            // 
            // cbbChuDe
            // 
            this.cbbChuDe.FormattingEnabled = true;
            this.cbbChuDe.Location = new System.Drawing.Point(193, 167);
            this.cbbChuDe.Name = "cbbChuDe";
            this.cbbChuDe.Size = new System.Drawing.Size(160, 21);
            this.cbbChuDe.TabIndex = 15;
            this.cbbChuDe.SelectedIndexChanged += new System.EventHandler(this.cbbChuDe_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã chủ đề";
            // 
            // txtMaChuDe
            // 
            this.txtMaChuDe.Location = new System.Drawing.Point(196, 229);
            this.txtMaChuDe.Name = "txtMaChuDe";
            this.txtMaChuDe.Size = new System.Drawing.Size(160, 20);
            this.txtMaChuDe.TabIndex = 17;
            // 
            // ThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 339);
            this.Controls.Add(this.txtMaChuDe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbChuDe);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.bnt_themsach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaSach);
            this.Name = "ThemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bnt_themsach;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.ComboBox cbbChuDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaChuDe;
    }
}