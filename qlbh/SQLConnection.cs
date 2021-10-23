﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace qlbh
{
    class SQLConnection
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void Ketnoi_DuLieu()
        {
            // Huan
            string source = "Data Source=DESKTOP-201IC1A\\SQLEXPRESS;Initial Catalog=qlbanhang;Integrated Security=True";
           
            // Tham
            //string source = @"Data Source=DESKTOP-1AMUFBN\SQLEXPRESS;Initial Catalog=qlbanhang;Integrated Security=True";
            cnn = new SqlConnection(source);
            cnn.Open();
        }
        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
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
            cmd = new SqlCommand(Sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}