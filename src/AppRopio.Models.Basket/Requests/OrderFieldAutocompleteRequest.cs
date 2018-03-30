using System;
using System.Collections.Generic;

namespace AppRopio.Models.Basket.Requests
{
    public class OrderFieldAutocompleteRequest
    {
        /// <summary>
        /// Id поля с автозаполнением
        /// </summary>
        public string FieldId { get; set; }
        
        /// <summary>
        /// Текущее значение поля
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Значения звисимых полей
        /// </summary>
        public Dictionary<string, string> DependentFieldsValues { get; set; }
    }
}
