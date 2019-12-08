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
        public static string tk;
        public static string mk;
        public MyLogin()
        {
            InitializeComponent();
        }
     
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataGridView a = new DataGridView();

            if (textAcc.Text == "" || textPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản và mật khẩu", "Thông báo");
                return;
            }
             tk =textAcc.Text;
             mk = textPass.Text;
            string b = "";
            string kiemtra = @"exec dbo.laymk1 N'" + tk + "',N'"+ mk +"'";
            DataTable dt = connect.getDataTable(kiemtra);
            if (dt.Rows.Count > 0 )
            {

                string kiemtra2 = @"exec dbo.laymk2 N'" + tk + "',N'" + mk + "',N'" + 1 + "'";
                DataTable dt2 = connect.getDataTable(kiemtra2);

                if (dt2.Rows.Count > 0)
                {
                    b = "1";
                }
                else
                {
                    b = "0";
                }

                MessageBox.Show("Xin chào " + textAcc.Text + "! Bạn đã đăng nhập thành công!", "Thông báo");
                this.Hide();
                if(b =="1")
                {
                    MainWindow.ilogin = true;
                    MainWindow.checkuser = true;
                }
                else if (b =="0")
                {
                    MainWindow.ilogin = true;
                    MainWindow.checkuser = false;
                }
                
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
