using MongoShopping.Dtos.ProductDtos;
using MongoShopping.Dtos.ProductImages;

namespace MongoShopping.Services.ProductImagesServices
{
    public interface IProductImagesServices
    {
        Task<List<ResultProductImagesDto>> GetAllProductImagesAsync();
        Task CreateProductImagesAsync(CreateProductImagesDto createProductImagesDto);
        Task UpdateProductImagesAsync(UpdateProductImagesDto updateProductImagesDto);
        Task DeleteProductImagesAsync(string id);
        Task<GetProductImagesByIdDto> GetProductImagesByIdAsync(string id);
        Task<List<GetProductImagesByIdDto>> GetProductImagesByProductIdAsync(string productId);

    }
}
