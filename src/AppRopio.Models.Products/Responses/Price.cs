using System;
namespace AppRopio.Models.Products.Responses
{
    public class Price
    {
        /// <summary>
        /// Цена товара
        /// </summary>
        public decimal? Value { get; set; }

        /// <summary>
        /// Единица измерения товара по этой цене
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// Шаг изменения количества товара по этой цене
        /// </summary>
        public float? UnitStep { get; set; }
    }
}
