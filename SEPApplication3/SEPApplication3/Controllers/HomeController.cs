using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SEPApplication3.Connect;
namespace SEPApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var connection = new Connect_API();
            var model = connection.GetCourse("ND");
            return View(model.Data);
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