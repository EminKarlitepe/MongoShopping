using Microsoft.AspNetCore.Mvc;

namespace MongoShopping.ViewComponents
{
    public class _DefaultHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
