using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using BlogProject.Controllers;

namespace BlogProject.Tests
{
    public class BlogControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new BlogController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
