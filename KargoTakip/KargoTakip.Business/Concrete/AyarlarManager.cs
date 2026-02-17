using KargoTakip.Business.Abstract;
using KargoTakip.DataAccess.Abstract;
using KargoTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Business.Concrete
{
    public class AyarlarManager : IAyarlarService
    {
        private readonly IAyarlarDal _ayarlarDal;

        public AyarlarManager(IAyarlarDal ayarlarDal)
        {
            _ayarlarDal = ayarlarDal;
        }

        public Task AddAsync(Ayarlar entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Ayarlar entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ayarlar>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Ayarlar> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task TAdd(Ayarlar t)
        {
            await _ayarlarDal.AddAsync(t);
        }

        public async Task TDelete(Ayarlar t)
        {
            await _ayarlarDal.DeleteAsync(t);
        }

        public async Task<List<Ayarlar>> TGetAll()
        {
            return await _ayarlarDal.GetAllAsync();
        }

        public async Task<Ayarlar> TGetById(int id)
        {
            return await _ayarlarDal.GetByIdAsync(id);
        }

        public async Task TUpdate(Ayarlar t)
        {
            await _ayarlarDal.UpdateAsync(t);
        }

        public Task UpdateAsync(Ayarlar entity)
        {
            throw new NotImplementedException();
        }
    }
}