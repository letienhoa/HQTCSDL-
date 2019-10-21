using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamMemQuanLyKho1._1
{
    public partial class MyLogin : Form
    {
        public MyLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ALVIND-MARTIN-P\SQLEXPRESS;Initial Catalog=QuanLyNhaTro;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = textAcc.Text;
                string pass = textPass.Text;
                string sql = "select *from LoginProgram where TaiKhoan='" + tk + "'and MatKhau='" + pass + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    //MainWindow.ilogin = true;
                    DialogResult dgtc = MessageBox.Show("đăng nhập thành công.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (dgtc == DialogResult.OK)
                    {
                        
                        MainWindow main = new MainWindow();
                        this.Hide();
                        main.ShowDialog();
                        
                    }
                }
                else
                {

                    if (textAcc.Text == "" & textPass.Text == "")
                    {
                        DialogResult dg1 = MessageBox.Show("xin mời đăng nhập !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        DialogResult dg = MessageBox.Show("đăng nhập sai !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thoát Chương Trình", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //no code
            }
        }
    }
}
