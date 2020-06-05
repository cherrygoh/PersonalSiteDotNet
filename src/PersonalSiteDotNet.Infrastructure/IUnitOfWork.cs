using PersonalSiteDotNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalSiteDotNet.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();

        Task CommitAsync();
    }
}
