using System;
using System.Collections.Generic;

namespace AppRopio.Models.Auth.Requests
{
	public class RegistrationRequest
	{
		public List<RegistrationRequestItem> Fields { get; set; }
	}
}
