using Microsoft.EntityFrameworkCore;
using PersonalSiteDotNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSiteDotNet.Infrastructure
{
    public class MainContext: DbContext
    {
        public MainContext(DbContextOptions<MainContext> options): base(options)
        {

        }
        public DbSet<Blog> Blogs { get; }
        public DbSet<Entry> Entries { get; }
        public DbSet<Tag> Tags { get; }
        public DbSet<EntryTag> EntryTags { get; }
    }
}
