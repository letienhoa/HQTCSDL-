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
    public partial class KhoHang_form : Form
    {
        bool them;
        string err;
        KhoHang kh = new KhoHang();
        public KhoHang_form()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                DGVkho.DataSource = kh.LayKhoHang();
                DGVkho.DataSource = kh.LayThongTinChoKhoHang();
                DGVkho.DataSource = "";
                DGVkho.Columns["MaKho"].Visible = false;
                DGVkho.Columns["TenKho"].Visible = false;

                DGVkho.AutoResizeColumns();
                txtMP.ResetText();
                txtTP.ResetText();
                txtTT.ResetText();
                txtTTP.ResetText();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                pnlcontrol.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnthoat.Enabled = true;

                DGVkho_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu. Lỗi!!!");
            }
        }
        private void KhoHang_form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DGVkho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = DGVkho.CurrentCell.RowIndex;

                txtMP.Text =
                DGVkho.Rows[r].Cells[0].Value.ToString();
                txtTP.Text =
                DGVkho.Rows[r].Cells[1].Value.ToString();
                txtTT.Text =
                DGVkho.Rows[r].Cells[2].Value.ToString();
                txtTTP.Text =
                DGVkho.Rows[r].Cells[3].Value.ToString();
            }
            catch
            { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
