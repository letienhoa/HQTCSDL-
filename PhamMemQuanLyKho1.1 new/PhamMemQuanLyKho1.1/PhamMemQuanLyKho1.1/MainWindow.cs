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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            loadDATA();
        }
        public static bool ilogin = false;
        public static bool checkuser = false;
        void loadDATA()
        {

            if (ilogin == true && checkuser ==true)
            {
                btnLogin.Enabled = false;
                btnLogout.Enabled = true;
                btnSach.Enabled = true;
                btnLoaiSach.Enabled = true;
                btnKeSach.Enabled = true;
                btnNCC.Enabled = true;
                btnNV.Enabled = true;
                btnKH.Enabled = true;
                btnBPNV.Enabled = true;
                btnPN.Enabled = true;
                btnPX.Enabled = true;
                acountbtn.Enabled = true;
            }
            else if (ilogin == true && checkuser == false)
            {
                btnLogin.Enabled = false;
                btnLogout.Enabled = true;
                btnSach.Enabled = false;
                btnLoaiSach.Enabled = false;
                btnKeSach.Enabled = false;
                btnNCC.Enabled = false;
                btnNV.Enabled = false;
                btnKH.Enabled = false;
                btnBPNV.Enabled = false;
                btnPN.Enabled = false;
                btnPX.Enabled = true;
                acountbtn.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = true;
                btnLogout.Enabled = false;
                btnSach.Enabled = false;
                btnLoaiSach.Enabled = false;
                btnKeSach.Enabled = false;
                btnNCC.Enabled = false;
                btnNV.Enabled = false;
                btnKH.Enabled = false;
                btnBPNV.Enabled = false;
                btnPN.Enabled = false;
                btnPX.Enabled = false;
                acountbtn.Enabled = false;

            }

        }
        void loadDATAlogout()
        {
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            btnSach.Enabled = false;
            btnLoaiSach.Enabled = false;
            btnKeSach.Enabled = false;
            btnNCC.Enabled = false;
            btnNV.Enabled = false;
            btnKH.Enabled = false;
            btnBPNV.Enabled = false;
            btnPN.Enabled = false;
            btnPX.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MyLogin lg = new MyLogin();
            lg.ShowDialog();
            loadDATA();
        }

        private void btnKeSach_Click(object sender, EventArgs e)
        {
            Form ke = new Ke();
            ke.ShowDialog();
        }

        private void btnLoaiSach_Click(object sender, EventArgs e)
        {
            Form ls = new LoaiSach();
            ls.ShowDialog();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            Form nhacungcap = new NhaCungCap();
            nhacungcap.ShowDialog();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            Form nv = new NhanVien();
            nv.ShowDialog();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            Form khachhang = new KhachHang();
            khachhang.ShowDialog();
        }

        private void btnBPNV_Click(object sender, EventArgs e)
        {
            Form bophannv = new BoPhanNhanVien();
            bophannv.ShowDialog();
        }

        private void btnPX_Click(object sender, EventArgs e)
        {
            Form px = new PhieuXuat();
            px.ShowDialog();
        }

        private void btnPN_Click(object sender, EventArgs e)
        {
            Form px = new PhieuNhap();
            px.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn muốn thoát thật chứ ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            Form sach = new Sach();
            sach.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loadDATAlogout();
            DialogResult dialog = MessageBox.Show("Bạn đã thoát đăng nhập, OK để đăng nhập lại hoặc CANCEL ?", "Thoát đăng nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                MyLogin lg = new MyLogin();
                lg.ShowDialog();
                loadDATA();

                
            }
            else if(dialog == DialogResult.Cancel)
            {
                loadDATAlogout();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ac = new Acount();
            ac.ShowDialog();
            loadDATA();
        }
    }
}
