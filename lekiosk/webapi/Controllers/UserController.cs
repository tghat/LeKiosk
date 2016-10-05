using AutoMapper;
using entities;
using services.Users;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi.Models;

namespace webapi.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserService userService;
        public UserController(IUserService userService) { this.userService = userService; }

        // GET api/user/5
        public UserModel Get(string username, string password) { return Mapper.Map<UserModel>(userService.Login(username,password)); }

        // POST api/user
        public void Post(UserModel value) { userService.Create(Mapper.Map<User>(value)); }

        // PUT api/user/
        public void Put(UserModel value) { userService.Update(Mapper.Map<User>(value)); }

        // DELETE api/user/5
        public void Delete(UserModel value) { userService.Delete(Mapper.Map<User>(value)); }
    }
}
