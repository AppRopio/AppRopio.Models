using System;
namespace AppRopio.Models.Feedback.Responses
{
    /// <summary>
    /// Сокращенная модель отзыва
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

		/// <summary>
		/// Название товара
		/// </summary>
		public string ProductTitle { get; set; }

		/// <summary>
		/// Ссылка на изображение товара
		/// </summary>
		public string ProductImageUrl { get; set; }

        /// <summary>
        /// Автор отзыва
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Дата публикации
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Превью текста
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Оценка
        /// </summary>
        public ReviewRating Rating { get; set; }
    }
}