using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Blog
    {
        string Name { get; set; }
        int Id { get; set; }
        string Image { get; set; }

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
