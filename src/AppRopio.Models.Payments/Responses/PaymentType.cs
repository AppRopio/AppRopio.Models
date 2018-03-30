namespace AppRopio.Models.Payments.Responses
{
    public enum PaymentType
    {
        /// <summary>
        /// Наличные
        /// </summary>
        Cash = 0,

        /// <summary>
        /// Банковская карта
        /// </summary>
        CreditCard = 1,

        /// <summary>
        /// Через электронные деньги
        /// </summary>
        EWallet = 2,

        /// <summary>
        /// Через нативные средства оплаты (Apple Pay, Google Pay)
        /// </summary>
        Native = 3
    }
}
