using Microsoft.AspNetCore.Mvc;
using PartialViewSample.Models;

namespace PartialViewSample.Controllers
{
    public class ProductController : Controller
    {

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
            return View(products);
        }

        public IActionResult Details(int id)
        {
            Product product = products.FirstOrDefault(x => x.ProductID == id);
            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult ProductDetail(int id)
        {
            Product product = products.FirstOrDefault(x => x.ProductID == id);
            //return PartialView("ProductDetail", product); // viewName, model
            return PartialView("~/Views/Shared/ProductDetail.cshtml", product); 
        }
    }
}
