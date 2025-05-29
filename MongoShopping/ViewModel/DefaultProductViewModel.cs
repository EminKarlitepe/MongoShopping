using MongoShopping.Dtos.ProductDtos;
using MongoShopping.Dtos.CategoryDtos;
using System.Collections.Generic;

namespace MongoShopping.ViewModel
{
    public class DefaultProductViewModel
    {
        public List<ResultProductDto> Products { get; set; }
        public List<ResultCategoryDto> Categories { get; set; }
    }
}
