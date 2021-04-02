using Gta.Application.interfaces;
using Gta.Application.Services;
using Gta.Data.Repositories;
using Gta.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Gta.IoC
{
    public static class NativeInjector
    {
        public static void RegisterService(IServiceCollection services) {

            #region Services
            services.AddScoped<IUserService, UserService>();
            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion

            #region 
            #endregion
        }

    }
}
