
namespace BANHANG
{
    partial class Form5
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
            this.cbover = new System.Windows.Forms.ComboBox();
            this.txtgiara = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.txtgiavao = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttenalb = new System.Windows.Forms.TextBox();
            this.txtalb = new System.Windows.Forms.TextBox();
            this.lbgiara = new System.Windows.Forms.Label();
            this.lbgiavao = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.lbver = new System.Windows.Forms.Label();
            this.lbtenalb = new System.Windows.Forms.Label();
            this.lbmabl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntrangchu = new System.Windows.Forms.Button();
            this.lbanh = new System.Windows.Forms.Label();
            this.lbllanh = new System.Windows.Forms.Label();
            this.btnlmoi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnmo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(353, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ALBUM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.cbover);
            this.panel1.Controls.Add(this.txtgiara);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.lbTim);
            this.panel1.Controls.Add(this.txtgiavao);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.txttenalb);
            this.panel1.Controls.Add(this.txtalb);
            this.panel1.Controls.Add(this.lbgiara);
            this.panel1.Controls.Add(this.lbgiavao);
            this.panel1.Controls.Add(this.lbsoluong);
            this.panel1.Controls.Add(this.lbver);
            this.panel1.Controls.Add(this.lbtenalb);
            this.panel1.Controls.Add(this.lbmabl);
            this.panel1.Location = new System.Drawing.Point(69, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 311);
            this.panel1.TabIndex = 1;
            // 
            // cbover
            // 
            this.cbover.FormattingEnabled = true;
            this.cbover.Location = new System.Drawing.Point(162, 86);
            this.cbover.Name = "cbover";
            this.cbover.Size = new System.Drawing.Size(161, 24);
            this.cbover.TabIndex = 11;
            // 
            // txtgiara
            // 
            this.txtgiara.Location = new System.Drawing.Point(162, 191);
            this.txtgiara.Name = "txtgiara";
            this.txtgiara.Size = new System.Drawing.Size(161, 23);
            this.txtgiara.TabIndex = 10;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(248, 254);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(61, 254);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(172, 23);
            this.txtTim.TabIndex = 4;
            this.txtTim.Text = "Nhập mã album cần tìm";
            this.txtTim.Click += new System.EventHandler(this.txtTim_Click);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Location = new System.Drawing.Point(29, 224);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(61, 16);
            this.lbTim.TabIndex = 5;
            this.lbTim.Text = "Tìm kiếm";
            // 
            // txtgiavao
            // 
            this.txtgiavao.Location = new System.Drawing.Point(162, 157);
            this.txtgiavao.Name = "txtgiavao";
            this.txtgiavao.Size = new System.Drawing.Size(161, 23);
            this.txtgiavao.TabIndex = 9;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(162, 120);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(161, 23);
            this.txtsoluong.TabIndex = 8;
            // 
            // txttenalb
            // 
            this.txttenalb.Location = new System.Drawing.Point(162, 51);
            this.txttenalb.Name = "txttenalb";
            this.txttenalb.Size = new System.Drawing.Size(161, 23);
            this.txttenalb.TabIndex = 7;
            // 
            // txtalb
            // 
            this.txtalb.Location = new System.Drawing.Point(162, 17);
            this.txtalb.Name = "txtalb";
            this.txtalb.Size = new System.Drawing.Size(161, 23);
            this.txtalb.TabIndex = 6;
            // 
            // lbgiara
            // 
            this.lbgiara.AutoSize = true;
            this.lbgiara.Location = new System.Drawing.Point(22, 191);
            this.lbgiara.Name = "lbgiara";
            this.lbgiara.Size = new System.Drawing.Size(91, 16);
            this.lbgiara.TabIndex = 5;
            this.lbgiara.Text = "Giá bán Album";
            // 
            // lbgiavao
            // 
            this.lbgiavao.AutoSize = true;
            this.lbgiavao.Location = new System.Drawing.Point(22, 157);
            this.lbgiavao.Name = "lbgiavao";
            this.lbgiavao.Size = new System.Drawing.Size(98, 16);
            this.lbgiavao.TabIndex = 4;
            this.lbgiavao.Text = "Giá nhập Album";
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(29, 120);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(59, 16);
            this.lbsoluong.TabIndex = 3;
            this.lbsoluong.Text = "Số lượng";
            // 
            // lbver
            // 
            this.lbver.AutoSize = true;
            this.lbver.Location = new System.Drawing.Point(29, 86);
            this.lbver.Name = "lbver";
            this.lbver.Size = new System.Drawing.Size(28, 16);
            this.lbver.TabIndex = 2;
            this.lbver.Text = "Ver";
            // 
            // lbtenalb
            // 
            this.lbtenalb.AutoSize = true;
            this.lbtenalb.Location = new System.Drawing.Point(29, 54);
            this.lbtenalb.Name = "lbtenalb";
            this.lbtenalb.Size = new System.Drawing.Size(70, 16);
            this.lbtenalb.TabIndex = 1;
            this.lbtenalb.Text = "Tên Album";
            // 
            // lbmabl
            // 
            this.lbmabl.AutoSize = true;
            this.lbmabl.Location = new System.Drawing.Point(29, 24);
            this.lbmabl.Name = "lbmabl";
            this.lbmabl.Size = new System.Drawing.Size(65, 16);
            this.lbmabl.TabIndex = 0;
            this.lbmabl.Text = "Mã Album";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.btntrangchu);
            this.panel2.Controls.Add(this.lbanh);
            this.panel2.Controls.Add(this.lbllanh);
            this.panel2.Controls.Add(this.btnlmoi);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnmo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(476, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 309);
            this.panel2.TabIndex = 2;
            // 
            // btntrangchu
            // 
            this.btntrangchu.Location = new System.Drawing.Point(248, 241);
            this.btntrangchu.Name = "btntrangchu";
            this.btntrangchu.Size = new System.Drawing.Size(75, 55);
            this.btntrangchu.TabIndex = 15;
            this.btntrangchu.Text = "Home";
            this.btntrangchu.UseVisualStyleBackColor = true;
            this.btntrangchu.Click += new System.EventHandler(this.btntrangchu_Click);
            // 
            // lbanh
            // 
            this.lbanh.AutoSize = true;
            this.lbanh.Location = new System.Drawing.Point(25, 213);
            this.lbanh.Name = "lbanh";
            this.lbanh.Size = new System.Drawing.Size(42, 16);
            this.lbanh.TabIndex = 14;
            this.lbanh.Text = "label3";
            // 
            // lbllanh
            // 
            this.lbllanh.AutoSize = true;
            this.lbllanh.Location = new System.Drawing.Point(16, 18);
            this.lbllanh.Name = "lbllanh";
            this.lbllanh.Size = new System.Drawing.Size(30, 16);
            this.lbllanh.TabIndex = 13;
            this.lbllanh.Text = "Ảnh";
            // 
            // btnlmoi
            // 
            this.btnlmoi.Location = new System.Drawing.Point(153, 273);
            this.btnlmoi.Name = "btnlmoi";
            this.btnlmoi.Size = new System.Drawing.Size(75, 23);
            this.btnlmoi.TabIndex = 12;
            this.btnlmoi.Text = "Làm mới";
            this.btnlmoi.UseVisualStyleBackColor = true;
            this.btnlmoi.Click += new System.EventHandler(this.btnlmoi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(28, 273);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(153, 241);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(28, 241);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnmo
            // 
            this.btnmo.Location = new System.Drawing.Point(19, 52);
            this.btnmo.Name = "btnmo";
            this.btnmo.Size = new System.Drawing.Size(75, 23);
            this.btnmo.TabIndex = 8;
            this.btnmo.Text = "Mở";
            this.btnmo.UseVisualStyleBackColor = true;
            this.btnmo.Click += new System.EventHandler(this.btnmo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(143, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 183);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Thông tin Album";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(94, 405);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(724, 150);
            this.data.TabIndex = 7;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(868, 566);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form5";
            this.Text = "ALBUM";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbover;
        private System.Windows.Forms.TextBox txtgiara;
        private System.Windows.Forms.TextBox txtgiavao;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttenalb;
        private System.Windows.Forms.TextBox txtalb;
        private System.Windows.Forms.Label lbgiara;
        private System.Windows.Forms.Label lbgiavao;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.Label lbver;
        private System.Windows.Forms.Label lbtenalb;
        private System.Windows.Forms.Label lbmabl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlmoi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnmo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label lbanh;
        private System.Windows.Forms.Label lbllanh;
        private System.Windows.Forms.Button btntrangchu;
    }
}