using System;
using System.Collections.Generic;
using AppRopio.Models.Auth.Enums;
namespace AppRopio.Models.Auth.Responses
{
	public class RegistrationResponse : AuthResponse
	{
		public string Error { get; set; }

		public bool Successful { get; set; }

		public List<string> InvalidFieldsIds { get; set; }
	}
}
