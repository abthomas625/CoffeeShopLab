using CoffeeShopRegistrationLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistrationLab.Controllers
{
    public class ProductController : Controller
    {
        CoffeeHouseContext db = new CoffeeHouseContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult DisplayDescription()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }
    }
}
