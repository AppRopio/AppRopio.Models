using System.Collections.Generic;

namespace AppRopio.Models.Products.Responses
{
    public class ProductParameter : ApplyedProductParameter
    {
        public ProductWidgetType WidgetType { get; set; }

        public new List<ProductParameterValue> Values { get; set; }
    }
}