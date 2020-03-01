using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private BlogContext db;
        public TagRepository(BlogContext db)
        {
            this.db = db;
        }

        public void Create(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tag obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Tags;
        }

        public Tag GetById(int id)
        {
            return db.Tags.Single(t => t.Id == id);
        }

        public void Update(Tag obj)
        {
            throw new NotImplementedException();
        }
    }
}
