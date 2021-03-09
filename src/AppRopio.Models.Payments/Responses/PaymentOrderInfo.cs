using System;
using System.Collections.Generic;

namespace AppRopio.Models.Payments.Responses
{
    /// <summary>
    /// Информация о заказе для оплаты
    /// </summary>
    public class PaymentOrderInfo
    {
        /// <summary>
        /// Сумма к оплате
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Имя покупателя
        /// </summary>
        public string CustomerFirstName { get; set; }

        /// <summary>
        /// Фамилия покупателя
        /// </summary>
        public string CustomerLastName { get; set; }

        /// <summary>
        /// Телефон покупателя
        /// </summary>
        public string CustomerPhone { get; set; }

		/// <summary>
		/// Email покупателя
		/// </summary>
		public string CustomerEmail { get; set; }

        /// <summary>
        /// Товары
        /// </summary>
        public List<PaymentOrderItem> Items { get; set; }
    }
}