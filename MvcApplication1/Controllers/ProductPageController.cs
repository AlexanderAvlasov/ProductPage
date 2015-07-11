using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
namespace MvcApplication1.Controllers
{
    public class ProductPageController : Controller
    {
        //
        // GET: /ProductPage/
        StackContext context = new StackContext();
        [HttpGet]
        public ActionResult Index()
        {
            
            //List<Product> list = new List<Product>();
            //list.Add(new Product("Apple", "Golden", 5));
            //list.Add(new Product("Apple","Green",10));
            //list.Add(new Product("Apple", "Green", 10));
            ProductModel model = new ProductModel();
            model.products = context.Products.AsEnumerable().ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult CreateNew()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }

    }
}
