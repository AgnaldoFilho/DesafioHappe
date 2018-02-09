using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioHappe.ViewModels
{
    public class ParentDropDownViewModel
    {
        public int OrderNumber { get; set; }
        public List<ItensSideMenuMarketViewModel> Items { get; set; }
        public int Selected { get; set; }
    }
}