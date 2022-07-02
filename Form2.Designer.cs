
namespace BANHANG
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbrepass = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtrepass = new System.Windows.Forms.TextBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(32, 190);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(75, 18);
            this.lbuser.TabIndex = 2;
            this.lbuser.Text = "Username";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(32, 236);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(69, 18);
            this.lbpass.TabIndex = 3;
            this.lbpass.Text = "Password";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Location = new System.Drawing.Point(32, 283);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(100, 18);
            this.lbphone.TabIndex = 4;
            this.lbphone.Text = "NumberPhone";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(32, 339);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 18);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // lbrepass
            // 
            this.lbrepass.AutoSize = true;
            this.lbrepass.Location = new System.Drawing.Point(32, 395);
            this.lbrepass.Name = "lbrepass";
            this.lbrepass.Size = new System.Drawing.Size(86, 18);
            this.lbrepass.TabIndex = 6;
            this.lbrepass.Text = "RePassword";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(160, 182);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(127, 26);
            this.txtuser.TabIndex = 7;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(160, 228);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(127, 26);
            this.txtpass.TabIndex = 8;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(160, 283);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(127, 26);
            this.txtphone.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(160, 336);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(127, 26);
            this.txtemail.TabIndex = 10;
            // 
            // txtrepass
            // 
            this.txtrepass.Location = new System.Drawing.Point(160, 387);
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.PasswordChar = '*';
            this.txtrepass.Size = new System.Drawing.Size(127, 26);
            this.txtrepass.TabIndex = 11;
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(57, 477);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 35);
            this.btnsignup.TabIndex = 12;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(184, 477);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 35);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit\r\n";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(160, 439);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 22);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(342, 524);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.txtrepass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbrepass);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbphone);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbrepass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtrepass;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}