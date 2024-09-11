namespace QuanLiThuVienSachCaNhan
{
    partial class Form_chinh
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
            this.components = new System.ComponentModel.Container();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntThemSach = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ThemChuDeMenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntLoc = new System.Windows.Forms.Button();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbbTimKiem2 = new System.Windows.Forms.ComboBox();
            this.btnLoc2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_timkiem2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(76, 66);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(129, 20);
            this.txt_timkiem.TabIndex = 7;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tìm kiếm:";
            // 
            // bntThemSach
            // 
            this.bntThemSach.Location = new System.Drawing.Point(300, 36);
            this.bntThemSach.Name = "bntThemSach";
            this.bntThemSach.Size = new System.Drawing.Size(75, 23);
            this.bntThemSach.TabIndex = 9;
            this.bntThemSach.Text = "Thêm Sách";
            this.bntThemSach.UseVisualStyleBackColor = true;
            this.bntThemSach.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemChuDeMenustrip,
            this.quảnLýSáchToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ThemChuDeMenustrip
            // 
            this.ThemChuDeMenustrip.Name = "ThemChuDeMenustrip";
            this.ThemChuDeMenustrip.Size = new System.Drawing.Size(88, 20);
            this.ThemChuDeMenustrip.Text = "Thêm chủ đề";
            this.ThemChuDeMenustrip.Click += new System.EventHandler(this.ThemChuDeMenustrip_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // bntLoc
            // 
            this.bntLoc.Location = new System.Drawing.Point(300, 65);
            this.bntLoc.Name = "bntLoc";
            this.bntLoc.Size = new System.Drawing.Size(75, 23);
            this.bntLoc.TabIndex = 11;
            this.bntLoc.Text = "Lọc";
            this.bntLoc.UseVisualStyleBackColor = true;
            this.bntLoc.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "TatCa",
            "MaSach",
            "TacGia",
            "ChuDe",
            "ViTri",
            "TenSach"});
            this.cbbTimKiem.Location = new System.Drawing.Point(211, 65);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(83, 21);
            this.cbbTimKiem.TabIndex = 12;
            this.cbbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbbTimKiem_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.choMượnToolStripMenuItem,
            this.xóaSáchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 70);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // choMượnToolStripMenuItem
            // 
            this.choMượnToolStripMenuItem.Name = "choMượnToolStripMenuItem";
            this.choMượnToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.choMượnToolStripMenuItem.Text = "Cho Mượn";
            this.choMượnToolStripMenuItem.Click += new System.EventHandler(this.choMượnToolStripMenuItem_Click);
            // 
            // xóaSáchToolStripMenuItem
            // 
            this.xóaSáchToolStripMenuItem.Name = "xóaSáchToolStripMenuItem";
            this.xóaSáchToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.xóaSáchToolStripMenuItem.Text = "Xóa";
            this.xóaSáchToolStripMenuItem.Click += new System.EventHandler(this.xóaSáchToolStripMenuItem_Click);
            // 
            // cbbTimKiem2
            // 
            this.cbbTimKiem2.FormattingEnabled = true;
            this.cbbTimKiem2.Items.AddRange(new object[] {
            "MaSach",
            "TenSach",
            "HoTen",
            "TinhTrang",
            "NgayMuon",
            "NgayTra",
            "SDT",
            "DiaChi"});
            this.cbbTimKiem2.Location = new System.Drawing.Point(668, 66);
            this.cbbTimKiem2.Name = "cbbTimKiem2";
            this.cbbTimKiem2.Size = new System.Drawing.Size(83, 21);
            this.cbbTimKiem2.TabIndex = 19;
            // 
            // btnLoc2
            // 
            this.btnLoc2.Location = new System.Drawing.Point(757, 65);
            this.btnLoc2.Name = "btnLoc2";
            this.btnLoc2.Size = new System.Drawing.Size(75, 23);
            this.btnLoc2.TabIndex = 18;
            this.btnLoc2.Text = "Lọc";
            this.btnLoc2.UseVisualStyleBackColor = true;
            this.btnLoc2.Click += new System.EventHandler(this.btnLoc2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tìm kiếm:";
            // 
            // txt_timkiem2
            // 
            this.txt_timkiem2.Location = new System.Drawing.Point(547, 67);
            this.txt_timkiem2.Name = "txt_timkiem2";
            this.txt_timkiem2.Size = new System.Drawing.Size(115, 20);
            this.txt_timkiem2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 404);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(421, 403);
            this.dataGridView2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 428);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thông tin sách cá nhân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(473, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 429);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Thông Tin Sách Mượn";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(95, 48);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // Form_chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbbTimKiem2);
            this.Controls.Add(this.btnLoc2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_timkiem2);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.bntLoc);
            this.Controls.Add(this.bntThemSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_chinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ THƯ VIỆN SÁCH CÁ NHÂN";
            this.Load += new System.EventHandler(this.Form_chinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntThemSach;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThemChuDeMenustrip;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Button bntLoc;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSáchToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbTimKiem2;
        private System.Windows.Forms.Button btnLoc2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_timkiem2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
    }
}

