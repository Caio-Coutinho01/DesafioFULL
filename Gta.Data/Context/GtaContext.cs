using Gta.Data.Extensions;
using Gta.Data.Mappings;
using Gta.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gta.Data.Context
{
    public class GtaContext: DbContext
    {
        public GtaContext(DbContextOptions<GtaContext> options)
            : base(options) { }

        #region "DbSets"

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.SeedData();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
