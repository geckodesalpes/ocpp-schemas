// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.FirmwareStatusNotificationRequest;
//
//    var firmwareStatusNotificationRequest = FirmwareStatusNotificationRequest.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.FirmwareStatusNotificationRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class FirmwareStatusNotificationRequest
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// The request id that was provided in the
        /// UpdateFirmwareRequest that started this firmware update.
        /// This field is mandatory, unless the message was triggered by a TriggerMessageRequest AND
        /// there is no firmware update ongoing.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? RequestId { get; set; }

        [JsonProperty("status")]
        public virtual FirmwareStatusEnumType Status { get; set; }
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

    /// <summary>
    /// This contains the progress status of the firmware installation.
    /// </summary>
    public enum FirmwareStatusEnumType { DownloadFailed, DownloadPaused, DownloadScheduled, Downloaded, Downloading, Idle, InstallRebooting, InstallScheduled, InstallVerificationFailed, InstallationFailed, Installed, Installing, InvalidSignature, SignatureVerified };

    public partial class FirmwareStatusNotificationRequest
    {
        public static FirmwareStatusNotificationRequest FromJson(string json) => JsonConvert.DeserializeObject<FirmwareStatusNotificationRequest>(json, Ocpp._201.Generated.Models.FirmwareStatusNotificationRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this FirmwareStatusNotificationRequest self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.FirmwareStatusNotificationRequest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                FirmwareStatusEnumTypeConverter.Singleton,
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

    internal class FirmwareStatusEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FirmwareStatusEnumType) || t == typeof(FirmwareStatusEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DownloadFailed":
                    return FirmwareStatusEnumType.DownloadFailed;
                case "DownloadPaused":
                    return FirmwareStatusEnumType.DownloadPaused;
                case "DownloadScheduled":
                    return FirmwareStatusEnumType.DownloadScheduled;
                case "Downloaded":
                    return FirmwareStatusEnumType.Downloaded;
                case "Downloading":
                    return FirmwareStatusEnumType.Downloading;
                case "Idle":
                    return FirmwareStatusEnumType.Idle;
                case "InstallRebooting":
                    return FirmwareStatusEnumType.InstallRebooting;
                case "InstallScheduled":
                    return FirmwareStatusEnumType.InstallScheduled;
                case "InstallVerificationFailed":
                    return FirmwareStatusEnumType.InstallVerificationFailed;
                case "InstallationFailed":
                    return FirmwareStatusEnumType.InstallationFailed;
                case "Installed":
                    return FirmwareStatusEnumType.Installed;
                case "Installing":
                    return FirmwareStatusEnumType.Installing;
                case "InvalidSignature":
                    return FirmwareStatusEnumType.InvalidSignature;
                case "SignatureVerified":
                    return FirmwareStatusEnumType.SignatureVerified;
            }
            throw new Exception("Cannot unmarshal type FirmwareStatusEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FirmwareStatusEnumType)untypedValue;
            switch (value)
            {
                case FirmwareStatusEnumType.DownloadFailed:
                    serializer.Serialize(writer, "DownloadFailed");
                    return;
                case FirmwareStatusEnumType.DownloadPaused:
                    serializer.Serialize(writer, "DownloadPaused");
                    return;
                case FirmwareStatusEnumType.DownloadScheduled:
                    serializer.Serialize(writer, "DownloadScheduled");
                    return;
                case FirmwareStatusEnumType.Downloaded:
                    serializer.Serialize(writer, "Downloaded");
                    return;
                case FirmwareStatusEnumType.Downloading:
                    serializer.Serialize(writer, "Downloading");
                    return;
                case FirmwareStatusEnumType.Idle:
                    serializer.Serialize(writer, "Idle");
                    return;
                case FirmwareStatusEnumType.InstallRebooting:
                    serializer.Serialize(writer, "InstallRebooting");
                    return;
                case FirmwareStatusEnumType.InstallScheduled:
                    serializer.Serialize(writer, "InstallScheduled");
                    return;
                case FirmwareStatusEnumType.InstallVerificationFailed:
                    serializer.Serialize(writer, "InstallVerificationFailed");
                    return;
                case FirmwareStatusEnumType.InstallationFailed:
                    serializer.Serialize(writer, "InstallationFailed");
                    return;
                case FirmwareStatusEnumType.Installed:
                    serializer.Serialize(writer, "Installed");
                    return;
                case FirmwareStatusEnumType.Installing:
                    serializer.Serialize(writer, "Installing");
                    return;
                case FirmwareStatusEnumType.InvalidSignature:
                    serializer.Serialize(writer, "InvalidSignature");
                    return;
                case FirmwareStatusEnumType.SignatureVerified:
                    serializer.Serialize(writer, "SignatureVerified");
                    return;
            }
            throw new Exception("Cannot marshal type FirmwareStatusEnumType");
        }

        public static readonly FirmwareStatusEnumTypeConverter Singleton = new FirmwareStatusEnumTypeConverter();
    }
}
