using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Core.Entities
{
    public class Ayarlar
    {
        public int Id { get; set; } 
        public string Siteisim { get; set; }
        public string Destekhattı { get; set; }
        public string Şubeiletişim { get; set; }
        public string Mail { get; set; }
        public string MesaiSaatleri { get; set; }
    }
}
