using Newtonsoft.Json;
using PayNL.Objects;

namespace PayNL.API.Transaction.GetService
{
    public class Response : ResponseBase
    {
        [JsonProperty("merchant")]
        public Merchant Merchant { get; set; }

        [JsonProperty("service")]
        public Objects.Service Service { get; set; }

        [JsonProperty("countryOptionList")]
        public CountryOptions CountryOptions { get; set; }
    }
}
