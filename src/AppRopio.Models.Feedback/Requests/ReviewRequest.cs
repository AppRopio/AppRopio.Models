using System;
namespace AppRopio.Models.Feedback.Requests
{
    public class ReviewRequest
    {
        public string ProductId { get; set; }

        public string ProductGroupId { get; set; }

        public int Count { get; set; }

        public int Offset { get; set; }
    }
}
