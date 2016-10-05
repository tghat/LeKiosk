using entities;
using repositories.common;
using repositories.Users;
using services.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.Users
{
    public class UserService : EntityService<User>, IUserService
    {
        IUnitOfWork _unitOfWork;
        IUserRepository _userRepository;

        public UserService(IUnitOfWork unitOfWork, IUserRepository userRepository)
            : base(unitOfWork, userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public bool Login(string username, string password)
        {
            //var hashed_password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
            //var user = _userRepository.FindBy(x => x.UserName.Equals(username) && x.Password.Equals(hashed_password));
            return false;
        }
    }
}
