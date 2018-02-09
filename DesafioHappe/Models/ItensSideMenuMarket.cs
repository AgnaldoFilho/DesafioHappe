using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioHappe.Models
{
    public class ItensSideMenuMarket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Route { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual ItensSideMenuMarket Parent { get; set; }
        
        [InverseProperty("Parent")]
        public virtual ICollection<ItensSideMenuMarket> Childs { get; set; }
        

    }
}