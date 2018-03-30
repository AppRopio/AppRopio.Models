using System;
namespace AppRopio.Models.Auth.Requests
{
	public class ValidateCodeRequest
	{
		/// <summary>
		/// Код подтверждения (например из смс)
		/// </summary>
		/// <value>The code.</value>
		public string Code { get; set; }
	}
}
