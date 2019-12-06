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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }
        public void loaddulieu()
        {
            string thongtin = @"exec dbo.thongtinncc";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_nhacungcap.DataSource = dt;
        }
        private void btn_clearncc_Click(object sender, EventArgs e)
        {
            this.txb_mancc.Clear();
            this.txb_tennhacungcap.Clear();
            this.txb_diachi.Clear();
            this.txb_sdt.Clear();
        }

        private void btn_exitncc_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btn_addncc_Click(object sender, EventArgs e)
        {
            string kiemtrancc = @"exec dbo.kiemtrancc N'" + txb_mancc.Text + "'";
            DataTable dt = connect.getDataTable(kiemtrancc);
            if (dt.Rows.Count == 0)
            {
                string themvao = @"exec dbo.themncc N'" + txb_mancc.Text + "',N'" + txb_tennhacungcap.Text
                    + "',N'" + txb_diachi.Text + "',N'" + txb_sdt.Text + "'";
                connect.executeQuery(themvao);
                DialogResult dialog = MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddulieu();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Mã nhà cung cấp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void btn_fixncc_Click(object sender, EventArgs e)
        {
            string sua= @"exec dbo.suancc N'"+txb_mancc.Text+"',N'" + txb_tennhacungcap.Text
                    + "',N'" + txb_diachi.Text + "',N'" + txb_sdt.Text + "'";
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

        private void btn_deletencc_Click(object sender, EventArgs e)
        {
            string xoa = @"exec dbo.xoancc N'" + txb_mancc.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn muốn xóa thông tin này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try {
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

        private void dtgv_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_nhacungcap.CurrentCell.RowIndex;
            txb_mancc.Text = dtgv_nhacungcap.Rows[r].Cells[0].Value.ToString();
            txb_tennhacungcap.Text= dtgv_nhacungcap.Rows[r].Cells[1].Value.ToString();
            txb_diachi.Text= dtgv_nhacungcap.Rows[r].Cells[2].Value.ToString();
            txb_sdt.Text= dtgv_nhacungcap.Rows[r].Cells[3].Value.ToString();
        }

        private void txb_searchid_TextChanged(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.searchncc N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_nhacungcap.DataSource = dt;
        }
    }
}
