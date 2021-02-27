using MelikaSuperMarket.Domain.Entities.Commons;
using System.Collections.Generic;

namespace MelikaSuperMarket.Domain.Entities.Users
{
    public class Role: BaseEntity
    {
         public string  Name { get; set; }
        public ICollection<UserInRole > UserInRoles { get; set; }
    }
}
