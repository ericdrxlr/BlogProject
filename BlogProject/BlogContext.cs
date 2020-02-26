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
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Blogs;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                {
                    Id = 1,
                    Name = "Dream Log",
                    Image = "/img/dreaming.jpg"
                },
                new Blog()
                {
                    Id = 2,
                    Name = "Ziplining",
                    Image = "/img/zipline.jpg"
                },
                new Blog()
                {
                    Id = 3,
                    Name = "Exotic Pets",
                    Image = "/img/lizard.jpg"
                }
            );
            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    Id = 1,
                    Title = "That one time with the duck",
                    Body = "There was a duck. It was weird.",
                    Author = "Josh",
                    PublishDate = "0",
                    BlogId = 1
                },
                new Post()
                {
                    Id = 2,
                    Title = "Ziplining in Hawaii",
                    Body = "The best ziplining experience in the USA",
                    Author = "Johnny",
                    PublishDate = "12/20/2020",
                    BlogId = 2
                },
                new Post()
                {
                    Id = 3,
                    Title = "Please don't adopt a fox",
                    Body = "Foxes are not domesticated pets. Adopt at your own risk.",
                    Author = "Juniper",
                    PublishDate = "2/4/2018",
                    BlogId = 3
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
