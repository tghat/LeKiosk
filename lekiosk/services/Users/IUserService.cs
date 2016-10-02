using entities;
using services.common;
using System;
namespace services.Users
{
    public interface IUserService : IEntityService<User>
    {
        void Register(User user);
    }
}
