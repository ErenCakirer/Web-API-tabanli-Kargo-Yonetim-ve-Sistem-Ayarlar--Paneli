using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Core.Entities
{
    public class SevkiyatGeçmişi
    {
        public int ID { get; set; }
        public int SevkiyatID { get; set; }
        public string SevkiyatAçıklaması { get; set; }
        public DateTime İşlemTarihi { get; set; }
        public string Konum { get; set; }
    }
}
