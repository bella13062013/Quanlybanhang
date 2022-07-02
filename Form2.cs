using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
namespace BANHANG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.PasswordChar = (char)0;
                txtrepass.PasswordChar = (char)0;
            }
            else
            {
                txtpass.PasswordChar = '*';
                txtrepass.PasswordChar = '*';
            }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (txtpass.Text != txtrepass.Text)
            {
                MessageBox.Show("Mật khẩu không trùng !");
            }
            else
            { 
                string sql = "Insert into admin values(@Username,@Password ,@Numberphone,@Email,@Repassword)";

                string[] name = { "@Username", "@Password", "@Numberphone", "@Email", "@Repassword" };

                object[] value = { txtuser.Text, txtpass.Text, txtphone.Text, txtemail.Text, txtrepass.Text };

                KetNoi.moKetNoi();
                KetNoi.updateData(sql, value, name, 5);
                FrmMain fmain = new FrmMain();
                this.Hide();
                fmain.ShowDialog();
                KetNoi.dongKetNoi();
        }
                
            }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.ShowDialog();
        }
    }
 }
