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
    public partial class PhieuXuat : Form
    {
        public PhieuXuat()
        {
            InitializeComponent();
        }
        public void loaddulieu()
        {
            string thongtin = @"exec dbo.infophieuxuat";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_phieuxuat.DataSource = dt;
        }

        private void btn_exitpx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clearpx_Click(object sender, EventArgs e)
        {
            this.txb_makhachhang.Clear();
            this.txb_maphieuxuat.Clear();
            this.txb_ngayxuat.Clear();
            this.txb_mathukho.Clear();
            this.txb_mahang.Clear();
            this.txb_soluong.Clear();
            this.txb_trangthai.Clear();
        }

        private void dtgv_phieuxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_phieuxuat.CurrentCell.RowIndex;
            txb_maphieuxuat.Text = dtgv_phieuxuat.Rows[r].Cells[0].Value.ToString();
            txb_ngayxuat.Text = dtgv_phieuxuat.Rows[r].Cells[1].Value.ToString();
            txb_mathukho.Text = dtgv_phieuxuat.Rows[r].Cells[2].Value.ToString();
            txb_mahang.Text = dtgv_phieuxuat.Rows[r].Cells[3].Value.ToString();
            txb_soluong.Text = dtgv_phieuxuat.Rows[r].Cells[4].Value.ToString();
            txb_makhachhang.Text = dtgv_phieuxuat.Rows[r].Cells[5].Value.ToString();
            txb_trangthai.Text = dtgv_phieuxuat.Rows[r].Cells[6].Value.ToString();
        }

        private void btn_addpx_Click(object sender, EventArgs e)
        {
            string kiemtrancc = @"exec dbo.kiemtraphieuxuat N'" + txb_maphieuxuat.Text + "'";
            DataTable dt = connect.getDataTable(kiemtrancc);
            if (dt.Rows.Count == 0)
            {
                string themvao = @"exec dbo.themphieunhap N'" + txb_maphieuxuat.Text + "',N'" + txb_ngayxuat.Text
                    + "',N'" + txb_mathukho.Text + "',N'" + txb_mahang.Text + "',N'" + txb_soluong.Text + "',N'" + txb_makhachhang.Text + "',N'" + txb_trangthai.Text + "'";
                connect.executeQuery(themvao);
                DialogResult dialog = MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddulieu();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Mã phiếu nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_fixpx_Click(object sender, EventArgs e)
        {
            string sua = @"exec dbo.suaphieuxuat N'" + txb_maphieuxuat.Text + "',N'" + txb_ngayxuat.Text
                   + "',N'" + txb_mathukho.Text + "',N'" + txb_mahang.Text + "',N'" + txb_soluong.Text + "',N'" + txb_makhachhang.Text + "',N'" + txb_trangthai.Text + "'";
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
    }
}
