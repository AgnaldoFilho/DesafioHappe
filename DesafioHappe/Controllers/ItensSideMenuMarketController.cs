using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using DesafioHappe.Base;
using DesafioHappe.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace DesafioHappe.Controllers
{
    public class ItensSideMenuMarketController : BaseController
    {

        public ItensSideMenuMarketController()
        {
        }

        public ItensSideMenuMarketController(ApplicationUserManager userManager, ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            UserManager = userManager;
        }

        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get { return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }
            set { _userManager = value; }
        }

        private ApplicationDbContext _dbContext;

        public ApplicationDbContext DbContext
        {
            get { return _dbContext ?? HttpContext.GetOwinContext().GetUserManager<ApplicationDbContext>(); }
            set { _dbContext = value; }
        }

        // GET: ClaimsAdmin
        public ActionResult Index()
        {
            //ItensSideMenuMarket.ItensSideMenuModel item = new ItensSideMenuMarket.ItensSideMenuModel();

            //item.ItensSideMenu


            return View(DbContext.ItensSideMenuMarkets.ToList().Where(c => c.ParentId == null));
        }

        public ActionResult CreateMenusForUser()
        {
            var userId = User.Identity.GetUserId();
        
            return View(userId);
        }

        //// GET: ClaimsAdmin/SetUserClaim
        //public ActionResult SetUserClaim(string id)
        //{
        //    ViewBag.Type = new SelectList
        //    (
        //        DbContext.ItensSideMenuMarket.ToList(),
        //        "Name",
        //        "Name"
        //    );

        //    ViewBag.User = UserManager.FindById(id);

        //    return View();
        //}

        //// POST: ClaimsAdmin/SetUserClaim
        //[HttpPost]
        //public ActionResult SetUserClaim(ClaimViewModel claim, string id)
        //{
        //    try
        //    {
        //        UserManager.AddClaimAsync(id, new Claim(claim.Type, claim.Value));

        //        return RedirectToAction("Details", "UsersAdmin", new { id = id });
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ClaimsAdmin/CreateItemPai
        public ActionResult CreateItemPai()
        {
            return View();
        }

        // POST: ClaimsAdmin/CreateItemPai
        [HttpPost]
        public ActionResult CreateItemPai(ItensSideMenuMarket item)
        {
     

            try
            {
                if (ModelState.IsValid)
                {

                    ViewData["Items"] = new SelectList(DbContext.ItensSideMenuMarkets, "Items", "Items");

                    DbContext.ItensSideMenuMarkets.Add(item);
                    DbContext.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new ItensSideMenuMarketViewModel();


            //    DbContext.ItensSideMenuMarkets.Add(item);
            //    DbContext.SaveChanges();

            //    return View("Index", viewModel);
            //}

            //return RedirectToAction("Index", "ItensSideMenuMarket");
        }

        public ActionResult CreateItemsFilho(int id)
        {

            var ItemPai = DbContext.ItensSideMenuMarkets.Single(i => i.Id == id);
            

            return View();
        }
    }
}