using System.Collections.Generic;

namespace AppRopio.Models.Basket.Responses.Order
{
    public class OrderFieldsGroup
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<OrderField> Items { get; set; }
    }
}
