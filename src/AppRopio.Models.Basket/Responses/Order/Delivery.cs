using AppRopio.Models.Basket.Responses.Enums;

namespace AppRopio.Models.Basket.Responses.Order
{
    public class Delivery
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DeliveryType Type { get; set; }

        public decimal? Price { get; set; }

        public bool DeliveryTimeIsNeeded { get; set; }

        public bool RequiredDataEntry { get; set; }       

        //регулирует возможность использования поля для выбора в качестве способа доставки (если true, то показывай пользователю Message)
        public bool NotAvailable { get; set; }

        //сообщение, которое выводится пользователю, если способ не доступен для использования
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:AppRopio.Models.Basket.Responses.Order.Delivery"/>
        /// previously selected by user. In deliveries list should be only one selected delivery.
        /// </summary>
        /// <value><c>true</c> if previously selected; otherwise, <c>false</c>.</value>
        public bool PreviouslySelected { get; set; }
    }
}
