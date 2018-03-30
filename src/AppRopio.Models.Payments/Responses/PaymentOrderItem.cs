using System;

namespace AppRopio.Models.Payments.Responses
{
    /// <summary>
    /// Информация о товаре при оплате
    /// </summary>
    public class PaymentOrderItem
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public double Quantity { get; set; }
    }
}
