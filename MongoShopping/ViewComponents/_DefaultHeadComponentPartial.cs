using Microsoft.AspNetCore.Mvc;

namespace MongoShopping.ViewComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
