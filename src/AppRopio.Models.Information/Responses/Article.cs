using System;
using AppRopio.Models.Information.Enums;

namespace AppRopio.Models.Information.Responses
{
    public class Article
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public ArticleType Type { get; set; }
    }
}