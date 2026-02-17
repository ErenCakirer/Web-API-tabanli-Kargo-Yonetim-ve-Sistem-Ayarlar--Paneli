using KargoTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Business.Abstract
{
    public interface ISevkiyatService
    {
        Task<List<Sevkiyat>> TGetAll();
        Task<Sevkiyat> TGetById(int id);
        Task TAdd(Sevkiyat sevkiyat);
        void TUpdate(Sevkiyat sevkiyat);
        void TDelete(Sevkiyat sevkiyat);
        string TakipNoOlustur();
    }
}
