using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolNhanVien_Click(object sender, EventArgs e)
        {
            Form3 nv = new Form3();
            this.Hide();
            nv.ShowDialog();
        }

        private void toolKhachHang_Click(object sender, EventArgs e)
        {
            Form4 kh = new Form4();
            this.Hide();
            kh.ShowDialog();
        }

        private void toolAblum_Click(object sender, EventArgs e)
        {
            Form5 sp = new Form5();
            this.Hide();
            sp.ShowDialog();
        }

        private void toolHoaDon_Click(object sender, EventArgs e)
        {
            Form6 hd = new Form6();
            this.Hide();
            hd.ShowDialog();
        }

        private void toolThoat_Click(object sender, EventArgs e)
        {
            Form7 sign = new Form7();
            this.Hide();
            sign.ShowDialog();
        }

       
    }
}
