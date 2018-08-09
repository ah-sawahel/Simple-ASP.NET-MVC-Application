using Microsoft.AspNet.Identity;
using MVCSimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [Authorize]
        public ActionResult Buy()
        {
            ViewBag.Message = "Please " + User.Identity.Name + ", buy our items from here :)";

            Entities db = new Entities();
            AspNetUser user = db.AspNetUsers.Find(User.Identity.GetUserId());

            ViewBag.CurrentItems = "You currently have " + user.BaughtItemsCount + " in your cart.";
            return View(User);
        }

        [HttpPost]
        public ActionResult BuyItem()
        {
            Entities db = new Entities();
            AspNetUser user = db.AspNetUsers.Find(User.Identity.GetUserId());
            user.BaughtItemsCount++;
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Buy");
            }

            return RedirectToAction("Buy");
        }
    }
}