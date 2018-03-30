using System;
namespace AppRopio.Models.Basket.Requests
{
    public class ConfirmOrderRequest
    {
        public string Id { get; set; }

        public bool IsPaid { get; set; }
    }
}
