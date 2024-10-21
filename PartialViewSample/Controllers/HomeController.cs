using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartialViewSample.Models;

namespace PartialViewSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        List<Product> products = new List<Product>()
        {
            new Product(){ProductID=1,ProductName="Product 1",CategoryName="Category 1", Description ="Description 1", Price= 10.50M},
            new Product(){ProductID=2,ProductName="Product 2",CategoryName="Category 1", Description ="Description 2", Price= 15.50M},
            new Product(){ProductID=3,ProductName="Product 3",CategoryName="Category 2", Description ="Description 3", Price= 10M},
            new Product(){ProductID=4,ProductName="Product 4",CategoryName="Category 4", Description ="Description 4", Price= 13M},
            new Product(){ProductID=5,ProductName="Product 5",CategoryName="Category 1", Description ="Description 5", Price= 13M},
        };

        public IActionResult Index()
        {
            var productList = products.OrderBy(x => x.Price).ThenByDescending(x => x.CategoryName);
            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
