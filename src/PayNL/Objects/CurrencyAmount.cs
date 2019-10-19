using Newtonsoft.Json;

namespace PayNL.Objects
{
    /// <summary>
    /// "Currency Amount" - aka an amount in a certain currency
    /// </summary>
    public class CurrencyAmount
    {
        /// <summary>
        /// Amount
        /// </summary>
        [JsonProperty("value")]
        public int Amount { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
