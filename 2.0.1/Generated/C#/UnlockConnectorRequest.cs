// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.UnlockConnectorRequest;
//
//    var unlockConnectorRequest = UnlockConnectorRequest.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.UnlockConnectorRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class UnlockConnectorRequest
    {
        /// <summary>
        /// This contains the identifier of the connector that needs to be unlocked.
        /// </summary>
        [JsonProperty("connectorId")]
        public virtual long ConnectorId { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// This contains the identifier of the EVSE for which a connector needs to be unlocked.
        /// </summary>
        [JsonProperty("evseId")]
        public virtual long EvseId { get; set; }
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

    public partial class UnlockConnectorRequest
    {
        public static UnlockConnectorRequest FromJson(string json) => JsonConvert.DeserializeObject<UnlockConnectorRequest>(json, Ocpp._201.Generated.Models.UnlockConnectorRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this UnlockConnectorRequest self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.UnlockConnectorRequest.Converter.Settings);
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