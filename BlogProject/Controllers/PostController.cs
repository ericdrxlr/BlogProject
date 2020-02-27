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
        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;
        }
        public ViewResult Index()
        {
            var model = postRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = postRepo.GetById(id);
            return View(model);

        }
        [HttpGet]
        public ViewResult CreateByBlogId(int id)
        {
            ViewBag.BlogId = id;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Post post)
        {
            postRepo.Create(post);
            return RedirectToAction("Details", "Blog", new { id = post.BlogId });
        }
        [HttpGet]
        public ViewResult Update(int id)
        {
            Post model = postRepo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            postRepo.Update(post);
            return RedirectToAction("Details", "Blog", new { id = post.BlogId });
        }
        [HttpGet]
        public ViewResult Delete(int id)
        {
            Post model = postRepo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var tempId = post.BlogId;
            postRepo.Delete(post);
            return RedirectToAction("Details", "Blog", new { id = tempId });
        }
    }
}
