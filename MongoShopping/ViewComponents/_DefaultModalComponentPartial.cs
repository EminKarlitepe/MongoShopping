using Microsoft.AspNetCore.Mvc;

public class _DefaultModalComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
