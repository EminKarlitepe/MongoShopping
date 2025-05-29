using Microsoft.AspNetCore.Mvc;
using MongoShopping.Dtos.ProductImages;
using MongoShopping.Services.ProductImagesServices;
using MongoShopping.Services.ProductServices;

public class _DefaultProductDetailModalComponent : ViewComponent
{
    private readonly IProductService _productService;

    public _DefaultProductDetailModalComponent(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<IViewComponentResult> InvokeAsync(string id)
    {
        var product = await _productService.GetProductByIdAsync(id);
        return View(product);
    }
}
