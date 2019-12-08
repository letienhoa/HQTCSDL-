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
    public partial class BoPhanNhanVien : Form
    {
        int a = 0;
        public BoPhanNhanVien()
        {
            InitializeComponent();
        }
        public void loaddulieu()
        {
            string thongtin = @"exec dbo.thongtinbophan";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_bophannhanvien.DataSource = dt;

            txb_ma.Enabled = false;
            txb_ten.Enabled = false;
        }

        private void btn_clearncc_Click(object sender, EventArgs e)
        {
            this.txb_ma.Clear();
            this.txb_ten.Clear();
            loaddulieu();
        }

        private void btn_addncc_Click(object sender, EventArgs e)
        {
            a = 1;
            txb_ma.Enabled = true;
            txb_ten.Enabled = true;
        }

        private void btn_exitncc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_fixncc_Click(object sender, EventArgs e)
        {
            if(a ==1)
            {
                string kiemtra = @"exec dbo.kiembophan N'" + txb_ma.Text + "'";
                DataTable dt = connect.getDataTable(kiemtra);
                if (dt.Rows.Count == 0)
                {
                    try
                    {
                        string themvao = @"exec dbo.thembophan N'" + txb_ma.Text + "',N'" + txb_ten.Text + "'";
                        connect.executeQuery(themvao);
                        loaddulieu();
                        DialogResult dialog = MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm bị lỗi!!!");
                    }
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Mã nhà cung cấp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (a == 2)
            {
                string sua = @"exec dbo.suabophan N'" + txb_ma.Text + "',N'" + txb_ten.Text + "'";
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

        private void btn_deletencc_Click(object sender, EventArgs e)
        {
            string xoa = @"exec dbo.xoabophan N'" + txb_ma.Text + "'";
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

        private void BoPhanNhanVien_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void dtgv_bophannhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_bophannhanvien.CurrentCell.RowIndex;
            txb_ma.Text = dtgv_bophannhanvien.Rows[r].Cells[0].Value.ToString();
            txb_ten.Text = dtgv_bophannhanvien.Rows[r].Cells[1].Value.ToString();
        }

        private void txb_searchid_TextChanged(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.searchbophannv N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_bophannhanvien.DataSource = dt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            a = 2;
            txb_ma.Enabled = false;
            txb_ten.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.thongtinbophanid N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_bophannhanvien.DataSource = dt;
        }
    }
}
