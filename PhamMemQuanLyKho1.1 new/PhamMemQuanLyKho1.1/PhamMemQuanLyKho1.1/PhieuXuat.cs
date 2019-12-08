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
        int a = 0;
        public PhieuXuat()
        {
            InitializeComponent();
        }
        public void loaddulieu()
        {
            string thongtin = @"exec dbo.infophieuxuat";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_phieuxuat.DataSource = dt;

            string thongtin2 = @"exec dbo.phieuxuatnv";
            DataTable dt2 = connect.getDataTable(thongtin2);
            txb_mathukho.DataSource = dt2;
            txb_mathukho.DisplayMember = "manhanvien";

            string thongtin3 = @"exec dbo.phieuxuats";
            DataTable dt3 = connect.getDataTable(thongtin3);
            txb_mahang.DataSource = dt3;
            txb_mahang.DisplayMember = "masach";

            string thongtin4 = @"exec dbo.phieuxuatmkh";
            DataTable dt4 = connect.getDataTable(thongtin4);
            txb_makhachhang.DataSource = dt4;
            txb_makhachhang.DisplayMember = "makhachhang";


            txb_maphieuxuat.Enabled = false;
            txb_ngayxuat.Enabled = false;
            txb_mathukho.Enabled = false;
            txb_mahang.Enabled = false;
            txb_soluong.Enabled = false;
            txb_makhachhang.Enabled = false;
            txb_trangthai.Enabled = false;
        }

        private void btn_exitpx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clearpx_Click(object sender, EventArgs e)
        {
            this.txb_makhachhang.ResetText();
            this.txb_maphieuxuat.Clear();
            this.txb_ngayxuat.Clear();
            this.txb_mathukho.ResetText();
            this.txb_mahang.ResetText();
            this.txb_soluong.Clear();
            this.txb_trangthai.ResetText();
            loaddulieu();
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
            a = 1;
            txb_maphieuxuat.Enabled = true;
            txb_ngayxuat.Enabled = true;
            txb_mathukho.Enabled = true;
            txb_mahang.Enabled = true;
            txb_soluong.Enabled = true;
            txb_makhachhang.Enabled = true;
            txb_trangthai.Enabled = true;
            
        }

        private void btn_fixpx_Click(object sender, EventArgs e)
        {
            if(a == 1)
            {
                string kiemtrancc = @"exec dbo.kiemtraphieuxuat N'" + txb_maphieuxuat.Text + "'";
                DataTable dt = connect.getDataTable(kiemtrancc);
                if (dt.Rows.Count == 0)
                {
                    string themvao = @"exec dbo.themphieuxuat N'" + txb_maphieuxuat.Text + "',N'" + txb_ngayxuat.Text
                        + "',N'" + txb_mathukho.Text + "',N'" + txb_mahang.Text + "',N'" + txb_soluong.Text + "',N'" + txb_makhachhang.Text + "',N'" + txb_trangthai.Text + "'";
                    connect.executeQuery(themvao);
                    loaddulieu();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Mã phiếu xuất đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (a == 2)
            {
                string sua = @"exec dbo.suaphieuxuat N'" + txb_maphieuxuat.Text + "',N'" + txb_ngayxuat.Text
                   + "',N'" + txb_mathukho.Text + "',N'" + txb_mahang.Text + "',N'" + txb_soluong.Text + "',N'" + txb_makhachhang.Text + "',N'" + txb_trangthai.Text + "'";
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
            a = 0;
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            a = 2;
            txb_maphieuxuat.Enabled = false;
            txb_ngayxuat.Enabled = true;
            txb_mathukho.Enabled = true;
            txb_mahang.Enabled = true;
            txb_soluong.Enabled = true;
            txb_makhachhang.Enabled = true;
            txb_trangthai.Enabled = true;
        }

        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = txb_searchid.Text;
            string kiemtra = @"exec dbo.thongtinphieuxuatid N'" + s + "'";
            DataTable dt = connect.getDataTable(kiemtra);
            dtgv_phieuxuat.DataSource = dt;
        }
    }
}
