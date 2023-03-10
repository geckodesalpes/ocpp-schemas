// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.GetChargingProfilesRequest;
//
//    var getChargingProfilesRequest = GetChargingProfilesRequest.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.GetChargingProfilesRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetChargingProfilesRequest
    {
        [JsonProperty("chargingProfile")]
        public virtual ChargingProfileCriterionType ChargingProfile { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// For which EVSE installed charging profiles SHALL be reported. If 0, only charging
        /// profiles installed on the Charging Station itself (the grid connection) SHALL be
        /// reported. If omitted, all installed charging profiles SHALL be reported.
        /// </summary>
        [JsonProperty("evseId", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? EvseId { get; set; }

        /// <summary>
        /// Reference identification that is to be used by the Charging Station in the
        /// &lt;&lt;reportchargingprofilesrequest, ReportChargingProfilesRequest&gt;&gt; when
        /// provided.
        /// </summary>
        [JsonProperty("requestId")]
        public virtual long RequestId { get; set; }
    }

    /// <summary>
    /// Charging_ Profile
    /// urn:x-oca:ocpp:uid:2:233255
    /// A ChargingProfile consists of ChargingSchedule, describing the amount of power or current
    /// that can be delivered per time interval.
    /// </summary>
    public partial class ChargingProfileCriterionType
    {
        /// <summary>
        /// For which charging limit sources, charging profiles SHALL be reported. If omitted, the
        /// Charging Station SHALL not filter on chargingLimitSource.
        /// </summary>
        [JsonProperty("chargingLimitSource", NullValueHandling = NullValueHandling.Ignore)]
        public virtual System.Collections.Generic.List<ChargingLimitSourceEnumType> ChargingLimitSource { get; set; }

        /// <summary>
        /// List of all the chargingProfileIds requested. Any ChargingProfile that matches one of
        /// these profiles will be reported. If omitted, the Charging Station SHALL not filter on
        /// chargingProfileId. This field SHALL NOT contain more ids than set in
        /// &lt;&lt;configkey-charging-profile-entries,ChargingProfileEntries.maxLimit&gt;&gt;
        /// </summary>
        [JsonProperty("chargingProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public virtual System.Collections.Generic.List<long> ChargingProfileId { get; set; }

        [JsonProperty("chargingProfilePurpose", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ChargingProfilePurposeEnumType? ChargingProfilePurpose { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Charging_ Profile. Stack_ Level. Counter
        /// urn:x-oca:ocpp:uid:1:569230
        /// Value determining level in hierarchy stack of profiles. Higher values have precedence
        /// over lower values. Lowest level is 0.
        /// </summary>
        [JsonProperty("stackLevel", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? StackLevel { get; set; }
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

    public enum ChargingLimitSourceEnumType { Cso, Ems, Other, So };

    /// <summary>
    /// Charging_ Profile. Charging_ Profile_ Purpose. Charging_ Profile_ Purpose_ Code
    /// urn:x-oca:ocpp:uid:1:569231
    /// Defines the purpose of the schedule transferred by this profile
    /// </summary>
    public enum ChargingProfilePurposeEnumType { ChargingStationExternalConstraints, ChargingStationMaxProfile, TxDefaultProfile, TxProfile };

    public partial class GetChargingProfilesRequest
    {
        public static GetChargingProfilesRequest FromJson(string json) => JsonConvert.DeserializeObject<GetChargingProfilesRequest>(json, Ocpp._201.Generated.Models.GetChargingProfilesRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetChargingProfilesRequest self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.GetChargingProfilesRequest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ChargingLimitSourceEnumTypeConverter.Singleton,
                ChargingProfilePurposeEnumTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ChargingLimitSourceEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ChargingLimitSourceEnumType) || t == typeof(ChargingLimitSourceEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CSO":
                    return ChargingLimitSourceEnumType.Cso;
                case "EMS":
                    return ChargingLimitSourceEnumType.Ems;
                case "Other":
                    return ChargingLimitSourceEnumType.Other;
                case "SO":
                    return ChargingLimitSourceEnumType.So;
            }
            throw new Exception("Cannot unmarshal type ChargingLimitSourceEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ChargingLimitSourceEnumType)untypedValue;
            switch (value)
            {
                case ChargingLimitSourceEnumType.Cso:
                    serializer.Serialize(writer, "CSO");
                    return;
                case ChargingLimitSourceEnumType.Ems:
                    serializer.Serialize(writer, "EMS");
                    return;
                case ChargingLimitSourceEnumType.Other:
                    serializer.Serialize(writer, "Other");
                    return;
                case ChargingLimitSourceEnumType.So:
                    serializer.Serialize(writer, "SO");
                    return;
            }
            throw new Exception("Cannot marshal type ChargingLimitSourceEnumType");
        }

        public static readonly ChargingLimitSourceEnumTypeConverter Singleton = new ChargingLimitSourceEnumTypeConverter();
    }

    internal class ChargingProfilePurposeEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ChargingProfilePurposeEnumType) || t == typeof(ChargingProfilePurposeEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ChargingStationExternalConstraints":
                    return ChargingProfilePurposeEnumType.ChargingStationExternalConstraints;
                case "ChargingStationMaxProfile":
                    return ChargingProfilePurposeEnumType.ChargingStationMaxProfile;
                case "TxDefaultProfile":
                    return ChargingProfilePurposeEnumType.TxDefaultProfile;
                case "TxProfile":
                    return ChargingProfilePurposeEnumType.TxProfile;
            }
            throw new Exception("Cannot unmarshal type ChargingProfilePurposeEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ChargingProfilePurposeEnumType)untypedValue;
            switch (value)
            {
                case ChargingProfilePurposeEnumType.ChargingStationExternalConstraints:
                    serializer.Serialize(writer, "ChargingStationExternalConstraints");
                    return;
                case ChargingProfilePurposeEnumType.ChargingStationMaxProfile:
                    serializer.Serialize(writer, "ChargingStationMaxProfile");
                    return;
                case ChargingProfilePurposeEnumType.TxDefaultProfile:
                    serializer.Serialize(writer, "TxDefaultProfile");
                    return;
                case ChargingProfilePurposeEnumType.TxProfile:
                    serializer.Serialize(writer, "TxProfile");
                    return;
            }
            throw new Exception("Cannot marshal type ChargingProfilePurposeEnumType");
        }

        public static readonly ChargingProfilePurposeEnumTypeConverter Singleton = new ChargingProfilePurposeEnumTypeConverter();
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
