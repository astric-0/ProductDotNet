using ProductDotNet.Models;
using System.Net;
using System.Web.Mvc;
using System.Net.Http;

namespace ProductDotNet.Controllers
{
    public class HomeController : Controller
    {
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