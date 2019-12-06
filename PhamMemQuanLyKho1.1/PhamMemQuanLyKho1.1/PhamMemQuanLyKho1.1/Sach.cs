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
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }
        public void loaddulieu()
        {
            string thongtin = @"exec dbo.thongtinsach";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_sach.DataSource = dt;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txb_masach.Clear();
            this.txb_tensach.Clear();
            this.txb_loaisach.Clear();
            this.txb_make.Clear();
            this.txb_make.Clear();
            this.txb_soluong.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string kiemtrancc = @"exec dbo.kiemtrasach N'" + txb_masach.Text + "'";
            DataTable dt = connect.getDataTable(kiemtrancc);
            if (dt.Rows.Count == 0)
            {
                string themvao = @"exec dbo.themsach N'" + txb_masach.Text + "',N'" + txb_tensach.Text
                    + "',N'" + txb_loaisach.Text + "',N'" +txb_make+ "'";
                connect.executeQuery(themvao);
                DialogResult dialog = MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddulieu();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Mã sách cấp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            string sua = @"exec dbo.suasach N'" + txb_masach.Text + "',N'" + txb_tensach.Text
                   + "',N'" + txb_loaisach.Text + "',N'" + txb_make.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc là muốn sửa thông tin", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(sua);
                    loaddulieu();
                }
                catch
                {
                    MessageBox.Show("Lỗi thực thi !!!");
                }
            }

        }

        private void dtgv_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_sach.CurrentCell.RowIndex;
            txb_masach.Text = dtgv_sach.Rows[r].Cells[0].Value.ToString();
            txb_tensach.Text = dtgv_sach.Rows[r].Cells[1].Value.ToString();
            txb_loaisach.Text = dtgv_sach.Rows[r].Cells[2].Value.ToString();
            txb_soluong.Text = dtgv_sach.Rows[r].Cells[3].Value.ToString();
            txb_make.Text = dtgv_sach.Rows[r].Cells[4].Value.ToString();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }
    }
}
