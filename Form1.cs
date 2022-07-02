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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtpass.PasswordChar = (char)0;
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void btblog_Click(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            if (KetNoi.dangNhap(txtuser.Text,txtpass.Text) == false)
                MessageBox.Show("Tên đăng nhập/Mật khẩu không hợp lệ!");
            else
            {
                FrmMain main = new FrmMain();
                this.Hide();
                main.ShowDialog();
            }                
            KetNoi.dongKetNoi();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.ShowDialog();
        }

       

        private void lbregister_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }
    }
}
