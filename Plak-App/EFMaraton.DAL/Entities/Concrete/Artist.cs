using EFMaraton.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.DAL.Entities.Concrete
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Album> Albums { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
