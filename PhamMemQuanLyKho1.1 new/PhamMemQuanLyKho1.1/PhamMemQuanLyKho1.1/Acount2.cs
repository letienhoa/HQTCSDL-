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
    public partial class Acount2 : Form
    {
        public Acount2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sua = @"exec dbo.suataikhoan N'" + MyLogin.tk.ToString() + "',N'" + mktb.Text+  "'";
                try
                {
                    connect.executeQuery(sua);
                    MessageBox.Show("Sửa thành công");
                }
                catch
                {
                    MessageBox.Show("Lỗi thực thi !!!");
                }
            MyLogin.mk = mktb.Text;
             this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();        }
    }
}
