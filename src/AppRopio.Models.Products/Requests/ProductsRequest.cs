using System.Collections.Generic;
using AppRopio.Models.Filters.Responses;

namespace AppRopio.Models.Products.Requests
{
    public class ProductsRequest
    {
        public string CategoryId { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
        public string SearchText { get; set; }
        public List<ApplyedFilter> Filters { get; set; }
        public SortType SortType { get; set; }
    }
}