
namespace BANHANG
{
    partial class Form4
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
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDChi = new System.Windows.Forms.TextBox();
            this.txttenKH = new System.Windows.Forms.TextBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbDchi = new System.Windows.Forms.Label();
            this.lbtenKH = new System.Windows.Forms.Label();
            this.lbKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntrangchu = new System.Windows.Forms.Button();
            this.btnlmoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.lbgtinh = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.rdNu);
            this.panel1.Controls.Add(this.rdNam);
            this.panel1.Controls.Add(this.lbgtinh);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtDChi);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txttenKH);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.lbTim);
            this.panel1.Controls.Add(this.txtKH);
            this.panel1.Controls.Add(this.lbSDT);
            this.panel1.Controls.Add(this.lbDchi);
            this.panel1.Controls.Add(this.lbtenKH);
            this.panel1.Controls.Add(this.lbKH);
            this.panel1.Location = new System.Drawing.Point(43, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 187);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(449, 73);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(203, 26);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDChi
            // 
            this.txtDChi.Location = new System.Drawing.Point(151, 127);
            this.txtDChi.Name = "txtDChi";
            this.txtDChi.Size = new System.Drawing.Size(154, 26);
            this.txtDChi.TabIndex = 6;
            // 
            // txttenKH
            // 
            this.txttenKH.Location = new System.Drawing.Point(151, 76);
            this.txttenKH.Name = "txttenKH";
            this.txttenKH.Size = new System.Drawing.Size(154, 26);
            this.txttenKH.TabIndex = 5;
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(151, 24);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(154, 26);
            this.txtKH.TabIndex = 4;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(337, 76);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(92, 18);
            this.lbSDT.TabIndex = 3;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // lbDchi
            // 
            this.lbDchi.AutoSize = true;
            this.lbDchi.Location = new System.Drawing.Point(16, 121);
            this.lbDchi.Name = "lbDchi";
            this.lbDchi.Size = new System.Drawing.Size(50, 18);
            this.lbDchi.TabIndex = 2;
            this.lbDchi.Text = "Địa chỉ";
            // 
            // lbtenKH
            // 
            this.lbtenKH.AutoSize = true;
            this.lbtenKH.Location = new System.Drawing.Point(16, 76);
            this.lbtenKH.Name = "lbtenKH";
            this.lbtenKH.Size = new System.Drawing.Size(114, 18);
            this.lbtenKH.TabIndex = 1;
            this.lbtenKH.Text = "Tên khách hàng";
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Location = new System.Drawing.Point(16, 24);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(108, 18);
            this.lbKH.TabIndex = 0;
            this.lbKH.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(322, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.btntrangchu);
            this.panel2.Controls.Add(this.btnlmoi);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Location = new System.Drawing.Point(150, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 79);
            this.panel2.TabIndex = 2;
            // 
            // btntrangchu
            // 
            this.btntrangchu.Location = new System.Drawing.Point(420, 22);
            this.btntrangchu.Name = "btntrangchu";
            this.btntrangchu.Size = new System.Drawing.Size(79, 27);
            this.btntrangchu.TabIndex = 4;
            this.btntrangchu.Text = "Home";
            this.btntrangchu.UseVisualStyleBackColor = true;
            this.btntrangchu.Click += new System.EventHandler(this.btntrangchu_Click);
            // 
            // btnlmoi
            // 
            this.btnlmoi.Location = new System.Drawing.Point(320, 22);
            this.btnlmoi.Name = "btnlmoi";
            this.btnlmoi.Size = new System.Drawing.Size(79, 27);
            this.btnlmoi.TabIndex = 3;
            this.btnlmoi.Text = "Làm mới";
            this.btnlmoi.UseVisualStyleBackColor = true;
            this.btnlmoi.Click += new System.EventHandler(this.btnlmoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(219, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 27);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(119, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 27);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(19, 22);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(79, 27);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(449, 127);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(203, 26);
            this.txtTim.TabIndex = 3;
            this.txtTim.Text = "Nhập mã khách hàng cần tìm ";
            this.txtTim.Click += new System.EventHandler(this.txtTim_Click);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Location = new System.Drawing.Point(337, 121);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(68, 18);
            this.lbTim.TabIndex = 4;
            this.lbTim.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(658, 121);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(52, 36);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thông tin khách hàng ";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(150, 376);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(518, 150);
            this.data.TabIndex = 7;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick_1);
            // 
            // lbgtinh
            // 
            this.lbgtinh.AutoSize = true;
            this.lbgtinh.Location = new System.Drawing.Point(337, 24);
            this.lbgtinh.Name = "lbgtinh";
            this.lbgtinh.Size = new System.Drawing.Size(58, 18);
            this.lbgtinh.TabIndex = 8;
            this.lbgtinh.Text = "Giới tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(449, 22);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 22);
            this.rdNam.TabIndex = 9;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(564, 22);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 22);
            this.rdNu.TabIndex = 10;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(836, 549);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDChi;
        private System.Windows.Forms.TextBox txttenKH;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbDchi;
        private System.Windows.Forms.Label lbtenKH;
        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlmoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btntrangchu;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label lbgtinh;
    }
}