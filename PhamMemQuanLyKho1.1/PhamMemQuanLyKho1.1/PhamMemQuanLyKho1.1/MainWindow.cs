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
        void loadDATA()
        {

                btnSach.Enabled = true;
                //btn2.Enabled = true;
                //btn3.Enabled = true;
                //btn4.Enabled = true;
                //btn5.Enabled = true;
                //btn6.Enabled = true;

        }
        public MainWindow()
        {
            InitializeComponent();
            loadDATA();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            Form khachhang = new KhachHang();
            khachhang.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            Form nhacungcap = new NhaCungCap();
            nhacungcap.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Form ke = new Ke();
            ke.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ls = new LoaiSach();
            ls.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
     
            Form bophannv = new BoPhanNhanVien();
            bophannv.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form px = new PhieuNhap();
            px.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form px = new PhieuXuat();
            px.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
