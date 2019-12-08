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
    public partial class Acount : Form
    {
        public Acount()
        {
            InitializeComponent();
        }
        private void Acount_Load(object sender, EventArgs e)
        {
            txb_taikhoan.Text = MyLogin.tk.ToString();
            txb_matkhau.Text = MyLogin.mk.ToString();
            this.txb_taikhoan.Enabled = false;
            this.txb_matkhau.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form ac2 = new Acount2();
            ac2.ShowDialog();    
        }
    }
}
