using StudentManagement.Business.Contracts;
using StudentManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        private IBlogBusinessService blogService;

        public HomeController(IBlogBusinessService service)
        {
            blogService = service;
        }
        public ActionResult Index()
        {
            //var blogs = blogService.GetAllBlogs().Select(x => new BlogPostViewModels()
            //{
            //    Title = x.Title,
            //    Content = x.Content,
            //    PostDate = x.PostDate
            //});
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}