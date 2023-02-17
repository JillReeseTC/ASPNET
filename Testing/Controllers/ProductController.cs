using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;
        
        public int id { get => id; set => id = value; }

        //public int Id { get => id; set => id = value; }

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();

            return View(products);
        }
        public IActionResult ViewProduct(int id) 
        {
            var product = repo.GetProduct(id);
            return View(product);
        }
    }
}
