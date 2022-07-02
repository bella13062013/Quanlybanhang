
namespace BANHANG
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mANAGESSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAblum = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.gIÚPĐỠToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANAGESSToolStripMenuItem,
            this.gIÚPĐỠToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mANAGESSToolStripMenuItem
            // 
            this.mANAGESSToolStripMenuItem.BackColor = System.Drawing.Color.LightPink;
            this.mANAGESSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNhanVien,
            this.toolKhachHang,
            this.toolAblum,
            this.toolHoaDon});
            this.mANAGESSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANAGESSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.mANAGESSToolStripMenuItem.Name = "mANAGESSToolStripMenuItem";
            this.mANAGESSToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.mANAGESSToolStripMenuItem.Text = "QUẢN LÝ";
            // 
            // toolNhanVien
            // 
            this.toolNhanVien.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolNhanVien.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolNhanVien.Name = "toolNhanVien";
            this.toolNhanVien.Size = new System.Drawing.Size(180, 22);
            this.toolNhanVien.Text = "NHÂN VIÊN";
            this.toolNhanVien.Click += new System.EventHandler(this.toolNhanVien_Click);
            // 
            // toolKhachHang
            // 
            this.toolKhachHang.BackColor = System.Drawing.Color.MistyRose;
            this.toolKhachHang.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolKhachHang.Name = "toolKhachHang";
            this.toolKhachHang.Size = new System.Drawing.Size(180, 22);
            this.toolKhachHang.Text = "KHÁCH HÀNG";
            this.toolKhachHang.Click += new System.EventHandler(this.toolKhachHang_Click);
            // 
            // toolAblum
            // 
            this.toolAblum.BackColor = System.Drawing.Color.PeachPuff;
            this.toolAblum.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolAblum.Name = "toolAblum";
            this.toolAblum.Size = new System.Drawing.Size(180, 22);
            this.toolAblum.Text = "ABLUM";
            this.toolAblum.Click += new System.EventHandler(this.toolAblum_Click);
            // 
            // toolHoaDon
            // 
            this.toolHoaDon.BackColor = System.Drawing.Color.Pink;
            this.toolHoaDon.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHoaDon.Name = "toolHoaDon";
            this.toolHoaDon.Size = new System.Drawing.Size(180, 22);
            this.toolHoaDon.Text = "HÓA ĐƠN";
            this.toolHoaDon.Click += new System.EventHandler(this.toolHoaDon_Click);
            // 
            // gIÚPĐỠToolStripMenuItem
            // 
            this.gIÚPĐỠToolStripMenuItem.BackColor = System.Drawing.Color.LightPink;
            this.gIÚPĐỠToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThoat});
            this.gIÚPĐỠToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gIÚPĐỠToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gIÚPĐỠToolStripMenuItem.Name = "gIÚPĐỠToolStripMenuItem";
            this.gIÚPĐỠToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.gIÚPĐỠToolStripMenuItem.Text = "GIÚP ĐỠ";
            // 
            // toolThoat
            // 
            this.toolThoat.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolThoat.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolThoat.Name = "toolThoat";
            this.toolThoat.Size = new System.Drawing.Size(180, 22);
            this.toolThoat.Text = "THOÁT";
            this.toolThoat.Click += new System.EventHandler(this.toolThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("VnGatineau2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAGIC SHOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font(".Vn3DH", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 70);
            this.label2.TabIndex = 3;
            this.label2.Text = "방탄소년단";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 210);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(807, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 210);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mANAGESSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolNhanVien;
        private System.Windows.Forms.ToolStripMenuItem gIÚPĐỠToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolKhachHang;
        private System.Windows.Forms.ToolStripMenuItem toolAblum;
        private System.Windows.Forms.ToolStripMenuItem toolHoaDon;
        private System.Windows.Forms.ToolStripMenuItem toolThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}