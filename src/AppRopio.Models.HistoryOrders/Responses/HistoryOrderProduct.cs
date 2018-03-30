using System;

namespace AppRopio.Models.HistoryOrders.Responses
{
    /// <summary>
    /// Товар в истории
    /// </summary>
    public class HistoryOrderProduct
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Id товара
        /// </summary>
        public string ProductId { get; set;}

		/// <summary>
		/// Id группы товара
		/// </summary>
		public string GroupId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Итоговая стоимость
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Есть в наличии
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Бейдж (например нет в наличии)
        /// </summary>
        public string Badge { get; set; }

        /// <summary>
        /// Ссылка на изображение
        /// </summary>
        public string ImageUrl { get; set; }
    }
}