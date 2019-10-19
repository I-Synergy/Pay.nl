using Newtonsoft.Json;
using PayNL.Objects;

namespace PayNL.API.Transaction.Details
{
    public class Response : ResponseBase
    {
        [JsonProperty("paymentDetails")]
        public TransactionDetailsPaymentDetails PaymentDetails { get; protected set; }
    }
}
