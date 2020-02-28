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
                    Name = "Meditation",
                    Image = "/img/meditate.jpg"
                },
                new Blog()
                {
                    Id = 3,
                    Name = "Yoga",
                    Image = "/img/yoga.jpg"
                }
            );
            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    Id = 1,
                    Title = "That one time with the duck",
                    Body = "There was a duck. It was weird.",
                    Author = "Josh",
                    PublishDate = "2/20/2020",
                    BlogId = 1
                },
                new Post()
                {
                    Id = 2,
                    Title = "My Collection of Crystals",
                    Body = "I recommend amethyst for your salt baths to add positive energy to your relaxation experience.",
                    Author = "Johnny",
                    PublishDate = "12/20/2020",
                    BlogId = 2
                },
                new Post()
                {
                    Id = 3,
                    Title = "Want to step into the world of yoga?",
                    Body = "Come to my yoga classes on wednesdays at 3 pm!",
                    Author = "Juniper",
                    PublishDate = "2/4/2018",
                    BlogId = 3
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
