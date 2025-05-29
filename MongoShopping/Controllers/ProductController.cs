using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoShopping.Dtos.ProductDtos;
using MongoShopping.Dtos.ProductImages;
using MongoShopping.Services.CategoryServices;
using MongoShopping.Services.ProductImagesServices;
using MongoShopping.Services.ProductServices;
using MongoShopping.ViewModel;

namespace MongoShopping.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProductImagesServices _productImagesServices;

        public ProductController(IProductService productService, ICategoryService categoryService, IProductImagesServices productImagesServices)
        {
            _productService = productService;
            _categoryService = categoryService;
            _productImagesServices = productImagesServices;
        }

        public async Task<IActionResult> ProductList()
        {
            var values = await _productService.GetAllProductAsync();
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.Categories = categories;
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> ProductOverview()
        {
            var products = await _productService.GetAllProductAsync();
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.Categories = categories;
            return View(products);
        }

        public async Task<IActionResult> ProductDetailModal(string id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            var images = await _productImagesServices.GetProductImagesByProductIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            var model = new ProductModalViewModel
            {
                Product = product,
                Images = images ?? new List<GetProductImagesByIdDto>()
            };

            return PartialView("_ProductDetailModal", model);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName", product.CategoryId);

            var updateDto = new UpdateProductDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Description = product.Description,
                ProductPrice = product.ProductPrice,
                StockCount = product.StockCount,
                CategoryId = product.CategoryId,
                Brand = product.Brand,
                ImageUrl = product.ImageUrl,
                Status = product.Status
            };

            return View(updateDto);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }
    }
}
