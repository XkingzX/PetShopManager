using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DeTai_QuanLyCuaHangThuCung
{
    class DataProvider
    {
        static string cnStr = @"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;Encrypt=True;";
        static SqlConnection connect;
        static public DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable();
            connect = new SqlConnection(cnStr);
            SqlCommand command = new SqlCommand(sql, connect);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            return dt;
        }

        static public DataSet LoadCSDLDTS(string sql)
        {
            DataSet dts = new DataSet();
            connect = new SqlConnection(cnStr);
            SqlCommand cm = new SqlCommand(sql, connect);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dts);
            return dts;
        }

        static public int Change(string sql)
        {
            connect = new SqlConnection(cnStr);
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            SqlCommand cm = new SqlCommand(sql, connect);
            int kq = cm.ExecuteNonQuery();
            connect.Close();
            return kq;
        }

    }
}
