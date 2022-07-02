
namespace BANHANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbregister = new System.Windows.Forms.LinkLabel();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btblog = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.chkShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign In";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(45, 179);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(66, 16);
            this.lbuser.TabIndex = 2;
            this.lbuser.Text = "Username";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(45, 230);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(63, 16);
            this.lbpass.TabIndex = 3;
            this.lbpass.Text = "Password";
            // 
            // lbregister
            // 
            this.lbregister.AutoSize = true;
            this.lbregister.Location = new System.Drawing.Point(77, 351);
            this.lbregister.Name = "lbregister";
            this.lbregister.Size = new System.Drawing.Size(200, 16);
            this.lbregister.TabIndex = 4;
            this.lbregister.TabStop = true;
            this.lbregister.Text = "Do not have an account ? Sign Up\r\n";
            this.lbregister.Click += new System.EventHandler(this.lbregister_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(131, 172);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(146, 23);
            this.txtuser.TabIndex = 5;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(131, 223);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(146, 23);
            this.txtpass.TabIndex = 6;
            // 
            // btblog
            // 
            this.btblog.Location = new System.Drawing.Point(80, 294);
            this.btblog.Name = "btblog";
            this.btblog.Size = new System.Drawing.Size(75, 40);
            this.btblog.TabIndex = 7;
            this.btblog.Text = "Sign In";
            this.btblog.UseVisualStyleBackColor = true;
            this.btblog.Click += new System.EventHandler(this.btblog_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(202, 294);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 40);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(131, 268);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(118, 20);
            this.chkShow.TabIndex = 9;
            this.chkShow.Text = "Show password";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(336, 388);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btblog);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbregister);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.LinkLabel lbregister;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btblog;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.CheckBox chkShow;
    }
}

