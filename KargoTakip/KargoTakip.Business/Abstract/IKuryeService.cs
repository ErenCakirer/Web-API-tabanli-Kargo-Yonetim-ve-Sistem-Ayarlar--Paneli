using KargoTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Business.Abstract
{
    public interface IKuryeService
    {
       
        Task<List<Kurye>> TGetListAll();

        
        Task TAdd(Kurye kurye);

       
        Task TDelete(Kurye kurye);

        
        Task TUpdate(Kurye kurye);

       
        Task<Kurye> TGetById(int id);
    }
}