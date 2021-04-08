using Gta.Application.Services;
using Gta.Application.ViewModel;
using Gta.Data.Context;
using Gta.Domain.Entity;
using Gta.Domain.Interface;
using Gta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Data.Repositories
{
    public class ParcelRepository : Repository<Parcel>, IParcelRepository
    {
        public ParcelRepository(GtaContext context)
           : base(context) { }

        public IEnumerable<Parcel> FindAllParcels(int id)
        {
            return Query(x =>x.IdUser == id && !x.IsDeleted);
        }
        public IEnumerable<Parcel> FindParcels(int id)
        {
            return Query(x => x.IdUser == id && !x.IsDeleted);
        }
    }
}
