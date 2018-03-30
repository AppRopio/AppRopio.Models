using System;
namespace AppRopio.Models.Products.Responses
{
    /// <summary>
    /// Магазин
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Продукт в наличии
        /// </summary>
        public bool IsProductAvailable { get; set; }

        /// <summary>
        /// Кол-во
        /// </summary>
        public int? Count { get; set; }
    }
}
