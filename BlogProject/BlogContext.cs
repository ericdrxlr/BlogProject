using BlogProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Blogs;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
    }
}
