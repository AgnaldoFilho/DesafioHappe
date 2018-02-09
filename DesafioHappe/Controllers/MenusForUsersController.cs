using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DesafioHappe.Models;
using DesafioHappe.ViewModels;
using Microsoft.AspNet.Identity;
using WebGrease.Css.Extensions;
using System.Data.Entity;
using Newtonsoft.Json;

namespace DesafioHappe.Controllers
{
    public class MenusForUsersController : Controller
    {
        private ApplicationDbContext _context;

        public MenusForUsersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: MenusForUsers
        public ActionResult Index()
        {

            var itens = _context.ItensSideMenuMarkets.Where(x => x.ParentId == null).Select(c => new {
                ItemID = c.Id,
                ItemName = c.Name
            }).ToList();

            ViewBag.Itens = new MultiSelectList(itens, "ItemID", "ItemName", new[] { 1, 3, 7 });
            
            return View(itens);
        }
        [HttpGet]
        public ActionResult ObterMeusItens()
        {
            var userID = User.Identity.GetUserId();
            var itens = _context.MenusForUsers
                .Include(x => x.ItensSideMenuMarket)
                .Include(x => x.ItensSideMenuMarket.Childs)
                .Where(x => x.ApplicationUserId == userID)
                .Select(x => x.ItensSideMenuMarket)
                .ToList();
            
            var jsSettings =
                new JsonSerializerSettings {ReferenceLoopHandling = ReferenceLoopHandling.Ignore};
            var converted = JsonConvert.SerializeObject(itens, null, jsSettings);
            return Content(converted, "application/json");
            
        }

        [HttpPost]
        public ActionResult CreateMenus(int[] id)
        {
            var userId = User.Identity.GetUserId();

            List<MenusForUser> lstMenus = new List<MenusForUser>();
            try
            {
                foreach (int menu in id)
                {
                    lstMenus.Add(new MenusForUser
                    {
                        ApplicationUserId = userId,
                        ItensSideMenuMarketId = menu,
                        Ativo = true
                    });
                }
                _context.MenusForUsers.AddRange(lstMenus);

                _context.SaveChanges();

                return RedirectToAction("Index", "MenusForUsers");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            

            return View();

        }

        //public ActionResult SideMenu2()
        //{

        //    SqlDataReader dtr = _context.ItensSideMenuMarkets.ExecuteReader();
        //    while (dtr.Read())
        //    {
        //        MenuItem mi = null;

        //        mi = new MenuItem(dtr["Titulo"].ToString(), dtr["Id"].ToString());

        //        //Verifica se a linha é raiz
        //        if (dtr["PaiId"] == DBNull.Value)
        //        {
        //            //Adiciona um novo nó no Menu
        //            Menu1.Items.Add(mi);
        //        }
        //        else
        //        {
        //            miPaiNo = null;
        //            MenuItem miPai = localizaMenuPai(Menu1.Items, (int)dtr["PaiId"]);
        //            if (miPai != null) miPai.ChildItems.Add(mi);
        //        }

        //    }
        //}

        public ViewResult SideMenu()
        {
            return View();
        }

        public ActionResult New()
        {
            var itensMenu = _context.ItensSideMenuMarkets.ToList();
            var viewModel = new NewMenusForUserViewModel
            {
                ItensSideMenuMarkets = itensMenu
            };

            return View();
        }



    }
}