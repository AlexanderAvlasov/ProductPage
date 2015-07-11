using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Product
    {
        public String Name {set;get;}
        public int Id { set; get; }
        public String Type { set; get; }
        public int Count { set; get; }

        public Product(String Name,String Type,int Count)
        {
            this.Name = Name;
            this.Type = Type;
            this.Count = Count;
        }
        public Product() { }

    }
}