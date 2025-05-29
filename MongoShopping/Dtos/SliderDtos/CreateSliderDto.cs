namespace MongoShopping.Dtos.SliderDtos
{
    public class CreateSliderDto
    {
        public string SectionName { get; set; }
        public string AnchorId { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
