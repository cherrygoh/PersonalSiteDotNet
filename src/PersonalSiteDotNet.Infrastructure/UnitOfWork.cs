using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PersonalSiteDotNet.Core.Interfaces;
using PersonalSiteDotNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalSiteDotNet.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }  

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
