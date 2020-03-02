using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Repositories
{
    public class PostTagRepository : IRepository<PostTag>
    {
        private BlogContext db;

        public PostTagRepository(BlogContext db)
        {
            this.db = db;
        }

        public void Delete(PostTag obj)
        {
            throw new NotImplementedException();
        }

        public void Update(PostTag obj)
        {
            throw new NotImplementedException();
        }
        public void Create(PostTag posttag)
        {
            db.PostTags.Add(posttag);
            db.SaveChanges();
        }

        public IEnumerable<PostTag> GetAll()
        {
            return db.PostTags;
        }
        public PostTag GetById(int id)
        {
            return db.PostTags.Single(pt => pt.Id == id);
        }
    }
}