using System;
using System.Collections.Generic;

namespace AppRopio.Models.Products.Responses
{
    public class ApplyedProductParameter
    {
        public string Id { get; set; }

        public string MinValue { get; set; }

        public string MaxValue { get; set; }

        public bool? Enabled { get; set; }

        public string Name { get; set; }

        public string CustomType { get; set; }

        public string Content { get; set; }

        public ProductDataType DataType { get; set; }

        public List<ApplyedProductParameterValue> Values { get; set; }
    }
}
