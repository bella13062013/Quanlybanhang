using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;


namespace BANHANG
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            KetNoi.moKetNoi();
            loadData();
            loadVer();
            KetNoi.dongKetNoi();
        }
        public void loadVer()
        {
            string sql = "select * from LoaiVer";

            cboVer.DataSource = KetNoi.getData(sql);
            cboVer.DisplayMember = "TenVer";
            cboVer.ValueMember = "MaVer";

        }
        public void loadData()
        {
            string sql = "select * from hoadon";
            data.DataSource = KetNoi.getData(sql);
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Clear();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from hoadon where MaHD like N'%{0}%'", txtTim.Text);
            data.DataSource = KetNoi.getData(sql);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sql = "Insert into hoadon values(@MaHD, @TenHD, @MaNV, @TenNV, @MaKH ,@TenKH , @MaAlbum, @TenAlbum, @MaVer, @SLuong, @ThanhTien, @NgayDatHang, @NgayNhanHang, @DiaChiNhan, @GhiChu)";

            string[] name = { "@MaHD", "@TenHD", "@MaNV", "@TenNV", "@MaKH", "@TenKH", "@MaAlbum", "@TenAlbum" , "@MaVer", "@SLuong", "@ThanhTien", "@NgayDatHang", "@NgayNhanHang", "@DiaChiNhan", "@GhiChu" };

            object[] value = {txtmahd.Text, txttenhd.Text, txtmanv.Text, txttennv.Text , txtmakh.Text, txttenkh.Text, txtmalb.Text, txttenalbum.Text, cboVer.SelectedValue, txtsluong.Text, txttien.Text, dtime1.Value,dtime2.Value,txtdchi.Text,  txtGhiChu.Text};

            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 15);
            loadData();
            KetNoi.dongKetNoi();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Update hoadon set MaHD = @MaHD, TenHD = @TenHD, MaNV = @MaNV, TenNV = @TenNV, MaKH = @MaKH , TenKH = @TenKH, MaAlbum = @MaAlbum, TenAlbum = @TenAlbum, MaVer = @MaVer, SLuong = @SLuong, ThanhTien = @ThanhTien, NgayDatHang = @NgayDatHang, NgayNhanHang = @NgayNhanHang, DiaChiNhan = @DiaChiNhan, GhiChu = @GhiChu where MaHD ='{0}'", txtmahd.Text);

            string[] name = { "@MaHD", "@TenHD", "@MaNV", "@TenNV", "@MaKH", "@TenKH", "@MaAlbum", "@TenAlbum", "@MaVer", "@SLuong", "@ThanhTien", "@NgayDatHang", "@NgayNhanHang", "@DiaChiNhan", "@GhiChu" };

            object[] value = { txtmahd.Text, txttenhd.Text, txtmanv.Text, txttennv.Text, txtmakh.Text, txttenkh.Text, txtmalb.Text, txttenalbum.Text, cboVer.SelectedValue, txtsluong.Text, txttien.Text, dtime1.Value, dtime2.Value, txtdchi.Text, txtGhiChu.Text };

            KetNoi.moKetNoi();
            KetNoi.updateData(sql, value, name, 15);
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
                    string sql = string.Format("delete from hoadon where MaHD ='{0}'", ma);
                    object[] value = { };
                    string[] name = { };

                    KetNoi.moKetNoi();
                    KetNoi.updateData(sql, value, name, 0);
                    loadData();
                    KetNoi.dongKetNoi();
                }
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmahd.Clear();
            txttenhd.Clear();
            txtmanv.Clear();
            txttennv.Clear();
            txtmakh.Clear();
            txttenkh.Clear();
            txtmalb.Clear();
            txttenalbum.Clear();
            txtsluong.Clear();
            txttien.Clear();
            txtdchi.Clear();
            txtGhiChu.Clear();

            txttenhd.Focus();
            KetNoi.moKetNoi();
            loadData();
            KetNoi.dongKetNoi();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = data.CurrentCell.RowIndex;
            txtmahd.Text        = data.Rows[i].Cells[0].Value.ToString();
            txttenhd.Text       = data.Rows[i].Cells[1].Value.ToString();
            txtmanv.Text        = data.Rows[i].Cells[2].Value.ToString();
            txttennv.Text       = data.Rows[i].Cells[3].Value.ToString();
            txtmakh.Text        = data.Rows[i].Cells[4].Value.ToString();
            txttenkh.Text       = data.Rows[i].Cells[5].Value.ToString();
            txtmalb.Text        = data.Rows[i].Cells[6].Value.ToString();
            txttenalbum.Text    = data.Rows[i].Cells[7].Value.ToString();
            cboVer.SelectedValue= data.Rows[i].Cells[8].Value.ToString();
            txtsluong.Text      = data.Rows[i].Cells[9].Value.ToString();
            txttien.Text        = data.Rows[i].Cells[10].Value.ToString();
            dtime1.Text         = data.Rows[i].Cells[11].Value.ToString();
            dtime2.Text         = data.Rows[i].Cells[12].Value.ToString();
            txtdchi.Text        = data.Rows[i].Cells[13].Value.ToString();
            txtGhiChu.Text      = data.Rows[i].Cells[14].Value.ToString();
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            FrmMain fmain = new FrmMain();
            this.Hide();
            fmain.ShowDialog();
        }

        
    }
}
