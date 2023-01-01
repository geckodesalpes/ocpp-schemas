// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.RequestStopTransactionResponse;
//
//    var requestStopTransactionResponse = RequestStopTransactionResponse.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.RequestStopTransactionResponse
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RequestStopTransactionResponse
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        [JsonProperty("status")]
        public virtual RequestStartStopStatusEnumType Status { get; set; }

        [JsonProperty("statusInfo", NullValueHandling = NullValueHandling.Ignore)]
        public virtual StatusInfoType StatusInfo { get; set; }
    }

    /// <summary>
    /// This class does not get 'AdditionalProperties = false' in the schema generation, so it
    /// can be extended with arbitrary JSON properties to allow adding custom data.
    /// </summary>
    public partial class CustomDataType
    {
        [JsonProperty("vendorId")]
        [JsonConverter(typeof(PurpleMinMaxLengthCheckConverter))]
        public virtual string VendorId { get; set; }
    }

    /// <summary>
    /// Element providing more information about the status.
    /// </summary>
    public partial class StatusInfoType
    {
        /// <summary>
        /// Additional text to provide detailed information.
        /// </summary>
        [JsonProperty("additionalInfo", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string AdditionalInfo { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// A predefined code for the reason why the status is returned in this response. The string
        /// is case-insensitive.
        /// </summary>
        [JsonProperty("reasonCode")]
        [JsonConverter(typeof(TentacledMinMaxLengthCheckConverter))]
        public virtual string ReasonCode { get; set; }
    }

    /// <summary>
    /// Status indicating whether Charging Station accepts the request to stop a transaction.
    /// </summary>
    public enum RequestStartStopStatusEnumType { Accepted, Rejected };

    public partial class RequestStopTransactionResponse
    {
        public static RequestStopTransactionResponse FromJson(string json) => JsonConvert.DeserializeObject<RequestStopTransactionResponse>(json, Ocpp._201.Generated.Models.RequestStopTransactionResponse.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RequestStopTransactionResponse self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.RequestStopTransactionResponse.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                RequestStartStopStatusEnumTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PurpleMinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length <= 255)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 255)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly PurpleMinMaxLengthCheckConverter Singleton = new PurpleMinMaxLengthCheckConverter();
    }

    internal class RequestStartStopStatusEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RequestStartStopStatusEnumType) || t == typeof(RequestStartStopStatusEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Accepted":
                    return RequestStartStopStatusEnumType.Accepted;
                case "Rejected":
                    return RequestStartStopStatusEnumType.Rejected;
            }
            throw new Exception("Cannot unmarshal type RequestStartStopStatusEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RequestStartStopStatusEnumType)untypedValue;
            switch (value)
            {
                case RequestStartStopStatusEnumType.Accepted:
                    serializer.Serialize(writer, "Accepted");
                    return;
                case RequestStartStopStatusEnumType.Rejected:
                    serializer.Serialize(writer, "Rejected");
                    return;
            }
            throw new Exception("Cannot marshal type RequestStartStopStatusEnumType");
        }

        public static readonly RequestStartStopStatusEnumTypeConverter Singleton = new RequestStartStopStatusEnumTypeConverter();
    }

    internal class FluffyMinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length <= 512)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 512)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly FluffyMinMaxLengthCheckConverter Singleton = new FluffyMinMaxLengthCheckConverter();
    }

    internal class TentacledMinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length <= 20)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 20)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly TentacledMinMaxLengthCheckConverter Singleton = new TentacledMinMaxLengthCheckConverter();
    }
}
