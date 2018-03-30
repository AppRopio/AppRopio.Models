namespace AppRopio.Models.Products.Responses
{
    public class Category
    {
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Используется для загрузки небольших иконок (не путать с картинками/фотографиями) для иллюстрации категории
        /// </summary>
        /// <value>The icon URL.</value>
        public string IconUrl { get; set; }

        /// <summary>
        /// Используется для загрузки изображений для фона карточек категорий
        /// </summary>
        public string BackgroundImageUrl { get; set; }

        public CategoryContainerType ContainerType { get; set; }
    }
}
