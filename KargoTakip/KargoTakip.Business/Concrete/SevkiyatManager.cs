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
    public class SevkiyatManager : ISevkiyatService
    {
        
        private readonly IGenericRepository<Sevkiyat> _sevkiyatRepository;

        public SevkiyatManager(IGenericRepository<Sevkiyat> sevkiyatRepository)
        {
            _sevkiyatRepository = sevkiyatRepository;
        }

        
        public async Task TAdd(Sevkiyat sevkiyat)
        {
            sevkiyat.TakipNo = TakipNoOlustur();
            sevkiyat.OluşturulmaTarihi = DateTime.Now;
            sevkiyat.Durum = "Kargo Kabul Edildi";

            await _sevkiyatRepository.AddAsync(sevkiyat);
        }

        public string TakipNoOlustur()
        {
            Random rand = new Random();
            return $"KRG-{DateTime.Now.Year}-{rand.Next(10000, 99999)}";
        }

      
        public async Task<List<Sevkiyat>> TGetAll() => await _sevkiyatRepository.GetAllAsync();

        public async Task<Sevkiyat> TGetById(int id) => await _sevkiyatRepository.GetByIdAsync(id);

        public async Task TDelete(Sevkiyat sevkiyat) => await _sevkiyatRepository.DeleteAsync(sevkiyat);

        public async Task TUpdate(Sevkiyat sevkiyat) => await _sevkiyatRepository.UpdateAsync(sevkiyat);

        void ISevkiyatService.TUpdate(Sevkiyat sevkiyat)
        {
            throw new NotImplementedException();
        }

        void ISevkiyatService.TDelete(Sevkiyat sevkiyat)
        {
            throw new NotImplementedException();
        }
    }
}
