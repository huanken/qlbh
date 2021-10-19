using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace qlbh
{
    //Data Source=DESKTOP-1AMUFBN\SQLEXPRESS;Initial Catalog=qlbanhang;Integrated Security=True
    class SQLConnection
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

       
        public void Ketnoi_Dulieu()
        {
            string Ketnoi = @"Data Source=DESKTOP-1AMUFBN\SQLEXPRESS;Initial Catalog=qlbanhang;Integrated Security=True";
            cnn = new SqlConnection(Ketnoi);
            cnn.open();
        }
        public void HuyKetnoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public DataTable Lay_Dulieubang(string sql)
        {
            Ketnoi_Dulieu();
            ada = new SqlDataAdapter(sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
        public void ThucThi(string sql)
        {
            Ketnoi_Dulieu();
            cmd = new SqlCommand(sql,cnn);
            cmd.ExcuteNonQuery();
            HuyKetnoi();
        }
    }
}
