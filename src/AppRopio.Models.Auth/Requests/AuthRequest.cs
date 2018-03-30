using System;
namespace AppRopio.Models.Auth.Requests
{
	public class AuthRequest
	{
		/// <summary>
		/// Идентификатор пользователя: email/телефон в зависимости от настроек
		/// </summary>
		/// <value>The identifier.</value>
		public string Identifier { get; set; }

		/// <summary>
		/// Пароль пользователя
		/// </summary>
		/// <value>The password.</value>
		public string Password { get; set; }
	}
}
