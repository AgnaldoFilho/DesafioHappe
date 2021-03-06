﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DesafioHappe.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //public virtual ICollection<ItensSideMenuMarket> ItensSideMenuMarkets { get; set; }


        //[ForeignKey("ApplicationUserId")]
        //public virtual ApplicationUser AppUser { get; set; }

        //[Required]
        //public string ApplicationUserId { get; set; }

        //public ItensSideMenuMarket ItensSideMenuMarket { get; set; }

        //[Required]
        //public int ItensSideMenuMarketId { get; set; }

        //public bool Ativo { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here



            //var claims = new IEnumerable<ItensSideMenuMarket>();
            

            //userIdentity.AddClaim(new Claim("Id", ItensSideMenuMarkets.Contains()));
            return userIdentity;
        }
    }
}