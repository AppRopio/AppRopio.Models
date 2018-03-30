using System;
namespace AppRopio.Models.Feedback.Responses
{
    public class ReviewDetails : Review
    {
        /// <summary>
        /// Id товара
        /// </summary>
        public string ProductId { get; set; }

		/// <summary>
		/// Id группы товара
		/// </summary>
		public string ProductGroupId { get; set; }

		/// <summary>
		/// Может ли текущий пользователь изменять или удалять отзыв
		/// </summary>
		public bool Editable { get; set; }
    }
}