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
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }

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
                    PublishDate = DateTime.Now,
                    BlogId = 1
                },
                new Post()
                {
                    Id = 2,
                    Title = "My Collection of Crystals",
                    Body = "I recommend amethyst for your salt baths to add positive energy to your relaxation experience.",
                    Author = "Johnny",
                    PublishDate = DateTime.Now,
                    BlogId = 2
                },
                new Post()
                {
                    Id = 3,
                    Title = "Want to step into the world of yoga?",
                    Body = "Come to my yoga classes on wednesdays at 3 pm!",
                    Author = "Juniper",
                    PublishDate = DateTime.Now,
                    BlogId = 3
                },
                new Post()
                {
                    Id = 4,
                    Title = "Flying",
                    Body = "All my life, I had been terrified of flying. The concept of getting into a plane and traveling at high speeds for multiple hours made me feel sick to my stomach. But last night, I had a dream that I floated up into the clouds above the city. The buildings and roads looked beautiful from above. It was initially gut-wrenching, but the sensation of floating has convinced me that I need to see what the world looks like from the window of an airplane. I have a flight booked to New York City tomorrow.",
                    Author = "Ben",
                    PublishDate = DateTime.Now,
                    BlogId = 1
                },
                new Post()
                {
                    Id = 5,
                    Title = "What Is Meditation?",
                    Body = "I found a great resource online explaining exactly what meditation is and how it can help you in your everyday lives. You can check it out at this link here: https://mindworks.org/blog/meditation-definition/",
                    Author = "Ben",
                    PublishDate = DateTime.Now,
                    BlogId = 2
                },
                new Post()
                {
                    Id = 6,
                    Title = "My experience with yoga at We Can Code IT",
                    Body = "I spent a half hour in the afternoon doing yoga in the zen room with some friends. It was hard at first because I'm horribly out of shape, but at the end of the session I felt refreshed and happy. I highly recommend getting into yoga if you haven't already.",
                    Author = "Josh",
                    PublishDate = DateTime.Now,
                    BlogId = 3
                },
                new Post()
                {
                    Id = 7,
                    Title = "Test",
                    Body = "test",                   
                    Author = "Josh",
                    PublishDate = DateTime.Now,
                    BlogId = 3
                }
                );
            modelBuilder.Entity<Tag>().HasData(
                new Tag()
                {
                    Id = 1,
                    Name = "relaxing"
                },
                new Tag()
                {
                    Id = 2,
                    Name = "subconscious"
                },
                new Tag()
                {
                    Id = 3,
                    Name = "mindful"
                },
                new Tag()
                {
                    Id = 4,
                    Name = "zen"
                });
            modelBuilder.Entity<PostTag>().HasData(
                new PostTag()
                {
                    Id = 1,
                    TagId = 1,
                    PostId = 2
                },
                new PostTag()
                {
                    Id = 2,
                    TagId = 1,
                    PostId = 5
                },
                new PostTag()
                {
                    Id = 3,
                    TagId = 2,
                    PostId = 1
                },
                new PostTag()
                {
                    Id = 4,
                    TagId = 2,
                    PostId = 4
                },
                new PostTag()
                {
                    Id = 5,
                    TagId = 3,
                    PostId = 5
                },
                new PostTag()
                {
                    Id = 6,
                    TagId = 3,
                    PostId = 6
                },
                new PostTag()
                {
                    Id = 7,
                    TagId = 4,
                    PostId = 2
                },
                new PostTag()
                {
                    Id = 8,
                    TagId = 4,
                    PostId = 3
                },
                new PostTag()
                {
                    Id = 9,
                    TagId = 4,
                    PostId = 6
                });

base.OnModelCreating(modelBuilder);
        }
    }
}
