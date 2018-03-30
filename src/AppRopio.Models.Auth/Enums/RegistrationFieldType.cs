using System;
using System.Runtime.Serialization;

namespace AppRopio.Models.Auth.Enums
{
	public enum RegistrationFieldType
	{
		Unknown,
		[EnumMember(Value = "email")]
		Email,
		[EnumMember(Value = "password")]
		Password,
		[EnumMember(Value = "phone")]
		Phone,
		[EnumMember(Value = "textField")]
		TextField,
		[EnumMember(Value = "picker")]
		Picker,
		[EnumMember(Value = "date")]
		Date
	}
}
