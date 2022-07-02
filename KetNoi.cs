using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace BANHANG
{
    static class KetNoi
    {
        static SqlConnection conn;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader reader;

        static public void moKetNoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ketnoi"].ConnectionString.ToString();
            try
            {
                conn.Open();

            }
            catch
            {

            }
        }
        static public void dongKetNoi()
        {
            conn.Close();
        }
        static public DataTable getData(string sql)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        static public void updateData(string sql, object[] value, string[] name, int slthamso)
        {
            cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Clear();
            for (int i = 0; i < slthamso; i++)
                cmd.Parameters.AddWithValue(name[i], value[i]);

            cmd.ExecuteNonQuery();

        }
        static public int ktraMaNV(string ma)
        {
            string sql = string.Format("select count(*) from nhanvien where MaNV ='{0}'", ma.Trim()); 
            cmd = new SqlCommand(sql, conn);
            int sl = (int)cmd.ExecuteScalar();
            return sl;
        }
        public static bool dangNhap(string user, string pw)
        {
            SqlDataReader reader = null;
            bool OK = false;
            string sql = "select * from admin";
            SqlCommand cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((user.Trim() == reader["Username"].
                ToString().Trim()) && pw.Trim() ==
                reader["Password"].ToString().Trim())
                    OK = true;
            }


            return OK;
        }
    }
}
