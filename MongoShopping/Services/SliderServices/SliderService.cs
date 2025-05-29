using AutoMapper;
using MongoDB.Driver;
using MongoShopping.Dtos.SliderDtos;
using MongoShopping.Entities;
using MongoShopping.Settings;

namespace MongoShopping.Services.SliderServices
{
    public class SliderService : ISliderService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Slider> _sliderCollection;
        public SliderService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _sliderCollection = database.GetCollection<Slider>(_databaseSettings.SliderCollectionName);
            _mapper = mapper;
        }

        public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            var value = _mapper.Map<Slider>(createSliderDto);
            await _sliderCollection.InsertOneAsync(value);
        }

        public async Task DeleteSliderAsync(string id)
        {
            await _sliderCollection.DeleteOneAsync(x => x.SectionId == id);
        }

        public async Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            var value = await _sliderCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultSliderDto>>(value);
        }

        public async Task<GetSliderByIdDto> GetSliderByIdDtoAsync(string id)
        {
            var value = await _sliderCollection.Find(x => x.SectionId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetSliderByIdDto>(value);
        }

        public async Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            var value = _mapper.Map<Slider>(updateSliderDto);
            await _sliderCollection.FindOneAndReplaceAsync(x => x.SectionId == updateSliderDto.SectionId, value);
        }
    }
}
