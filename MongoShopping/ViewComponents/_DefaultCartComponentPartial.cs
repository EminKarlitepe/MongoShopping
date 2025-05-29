using Microsoft.AspNetCore.Mvc;

namespace MongoShopping.ViewComponents
{
    public class _DefaultCartComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
