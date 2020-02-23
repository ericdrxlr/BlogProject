﻿using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Repositories
{
    public class BlogRepository : IRepository<Blog>
    {
        private BlogContext db;

        public BlogRepository(BlogContext db)
        {
            this.db = db;
        }
        public int Count()
        {
            return db.Blogs.Count();
        }
        public IEnumerable<Blog> GetAll()
        {
            return db.Blogs;
        }
        public Blog GetById(int id)
        {
            return db.Blogs.Single(b => b.Id == id);
        }
        public void Create(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
        }
    }
}