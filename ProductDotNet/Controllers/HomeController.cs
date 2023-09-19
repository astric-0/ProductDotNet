using ProductDotNet.Models;
using System.Web.Mvc;
using ProductDotNet.Service.ProductDotNetService;
using System.Net.Http;
using System.Net;
using ProductDotNet.Service.Entity;

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

        public ActionResult GetAll()
        {           
            return Json(_productService.GetAll(), JsonRequestBehavior.AllowGet);
        }

        [ HttpGet ]       
        [ Route("{id}") ]
        public HttpResponseMessage DeleteProduct(int id)
        {
            if (_productService.DeleteProduct(id))
                return new HttpResponseMessage(HttpStatusCode.OK);
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        [ HttpPost ]
        [ Route("{id}") ]
        public HttpResponseMessage UpdateProduct(int id, ProductModel product) 
        {
            var productInfo = AutoMapper.Mapper.Map<ProductModel, ProductEntity>(product);
            _productService.UpdateProduct(id, productInfo);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [ HttpPost ]       
        public HttpResponseMessage AddProduct(ProductModel product)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            var productInfo = AutoMapper.Mapper.Map<ProductModel, ProductEntity>(product);
            _productService.AddProduct(productInfo);
            return response;
        }
    }
}