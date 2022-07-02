using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokApp.Data.Absract
{
    public interface IDbContext
    {
        string _conStr { get; set; }
        /// <summary>
        /// Sql bağlantı durumunu bildirir.
        /// </summary>
        /// <returns></returns>
        string SqlBaglantiDurumu();
        /// <summary>
        /// Sql bağlantı kapalı ise açar
        /// </summary>
        /// <returns></returns>
        bool SqlBaglatiAc();
        /// <summary>
        /// Sql bağlantı açık ise kapatır.
        /// </summary>
        /// <returns></returns>
        bool SqlBaglatiKapat();
        /// <summary>
        /// Sql sp_InOutTabel prosedürünü çalıştırır. Geriye data reader döner.
        /// </summary>
        /// <param name="malKod">Ekrandan seçilecek olan ürün kodu</param>
        /// <param name="baslangıc">Ekrandan seçilecek olan ilk tarih</param>
        /// <param name="bitis">Ekrandan seçilecek olan ikinci tarih</param>
        /// <returns></returns>
        SqlDataReader SPwithParam(string malKod, int baslangıc, int bitis);
        /// <summary>
        /// Sql sp_InOutTabelwithoutParam prosedürünü çalıştırır. Geriye data reader döner.
        /// </summary>
        /// <returns></returns>
        SqlDataReader SPwithoutParam();
        /// <summary>
        /// Herhangi bir sql sorgusunu çalıştırır.
        /// </summary>
        /// <param name="sql">Sql sorgusu</param>
        /// <returns></returns>
        SqlDataReader ExecuteQuery(string sql)
    }
}
