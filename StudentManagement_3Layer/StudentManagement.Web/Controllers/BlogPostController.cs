using StudentManagement.Business;
using StudentManagement.Business.Contracts;
using StudentManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Web.Controllers
{
    public class BlogPostController : Controller
    {
        private IBlogBusinessService blogService;

        public BlogPostController (IBlogBusinessService service)
        {
            blogService = service;
        }

        // GET: BlogPost
        public ActionResult Index()
        {
            var blogs = blogService.GetAllBlogs().Select(x => new BlogPostViewModels()
            {
                Title = x.Title,
                Content = x.Content,
                PostDate = x.PostDate
            });
            return View(blogs);
        }
    }
}