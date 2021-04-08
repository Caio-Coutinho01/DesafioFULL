using Gta.Domain.Entity;
using Gta.Domain.Interfaces;
using Gta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Domain.Interface
{
    public interface IParcelRepository : IRepository<Parcel>
    {
        IEnumerable<Parcel> FindAllParcels(int Id);
        //IEnumerable<Parcel> FindAllParcels();
        IEnumerable<Parcel> FindParcels(int id);


    }
}
