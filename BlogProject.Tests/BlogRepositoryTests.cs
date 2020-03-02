using BlogProject.Models;
using BlogProject.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlogProject.Tests
{
    public class BlogRepositoryTests : IDisposable
    {
        private BlogContext db;
        private BlogRepository underTest;

        public BlogRepositoryTests()
        {
            db = new BlogContext();
            db.Database.BeginTransaction();

            underTest = new BlogRepository(db);
        }

        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        [Fact]
        public void Count_Starts_At_Zero()
        {
            var count = underTest.Count();

            Assert.Equal(0, count);
        }
        [Fact]
        public void Create_Increases_Count()
        {

            underTest.Create(new Blog() { Name = "Pet" });

            var count = underTest.Count();
            Assert.Equal(1, count); 
        }

    }
}
