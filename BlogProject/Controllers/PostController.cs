using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogProject.Repositories;
using BlogProject.Models;

namespace BlogProject.Controllers
{
    public class PostController : Controller
    {
        IRepository<Post> postRepo;
        public ViewResult Index()
        {
            var model = postRepo.GetAll();
            return View(model);
        }
    }
}
