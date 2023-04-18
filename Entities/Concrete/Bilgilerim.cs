using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Bilgilerim
    {
        public int id { get; set; }
        public int Grubsid { get; set; }
        public int Tursid { get; set; }
        public string TabelaAdi { get; set; }
        public int Ulkesid  { get; set; }
        public int Sehirsid  { get; set; }
        public int İlcesid  { get; set; }
        public string Postakodu { get; set; }
        public string Adres { get; set; }
        public string Sabitno { get; set; }
        public string Gsm { get; set; }
        public string Fax { get; set; }
        public string Eposta { get; set; }
        public string Url { get; set; }
        public string Vergidaire { get; set; }
        public string Vergino { get; set; }
        public string AdSoyad { get; set; }
    }
}
