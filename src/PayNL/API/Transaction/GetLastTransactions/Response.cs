using Newtonsoft.Json;
using PayNL.Objects;

namespace PayNL.API.Transaction.GetLastTransactions
{
    public class Response : ResponseBase
    {
        [JsonProperty("arrStatsData")]
        public TransactionStatsList TransactionStats { get; set; }
    }
}
