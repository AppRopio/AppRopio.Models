using System;
using System.Collections.Generic;
namespace AppRopio.Models.Basket.Responses.Order
{
    public class DeliveryDay
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<DeliveryTime> Times { get; set; }
    }
}
