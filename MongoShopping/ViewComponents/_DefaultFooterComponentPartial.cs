﻿using Microsoft.AspNetCore.Mvc;

namespace MongoShopping.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
