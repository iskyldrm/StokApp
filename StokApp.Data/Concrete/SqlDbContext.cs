using StokApp.Data.Absract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StokApp.Data.Concrete
{
    public class SqlDbContext : IDbContext
    {
        //1. SqlConnection Nesnesi  
        public SqlConnection sqlConnection;

        // 2. Nesne SqlCommand Nesnesi
        public SqlCommand cmd;
        public string _conStr = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Test; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        /// <summary>
        /// Sql data connection sağlar. Bağlantı adresi girilirse girilen adresren bağlantı açar.
        /// Default olarak Test databaseni bağlanacak.
        /// </summary>
        /// <param name="sqlconnStr">Bağlanılacak adres.</param>
        public SqlDbContext(string sqlconnStr = null)
        {
            if (!String.IsNullOrEmpty(sqlconnStr))
                sqlConnection = new SqlConnection(sqlconnStr);
            else
                sqlConnection = new SqlConnection(_conStr);
        }
        public string SqlBaglantiDurumu()
        {
            if (sqlConnection.State == ConnectionState.Open)
                return "Açık";
            else
                return "Kapalı";
        }
        public bool SqlBaglatiAc()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open(); // bağlantı açıldı
            return true;
        }
        public bool SqlBaglatiKapat()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close(); //bağlantı kapatıldı
            return true;
        }
 
        public SqlDataReader ExecuteQuery(string sql)
        {
            cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = sql;
            SqlBaglatiAc();
            return cmd.ExecuteReader();
        }

        public SqlDataReader SPwithoutParam()
        {
            cmd = new SqlCommand("sp_InOutTableNoParam", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd.ExecuteReader();
        }

        public SqlDataReader SPwithParam(string malKod, int baslangıc, int bitis)
        {
            cmd = new SqlCommand("sp_InOutTable", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Malkodu", malKod);
            cmd.Parameters.AddWithValue("@BaslangıcT", baslangıc);
            cmd.Parameters.AddWithValue("@BitisT", bitis);
            return cmd.ExecuteReader();
        }

    }

}
