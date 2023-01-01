// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.GetCertificateStatusResponse;
//
//    var getCertificateStatusResponse = GetCertificateStatusResponse.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.GetCertificateStatusResponse
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetCertificateStatusResponse
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// OCSPResponse class as defined in &lt;&lt;ref-ocpp_security_24, IETF RFC 6960&gt;&gt;. DER
        /// encoded (as defined in &lt;&lt;ref-ocpp_security_24, IETF RFC 6960&gt;&gt;), and then
        /// base64 encoded. MAY only be omitted when status is not Accepted.
        /// </summary>
        [JsonProperty("ocspResult", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string OcspResult { get; set; }

        [JsonProperty("status")]
        public virtual GetCertificateStatusEnumType Status { get; set; }

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
    /// This indicates whether the charging station was able to retrieve the OCSP certificate
    /// status.
    /// </summary>
    public enum GetCertificateStatusEnumType { Accepted, Failed };

    public partial class GetCertificateStatusResponse
    {
        public static GetCertificateStatusResponse FromJson(string json) => JsonConvert.DeserializeObject<GetCertificateStatusResponse>(json, Ocpp._201.Generated.Models.GetCertificateStatusResponse.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetCertificateStatusResponse self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.GetCertificateStatusResponse.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                GetCertificateStatusEnumTypeConverter.Singleton,
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
            if (value.Length <= 5500)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 5500)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly FluffyMinMaxLengthCheckConverter Singleton = new FluffyMinMaxLengthCheckConverter();
    }

    internal class GetCertificateStatusEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GetCertificateStatusEnumType) || t == typeof(GetCertificateStatusEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Accepted":
                    return GetCertificateStatusEnumType.Accepted;
                case "Failed":
                    return GetCertificateStatusEnumType.Failed;
            }
            throw new Exception("Cannot unmarshal type GetCertificateStatusEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GetCertificateStatusEnumType)untypedValue;
            switch (value)
            {
                case GetCertificateStatusEnumType.Accepted:
                    serializer.Serialize(writer, "Accepted");
                    return;
                case GetCertificateStatusEnumType.Failed:
                    serializer.Serialize(writer, "Failed");
                    return;
            }
            throw new Exception("Cannot marshal type GetCertificateStatusEnumType");
        }

        public static readonly GetCertificateStatusEnumTypeConverter Singleton = new GetCertificateStatusEnumTypeConverter();
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