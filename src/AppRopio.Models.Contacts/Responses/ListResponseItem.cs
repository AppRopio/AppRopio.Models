using System;
using AppRopio.Models.Contacts.Enums;
namespace AppRopio.Models.Contacts.Responses
{
	public class ListResponseItem
	{
        /// <summary>
        /// Иконка в формате Base64
        /// </summary>
		public string ImageBASE64 { get; set; }

        /// <summary>
        /// "Сырое значение" (ссылка, телефон и т.д.)
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Отображаемый пользователю текст
        /// </summary>
        public string DisplayValue { get; set; }

        /// <summary>
        /// Тип контакта
        /// </summary>
		public ContactTypes Type { get; set; }
	}
}
