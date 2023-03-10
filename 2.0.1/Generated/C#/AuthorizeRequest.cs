// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.AuthorizeRequest;
//
//    var authorizeRequest = AuthorizeRequest.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.AuthorizeRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AuthorizeRequest
    {
        /// <summary>
        /// The X.509 certificated presented by EV and encoded in PEM format.
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleMinMaxLengthCheckConverter))]
        public virtual string Certificate { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        [JsonProperty("idToken")]
        public virtual IdTokenType IdToken { get; set; }

        [JsonProperty("iso15118CertificateHashData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual System.Collections.Generic.List<OcspRequestDataType> Iso15118CertificateHashData { get; set; }
    }

    /// <summary>
    /// This class does not get 'AdditionalProperties = false' in the schema generation, so it
    /// can be extended with arbitrary JSON properties to allow adding custom data.
    /// </summary>
    public partial class CustomDataType
    {
        [JsonProperty("vendorId")]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string VendorId { get; set; }
    }

    /// <summary>
    /// Contains a case insensitive identifier to use for the authorization and the type of
    /// authorization to support multiple forms of identifiers.
    /// </summary>
    public partial class IdTokenType
    {
        [JsonProperty("additionalInfo", NullValueHandling = NullValueHandling.Ignore)]
        public virtual System.Collections.Generic.List<AdditionalInfoType> AdditionalInfo { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// IdToken is case insensitive. Might hold the hidden id of an RFID tag, but can for example
        /// also contain a UUID.
        /// </summary>
        [JsonProperty("idToken")]
        [JsonConverter(typeof(TentacledMinMaxLengthCheckConverter))]
        public virtual string IdToken { get; set; }

        [JsonProperty("type")]
        public virtual IdTokenEnumType Type { get; set; }
    }

    /// <summary>
    /// Contains a case insensitive identifier to use for the authorization and the type of
    /// authorization to support multiple forms of identifiers.
    /// </summary>
    public partial class AdditionalInfoType
    {
        /// <summary>
        /// This field specifies the additional IdToken.
        /// </summary>
        [JsonProperty("additionalIdToken")]
        [JsonConverter(typeof(TentacledMinMaxLengthCheckConverter))]
        public virtual string AdditionalIdToken { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// This defines the type of the additionalIdToken. This is a custom type, so the
        /// implementation needs to be agreed upon by all involved parties.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StickyMinMaxLengthCheckConverter))]
        public virtual string Type { get; set; }
    }

    public partial class OcspRequestDataType
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        [JsonProperty("hashAlgorithm")]
        public virtual HashAlgorithmEnumType HashAlgorithm { get; set; }

        /// <summary>
        /// Hashed value of the issuers public key
        /// </summary>
        [JsonProperty("issuerKeyHash")]
        [JsonConverter(typeof(IndigoMinMaxLengthCheckConverter))]
        public virtual string IssuerKeyHash { get; set; }

        /// <summary>
        /// Hashed value of the Issuer DN (Distinguished Name).
        /// </summary>
        [JsonProperty("issuerNameHash")]
        [JsonConverter(typeof(IndigoMinMaxLengthCheckConverter))]
        public virtual string IssuerNameHash { get; set; }

        /// <summary>
        /// This contains the responder URL (Case insensitive).
        /// </summary>
        [JsonProperty("responderURL")]
        [JsonConverter(typeof(IndecentMinMaxLengthCheckConverter))]
        public virtual string ResponderUrl { get; set; }

        /// <summary>
        /// The serial number of the certificate.
        /// </summary>
        [JsonProperty("serialNumber")]
        [JsonConverter(typeof(HilariousMinMaxLengthCheckConverter))]
        public virtual string SerialNumber { get; set; }
    }

    /// <summary>
    /// Enumeration of possible idToken types.
    /// </summary>
    public enum IdTokenEnumType { Central, EMaid, Iso14443, Iso15693, KeyCode, Local, MacAddress, NoAuthorization };

    /// <summary>
    /// Used algorithms for the hashes provided.
    /// </summary>
    public enum HashAlgorithmEnumType { Sha256, Sha384, Sha512 };

    public partial class AuthorizeRequest
    {
        public static AuthorizeRequest FromJson(string json) => JsonConvert.DeserializeObject<AuthorizeRequest>(json, Ocpp._201.Generated.Models.AuthorizeRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AuthorizeRequest self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.AuthorizeRequest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                IdTokenEnumTypeConverter.Singleton,
                HashAlgorithmEnumTypeConverter.Singleton,
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

        public static readonly PurpleMinMaxLengthCheckConverter Singleton = new PurpleMinMaxLengthCheckConverter();
    }

    internal class FluffyMinMaxLengthCheckConverter : JsonConverter
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

        public static readonly FluffyMinMaxLengthCheckConverter Singleton = new FluffyMinMaxLengthCheckConverter();
    }

    internal class TentacledMinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length <= 36)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 36)
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
            if (value.Length <= 50)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 50)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly StickyMinMaxLengthCheckConverter Singleton = new StickyMinMaxLengthCheckConverter();
    }

    internal class IdTokenEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IdTokenEnumType) || t == typeof(IdTokenEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Central":
                    return IdTokenEnumType.Central;
                case "ISO14443":
                    return IdTokenEnumType.Iso14443;
                case "ISO15693":
                    return IdTokenEnumType.Iso15693;
                case "KeyCode":
                    return IdTokenEnumType.KeyCode;
                case "Local":
                    return IdTokenEnumType.Local;
                case "MacAddress":
                    return IdTokenEnumType.MacAddress;
                case "NoAuthorization":
                    return IdTokenEnumType.NoAuthorization;
                case "eMAID":
                    return IdTokenEnumType.EMaid;
            }
            throw new Exception("Cannot unmarshal type IdTokenEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (IdTokenEnumType)untypedValue;
            switch (value)
            {
                case IdTokenEnumType.Central:
                    serializer.Serialize(writer, "Central");
                    return;
                case IdTokenEnumType.Iso14443:
                    serializer.Serialize(writer, "ISO14443");
                    return;
                case IdTokenEnumType.Iso15693:
                    serializer.Serialize(writer, "ISO15693");
                    return;
                case IdTokenEnumType.KeyCode:
                    serializer.Serialize(writer, "KeyCode");
                    return;
                case IdTokenEnumType.Local:
                    serializer.Serialize(writer, "Local");
                    return;
                case IdTokenEnumType.MacAddress:
                    serializer.Serialize(writer, "MacAddress");
                    return;
                case IdTokenEnumType.NoAuthorization:
                    serializer.Serialize(writer, "NoAuthorization");
                    return;
                case IdTokenEnumType.EMaid:
                    serializer.Serialize(writer, "eMAID");
                    return;
            }
            throw new Exception("Cannot marshal type IdTokenEnumType");
        }

        public static readonly IdTokenEnumTypeConverter Singleton = new IdTokenEnumTypeConverter();
    }

    internal class HashAlgorithmEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HashAlgorithmEnumType) || t == typeof(HashAlgorithmEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "SHA256":
                    return HashAlgorithmEnumType.Sha256;
                case "SHA384":
                    return HashAlgorithmEnumType.Sha384;
                case "SHA512":
                    return HashAlgorithmEnumType.Sha512;
            }
            throw new Exception("Cannot unmarshal type HashAlgorithmEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HashAlgorithmEnumType)untypedValue;
            switch (value)
            {
                case HashAlgorithmEnumType.Sha256:
                    serializer.Serialize(writer, "SHA256");
                    return;
                case HashAlgorithmEnumType.Sha384:
                    serializer.Serialize(writer, "SHA384");
                    return;
                case HashAlgorithmEnumType.Sha512:
                    serializer.Serialize(writer, "SHA512");
                    return;
            }
            throw new Exception("Cannot marshal type HashAlgorithmEnumType");
        }

        public static readonly HashAlgorithmEnumTypeConverter Singleton = new HashAlgorithmEnumTypeConverter();
    }

    internal class IndigoMinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length <= 128)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 128)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly IndigoMinMaxLengthCheckConverter Singleton = new IndigoMinMaxLengthCheckConverter();
    }

    internal class IndecentMinMaxLengthCheckConverter : JsonConverter
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

        public static readonly IndecentMinMaxLengthCheckConverter Singleton = new IndecentMinMaxLengthCheckConverter();
    }

    internal class HilariousMinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length <= 40)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 40)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly HilariousMinMaxLengthCheckConverter Singleton = new HilariousMinMaxLengthCheckConverter();
    }
}
