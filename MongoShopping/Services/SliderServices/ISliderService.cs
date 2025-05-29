using MongoShopping.Dtos.SliderDtos;

namespace MongoShopping.Services.SliderServices
{
    public interface ISliderService
    {
        Task <List<ResultSliderDto>> GetAllSliderAsync();
        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);
        Task DeleteSliderAsync(string id);
        Task<GetSliderByIdDto> GetSliderByIdDtoAsync(string id);
    }
}
