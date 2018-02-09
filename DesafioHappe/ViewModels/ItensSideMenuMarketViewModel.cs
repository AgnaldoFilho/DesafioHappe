using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesafioHappe.ViewModels
{
    public class ItensSideMenuMarketViewModel
    {
         public int[] Id { get; set; }
         public MultiSelectList Name { get; set; }
    }
}