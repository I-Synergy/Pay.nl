using Newtonsoft.Json;
using PayNL.Objects;

namespace PayNL.API.Transaction.Start
{
    public class Response : ResponseBase
    {
        [JsonProperty("enduser")]
        public TransactionStartEnduser Enduser { get; set; }

        [JsonProperty("transaction")]
        public TransactionStartInfo Transaction { get; set; }
    }
}
