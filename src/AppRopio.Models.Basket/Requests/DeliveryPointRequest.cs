namespace AppRopio.Models.Basket.Requests
{
    public class DeliveryPointRequest
    {
        /// <summary>
        /// Идентификатор способа доставки
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Поисковый запрос
        /// </summary>
        public string SearchText { get; set; }
    }
}
