using Gta.Domain.Entity;
using Gta.Domain.Interfaces;
using Gta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Domain.Interface
{
    public interface IUserRepository: IRepository<User>
    {
        IEnumerable<User> GetAll();
      
    };
}
