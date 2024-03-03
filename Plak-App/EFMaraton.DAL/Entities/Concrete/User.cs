using EFMaraton.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.DAL.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
