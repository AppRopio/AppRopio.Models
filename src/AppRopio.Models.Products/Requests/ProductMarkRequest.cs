using System;
namespace AppRopio.Models.Products.Requests
{
    public class ProductMarkRequest : ProductRequest
    {
        public bool? IsMarked { get; set; }
    }
}
