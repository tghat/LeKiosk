using entities;
using repositories.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories.Users
{
    public class UserRepository : GenericRepository<LekioskEntities, User>, IUserRepository
    {
        
    }
}
