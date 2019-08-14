using Newtonsoft.Json;

namespace PayNL.API.Banktransfer.Add
{
    public class Response : ResponseBase
    {
        [JsonProperty("refundId")]
        public string RefundId { get; set; }
    }
}
