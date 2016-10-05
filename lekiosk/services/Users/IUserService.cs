using entities;
using services.common;
using System;
namespace services.Users
{
    public interface IUserService : IEntityService<User>
    {
        bool Login(string username, string password);
    }
}
