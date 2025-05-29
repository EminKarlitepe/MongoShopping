using Microsoft.AspNetCore.Mvc;
using MongoShopping.Services.CategoryServices;

namespace MongoShopping.ViewComponents
{
    public class _DefaultBannerComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public _DefaultBannerComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _categoryService.GetAllCategoryAsync();
            return View(value);
        }
    }
}
