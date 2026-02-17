using KargoTakip.Core.Entities;
using KargoTakip.Data.Context;
using KargoTakip.Data.Repositories;
using KargoTakip.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Data.Ef
{
    public class EfAyarlarRepository : GenericRepository<Ayarlar>, IAyarlarDal
    {
        public EfAyarlarRepository(KargoContext context) : base(context)
        {
        }
    }
}
