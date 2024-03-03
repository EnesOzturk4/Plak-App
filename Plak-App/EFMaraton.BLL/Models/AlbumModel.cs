using EFMaraton.DAL.Entities.Abstract;
using EFMaraton.DAL.Entities.Concrete;
using EFMaraton.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.BLL.Models
{
    public class AlbumModel : BaseEntity
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public SaleStatus SaleStatus { get; set; }
        public virtual Artist Artist { get; set; }

        //public DateTime Created;
    }
}
