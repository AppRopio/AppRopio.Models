using System;
using AppRopio.Models.Base.Responses;

namespace AppRopio.Models.Map.Requests
{
    public class PointsRequest
    {
        /// <summary>
        /// Текущие координаты пользователся, для возврата значения Distance
        /// </summary>
        public Coordinates Position { get; set; }

        public string SearchText { get; set; }

        public int Offset { get; set; }

        public int Count { get; set; }
    }
}
