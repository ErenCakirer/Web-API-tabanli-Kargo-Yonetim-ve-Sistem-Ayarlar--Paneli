using KargoTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Business.Abstract
{
    public interface IMesajService
    {
  
        Task<List<Mesaj>> TGetListAll();

       
    }
}
