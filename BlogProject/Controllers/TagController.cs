using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class TagController : Controller
    {
        IRepository<Tag> tagRepo;
        public TagController(IRepository<Tag> tagRepo)
        {
            this.tagRepo = tagRepo;
        }
       
    }
}
