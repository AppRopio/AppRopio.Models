using System;

namespace AppRopio.Models.Products.Responses
{
    public class Review
    {
        public long ID { get; set; }

        public DateTime Date { get; set; }

        public string UserName { get; set; }

        public string Text { get; set; }
    }
}