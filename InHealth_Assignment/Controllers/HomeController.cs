using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InHealth_Assignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        public ActionResult Login()
        {
            return View("~/Views/Home/_PartialLogin.cshtml");
        }

        public ActionResult UserRegistration()
        {
            return View("~/Views/Home/_PartialUserRegistration.cshtml");
        }

        public ActionResult BlogPost()
        {
            return View("~/Views/Home/_PartialBlogPost.cshtml");
        }

        public ActionResult BlogPostUser()
        {
            return View("~/Views/Home/_PartialBlogPostUser.cshtml");
        }

        public ActionResult BlogPostList()
        {
            return View("~/Views/Home/_PartialBlogPostList.cshtml");
        }

        public ActionResult NewPost()
        {
            return View("~/Views/Home/_PartialNewPost.cshtml");
        }

        public ActionResult PostDetail()
        {
            return View("~/Views/Home/_PartialPostDetail.cshtml");
        }

        public ActionResult UserList()
        {
            return View("~/Views/Home/_PartialUserList.cshtml");
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