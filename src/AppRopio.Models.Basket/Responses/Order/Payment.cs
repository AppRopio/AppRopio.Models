using AppRopio.Models.Payments.Responses;

namespace AppRopio.Models.Basket.Responses.Order
{
    public class Payment
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool InAppPurchase { get; set; }

        public PaymentType Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:AppRopio.Models.Basket.Responses.Order.Payment"/>
        /// previously selected by user. In payments list should be only one selected payment.
        /// </summary>
        /// <value><c>true</c> if previously selected; otherwise, <c>false</c>.</value>
        public bool PreviouslySelected { get; set; }
    }
}
