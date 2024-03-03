using EFMaraton.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.DAL.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DataStatus DataStatus { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
