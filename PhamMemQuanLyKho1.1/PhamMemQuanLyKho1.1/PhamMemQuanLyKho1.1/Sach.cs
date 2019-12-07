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
        int a = 0;
        public Sach()
        {
            InitializeComponent();
        }
        public void cl()
        {
            this.txb_masach.Clear();
            this.txb_tensach.Clear();
            this.txb_loaisach.ResetText();
            this.txb_make.ResetText();
            this.txb_soluong.Clear();
        }
        public void loaddulieu()
        {
            string thongtin = @"exec dbo.thongtinsach";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_sach.DataSource = dt;

            string thongtin2 = @"exec dbo.thongtinsach2";
            DataTable dt2 = connect.getDataTable(thongtin2);
            txb_loaisach.DataSource = dt2;
            txb_loaisach.DisplayMember = "tenloaisach";

            string thongtin3 = @"exec dbo.thongtinsach3";
            DataTable dt3 = connect.getDataTable(thongtin3);
            txb_make.DataSource = dt3;
            txb_make.DisplayMember = "make";


            txb_masach.Enabled = false;
            txb_tensach.Enabled = false;
            txb_loaisach.Enabled = false;
            txb_make.Enabled = false;
            txb_soluong.Enabled = false;

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            cl();
            loaddulieu();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            a = 1;
            cl();
            txb_masach.Enabled = true;
            txb_tensach.Enabled = true;
            txb_loaisach.Enabled = true;
            txb_make.Enabled = true;
            txb_soluong.Enabled = false;
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if (a == 2)
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
            else if (a == 1)
            {
                string kiemtrancc = @"exec dbo.kiemtrasach N'" + txb_masach.Text + "'";
                DataTable dt = connect.getDataTable(kiemtrancc);
                if (dt.Rows.Count == 0)
                {
                    string themvao = @"exec dbo.themsach N'" + txb_masach.Text + "',N'" + txb_tensach.Text
                        + "',N'" + txb_loaisach.Text + "',N'" + txb_make.Text + "'";
                    connect.executeQuery(themvao);
                    DialogResult dialog = MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddulieu();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Mã sách cấp đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            a = 0;

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            a = 2;
            txb_tensach.Enabled = true;
            txb_loaisach.Enabled = true;
            txb_make.Enabled = true;
        }

        private void txb_searchid_TextChanged(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.searchsach N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_sach.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.searchsach N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_sach.DataSource = dt;
        }
    }
}
