using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogProject.Repositories;

namespace BlogProject.Controllers
{
    public class PostController : Controller
    {
        public ViewResult Index()
        {
            var model = postRepo.GetAll();
            return View(model);
        }
    }
}
