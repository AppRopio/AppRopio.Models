namespace AppRopio.Models.Basket.Requests
{
    public class ChangeQuantityRequest
    {
        public string Id { get; set; }

        public float Quantity { get; set; }
    }
}