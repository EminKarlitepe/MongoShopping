using AutoMapper;
using MongoShopping.Dtos.CategoryDtos;
using MongoShopping.Dtos.ProductDtos;
using MongoShopping.Dtos.ProductImages;
using MongoShopping.Dtos.SliderDtos;
using MongoShopping.Entities;

namespace MongoShopping.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryByIdDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductByIdDto>().ReverseMap();

            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, GetSliderByIdDto>().ReverseMap();

            CreateMap<ProductImages, CreateProductImagesDto>().ReverseMap();
            CreateMap<ProductImages, ResultProductImagesDto>().ReverseMap();
            CreateMap<ProductImages, UpdateProductImagesDto>().ReverseMap();
            CreateMap<ProductImages, GetProductImagesByIdDto>().ReverseMap();
        }
    }
}
