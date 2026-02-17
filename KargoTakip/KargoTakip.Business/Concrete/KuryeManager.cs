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
    public class KuryeManager : IKuryeService
    {
        private readonly IGenericRepository<Kurye> _repository;

        public KuryeManager(IGenericRepository<Kurye> repository)
        {
            _repository = repository;
        }

        
        public async Task<List<Kurye>> TGetListAll()
        {
            return await _repository.GetAllAsync();
        }

        
        public async Task TAdd(Kurye kurye)
        {
            await _repository.AddAsync(kurye);
        }

       
        public async Task TDelete(Kurye kurye)
        {
            await _repository.DeleteAsync(kurye);
        }

        
        public async Task TUpdate(Kurye kurye)
        {
            await _repository.UpdateAsync(kurye);
        }

        
        public async Task<Kurye> TGetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}