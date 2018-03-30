using System;
using System.Collections.Generic;
using AppRopio.Models.Products.Responses;

namespace AppRopio.Models.Products.Requests
{
    public class ApplyedParametersRequest
    {
        public string GroupId { get; set; }

        public string ProductId { get; set; }

        public List<ApplyedProductParameter> Parameters { get; set; }
    }
}
