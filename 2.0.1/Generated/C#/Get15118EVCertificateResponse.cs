// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.Get15118EVCertificateResponse;
//
//    var get15118EvCertificateResponse = Get15118EvCertificateResponse.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.Get15118EVCertificateResponse
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Get15118EvCertificateResponse
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Raw CertificateInstallationRes response for the EV, Base64 encoded.
        /// </summary>
        [JsonProperty("exiResponse")]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string ExiResponse { get; set; }

        [JsonProperty("status")]
        public virtual Iso15118EvCertificateStatusEnumType Status { get; set; }

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
        [JsonConverter(typeof(TentacledMinMaxLengthCheckConverter))]
        public virtual string AdditionalInfo { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// A predefined code for the reason why the status is returned in this response. The string
        /// is case-insensitive.
        /// </summary>
        [JsonProperty("reasonCode")]
        [JsonConverter(typeof(StickyMinMaxLengthCheckConverter))]
        public virtual string ReasonCode { get; set; }
    }

    /// <summary>
    /// Indicates whether the message was processed properly.
    /// </summary>
    public enum Iso15118EvCertificateStatusEnumType { Accepted, Failed };

    public partial class Get15118EvCertificateResponse
    {
        public static Get15118EvCertificateResponse FromJson(string json) => JsonConvert.DeserializeObject<Get15118EvCertificateResponse>(json, Ocpp._201.Generated.Models.Get15118EVCertificateResponse.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Get15118EvCertificateResponse self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.Get15118EVCertificateResponse.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                Iso15118EvCertificateStatusEnumTypeConverter.Singleton,
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
            if (value.Length <= 5600)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 5600)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly FluffyMinMaxLengthCheckConverter Singleton = new FluffyMinMaxLengthCheckConverter();
    }

    internal class Iso15118EvCertificateStatusEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Iso15118EvCertificateStatusEnumType) || t == typeof(Iso15118EvCertificateStatusEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Accepted":
                    return Iso15118EvCertificateStatusEnumType.Accepted;
                case "Failed":
                    return Iso15118EvCertificateStatusEnumType.Failed;
            }
            throw new Exception("Cannot unmarshal type Iso15118EvCertificateStatusEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Iso15118EvCertificateStatusEnumType)untypedValue;
            switch (value)
            {
                case Iso15118EvCertificateStatusEnumType.Accepted:
                    serializer.Serialize(writer, "Accepted");
                    return;
                case Iso15118EvCertificateStatusEnumType.Failed:
                    serializer.Serialize(writer, "Failed");
                    return;
            }
            throw new Exception("Cannot marshal type Iso15118EvCertificateStatusEnumType");
        }

        public static readonly Iso15118EvCertificateStatusEnumTypeConverter Singleton = new Iso15118EvCertificateStatusEnumTypeConverter();
    }

    internal class TentacledMinMaxLengthCheckConverter : JsonConverter
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

        public static readonly TentacledMinMaxLengthCheckConverter Singleton = new TentacledMinMaxLengthCheckConverter();
    }

    internal class StickyMinMaxLengthCheckConverter : JsonConverter
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

        public static readonly StickyMinMaxLengthCheckConverter Singleton = new StickyMinMaxLengthCheckConverter();
    }
}
