using System;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class Methode
      
    {
        public static string img;
        public static int ID;
        public static string date;
        public static string fullname;
        public static string userNAME;
        public static string CLTnumber;
        public static string CLTemail;
        public static int quantité;
        public static DataTable dt = new DataTable();



        public static SqlConnection ConnectSqlserver()
        {
           

            string conn2 = @"Data Source=IMAD\SQLEXPRESS;Initial Catalog=gestion_Des_ventes_PFE;Integrated Security=True";
            //string conn1 =
            //"Server=tcp:dargonzo.database.windows.net,1433;" +
            //"Initial Catalog=gestiondeventes;" +
            //"Persist Security Info=False;" +
            //"User ID=dargonzo;" +
            //"Password=Gonzo2022;" +
            //"MultipleActiveResultSets=False;" +
            //"Encrypt=True;" +
            //"TrustServerCertificate=False;" +
            //"Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(conn2);
            conn.Open();
            return conn;
 
        }
        public static int Update(string req)
        {
            SqlConnection cn = ConnectSqlserver();
            SqlCommand cmd = new SqlCommand(req, cn);
            int rs = cmd.ExecuteNonQuery();
            cn.Close();
            return rs;
        }
        public static SqlDataReader select(string req)
        {
            SqlConnection cn = ConnectSqlserver();
            SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;

        }
        public static bool Search(string req)
        {
            SqlDataReader rd = select(req);

            if (rd.Read())
            {
                quantité = int.Parse(rd[0].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
