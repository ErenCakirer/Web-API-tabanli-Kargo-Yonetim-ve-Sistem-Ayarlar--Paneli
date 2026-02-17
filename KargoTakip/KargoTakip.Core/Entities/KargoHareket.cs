using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Core.Entities
{
    public class KargoHareket
    {
        public int KargoHareketID { get; set; }
        public string TakipKodu { get; set; } 
        public string Istasyon { get; set; } 
        public string Durum { get; set; }
        public DateTime Tarih { get; set; } 
        public string Aciklama { get; set; }
    }
}
