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
            if (textAcc.Text == "" || textPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản và mật khẩu", "Thông báo");
                return;
            }
            string tk =textAcc.Text;
            string mk = textPass.Text;
            string kiemtra = @"exec dbo.laymk1 N'" + tk + "',N'"+ mk +"'"; 
            DataTable dt= connect.getDataTable(kiemtra);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Xin chào " + textAcc.Text + "! Bạn đã đăng nhập thành công!", "Thông báo");
                this.Hide();
                Form MainWindow = new MainWindow();
                MainWindow.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                textAcc.Clear();
                textPass.Clear();
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
        #region hàm riêng
        void LoadAcountlist()
        {
            string chuoiketnoi = "Data Source=DESKTOP-BH96V59;Initial Catalog=QuanLyKho;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string query = "dbo.";
            conn.Open(); 
            SqlCommand command = new SqlCommand(query,conn);
            DataTable dulieu = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dulieu);
            conn.Close();
        }
        #endregion
    }
}
