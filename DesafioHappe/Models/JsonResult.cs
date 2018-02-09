using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioHappe.Models
{
    public class JsonResult<T>
    {
        public T Src { get; set; }
    }
}