// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.ClearChargingProfileResponse;
//
//    var clearChargingProfileResponse = ClearChargingProfileResponse.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.ClearChargingProfileResponse
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ClearChargingProfileResponse
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        [JsonProperty("status")]
        public virtual ClearChargingProfileStatusEnumType Status { get; set; }

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
    /// Indicates if the Charging Station was able to execute the request.
    /// </summary>
    public enum ClearChargingProfileStatusEnumType { Accepted, Unknown };

    public partial class ClearChargingProfileResponse
    {
        public static ClearChargingProfileResponse FromJson(string json) => JsonConvert.DeserializeObject<ClearChargingProfileResponse>(json, Ocpp._201.Generated.Models.ClearChargingProfileResponse.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ClearChargingProfileResponse self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.ClearChargingProfileResponse.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ClearChargingProfileStatusEnumTypeConverter.Singleton,
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

    internal class ClearChargingProfileStatusEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClearChargingProfileStatusEnumType) || t == typeof(ClearChargingProfileStatusEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Accepted":
                    return ClearChargingProfileStatusEnumType.Accepted;
                case "Unknown":
                    return ClearChargingProfileStatusEnumType.Unknown;
            }
            throw new Exception("Cannot unmarshal type ClearChargingProfileStatusEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ClearChargingProfileStatusEnumType)untypedValue;
            switch (value)
            {
                case ClearChargingProfileStatusEnumType.Accepted:
                    serializer.Serialize(writer, "Accepted");
                    return;
                case ClearChargingProfileStatusEnumType.Unknown:
                    serializer.Serialize(writer, "Unknown");
                    return;
            }
            throw new Exception("Cannot marshal type ClearChargingProfileStatusEnumType");
        }

        public static readonly ClearChargingProfileStatusEnumTypeConverter Singleton = new ClearChargingProfileStatusEnumTypeConverter();
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
