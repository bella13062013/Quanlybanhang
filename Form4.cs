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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            loadData();
            KetNoi.dongKetNoi();
        }
        public void loadData()
        {
            string sql = "select * from khachhang";
            data.DataSource = KetNoi.getData(sql);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sql = "Insert into khachhang values(@MaKH,@TenKH,@GTinh,@DChi,@SDT)";
            string[] name = { "@MaKH", "@TenKH", "@GTinh" , "@DChi", "@SDT" };
            bool gt = rdNam.Checked == true ? true : false;
            object[] value = { txtKH.Text, txttenKH.Text, gt , txtDChi.Text, txtSDT.Text };

            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 5);
            loadData();
            KetNoi.dongKetNoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Update khachhang set MaKH = @MaKH,TenKH =@TenKH , GTinh=@GTinh, DChi =@DChi ,SDT =@SDT where MaKH ='{0}'", txtKH.Text);

            string[] name = { "@MaKH", "@TenKH", "@GTinh", "@DChi", "@SDT" };

            bool gt = rdNam.Checked == true ? true : false;

            object[] value = { txtKH.Text, txttenKH.Text, gt , txtDChi.Text, txtSDT.Text };

            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 5);
            loadData();
            KetNoi.dongKetNoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = data.CurrentCell.RowIndex;
            if (i >= 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    string ma = data.Rows[i].Cells[0].Value.ToString();
                    string sql = string.Format("delete from khachhang where maKH ='{0}'", ma);
                    object[] value = { };
                    string[] name = { };

                    KetNoi.moKetNoi();
                    KetNoi.updateData(sql, value, name, 0);
                    loadData();
                    KetNoi.dongKetNoi();
                }
            }
        }

        private void btnlmoi_Click(object sender, EventArgs e)
        {
            txttenKH.Clear();
            txtKH.Clear();
            txtDChi.Clear();
            txtSDT.Clear();

            txttenKH.Focus();
            KetNoi.moKetNoi();
            loadData();
            KetNoi.dongKetNoi();
        }
        
        private void data_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = data.CurrentCell.RowIndex;
            txtKH.Text = data.Rows[i].Cells[0].Value.ToString();
            txttenKH.Text = data.Rows[i].Cells[1].Value.ToString();
            string gt = data.Rows[i].Cells[2].Value.ToString();
            if (gt == "True")
            {
                rdNam.Checked = true;
            }
            else
                rdNu.Checked = true;
            txtDChi.Text = data.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = data.Rows[i].Cells[4].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from khachhang where MaKH like N'%{0}%'", txtTim.Text);
            data.DataSource = KetNoi.getData(sql);
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            FrmMain fmain = new FrmMain();
            this.Hide();
            fmain.ShowDialog();
        }
    }
}
