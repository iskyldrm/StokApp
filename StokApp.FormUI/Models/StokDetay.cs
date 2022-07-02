using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokApp.FormUI.Models
{
    public class StokDetay
    {
        public int SiraNo { get; set; }
        public string İslemTipi { get; set; }
        public string EvrakNo { get; set; }
        public DateTime Tarih { get; set; }
        public int Giris { get; set; }
        public int Cikis { get; set; }
        public int Stok { get; set; }
    }
}
}
