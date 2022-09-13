using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module6HW4.core.Interfaces;
using Module6HW4.core.Entity;
namespace Module6HW4.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet("List")]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        [HttpGet("GetEntityById/{id}")]
        public IActionResult GetEntityId([FromRoute] int id)
        {
            var result = _productService.GetProductById(id);
            return View(result);
        }


        [HttpGet("PostPage")]
        public IActionResult PostPage()
        {
            return View("PostPage");
        }

        [HttpGet("DeletePage/{id}")]
        public IActionResult DeletePage([FromRoute] int id)
        {
            var list = _productService.ProductDelete(id);
            return View(list);
        }

        [HttpGet("EditPage")]
        public IActionResult EditPage()
        {
            return View("EditPage");
        }

        [HttpPost]
        public IActionResult Post([FromForm] Product product )
        {         
            _productService.ProductAdd(product);
            return RedirectToAction("GetAll");
        }


        [HttpPut]
        public IActionResult Put([FromForm] Product product)
        {
            _productService.ProductUpdate(product);
            return RedirectToAction("GetAll");
        }
    }
}