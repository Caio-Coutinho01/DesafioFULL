using Gta.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Domain.Interface
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    };
}
