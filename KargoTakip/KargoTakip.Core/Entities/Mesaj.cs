using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Core.Entities
{
   public class Mesaj
    {
        [Key]
        public int MesajID { get; set; } 

        public string GonderenAdSoyad { get; set; } 

        public string MesajIcerigi { get; set; } 

        public DateTime Tarih { get; set; } 

        public string ProfilFotoUrl { get; set; } 

        public bool IsRight { get; set; } 
    }
}
