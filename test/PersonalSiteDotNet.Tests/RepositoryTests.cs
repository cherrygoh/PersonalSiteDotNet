using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PersonalSiteDotNet.Infrastructure.Tests
{
    public class RepositoryTests
    {
        private Repository<StubEntity> _repository;
        private DbContext _testDbContext;
        public RepositoryTests()
        {
            _testDbContext = new testDbContext();
            _repository = new Repository<StubEntity>(_testDbContext);
        }

        [Fact]
        public void Add_NeWEntity_DbEntryAdded()
        {
            // arrange
            StubEntity newEntity = new StubEntity { Id = 1, Name = "test" };

            // act
            _repository.Add(newEntity);

            // assert
            Assert.Equal("test", _testDbContext.Set<StubEntity>().Find(newEntity.Id).Name);
        }

        [Fact]
        public void Delete_ExistingEntity_DbEntryDeleted()
        {
            // arrange
            StubEntity newEntity = new StubEntity { Id = 1, Name = "test" };

            _repository.Add(newEntity);
            _repository.Delete(newEntity);

            //assert
            Assert.Null(_testDbContext.Set<StubEntity>().Find(newEntity.Id));
        }

        [Fact]
        public void Update_ExistingEntity_DbEntryUpdated()
        {
            // arrange
            StubEntity newEntity = new StubEntity { Id = 1, Name = "test" };

            _repository.Add(newEntity);
            _repository.Update(new StubEntity { Id = 1, Name = "edited" });

            //assert
            Assert.Equal("edited", _testDbContext.Set<StubEntity>().Find(newEntity.Id).Name);
        }
    }
}
