using Microsoft.EntityFrameworkCore;
using PersonalSiteDotNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSiteDotNet.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        DbContext _dbContext;
        IRepository<Blog> _blogRepository;
        IRepository<Entry> _entryRepository;
        IRepository<Tag> _tagRepository;
        IRepository<EntryTag> _entryTagRepository;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<Blog> BlogRepository
        {
            get
            {
                return _blogRepository ?? (_blogRepository = new Repository<Blog>(_dbContext));
            }
            
        }

        public IRepository<Entry> EntryRepository
        {
            get
            {
                return _entryRepository ?? (_entryRepository = new Repository<Entry>(_dbContext));
            }
        }

        public IRepository<Tag> TagRepository
        {
            get
            {
                return _tagRepository ?? (_tagRepository = new Repository<Tag>(_dbContext));
            }
        }

        public IRepository<EntryTag> EntryTagRepository
        {
            get
            {
                return _entryTagRepository ?? (_entryTagRepository = new Repository<EntryTag>(_dbContext));
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
