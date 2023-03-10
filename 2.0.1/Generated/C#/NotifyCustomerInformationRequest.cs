// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.NotifyCustomerInformationRequest;
//
//    var notifyCustomerInformationRequest = NotifyCustomerInformationRequest.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.NotifyCustomerInformationRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NotifyCustomerInformationRequest
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// (Part of) the requested data. No format specified in which the data is returned. Should
        /// be human readable.
        /// </summary>
        [JsonProperty("data")]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string Data { get; set; }

        /// <summary>
        /// Timestamp of the moment this message was generated at the Charging Station.
        /// </summary>
        [JsonProperty("generatedAt")]
        public virtual DateTimeOffset GeneratedAt { get; set; }

        /// <summary>
        /// The Id of the request.
        /// </summary>
        [JsonProperty("requestId")]
        public virtual long RequestId { get; set; }

        /// <summary>
        /// Sequence number of this message. First message starts at 0.
        /// </summary>
        [JsonProperty("seqNo")]
        public virtual long SeqNo { get; set; }

        /// <summary>
        /// “to be continued” indicator. Indicates whether another part of the monitoringData follows
        /// in an upcoming notifyMonitoringReportRequest message. Default value when omitted is false.
        /// </summary>
        [JsonProperty("tbc", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? Tbc { get; set; }
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

    public partial class NotifyCustomerInformationRequest
    {
        public static NotifyCustomerInformationRequest FromJson(string json) => JsonConvert.DeserializeObject<NotifyCustomerInformationRequest>(json, Ocpp._201.Generated.Models.NotifyCustomerInformationRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this NotifyCustomerInformationRequest self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.NotifyCustomerInformationRequest.Converter.Settings);
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
}
