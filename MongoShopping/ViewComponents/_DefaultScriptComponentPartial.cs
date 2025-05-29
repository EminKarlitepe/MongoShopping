using Microsoft.AspNetCore.Mvc;

namespace MongoShopping.ViewComponents
{
    public class _DefaultScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
