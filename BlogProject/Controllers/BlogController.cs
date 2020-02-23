using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace BlogProject.Controllers
{
    public class BlogController : Controller
    {
        public ViewResult Index()
        {
            var model = new Blog();
            return View(model);
        }
    }
}
