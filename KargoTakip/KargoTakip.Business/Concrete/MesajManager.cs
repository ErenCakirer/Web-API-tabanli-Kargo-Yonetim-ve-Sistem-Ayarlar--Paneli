using KargoTakip.Core.Entities;
using KargoTakip.Data.Abstract;
using KargoTakip.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Business.Concrete
{
    public class MesajManager : IMesajService
    {
        private readonly IMesajDal _mesajDal;

        public MesajManager(IMesajDal mesajDal)
        {
            _mesajDal = mesajDal;
        }

        public async Task<List<Mesaj>> TGetListAll()
        {
            return await _mesajDal.GetAllAsync();
        }
    }
}
