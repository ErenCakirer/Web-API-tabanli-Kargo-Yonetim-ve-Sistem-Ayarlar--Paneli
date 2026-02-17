using KargoTakip.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KargoTakip.Business.Abstract
{
    public interface IKargoHareketService
    {
        Task<List<KargoHareket>> TGetListAll();
        Task TAdd(KargoHareket kargoHareket);
        Task TDelete(KargoHareket kargoHareket);
        Task TUpdate(KargoHareket kargoHareket);
        Task<KargoHareket> TGetById(int id);

     
        Task<List<KargoHareket>> TGetHareketlerByTakipKodu(string takipKodu);
    }
}