using AutoMapper;
using MongoDB.Driver;
using MongoShopping.Dtos.ProductDtos;
using MongoShopping.Dtos.ProductImages;
using MongoShopping.Entities;
using MongoShopping.Settings;

namespace MongoShopping.Services.ProductImagesServices
{
    public class ProductImagesService : IProductImagesServices
    {
        private readonly IMongoCollection<ProductImages> _productImagesCollection;
        private readonly IMapper _mapper;

        public ProductImagesService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productImagesCollection = database.GetCollection<ProductImages>(_databaseSettings.ProductImagesCollectionName);
            _mapper = mapper;
        }

        public Task CreateProductImagesAsync(CreateProductImagesDto createProductImagesDto)
        {
            var value = _mapper.Map<ProductImages>(createProductImagesDto);
            return _productImagesCollection.InsertOneAsync(value);

        }

        public async Task<List<GetProductImagesByIdDto>> GetProductImagesByProductIdAsync(string productId)
        {
            var images = await _productImagesCollection.Find(x => x.ProductId == productId).ToListAsync();
            return _mapper.Map<List<GetProductImagesByIdDto>>(images);
        }


        public async Task DeleteProductImagesAsync(string id)
        {
            await _productImagesCollection.DeleteOneAsync(x => x.ProductId == id);
        }

        public async Task<List<ResultProductImagesDto>> GetAllProductImagesAsync()
        {
            var value = await _productImagesCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductImagesDto>>(value);
        }

        public async Task<GetProductImagesByIdDto> GetProductImagesByIdAsync(string id)
        {
            var value = await _productImagesCollection.Find(x => x.ImageId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetProductImagesByIdDto>(value);
        }

        public async Task UpdateProductImagesAsync(UpdateProductImagesDto updateProductImagesDto)
        {
            var value = _mapper.Map<ProductImages>(updateProductImagesDto);
            await _productImagesCollection.FindOneAndReplaceAsync(x => x.ImageId == updateProductImagesDto.ImageId, value);
        }
    }
}
