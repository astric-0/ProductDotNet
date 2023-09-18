using ProductDotNet.Models;
using System.Web.Mvc;
using ProductDotNet.Service.ProductDotNetService;
using System.Net.Http;
using System.Net;

namespace ProductDotNet.Controllers
{
    public class HomeController : Controller
    {     
        private readonly IProductService _productService;

        /*public HomeController()
        {

        }*/

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [ HttpPost ]       
        public HttpResponseMessage AddProduct(ProductModel model)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            return response;
        }
    }
}