using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Blog
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public Blog()
        {

        }
        public Blog(string name, int id, string image)
        {
            Name = name;
            Id = id;
            Image = image;
        }
    }
}
