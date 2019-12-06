using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhamMemQuanLyKho1._1
{
    public class connect
    {
        public string Stringconnect = "";
        static SqlConnection cnn;
        static SqlDataAdapter da;
        static DataSet ds;
        static SqlCommand cmd;
        static string source;
        public static void openConnection()
        {
            source = @"Data Source=ALVIND-MARTIN-P\SQLEXPRESS;Initial Catalog=QuanLyKho;Integrated Security=True";
            cnn = new SqlConnection(source);
            try
            {
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không thể kết nối đến cơ sở dữ liệu!");
                return;
            }
        }
        public static void executeQuery(String sql)
        {
            cmd = new SqlCommand();
            //openConnection();
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi dữ liệu:" + ex.Message);
                return;
            }

        }

        public static DataSet getDataSet(String sql)
        {

            openConnection();
            da = new SqlDataAdapter(sql, cnn);
            ds = new DataSet();
            da.Fill(ds);
            cnn.Close();
            return ds;
        }

        public static DataTable getDataTable(String sql)
        {
            openConnection();
            da = new SqlDataAdapter(sql, cnn);
            ds = new DataSet();
            da.Fill(ds);
            cnn.Close();
            return ds.Tables[0];
        }
    }
}

