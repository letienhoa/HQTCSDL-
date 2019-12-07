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
    public partial class LoaiSach : Form
    {
        int a = 0;
        public LoaiSach()
        {
            InitializeComponent();
        }
        public void loaddulieu()
        {
            string thongtin = @"exec dbo.thongtinloaisach";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_loaisach.DataSource = dt;
            txb_ten.Enabled = false;
        }
        private void LoaiSach_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void btn_clearncc_Click(object sender, EventArgs e)
        {
            this.txb_ten.Clear();
            loaddulieu();
            btn_addncc.Enabled = true;
            btn_sua.Enabled = true;
            btn_deletencc.Enabled = true;
        }

        private void btn_addncc_Click(object sender, EventArgs e)
        {
            a = 1;
            txb_ten.Enabled = true;
            btn_addncc.Enabled = false;
            btn_sua.Enabled = false;
            btn_deletencc.Enabled = false;

        }

        private void btn_fixncc_Click(object sender, EventArgs e)
        {
            btn_addncc.Enabled = true;
            btn_sua.Enabled = true;
            btn_deletencc.Enabled = true;
            if (a == 1)
            {
                string kiemtrancc = @"exec dbo.kiemnhomhang N'" + txb_ten.Text + "'";
                DataTable dt = connect.getDataTable(kiemtrancc);
                if (dt.Rows.Count == 0)
                {
                    string themvao = @"exec dbo.themnhomhang N'" + txb_ten.Text + "'";
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
                string sua = @"exec dbo.suanhomhang N'" + txb_ten.Text + "'";
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
            string xoa = @"exec dbo.xoanhomhang N'" + txb_ten.Text + "'";
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

        private void btn_exitncc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_loaisach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_loaisach.CurrentCell.RowIndex;
            txb_ten.Text = dtgv_loaisach.Rows[r].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.searchloaisach N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_loaisach.DataSource = dt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            a = 2;
            txb_ten.Enabled = true;
            btn_addncc.Enabled = false;
            btn_sua.Enabled = false;
            btn_deletencc.Enabled = false;
        }

        private void txb_searchid_TextChanged(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.searchloaisach N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_loaisach.DataSource = dt;
        }
    }
}
