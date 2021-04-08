using Gta.Data.Context;
using Gta.Domain.Entity;
using Gta.Domain.Interface;
using Gta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(GtaContext context)
            : base(context) { }

        public IEnumerable<User> GetAll() {
            return Query(x => !x.IsDeleted);
        }

        //public List<IMainModel> GetAllUsers()
        //{
        //    return QueryAll();
        //}
    }
}
