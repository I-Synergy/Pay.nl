using Newtonsoft.Json;
using PayNL.Objects;

namespace PayNL.API.Refund.Info
{
    public class Response : ResponseBase
    {
        /// <summary>
        /// Refund information
        /// </summary>
        [JsonProperty("refund")]
        public RefundInfo Refund { get; protected set; }
    }
}
