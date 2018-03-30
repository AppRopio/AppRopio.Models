using System;
using System.Collections.Generic;
using AppRopio.Models.Feedback.Responses;

namespace AppRopio.Models.Feedback.Requests
{
    public class ApplicationResultRequest
    {
        public string ReviewId { get; set; }

        public string ProductId { get; set; }

        public string ProductGroupId { get; set; }

        public List<ReviewParameter> Parameters { get; set; }
    }
}