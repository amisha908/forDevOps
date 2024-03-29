using Microsoft.AspNetCore.Mvc;
using mvcWithMultipleReturn.Models;
using System.Diagnostics;

namespace mvcWithMultipleReturn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Product product = new Product();
            product.Id = 1;
            product.Name = "Test";
            product.Description = "Test pass";
            product.Price = 100;
            return View(product);
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

        public IActionResult DisplayProduct()
        {
            //Product product = new Product();
            //product.Id = 1;
            //product.Name = "Test";
            //product.Description = "Test pass";
            //product.Price = 100;

            //return View(product);
            List<Product> products1 = new List<Product>();

            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Test";
            product1.Description = "Test3";
            product1.Price = 100;

            products1.Add(product1);
            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Test";
            product2.Description = "Test3";
            product2.Price = 100;
            products1.Add(product2);


            List<Product> products = new List<Product>()
            {

            new Product()
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                Price = 100,
            },
            new Product()
            {
                Id= 2,
                Name = "Test2",
                Description = "Test2",
                Price = 200,
            }
            };
            
            return View(products);

        }
    }
    
}