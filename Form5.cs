using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANHANG
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            loadData();
            loadVer();
            KetNoi.dongKetNoi();
        }
        public void loadVer()
        {
            string sql = "select * from LoaiVer";

            cbover.DataSource = KetNoi.getData(sql);
            cbover.DisplayMember = "TenVer";
            cbover.ValueMember = "MaVer";

        }
        public void loadData()
        {
            string sql = "select * from sanpham";
            data.DataSource = KetNoi.getData(sql);
        }

        private void btnmo_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(oFile.FileName);
                lbanh.Text = Path.GetFileName(oFile.FileName);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sql = "Insert into sanpham values(@MaAlbum,@TenAlbum ,@MaVer,@SLuong,@GiaVao,@GiaRa,@Picture)";
            
            string[] name = { "@MaAlbum", "@TenAlbum", "@MaVer", "@SLuong", "@GiaVao", "@GiaRa", "@Picture" };

            object[] value = { txtalb.Text, txttenalb.Text, cbover.SelectedValue,txtsoluong.Text,txtgiavao.Text,txtgiara.Text, lbanh.Text };

            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 7);
            loadData();
            KetNoi.dongKetNoi();
        }
        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = data.CurrentCell.RowIndex;
            txtalb.Text = data.Rows[i].Cells[0].Value.ToString();
            txttenalb.Text = data.Rows[i].Cells[1].Value.ToString();
            cbover.SelectedValue = data.Rows[i].Cells[2].Value.ToString();

            txtsoluong.Text = data.Rows[i].Cells[3].Value.ToString();
            txtgiavao.Text = data.Rows[i].Cells[4].Value.ToString();
            txtgiara.Text = data.Rows[i].Cells[5].Value.ToString();

            lbanh.Text = data.Rows[i].Cells[6].Value.ToString();

            string pathAnh = ConfigurationManager.AppSettings.Get("duongdananh") + "\\" + lbanh.Text;
            if (File.Exists(pathAnh))
            {
                pictureBox1.Image = Image.FromFile(pathAnh);
            }
            else
                pictureBox1.Image = null;
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Update sanpham set MaAlbum = @MaAlbum,tenAlbum =@TenAlbum ,MaVer =@MaVer,SLuong =@SLuong ,GiaVao =@GiaVao, GiaRa = @GiaRa,Picture = @Picture where MaAlbum ='{0}'", txtalb.Text);

            string[] name = { "@MaAlbum", "@TenAlbum", "@MaVer", "@SLuong", "@GiaVao", "@GiaRa", "@Picture" };

            object[] value = { txtalb.Text, txttenalb.Text, cbover.SelectedValue, txtsoluong.Text, txtgiavao.Text, txtgiara.Text, lbanh.Text };

            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 7);
            loadData();
            KetNoi.dongKetNoi();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i = data.CurrentCell.RowIndex;
            if (i >= 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    string ma = data.Rows[i].Cells[0].Value.ToString();
                    string sql = string.Format("delete from sanpham where MaAlbum ='{0}'", ma);
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
            txttenalb.Clear();
            txtalb.Clear();
            txtsoluong.Clear();
            txtgiavao.Clear();
            txtgiara.Clear();

            txttenalb.Focus();
            KetNoi.moKetNoi();
            loadData();
            KetNoi.dongKetNoi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from sanpham where MaAlbum like N'%{0}%'", txtTim.Text);
            data.DataSource = KetNoi.getData(sql);
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            this.Hide();
            main.ShowDialog();
        }
    }
    
}
