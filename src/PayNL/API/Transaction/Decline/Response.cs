using Newtonsoft.Json;

namespace PayNL.API.Transaction.Decline
{
    public class Response : ResponseBase
    {
        [JsonProperty("message")]
        public string Message { get; protected set; }
    }
}
