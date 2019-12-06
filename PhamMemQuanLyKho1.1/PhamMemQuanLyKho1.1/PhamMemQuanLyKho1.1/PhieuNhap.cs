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
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
        }
        public void loaddulieu()
        {
            string thongtin = @"exec dbo.infophieunhap";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_phieunhap.DataSource = dt;
        }
        private void btn_exitpn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addpn_Click(object sender, EventArgs e)
        {
            string kiemtrancc = @"exec dbo.kiemtraphieunhap N'" + txb_maphieunhap.Text + "'";
            DataTable dt = connect.getDataTable(kiemtrancc);
            if (dt.Rows.Count == 0)
            {
                string themvao = @"exec dbo.themphieunhap N'" + txb_maphieunhap.Text + "',N'" + txb_ngaynhap.Text
                    + "',N'" + txb_mathukho.Text + "',N'" + txb_mancc.Text + "',N'" + txb_soluong.Text + "',N'" + txb_mahang.Text + "'";
                connect.executeQuery(themvao);
               
                loaddulieu();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Mã phiếu nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_clearpn_Click(object sender, EventArgs e)
        {
            this.txb_mancc.Clear();
            this.txb_maphieunhap.Clear();
            this.txb_ngaynhap.Clear();
            this.txb_mathukho.Clear();
            this.txb_mahang.Clear();
            this.txb_soluong.Clear();
            this.txb_mancc.Clear();
        }

        private void btn_fixpn_Click(object sender, EventArgs e)
        {
            string sua = @"exec dbo.suaphieunhap N'" + txb_maphieunhap.Text + "',N'" + txb_ngaynhap.Text
                    + "',N'" + txb_mathukho.Text + "',N'" + txb_mahang.Text + "',N'" + txb_soluong.Text + "',N'" + txb_mancc.Text + "'";
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

        private void dtgv_phieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_phieunhap.CurrentCell.RowIndex;
            txb_maphieunhap.Text = dtgv_phieunhap.Rows[r].Cells[0].Value.ToString();
            txb_ngaynhap.Text = dtgv_phieunhap.Rows[r].Cells[1].Value.ToString();
            txb_mathukho.Text = dtgv_phieunhap.Rows[r].Cells[2].Value.ToString();
            txb_mahang.Text = dtgv_phieunhap.Rows[r].Cells[3].Value.ToString();
            txb_soluong.Text = dtgv_phieunhap.Rows[r].Cells[4].Value.ToString();
            txb_mancc.Text = dtgv_phieunhap.Rows[r].Cells[5].Value.ToString();
        }
    }
}
