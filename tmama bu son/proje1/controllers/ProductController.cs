using Microsoft.AspNetCore.Mvc;
using proje1.models;
using System.Collections.Generic;
namespace proje1.controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>();
            new Product { Id = 1, Name = "Product 1", Price = 20.0m };
            new Product { Id = 2, Name = "Prodcuct 2", Price = 10.0m };
            return View(products);
        }
    }
}
