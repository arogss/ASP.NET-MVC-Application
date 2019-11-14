using Assgn2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assgn2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MyProfile(Person model)
        {
            if (ModelState.IsValid)
            {
                return View("MyProfile", model);
            }
            
            return View(model);
            
        }

        public ActionResult MyProfile()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}