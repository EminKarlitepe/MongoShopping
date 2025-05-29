using Microsoft.AspNetCore.Mvc;

namespace MongoShopping.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
