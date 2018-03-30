using System;
namespace AppRopio.Models.Products.Requests
{
    public class ProductsCompilationRequest
    {
        /// <summary>
        /// Идентификатор группы товаров
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Идентификатор товара
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Идентификатор параметра, запросившего подборку товаров
        /// </summary>
        public string ParameterId { get; set; }
    }
}
