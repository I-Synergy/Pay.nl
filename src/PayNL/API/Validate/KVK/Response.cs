﻿using Newtonsoft.Json;
using PayNL.Converters;

namespace PayNL.API.Validate.KVK
{
    public class Response : ResponseBase
    {
        [JsonProperty("result"), JsonConverter(typeof(BooleanConverter))]
        public bool result { get; protected set; }
    }
}
