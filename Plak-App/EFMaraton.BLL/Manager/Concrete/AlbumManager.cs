using EFMaraton.BLL.Manager.Abstract;
using EFMaraton.BLL.Models;
using EFMaraton.DAL.Context;
using EFMaraton.DAL.Entities.Concrete;
using EFMaraton.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.BLL.Manager.Concrete
{
    public class AlbumManager : Manager<AlbumModel, Album>
    {
        public AlbumManager()
        {
            _repository = new AlbumRepository(new EFMaratonDbContext());
        }
    }
}
