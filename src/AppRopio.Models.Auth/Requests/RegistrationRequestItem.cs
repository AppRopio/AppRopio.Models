using System;
using AppRopio.Models.Auth.Enums;

namespace AppRopio.Models.Auth.Requests
{
	public class RegistrationRequestItem
	{
		public string Id { get; set; }

		public RegistrationFieldType Type { get; set; }

		public string Value { get; set; }

	}
}
