using Microsoft.AspNetCore.Mvc;

namespace MVC_demo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }
    }
}
