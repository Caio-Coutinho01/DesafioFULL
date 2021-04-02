using Gta.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                new User { Id = Guid.Parse("c2dce21b-d207-4869-bf5f-08eb138bb919"), Name = "User Default", Email = "userdefault@gta.com", DateCreated = new DateTime(2020,2,2), IsDeleted= false, DateUpdated = null }
                );
            return builder;
        }
    }
}
