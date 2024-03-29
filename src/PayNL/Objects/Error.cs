﻿using Newtonsoft.Json;
using PayNL.Converters;

namespace PayNL.Objects
{
    /// <summary>
    /// Error definition
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Result of a call. In case of a real error, this SHOULD always be false.
        /// </summary>
        [JsonProperty("result"), JsonConverter(typeof(BooleanConverter))]
        public bool Result { get; protected set; }

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty("errorId")]
        public string Code { get; protected set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("errorMessage")]
        public string Message { get; protected set; }
    }
}
