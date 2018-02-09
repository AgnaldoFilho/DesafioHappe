using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DesafioHappe.Models
{
    public class MenusForUser
    {
        public int Id { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public ItensSideMenuMarket ItensSideMenuMarket { get; set; }

        [Required]
        public int ItensSideMenuMarketId { get; set; }

        public bool Ativo { get; set; }
    }
}