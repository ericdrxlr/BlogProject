using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace BlogProject.Controllers
{
    public class BlogController : Controller
    {
        IRepository<Blog> blogRepo;
        public BlogController(IRepository<Blog> blogRepo)
        {
            this.blogRepo = blogRepo;
        }
        public ViewResult Index()
        {
            var model = blogRepo.GetAll();
            return View(model);
        }
        public ViewResult Posts(int id)
        {
            var model = blogRepo.GetById(id);
            return View(model);
        }
    }
}
