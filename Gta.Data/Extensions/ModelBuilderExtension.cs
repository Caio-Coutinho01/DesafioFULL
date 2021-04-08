using Gta.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;
using Gta.Domain.Models;

namespace Gta.Data.Extensions
{

    public static class ModelBuilderExtension
    {

        public static ModelBuilder ApplyGlobalConfigurations(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Entidades.Id):
                            property.IsKey();
                            break;
                        case nameof(Entidades.DateUpdated):
                            property.IsNullable = true;
                            break;
                        case nameof(Entidades.DateCreated):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;
                        case nameof(Entidades.IsDeleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(false);
                            break;
                        default:
                            break;
                    }
                }
            }
            return builder;
        }
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                new User {Id = 1, Name = "User Default", CPF = "000.000.000-00", DateCreated = new DateTime(2021-05-04), IsDeleted= false, DateUpdated = null }
                );

            builder.Entity<Parcel>().HasData(
                new Parcel {Id = 1, IdUser = 1,Fees = 1,Fine = 1,DateDue = new DateTime(2021 -05-04),DateIssue = new DateTime(2021-06-04), VlrParcel = 300, DateCreated = new DateTime(2021 - 05 - 04), IsDeleted = false, DateUpdated = null }
                );
            return builder;
        }
    }
}
