// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.GetTransactionStatusResponse;
//
//    var getTransactionStatusResponse = GetTransactionStatusResponse.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.GetTransactionStatusResponse
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetTransactionStatusResponse
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Whether there are still message to be delivered.
        /// </summary>
        [JsonProperty("messagesInQueue")]
        public virtual bool MessagesInQueue { get; set; }

        /// <summary>
        /// Whether the transaction is still ongoing.
        /// </summary>
        [JsonProperty("ongoingIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? OngoingIndicator { get; set; }
    }

    /// <summary>
    /// This class does not get 'AdditionalProperties = false' in the schema generation, so it
    /// can be extended with arbitrary JSON properties to allow adding custom data.
    /// </summary>
    public partial class CustomDataType
    {
        [JsonProperty("vendorId")]
        [JsonConverter(typeof(MinMaxLengthCheckConverter))]
        public virtual string VendorId { get; set; }
    }

    public partial class GetTransactionStatusResponse
    {
        public static GetTransactionStatusResponse FromJson(string json) => JsonConvert.DeserializeObject<GetTransactionStatusResponse>(json, Ocpp._201.Generated.Models.GetTransactionStatusResponse.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetTransactionStatusResponse self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.GetTransactionStatusResponse.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class MinMaxLengthCheckConverter : JsonConverter
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

        public static readonly MinMaxLengthCheckConverter Singleton = new MinMaxLengthCheckConverter();
    }
}