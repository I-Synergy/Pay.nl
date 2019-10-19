using System;
using Newtonsoft.Json;
using PayNL.Utilities;

namespace PayNL.Converters
{
    public class TimestampConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is DateTime dateTime)
            {
                if (dateTime.Kind == DateTimeKind.Unspecified)
                {
                    throw new JsonSerializationException("Cannot convert date time with an unspecified kind");
                }
                if (dateTime.Kind != DateTimeKind.Utc)
                {
                    throw new JsonSerializationException("Given date time MUST be of the Utc kind");
                }
                var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                var timestamp = (long)dateTime.Subtract(epoch).TotalSeconds;
                writer.WriteValue(timestamp);
            }
            else
            {
                throw new JsonSerializationException("Expected value of type 'DateTime'.");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            if (reader.TokenType == JsonToken.Date)
            {
                var dateTime = (DateTime)reader.Value;
                if (dateTime.Kind == DateTimeKind.Unspecified)
                {
                    throw new JsonSerializationException("Parsed date time is not in the expected RFC3339 format");
                }
                return dateTime;
            }

            if (reader.TokenType == JsonToken.String)
            {
                double timestamp;
                var timeString = (string)reader.Value;
                // Try to parse the input as a double.
                try
                {
                    timestamp = Double.Parse(timeString);
                    // Format our new DateTime object to start at the UNIX Epoch
                    var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

                    // Add the timestamp (number of seconds since the Epoch) to be converted
                    return dateTime.AddSeconds(timestamp);
                }
                catch (Exception)
                {
                    return null;
                }
            }

            if (reader.TokenType == JsonToken.Integer)
            {
                var timestamp = (double)reader.Value;
                // Format our new DateTime object to start at the UNIX Epoch
                var dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

                // Add the timestamp (number of seconds since the Epoch) to be converted
                return dateTime.AddSeconds(timestamp);
            }
            if (reader.TokenType == JsonToken.Float)
            {
                var timestamp = (double)reader.Value;
                // Format our new DateTime object to start at the UNIX Epoch
                var dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

                // Add the timestamp (number of seconds since the Epoch) to be converted
                return dateTime.AddSeconds(timestamp);
            }
            throw new JsonSerializationException(String.Format("Unexpected token '{0}' when parsing date.", reader.TokenType));
        }

        public override bool CanConvert(Type objectType)
        {
            var t = (Reflection.IsNullable(objectType))
               ? Nullable.GetUnderlyingType(objectType)
               : objectType;

            return t == typeof(DateTime);
        }
    }
}
