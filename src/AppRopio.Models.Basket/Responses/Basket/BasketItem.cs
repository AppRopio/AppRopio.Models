using System.Collections.Generic;
using AppRopio.Models.Products.Responses;

namespace AppRopio.Models.Basket.Responses.Basket
{
    public class BasketItem : Product
    {
        /// <summary>
        /// Ключ - имя параметра
        /// </summary>
        public Dictionary<string, List<ProductParameter>> Parameters { get; set; }

        public Dictionary<string, ProductParameter> selectedParameters { get; set; }

        /// <summary>
        /// Количество единиц товара.
        /// ! Корректное количество является произведением Quantity на UnitStep.
        /// </summary>
        public float Quantity { get; set; }
    }
}
