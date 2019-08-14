using Newtonsoft.Json;
using PayNL.Enums;

namespace PayNL.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public class TransactionStartEnduser
    {
        /// <summary>
        /// Indidicator whether or not the cusomer is blacklisted
        /// </summary>
        [JsonProperty("blacklist")]
        public Blacklist Blacklist {get; protected set;}
    }
}
