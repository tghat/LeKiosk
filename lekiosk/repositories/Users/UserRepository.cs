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
        public void CreateUser(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
            return;
        }
    }
}
