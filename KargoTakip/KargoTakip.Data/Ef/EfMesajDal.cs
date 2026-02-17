using KargoTakip.Core.Entities;
using KargoTakip.Data.Abstract;
using KargoTakip.Data.Context;
using KargoTakip.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Data.Ef
{
    public class EfMesajDal : GenericRepository<Mesaj>, IMesajDal
    {
        public EfMesajDal(KargoContext context) : base(context)
        {
        }
    }
}
