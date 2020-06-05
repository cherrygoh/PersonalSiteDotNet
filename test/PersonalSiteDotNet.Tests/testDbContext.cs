using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSiteDotNet.Infrastructure.Tests
{
    public class testDbContext: DbContext 
    {
        public DbSet<StubEntity> stubEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Data Layer Testing Database");
        }
    }
}
