namespace AppRopio.Models.Geofencing.Responses
{
    public class GeofencingModel
    {
        /// <summary>
        /// Id региона
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Координаты
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Координаты
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Радиус
        /// </summary>
        public int Radius { get; set; }
    }
}
