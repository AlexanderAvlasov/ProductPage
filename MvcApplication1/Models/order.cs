using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Order
    {
        public int id { set; get; }
        public int count { set; get; }
        public int product_id { set; get; }
    }
}