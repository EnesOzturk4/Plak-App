using EFMaraton.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.BLL.Models
{
    public class ArtistModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Album> Albums { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
