using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesafioHappe.Models;

namespace DesafioHappe.ViewModels
{
    public class NewMenusForUserViewModel
    {
        public List<ItensSideMenuMarket> ItensSideMenuMarkets { get; set; }
        public MenusForUser MenusForUser { get; set; }
    }
}