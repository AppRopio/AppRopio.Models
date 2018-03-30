using System.Collections.Generic;

namespace AppRopio.Models.Basket.Requests
{
    public class ConfirmDeliveryAddressRequest
    {
        public string DeliveryId { get; set; }

        public Dictionary<string, string> FieldsValues { get; set; }
    }
}