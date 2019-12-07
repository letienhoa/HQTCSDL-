using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamMemQuanLyKho1._1
{
    public partial class NhanVien : Form
    {
        int a = 0;
        public NhanVien()
        {
            InitializeComponent();
        }
        public void loaddulieu()
        {
            string nv = @"exec dbo.thongtinnv";
            DataTable dt = connect.getDataTable(nv);
            dtgv_nhanvien.DataSource = dt;
            string nv2 = @"exec dbo.thongtinnv2";
            DataTable dt2 = connect.getDataTable(nv2);

            txb_mabophan.DataSource = dt2;
            txb_mabophan.DisplayMember = "mabophan";


            txb_ma.Enabled = false;
            txb_ten.Enabled = false;
            txb_giotinh.Enabled = false;
            txb_diachi.Enabled = false;
            txb_mabophan.Enabled = false;

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            a = 1;
            txb_ma.Enabled = true;
            txb_ten.Enabled = true;
            txb_giotinh.Enabled = true;
            txb_diachi.Enabled = true;
            txb_mabophan.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                string kiemtranv = @"exec dbo.kiemtranv N'" + txb_ma.Text + "'";
                DataTable dt = connect.getDataTable(kiemtranv);
                if (dt.Rows.Count == 0)
                {
                    string themvao = @"exec dbo.themnv N'" + txb_ma.Text + "',N'" + txb_ten.Text
                        + "',N'" + txb_diachi.Text + "',N'" + txb_giotinh.Text + "',N'" + txb_mabophan.Text + "'";
                    connect.executeQuery(themvao);
                    DialogResult dialog = MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddulieu();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Mã nhà cung cấp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (a == 2)
            {
                string sua = @"exec dbo.suanv N'" + txb_ma.Text + "',N'" + txb_ten.Text
                        + "',N'" + txb_diachi.Text + "',N'" + txb_giotinh.Text + "',N'" + txb_mabophan.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có chắc là muốn sửa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        connect.executeQuery(sua);
                        MessageBox.Show("Sửa thành công");
                        loaddulieu();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi thực thi !!!");
                    }
                }
            }
            a = 0;
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            a = 2;
            txb_ma.Enabled = false;
            txb_ten.Enabled = true;
            txb_giotinh.Enabled = true;
            txb_diachi.Enabled = true;
            txb_mabophan.Enabled = true;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txb_ma.Clear();
            this.txb_ten.Clear();
            this.txb_diachi.Clear();
            this.txb_giotinh.ResetText();
            this.txb_mabophan.ResetText();
            loaddulieu();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string xoa = @"exec dbo.xoanv N'" + txb_ma.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn muốn xóa thông tin này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(xoa);
                    MessageBox.Show("Đã xóa dữ liệu !");
                    loaddulieu();
                }
                catch
                {
                    MessageBox.Show("Lỗi thực thi !!!");
                }
            }
        }

        private void dtgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_nhanvien.CurrentCell.RowIndex;
            txb_ma.Text = dtgv_nhanvien.Rows[r].Cells[0].Value.ToString();
            txb_ten.Text = dtgv_nhanvien.Rows[r].Cells[1].Value.ToString();
            txb_diachi.Text = dtgv_nhanvien.Rows[r].Cells[2].Value.ToString();
            txb_giotinh.Text = dtgv_nhanvien.Rows[r].Cells[3].Value.ToString();
            txb_mabophan.Text = dtgv_nhanvien.Rows[r].Cells[4].Value.ToString();

        }

        private void txb_searchid_TextChanged(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.searchnv N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_nhanvien.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.searchnv N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_nhanvien.DataSource = dt;
        }
    }
}
