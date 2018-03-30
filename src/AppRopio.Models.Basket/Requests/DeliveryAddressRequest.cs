using System;
using AppRopio.Models.Base.Responses;
namespace AppRopio.Models.Basket.Requests
{
    public class DeliveryAddressRequest
    {
        /// <summary>
        /// Идентификатор способа доставки
        /// </summary>
        public string DeliveryId { get; set; }

        /// <summary>
        /// Координаты пользователя
        /// </summary>
        public Coordinates Coordinates { get; set; }
    }
}
