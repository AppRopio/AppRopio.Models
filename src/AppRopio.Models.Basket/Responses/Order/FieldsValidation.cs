using System.Collections.Generic;
namespace AppRopio.Models.Basket.Responses.Order
{
    public class FieldsValidation
    {
        public List<Field> NotValidFields { get; set; }

        public string Error { get; set; }
    }
}
