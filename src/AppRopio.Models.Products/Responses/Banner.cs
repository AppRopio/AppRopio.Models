namespace AppRopio.Models.Products.Responses
{
    public class Banner
    {
        public string Id { get; set; }

        public string ImageUrl { get; set; }

        public string Deeplink { get; set; }

        public BannerPosition Position { get; set; }
    }
}
