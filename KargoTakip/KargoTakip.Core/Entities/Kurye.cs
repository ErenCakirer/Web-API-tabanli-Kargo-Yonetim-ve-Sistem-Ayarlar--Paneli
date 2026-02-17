using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Core.Entities
{
   public class Kurye
    {

        public int KuryeID { get; set; }
        public string AdSoyad { get; set; }
        public string AracTipi { get; set; } 
        public string Durum { get; set; } 
        public string FotografUrl { get; set; }
    }
}
