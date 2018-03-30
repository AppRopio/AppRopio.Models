using System.Collections.Generic;

namespace AppRopio.Models.Basket.Responses.Basket
{
    public class BasketModel
    {
        public string VersionId { get; set; }

        public List<BasketItem> Items { get; set; }

        public decimal Amount { get; set; }

        public decimal? Discount { get; set; }

        public string Error { get; set; }
    }
}
