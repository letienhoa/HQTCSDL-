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
        int a = 0;
        public PhieuNhap()
        {
            InitializeComponent();
        }
        public void loaddulieu()
        {
            string thongtin = @"exec dbo.infophieunhap";
            DataTable dt = connect.getDataTable(thongtin);
            dtgv_phieunhap.DataSource = dt;

            string thongtin2 = @"exec dbo.phieunhapmanv";
            DataTable dt2 = connect.getDataTable(thongtin2);
            txb_mathukho.DataSource = dt2;
            txb_mathukho.DisplayMember = "manhanvien";

            string thongtin3 = @"exec dbo.phieunhapmasach";
            DataTable dt3 = connect.getDataTable(thongtin3);
            txb_mahang.DataSource = dt3;
            txb_mahang.DisplayMember = "masach";

            string thongtin4 = @"exec dbo.phieunhapmancc";
            DataTable dt4 = connect.getDataTable(thongtin4);
            txb_mancc.DataSource = dt4;
            txb_mancc.DisplayMember = "mancc";


            this.txb_mancc.Enabled = false;
            this.txb_maphieunhap.Enabled =false;
            this.txb_ngaynhap.Enabled = false;
            this.txb_mathukho.Enabled = false;
            this.txb_mahang.Enabled = false;
            this.txb_soluong.Enabled = false;
        }
        private void btn_exitpn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addpn_Click(object sender, EventArgs e)
        {
            a = 1;
            this.txb_mancc.Enabled = true;
            this.txb_maphieunhap.Enabled = true;
            this.txb_ngaynhap.Enabled = true;
            this.txb_mathukho.Enabled = true;
            this.txb_mahang.Enabled = true;
            this.txb_soluong.Enabled = true;
            
        }

        private void btn_clearpn_Click(object sender, EventArgs e)
        {
            this.txb_mancc.ResetText();
            this.txb_maphieunhap.Clear();
            this.txb_ngaynhap.Clear();
            this.txb_mathukho.ResetText();
            this.txb_mahang.ResetText();
            this.txb_soluong.Clear();
            loaddulieu();
        }

        private void btn_fixpn_Click(object sender, EventArgs e)
        {
            if(a == 1)
            {
                string kiemtrancc = @"exec dbo.kiemtraphieunhap N'" + txb_maphieunhap.Text + "'";
                DataTable dt = connect.getDataTable(kiemtrancc);
                if (dt.Rows.Count == 0)
                {
                    string themvao = @"exec dbo.themphieunhap N'" + txb_maphieunhap.Text + "',N'" + txb_ngaynhap.Text
                        + "',N'" + txb_mathukho.Text + "',N'" + txb_mahang.Text + "',N'" + txb_soluong.Text + "',N'" + txb_mancc.Text + "'";
                    connect.executeQuery(themvao);

                    loaddulieu();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Mã phiếu nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(a == 2)
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
            a = 0;
            
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

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            a = 2;
            this.txb_mancc.Enabled = true;
            this.txb_maphieunhap.Enabled = false;
            this.txb_ngaynhap.Enabled = true;
            this.txb_mathukho.Enabled = true;
            this.txb_mahang.Enabled = true;
            this.txb_soluong.Enabled = true;

        }
    }
}
