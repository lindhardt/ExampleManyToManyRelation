using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private MyTestDB context = new MyTestDB();

        // GET: Home
        public ActionResult Index()
        {
            return View("Index", context.Members.ToList());
        }

        public ActionResult Details(int id)
        {
             var member = context.Members.Find(id);

            ViewBag.MemberName = member.Name;

            return View(member.Roles.AsEnumerable());
        }

        public ActionResult About()
        {
            return View("About");
        }
    }
}