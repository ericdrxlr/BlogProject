using BlogProject.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlogProject.Tests
{
    public class BlogRepositoryTests
    {
        [Fact]
        public void Count_Starts_At_Zero()
        {
            var db = new BlogContext();
            var underTest = new BlogRepository(db);

            var count = underTest.Count();

            Assert.Equal(0, count);
        
        }

    }
}
