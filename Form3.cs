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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            loadData();
            KetNoi.dongKetNoi();
        }
        public void loadData()
        {
            string sql = "select * from nhanvien";
            data.DataSource = KetNoi.getData(sql);
        }

        private void btnanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            if(oFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(oFile.FileName);
                lbanh.Text = Path.GetFileName(oFile.FileName);
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            if (KetNoi.ktraMaNV(txtmanv.Text) == 0)
            {
                string sql = "Insert into nhanvien values(@MaNV,@TenNV ,@GTinh,@Nsinh,@DChi,@SDT,@Picture)";
                string[] name = { "@MaNV", "@TenNV", "@GTinh", "@NSinh", "@DChi", "@SDT", "@Picture" };
                bool gt = rdNam.Checked == true ? true : false;

                object[] value = { txtmanv.Text, txttennv.Text, gt, dtime.Value, txtDchi.Text, txtsdt.Text, lbanh.Text };

                KetNoi.moKetNoi();
                KetNoi.updateData(sql, value, name, 7);
                loadData();
                KetNoi.dongKetNoi();
            }
            else
                MessageBox.Show("Bị trùng mã nhân viên");
            KetNoi.dongKetNoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Update nhanvien set MaNV = @MaNV,tenNV =@TenNV ,GTinh = @GTinh, NSinh=@NSinh, DChi =@DChi ,SDT =@SDT,Picture = @Picture where MaNV ='{0}'", txtmanv.Text);

            string[] name = { "@MaNV", "@TenNV", "@GTinh", "@NSinh", "@DChi", "@SDT", "@Picture" };

            bool gt = rdNam.Checked == true ? true : false;

            object[] value = { txtmanv.Text, txttennv.Text, gt, dtime.Value, txtDchi.Text, txtsdt.Text, lbanh.Text };

            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 7);
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
                    string sql = string.Format("delete from nhanvien where maNV ='{0}'", ma);
                    object[] value = { };
                    string[] name = { };

                    KetNoi.moKetNoi();
                    KetNoi.updateData(sql, value, name, 0);
                    loadData();
                    KetNoi.dongKetNoi();
                }
            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = data.CurrentCell.RowIndex;
            txtmanv.Text = data.Rows[i].Cells[0].Value.ToString();
            txttennv.Text = data.Rows[i].Cells[1].Value.ToString();
            string gt = data.Rows[i].Cells[2].Value.ToString();
            if (gt == "True")
            {
                rdNam.Checked = true;
            }
            else
                rdNu.Checked = true;

            dtime.Text = data.Rows[i].Cells[3].Value.ToString();
            txtDchi.Text = data.Rows[i].Cells[4].Value.ToString();
            txtsdt.Text = data.Rows[i].Cells[5].Value.ToString();

            lbanh.Text = data.Rows[i].Cells[6].Value.ToString();

            string pathAnh = ConfigurationManager.AppSettings.Get("duongdananh") + "\\" + lbanh.Text;
            if (File.Exists(pathAnh))
            {
                pictureBox1.Image = Image.FromFile(pathAnh);
            }
            else
                pictureBox1.Image = null;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txttennv.Clear();
            txtmanv.Clear();
            txtDchi.Clear();
            txtsdt.Clear();
          
            txttennv.Focus();
            KetNoi.moKetNoi();
            loadData();
            KetNoi.dongKetNoi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from nhanvien where MaNV like N'%{0}%'", txtTim.Text);
            data.DataSource = KetNoi.getData(sql);
        }

        private void lbgtinh_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
