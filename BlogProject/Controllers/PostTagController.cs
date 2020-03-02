using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using BlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace BlogProject.Controllers
{
    public class PostTagController : Controller
    {
        IRepository<PostTag> posttagRepo;
        public PostTagController(IRepository<PostTag> posttagRepo)
        {
            this.posttagRepo = posttagRepo;
        }
        [HttpGet]
        public ViewResult CreateByPostId(int id)
        {
            ViewBag.PostId = id;
            return View();
        }
        [HttpPost]
        public ActionResult Create(PostTag posttag)
        {
            posttagRepo.Create(posttag);
            return RedirectToAction("Details", "Post", new { id = posttag.PostId });
        }
    }
}
