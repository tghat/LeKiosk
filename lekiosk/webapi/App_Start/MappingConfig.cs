using AutoMapper;
using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapi.Models;

namespace webapi.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterModelToViewModelMapping()
        {
            // User
            Mapper.Initialize(cfg => cfg.CreateMap<User, UserModel>());
        }

        public static void RegisterViewModelToModelMapping()
        {
            // User
            Mapper.Initialize(cfg => cfg.CreateMap<UserModel, User>());
        }
    }
}