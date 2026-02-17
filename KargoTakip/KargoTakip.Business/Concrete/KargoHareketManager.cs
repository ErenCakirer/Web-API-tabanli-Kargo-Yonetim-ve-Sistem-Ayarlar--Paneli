using KargoTakip.Business.Abstract;
using KargoTakip.Core.Entities;
using KargoTakip.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Business.Concrete
{
    public class KargoHareketManager : IKargoHareketService
    {
        private readonly IGenericRepository<KargoHareket> _repository;

        public KargoHareketManager(IGenericRepository<KargoHareket> repository)
        {
            _repository = repository;
        }

        public async Task TAdd(KargoHareket kargoHareket)
        {
            await _repository.AddAsync(kargoHareket);
        }

        public async Task TDelete(KargoHareket kargoHareket)
        {
            await _repository.DeleteAsync(kargoHareket);
        }

        public async Task TUpdate(KargoHareket kargoHareket)
        {
            await _repository.UpdateAsync(kargoHareket);
        }

        public async Task<List<KargoHareket>> TGetListAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<KargoHareket> TGetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<KargoHareket>> TGetHareketlerByTakipKodu(string takipKodu)
        {
          
            var allMoves = await _repository.GetAllAsync();
            return allMoves.Where(x => x.TakipKodu == takipKodu).ToList();
        }
    }
}
