using Newtonsoft.Json;
using PayNL.Converters;

namespace PayNL.API.SMS.PremiumMessage
{
    public class Response : ResponseBase
    {
        [JsonProperty("result"), JsonConverter(typeof(BooleanConverter))]
        public bool result { get; protected set; }
    }
}
