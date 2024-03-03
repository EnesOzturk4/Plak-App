using EFMaraton.DAL.Entities.Abstract;
using EFMaraton.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.DAL.Entities.Concrete
{
    public class Album : BaseEntity
    {
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public DateTime ReleaseDate { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public SaleStatus SaleStatus { get; set; }
    }
}
