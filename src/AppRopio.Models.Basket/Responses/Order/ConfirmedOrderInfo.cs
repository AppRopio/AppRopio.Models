using System;
namespace AppRopio.Models.Basket.Responses.Order
{
    /// <summary>
    /// Информация о подтвержденном заказе для систем аналитики
    /// </summary>
    public class ConfirmedOrderInfo
    {
        /// <summary>
        /// Стоимость заказа
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Общее число (сумма) единиц каждого товара в заказе
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Валюта заказа
        /// </summary>
        public string Currency { get; set; }
    }
}
