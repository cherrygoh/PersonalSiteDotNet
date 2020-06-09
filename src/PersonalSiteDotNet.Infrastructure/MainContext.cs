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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntryTag>()
                .HasKey(et => new { et.EntryId, et.TagId });
            modelBuilder.Entity<EntryTag>()
                .HasOne(et => et.Entry)
                .WithMany(e => e.EntryTags)
                .HasForeignKey(et => et.EntryId);
            modelBuilder.Entity<EntryTag>()
                .HasOne(et => et.Tag)
                .WithMany(t => t.EntryTags)
                .HasForeignKey(et => et.TagId);
        }
        public DbSet<Blog> Blogs { get; }
        public DbSet<Entry> Entries { get; }
        public DbSet<Tag> Tags { get; }
        public DbSet<EntryTag> EntryTags { get; }
    }
}
