using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using DesafioHappe.Models;
using Microsoft.AspNet.Identity;

namespace DesafioHappe.Base
{
    public class BaseController : Controller
    {
        internal ApplicationDbContext _context;

        public BaseController()
        {
            _context = new ApplicationDbContext();
        }
        [ChildActionOnly]
        public ActionResult Menu()
        {
            var userID = User.Identity.GetUserId();
            var menu = _context.MenusForUsers
                .Include(x => x.ItensSideMenuMarket)
                .Where(x => x.ApplicationUserId == userID)
                .Select(x => x.ItensSideMenuMarket)
                .ToList();

            return PartialView(menu);
        }
    }
}