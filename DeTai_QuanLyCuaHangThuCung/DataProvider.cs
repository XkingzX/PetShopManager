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
        static string cnStr = @"Data Source=TIENTOi;Initial Catalog=DB_CuaHangThuCung;Integrated Security=True;";
        static SqlConnection cn;
        static public DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable();
            cn = new SqlConnection(cnStr);
            SqlCommand cm = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }

        static public DataSet LoadCSDLDTS(string sql)
        {
            DataSet dts = new DataSet();
            cn = new SqlConnection(cnStr);
            SqlCommand cm = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dts);
            return dts;
        }

        static public int Change(string sql)
        {
            cn = new SqlConnection(cnStr);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cm = new SqlCommand(sql, cn);
            int kq = cm.ExecuteNonQuery();
            cn.Close();
            return kq;
        }

    }
}
