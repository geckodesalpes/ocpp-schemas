// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.GetMonitoringReportRequest;
//
//    var getMonitoringReportRequest = GetMonitoringReportRequest.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.GetMonitoringReportRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetMonitoringReportRequest
    {
        [JsonProperty("componentVariable", NullValueHandling = NullValueHandling.Ignore)]
        public virtual System.Collections.Generic.List<ComponentVariableType> ComponentVariable { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// This field contains criteria for components for which a monitoring report is requested
        /// </summary>
        [JsonProperty("monitoringCriteria", NullValueHandling = NullValueHandling.Ignore)]
        public virtual System.Collections.Generic.List<MonitoringCriterionEnumType> MonitoringCriteria { get; set; }

        /// <summary>
        /// The Id of the request.
        /// </summary>
        [JsonProperty("requestId")]
        public virtual long RequestId { get; set; }
    }

    /// <summary>
    /// Class to report components, variables and variable attributes and characteristics.
    /// </summary>
    public partial class ComponentVariableType
    {
        [JsonProperty("component")]
        public virtual ComponentType Component { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        [JsonProperty("variable", NullValueHandling = NullValueHandling.Ignore)]
        public virtual VariableType Variable { get; set; }
    }

    /// <summary>
    /// A physical or logical component
    /// </summary>
    public partial class ComponentType
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        [JsonProperty("evse", NullValueHandling = NullValueHandling.Ignore)]
        public virtual EvseType Evse { get; set; }

        /// <summary>
        /// Name of instance in case the component exists as multiple instances. Case Insensitive.
        /// strongly advised to use Camel Case.
        /// </summary>
        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string Instance { get; set; }

        /// <summary>
        /// Name of the component. Name should be taken from the list of standardized component names
        /// whenever possible. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        [JsonProperty("name")]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string Name { get; set; }
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
    /// EVSE
    /// urn:x-oca:ocpp:uid:2:233123
    /// Electric Vehicle Supply Equipment
    /// </summary>
    public partial class EvseType
    {
        /// <summary>
        /// An id to designate a specific connector (on an EVSE) by connector index number.
        /// </summary>
        [JsonProperty("connectorId", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? ConnectorId { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// EVSE Identifier. This contains a number (&gt; 0) designating an EVSE of the Charging
        /// Station.
        /// </summary>
        [JsonProperty("id")]
        public virtual long Id { get; set; }
    }

    /// <summary>
    /// Reference key to a component-variable.
    /// </summary>
    public partial class VariableType
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Name of instance in case the variable exists as multiple instances. Case Insensitive.
        /// strongly advised to use Camel Case.
        /// </summary>
        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string Instance { get; set; }

        /// <summary>
        /// Name of the variable. Name should be taken from the list of standardized variable names
        /// whenever possible. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        [JsonProperty("name")]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string Name { get; set; }
    }

    public enum MonitoringCriterionEnumType { DeltaMonitoring, PeriodicMonitoring, ThresholdMonitoring };

    public partial class GetMonitoringReportRequest
    {
        public static GetMonitoringReportRequest FromJson(string json) => JsonConvert.DeserializeObject<GetMonitoringReportRequest>(json, Ocpp._201.Generated.Models.GetMonitoringReportRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetMonitoringReportRequest self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.GetMonitoringReportRequest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                MonitoringCriterionEnumTypeConverter.Singleton,
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

        public static readonly FluffyMinMaxLengthCheckConverter Singleton = new FluffyMinMaxLengthCheckConverter();
    }

    internal class MonitoringCriterionEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MonitoringCriterionEnumType) || t == typeof(MonitoringCriterionEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DeltaMonitoring":
                    return MonitoringCriterionEnumType.DeltaMonitoring;
                case "PeriodicMonitoring":
                    return MonitoringCriterionEnumType.PeriodicMonitoring;
                case "ThresholdMonitoring":
                    return MonitoringCriterionEnumType.ThresholdMonitoring;
            }
            throw new Exception("Cannot unmarshal type MonitoringCriterionEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MonitoringCriterionEnumType)untypedValue;
            switch (value)
            {
                case MonitoringCriterionEnumType.DeltaMonitoring:
                    serializer.Serialize(writer, "DeltaMonitoring");
                    return;
                case MonitoringCriterionEnumType.PeriodicMonitoring:
                    serializer.Serialize(writer, "PeriodicMonitoring");
                    return;
                case MonitoringCriterionEnumType.ThresholdMonitoring:
                    serializer.Serialize(writer, "ThresholdMonitoring");
                    return;
            }
            throw new Exception("Cannot marshal type MonitoringCriterionEnumType");
        }

        public static readonly MonitoringCriterionEnumTypeConverter Singleton = new MonitoringCriterionEnumTypeConverter();
    }
}
