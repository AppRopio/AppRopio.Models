using System;
using AppRopio.Models.Products.Responses;
namespace AppRopio.Models.Products.Requests
{
    public class BannerRequest
    {
        /// <summary>
        /// Идентификатор баннера
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Позиция баннера (Top/Bottom)
        /// </summary>
        public BannerPosition Position { get; set; }
    }
}
