using PersonalSiteDotNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSiteDotNet.Infrastructure
{
    public interface IUnitOfWork
    {
        IRepository<Blog> BlogRepository { get; }
        IRepository<Entry> EntryRepository { get; }
        IRepository<Tag> TagRepository { get; }
        IRepository<EntryTag> EntryTagRepository { get; }
        void Save();
    }
}
