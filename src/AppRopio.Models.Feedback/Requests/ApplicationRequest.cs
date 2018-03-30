using System;
namespace AppRopio.Models.Feedback.Requests
{
    public class ApplicationRequest
    {
        public string ReviewId { get; set; }

        public string ProductId { get; set; }

        public string ProductGroupId { get; set; }
    }
}
