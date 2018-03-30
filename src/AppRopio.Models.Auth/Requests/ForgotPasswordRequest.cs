using System;
namespace AppRopio.Models.Auth.Requests
{
	public class ForgotPasswordRequest
	{
		/// <summary>
		/// Идентификатор пользователя: email/телефон в зависимости от настроек
		/// </summary>
		/// <value>The identifier.</value>
		public string Identifier { get; set; }
	}
}
