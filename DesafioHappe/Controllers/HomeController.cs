using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using DesafioHappe.Base;

namespace DesafioHappe.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //List<Itens> selected = CBLGold.Items.Cast<ListItem>()
            //    .Where(li => li.Selected)
            //    .ToList();
            return RedirectToAction("Index", "MenusForUsers");
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}