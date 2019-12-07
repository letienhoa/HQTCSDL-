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
    public partial class KhachHang : Form
    {
        int a = 0;
        public KhachHang()
        {
            InitializeComponent();
         
        }

        public void loaddulieu()
        {
            string thongtin = @"exec dbo.thongtinkhachhang";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_khachhang.DataSource = dt;

            txb_ma.Enabled = false;
            txb_ten.Enabled = false;
            txb_sex.Enabled = false;
            txb_diachi.Enabled = false;
        }
        private void btn_clearn_Click(object sender, EventArgs e)
        {
            this.txb_ma.Clear();
            this.txb_ten.Clear();
            this.txb_diachi.Clear();
            this.txb_sex.Clear();
            loaddulieu();
        }
        private void dtgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_khachhang.CurrentCell.RowIndex;
            txb_ma.Text = dtgv_khachhang.Rows[r].Cells[0].Value.ToString();
            txb_ten.Text = dtgv_khachhang.Rows[r].Cells[1].Value.ToString();
            txb_sex.Text = dtgv_khachhang.Rows[r].Cells[2].Value.ToString();
            txb_diachi.Text = dtgv_khachhang.Rows[r].Cells[3].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            a = 1;
            txb_ma.Enabled = true;
            txb_ten.Enabled = true;
            txb_sex.Enabled = true;
            txb_diachi.Enabled = true;
            
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if(a == 1)
            {
                string kiemtra = @"exec dbo.kiemtrakhachhang N'" + txb_ma.Text + "'";
                DataTable dt = connect.getDataTable(kiemtra);
                if (dt.Rows.Count == 0)
                {
                    string themvao = @"exec dbo.themkhachhang N'" + txb_ma.Text + "',N'" + txb_ten.Text
                        + "',N'" + txb_sex.Text + "',N'" + txb_diachi.Text + "'";
                    connect.executeQuery(themvao);
                    DialogResult dialog = MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddulieu();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Mã khách hàng đã tồn tại, vui long thêm lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(a ==2)
            {
                string sua = @"exec dbo.suakhachhang N'" + txb_ma.Text + "',N'" + txb_ten.Text
                   + "',N'" + txb_sex.Text + "',N'" + txb_diachi.Text + "'";
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string xoa = @"exec dbo.xoakhachhang N'" + txb_ma.Text + "'";
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void txb_searchid_TextChanged(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.searchkhachhang N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_khachhang.DataSource = dt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            a = 2;
            txb_ma.Enabled = false;
            txb_ten.Enabled = true;
            txb_sex.Enabled = true;
            txb_diachi.Enabled = true;
        }
    }
}
