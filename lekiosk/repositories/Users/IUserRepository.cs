using entities;
using repositories.common;
using System;
namespace repositories.Users
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void CreateUser(User user);
    }
}
