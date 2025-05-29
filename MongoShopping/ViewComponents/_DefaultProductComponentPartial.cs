using Microsoft.AspNetCore.Mvc;
using MongoShopping.Services.CategoryServices;
using MongoShopping.Services.ProductServices;
using System.Threading.Tasks;
using System.Collections.Generic;
using MongoShopping.Dtos.ProductDtos;
using MongoShopping.Dtos.CategoryDtos;

namespace MongoShopping.ViewComponents
{
    public class _DefaultProductComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public _DefaultProductComponentPartial(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<ResultProductDto> products = await _productService.GetAllProductAsync();
            List<ResultCategoryDto> categories = await _categoryService.GetAllCategoryAsync();

            ViewBag.Categories = categories;

            return View(products);
        }
    }
}
