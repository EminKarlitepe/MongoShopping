using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoShopping.Dtos.ProductDtos;
using MongoShopping.Dtos.ProductImages;
using MongoShopping.Services.ProductImagesServices;
using MongoShopping.Services.ProductServices;

namespace MongoShopping.Controllers
{
    public class ProductImagesController : Controller
    {
        private readonly IProductImagesServices _productImageService;
        private readonly IProductService _productService;

        public ProductImagesController(IProductImagesServices productImageService, IProductService productService)
        {
            _productImageService = productImageService;
            _productService = productService;
        }

        public async Task<IActionResult> ProductImagesList()
        {
            var values = await _productImageService.GetAllProductImagesAsync();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProductImages()
        {
            var products = await _productService.GetAllProductAsync();
            ViewBag.Products = products.Select(p => new SelectListItem
            {
                Text = p.ProductName,
                Value = p.ProductId
            }).ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImages(CreateProductImagesDto createProductImagesDto)
        {
            await _productImageService.CreateProductImagesAsync(createProductImagesDto);
            return RedirectToAction("ProductImagesList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProductImages(string id)
        {
            var products = await _productService.GetAllProductAsync();
            ViewBag.Products = products.Select(p => new SelectListItem
            {
                Text = p.ProductName,
                Value = p.ProductId
            }).ToList();

            var values = await _productImageService.GetProductImagesByIdAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductImages(UpdateProductImagesDto updateProductImagesDto)
        {
            await _productImageService.UpdateProductImagesAsync(updateProductImagesDto);
            return RedirectToAction("ProductImagesList");
        }

        public async Task<IActionResult> DeleteProductImages(string id)
        {
            await _productImageService.DeleteProductImagesAsync(id);
            return RedirectToAction("ProductImagesList");
        }
    }
}
