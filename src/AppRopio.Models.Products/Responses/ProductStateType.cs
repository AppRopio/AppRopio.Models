namespace AppRopio.Models.Products.Responses
{
    public enum ProductStateType
    {
        Unknown = 0,
        /// <summary>
        /// Нет в наличии
        /// </summary>
        NotAvailable,
        /// <summary>
        /// На складе
        /// </summary>
        OutOfStock,
        /// <summary>
        /// В наличии
        /// </summary>
        InStock
    }
    
}