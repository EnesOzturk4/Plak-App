using EFMaraton.DAL.Context;
using EFMaraton.DAL.Entities.Concrete;
using EFMaraton.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.DAL.Repository.Concrete
{
    public class ArtistRepository : Repository<Artist>
    {
        public ArtistRepository(EFMaratonDbContext db) : base(db)
        {
        }
    }
}
