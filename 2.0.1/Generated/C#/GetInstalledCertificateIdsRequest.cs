// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.GetInstalledCertificateIdsRequest;
//
//    var getInstalledCertificateIdsRequest = GetInstalledCertificateIdsRequest.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.GetInstalledCertificateIdsRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetInstalledCertificateIdsRequest
    {
        /// <summary>
        /// Indicates the type of certificates requested. When omitted, all certificate types are
        /// requested.
        /// </summary>
        [JsonProperty("certificateType", NullValueHandling = NullValueHandling.Ignore)]
        public virtual System.Collections.Generic.List<GetCertificateIdUseEnumType> CertificateType { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }
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

    public enum GetCertificateIdUseEnumType { CsmsRootCertificate, ManufacturerRootCertificate, MoRootCertificate, V2GCertificateChain, V2GRootCertificate };

    public partial class GetInstalledCertificateIdsRequest
    {
        public static GetInstalledCertificateIdsRequest FromJson(string json) => JsonConvert.DeserializeObject<GetInstalledCertificateIdsRequest>(json, Ocpp._201.Generated.Models.GetInstalledCertificateIdsRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetInstalledCertificateIdsRequest self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.GetInstalledCertificateIdsRequest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                GetCertificateIdUseEnumTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class GetCertificateIdUseEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GetCertificateIdUseEnumType) || t == typeof(GetCertificateIdUseEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CSMSRootCertificate":
                    return GetCertificateIdUseEnumType.CsmsRootCertificate;
                case "MORootCertificate":
                    return GetCertificateIdUseEnumType.MoRootCertificate;
                case "ManufacturerRootCertificate":
                    return GetCertificateIdUseEnumType.ManufacturerRootCertificate;
                case "V2GCertificateChain":
                    return GetCertificateIdUseEnumType.V2GCertificateChain;
                case "V2GRootCertificate":
                    return GetCertificateIdUseEnumType.V2GRootCertificate;
            }
            throw new Exception("Cannot unmarshal type GetCertificateIdUseEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GetCertificateIdUseEnumType)untypedValue;
            switch (value)
            {
                case GetCertificateIdUseEnumType.CsmsRootCertificate:
                    serializer.Serialize(writer, "CSMSRootCertificate");
                    return;
                case GetCertificateIdUseEnumType.MoRootCertificate:
                    serializer.Serialize(writer, "MORootCertificate");
                    return;
                case GetCertificateIdUseEnumType.ManufacturerRootCertificate:
                    serializer.Serialize(writer, "ManufacturerRootCertificate");
                    return;
                case GetCertificateIdUseEnumType.V2GCertificateChain:
                    serializer.Serialize(writer, "V2GCertificateChain");
                    return;
                case GetCertificateIdUseEnumType.V2GRootCertificate:
                    serializer.Serialize(writer, "V2GRootCertificate");
                    return;
            }
            throw new Exception("Cannot marshal type GetCertificateIdUseEnumType");
        }

        public static readonly GetCertificateIdUseEnumTypeConverter Singleton = new GetCertificateIdUseEnumTypeConverter();
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
