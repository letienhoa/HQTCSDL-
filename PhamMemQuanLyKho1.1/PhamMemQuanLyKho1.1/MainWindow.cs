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

                btnKho.Enabled = true;
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
            KhoHang_form kh = new KhoHang_form();
            kh.ShowDialog();
        }
    }
}
