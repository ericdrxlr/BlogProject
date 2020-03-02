using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using BlogProject.Controllers;
using BlogProject.Models;

namespace BlogProject.Tests
{
    public class BlogControllerTests
    {
        BlogController controller;

        //public BlogControllerTests()
        //{
        //    controller = new BlogController();
        //}

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Index_Passes_AllModels_To_View()
        {
            var result = controller.Index();

            Assert.IsAssignableFrom<Blog>(result.Model);
        }
        
    }
}
