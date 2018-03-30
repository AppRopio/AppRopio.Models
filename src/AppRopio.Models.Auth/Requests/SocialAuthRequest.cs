using System;
using AppRopio.Models.Auth.Enums;
namespace AppRopio.Models.Auth.Requests
{
	public class SocialAuthRequest
	{
		/// <summary>
		/// Токен, полученный от социальной сети
		/// </summary>
		/// <value>The token.</value>
		public string Token { get; set; }

		/// <summary>
		/// Тип социальной сети
		/// </summary>
		/// <value>The type.</value>
		public SocialType Type { get; set; }
	}
}
