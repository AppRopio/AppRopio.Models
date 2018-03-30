using System.Collections.Generic;
using AppRopio.Models.Basket.Responses.Order;

namespace AppRopio.Models.HistoryOrders.Responses
{
    /// <summary>
    /// Детали заказа в истории
    /// </summary>
    public class HistoryOrderDetails
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// История статусов заказа
        /// </summary>
        public List<string> OrderStatus { get; set; }

        /// <summary>
        /// Информация о доставке
        /// </summary>
        public Delivery Delivery { get; set; }

        /// <summary>
        /// Информация об адресе доставки
        /// </summary>
		public DeliveryPoint DeliveryPoint { get; set; }

        /// <summary>
        /// Способ оплаты
        /// </summary>
		public Payment Payment { get; set; }
    }
}