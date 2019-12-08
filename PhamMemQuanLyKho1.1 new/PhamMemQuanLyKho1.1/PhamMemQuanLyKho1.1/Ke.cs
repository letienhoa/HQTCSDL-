using PhamMemQuanLyKho1._1.MyClassCode;
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
    public partial class Ke : Form
    {
        int a = 0;
        public Ke()
        {
            InitializeComponent();
        }
        public void loaddulieu()
        {
            string thongtin = @"exec dbo.thongtinke";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_ke.DataSource = dt;

            txb_make.Enabled = false;
            txb_tenke.Enabled = false;
        }
        private void btn_clearn_Click(object sender, EventArgs e)
        {
            this.txb_make.Clear();
            this.txb_tenke.Clear();
            loaddulieu();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            a = 1;
            txb_make.Enabled = true;
            txb_tenke.Enabled = true;

            
        }

        private void Ke_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if(a == 1)
            {
                string kiemtrake = @"exec dbo.kiemtrake N'" + txb_make.Text + "'";
                DataTable dt = connect.getDataTable(kiemtrake);
                if (dt.Rows.Count == 0)
                {
                    string themvao = @"exec dbo.themke N'" + txb_make.Text + "',N'" + txb_tenke.Text + "'";
                    connect.executeQuery(themvao);
                    DialogResult dialog = MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddulieu();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Mã kệ đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (a == 2)
            {
                string sua = @"exec dbo.suake N'" + txb_make.Text + "',N'" + txb_tenke.Text + "'";
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
            string xoa = @"exec dbo.xoake N'" + txb_make.Text + "'";
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

        private void dtgv_ke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_ke.CurrentCell.RowIndex;
            txb_make.Text = dtgv_ke.Rows[r].Cells[0].Value.ToString();
            txb_tenke.Text = dtgv_ke.Rows[r].Cells[1].Value.ToString();
        }

        private void txb_searchid_TextChanged(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.searchke N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_ke.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.thongtinkeid N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_ke.DataSource = dt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            a = 2;
            txb_make.Enabled = false;
            txb_tenke.Enabled = true;
        }
    }
}
