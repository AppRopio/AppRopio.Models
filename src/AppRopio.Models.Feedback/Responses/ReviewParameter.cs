using System;
namespace AppRopio.Models.Feedback.Responses
{
    public class ReviewParameter
    {
        public string Id { get; set; }

        public ReviewWidgetType WidgetType { get; set; }

        public string Title { get; set; }

        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public string Value { get; set; }
    }
}