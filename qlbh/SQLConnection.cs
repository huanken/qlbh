using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlbh
{
    class SQLConnection
    {
        public static SqlConnection cnn;
        public static SqlCommand cmd;
        public static DataTable dta;
        public static SqlDataAdapter ada;

        public static void Ketnoi_DuLieu()
        {
            // Huan
            string source = "Data Source=DESKTOP-201IC1A\\SQLEXPRESS;Initial Catalog=qlbanhang;Integrated Security=True";

            // Binh
            //string source = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=qlbanhang;Integrated Security=True";

            // Ha
            //string source = "Data Source=DESKTOP-UKCIEJ7\\SQLEXPRESS;Initial Catalog=qlbanhang;Integrated Security=True";

            // Tham
            //string source = @"Data Source=DESKTOP-1AMUFBN\SQLEXPRESS;Initial Catalog=qlbanhang;Integrated Security=True";


            cnn = new SqlConnection(source);
            cnn.Open();
        }
        public static void HuyKetNoi()
        {
            if (cnn == null)
            {
                return;
            }
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        public DataTable Lay_DulieuBang(string Sql)
        {
            Ketnoi_DuLieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
        public void Thucthi(string Sql)
        {
            Ketnoi_DuLieu();
            try
            {
                cmd = new SqlCommand(Sql, cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
           
            HuyKetNoi();
        }
        public static string CreateUniqueID(string prefix, DateTime dt)
        {
            return prefix
                    + dt.ToString("dd/MM/yy").Replace("/", "")
                    + "T"
                    + dt.ToString("HH:mm:ss").Replace(":", "");
        }

        public static DataTable ExecuteDataTable(string commandText)
        {
            Ketnoi_DuLieu();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(commandText, cnn);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Fail to get datatable");
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                HuyKetNoi();
            }

            return null;
        }

        //Thực thi command
        public static void ExecuteCommand(SqlCommand cmd)
        {
            Ketnoi_DuLieu();
            cmd.Connection = cnn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                HuyKetNoi();
            }
        }
        public static string GetFieldValues(string commandText)
        {
            Ketnoi_DuLieu();

            string id = "";

            try
            {
                SqlDataReader reader = new SqlCommand(commandText, cnn).ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetValue(0).ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Fail to get field value");
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                HuyKetNoi();
            }

            return id;
        }


    }
}
