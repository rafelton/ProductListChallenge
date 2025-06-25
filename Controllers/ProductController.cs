using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ProductListChallenge.Models;
using ProductListChallenge.Services;

namespace ProductListChallenge.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService(new ApplicationDbContext());
        }

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}