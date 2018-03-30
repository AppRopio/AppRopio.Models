using System;

namespace AppRopio.Models.HistoryOrders.Responses
{
    /// <summary>
    /// Статус оплаты
    /// </summary>
    public enum PaymentStatus
    {
        /// <summary>
        /// Неизвестно
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Оплачено
        /// </summary>
        Paid = 1,
        /// <summary>
        /// Не оплачено
        /// </summary>
        NotPaid = 2
    }

    /// <summary>
    /// Заказ в истории
    /// </summary>
    public class HistoryOrder
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Номер заказа
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Количество товаров
        /// </summary>
        public int ItemsCount { get; set; }

        /// <summary>
        /// Статус оплаты
        /// </summary>
        public PaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// Последний статус заказа
        /// </summary>
        public string OrderStatus { get; set; }

        /// <summary>
        /// Итоговая стоимость
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        public string ImageUrl { get; set; }
    }
}
