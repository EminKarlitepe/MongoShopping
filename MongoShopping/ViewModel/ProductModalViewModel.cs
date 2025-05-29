using MongoShopping.Dtos.ProductDtos;
using MongoShopping.Dtos.ProductImages;

public class ProductModalViewModel
{
    public GetProductByIdDto Product { get; set; } = null!;
    public List<GetProductImagesByIdDto> Images { get; set; } = new();
}
