using Microsoft.AspNetCore.Mvc;
using MongoShopping.Services.SliderServices;

namespace MongoShopping.ViewComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _DefaultSliderComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _sliderService.GetAllSliderAsync();
            return View(values);
        }

    }
}
