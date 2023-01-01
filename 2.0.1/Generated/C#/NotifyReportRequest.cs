// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.NotifyReportRequest;
//
//    var notifyReportRequest = NotifyReportRequest.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.NotifyReportRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NotifyReportRequest
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Timestamp of the moment this message was generated at the Charging Station.
        /// </summary>
        [JsonProperty("generatedAt")]
        public virtual DateTimeOffset GeneratedAt { get; set; }

        [JsonProperty("reportData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual System.Collections.Generic.List<ReportDataType> ReportData { get; set; }

        /// <summary>
        /// The id of the GetReportRequest  or GetBaseReportRequest that requested this report
        /// </summary>
        [JsonProperty("requestId")]
        public virtual long RequestId { get; set; }

        /// <summary>
        /// Sequence number of this message. First message starts at 0.
        /// </summary>
        [JsonProperty("seqNo")]
        public virtual long SeqNo { get; set; }

        /// <summary>
        /// “to be continued” indicator. Indicates whether another part of the report follows in an
        /// upcoming notifyReportRequest message. Default value when omitted is false.
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

    /// <summary>
    /// Class to report components, variables and variable attributes and characteristics.
    /// </summary>
    public partial class ReportDataType
    {
        [JsonProperty("component")]
        public virtual ComponentType Component { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        [JsonProperty("variable")]
        public virtual VariableType Variable { get; set; }

        [JsonProperty("variableAttribute")]
        public virtual System.Collections.Generic.List<VariableAttributeType> VariableAttribute { get; set; }

        [JsonProperty("variableCharacteristics", NullValueHandling = NullValueHandling.Ignore)]
        public virtual VariableCharacteristicsType VariableCharacteristics { get; set; }
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

    /// <summary>
    /// Attribute data of a variable.
    /// </summary>
    public partial class VariableAttributeType
    {
        /// <summary>
        /// If true, value that will never be changed by the Charging Station at runtime. Default
        /// when omitted is false.
        /// </summary>
        [JsonProperty("constant", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? Constant { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        [JsonProperty("mutability", NullValueHandling = NullValueHandling.Ignore)]
        public virtual MutabilityEnumType? Mutability { get; set; }

        /// <summary>
        /// If true, value will be persistent across system reboots or power down. Default when
        /// omitted is false.
        /// </summary>
        [JsonProperty("persistent", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? Persistent { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public virtual AttributeEnumType? Type { get; set; }

        /// <summary>
        /// Value of the attribute. May only be omitted when mutability is set to 'WriteOnly'.
        ///
        /// The Configuration Variable
        /// &lt;&lt;configkey-reporting-value-size,ReportingValueSize&gt;&gt; can be used to limit
        /// GetVariableResult.attributeValue, VariableAttribute.value and EventData.actualValue. The
        /// max size of these values will always remain equal.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(TentacledMinMaxLengthCheckConverter))]
        public virtual string Value { get; set; }
    }

    /// <summary>
    /// Fixed read-only parameters of a variable.
    /// </summary>
    public partial class VariableCharacteristicsType
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        [JsonProperty("dataType")]
        public virtual DataEnumType DataType { get; set; }

        /// <summary>
        /// Maximum possible value of this variable. When the datatype of this Variable is String,
        /// OptionList, SequenceList or MemberList, this field defines the maximum length of the
        /// (CSV) string.
        /// </summary>
        [JsonProperty("maxLimit", NullValueHandling = NullValueHandling.Ignore)]
        public virtual double? MaxLimit { get; set; }

        /// <summary>
        /// Minimum possible value of this variable.
        /// </summary>
        [JsonProperty("minLimit", NullValueHandling = NullValueHandling.Ignore)]
        public virtual double? MinLimit { get; set; }

        /// <summary>
        /// Flag indicating if this variable supports monitoring.
        /// </summary>
        [JsonProperty("supportsMonitoring")]
        public virtual bool SupportsMonitoring { get; set; }

        /// <summary>
        /// Unit of the variable. When the transmitted value has a unit, this field SHALL be included.
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StickyMinMaxLengthCheckConverter))]
        public virtual string Unit { get; set; }

        /// <summary>
        /// Allowed values when variable is Option/Member/SequenceList.
        ///
        /// * OptionList: The (Actual) Variable value must be a single value from the reported (CSV)
        /// enumeration list.
        ///
        /// * MemberList: The (Actual) Variable value  may be an (unordered) (sub-)set of the
        /// reported (CSV) valid values list.
        ///
        /// * SequenceList: The (Actual) Variable value  may be an ordered (priority, etc)  (sub-)set
        /// of the reported (CSV) valid values.
        ///
        /// This is a comma separated list.
        ///
        /// The Configuration Variable
        /// &lt;&lt;configkey-configuration-value-size,ConfigurationValueSize&gt;&gt; can be used to
        /// limit SetVariableData.attributeValue and VariableCharacteristics.valueList. The max size
        /// of these values will always remain equal.
        /// </summary>
        [JsonProperty("valuesList", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(IndigoMinMaxLengthCheckConverter))]
        public virtual string ValuesList { get; set; }
    }

    /// <summary>
    /// Defines the mutability of this attribute. Default is ReadWrite when omitted.
    /// </summary>
    public enum MutabilityEnumType { ReadOnly, ReadWrite, WriteOnly };

    /// <summary>
    /// Attribute: Actual, MinSet, MaxSet, etc.
    /// Defaults to Actual if absent.
    /// </summary>
    public enum AttributeEnumType { Actual, MaxSet, MinSet, Target };

    /// <summary>
    /// Data type of this variable.
    /// </summary>
    public enum DataEnumType { Boolean, DateTime, Decimal, Integer, MemberList, OptionList, SequenceList, String };

    public partial class NotifyReportRequest
    {
        public static NotifyReportRequest FromJson(string json) => JsonConvert.DeserializeObject<NotifyReportRequest>(json, Ocpp._201.Generated.Models.NotifyReportRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this NotifyReportRequest self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.NotifyReportRequest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                MutabilityEnumTypeConverter.Singleton,
                AttributeEnumTypeConverter.Singleton,
                DataEnumTypeConverter.Singleton,
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

    internal class MutabilityEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MutabilityEnumType) || t == typeof(MutabilityEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ReadOnly":
                    return MutabilityEnumType.ReadOnly;
                case "ReadWrite":
                    return MutabilityEnumType.ReadWrite;
                case "WriteOnly":
                    return MutabilityEnumType.WriteOnly;
            }
            throw new Exception("Cannot unmarshal type MutabilityEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MutabilityEnumType)untypedValue;
            switch (value)
            {
                case MutabilityEnumType.ReadOnly:
                    serializer.Serialize(writer, "ReadOnly");
                    return;
                case MutabilityEnumType.ReadWrite:
                    serializer.Serialize(writer, "ReadWrite");
                    return;
                case MutabilityEnumType.WriteOnly:
                    serializer.Serialize(writer, "WriteOnly");
                    return;
            }
            throw new Exception("Cannot marshal type MutabilityEnumType");
        }

        public static readonly MutabilityEnumTypeConverter Singleton = new MutabilityEnumTypeConverter();
    }

    internal class AttributeEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AttributeEnumType) || t == typeof(AttributeEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Actual":
                    return AttributeEnumType.Actual;
                case "MaxSet":
                    return AttributeEnumType.MaxSet;
                case "MinSet":
                    return AttributeEnumType.MinSet;
                case "Target":
                    return AttributeEnumType.Target;
            }
            throw new Exception("Cannot unmarshal type AttributeEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AttributeEnumType)untypedValue;
            switch (value)
            {
                case AttributeEnumType.Actual:
                    serializer.Serialize(writer, "Actual");
                    return;
                case AttributeEnumType.MaxSet:
                    serializer.Serialize(writer, "MaxSet");
                    return;
                case AttributeEnumType.MinSet:
                    serializer.Serialize(writer, "MinSet");
                    return;
                case AttributeEnumType.Target:
                    serializer.Serialize(writer, "Target");
                    return;
            }
            throw new Exception("Cannot marshal type AttributeEnumType");
        }

        public static readonly AttributeEnumTypeConverter Singleton = new AttributeEnumTypeConverter();
    }

    internal class TentacledMinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length <= 2500)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 2500)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly TentacledMinMaxLengthCheckConverter Singleton = new TentacledMinMaxLengthCheckConverter();
    }

    internal class DataEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DataEnumType) || t == typeof(DataEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "MemberList":
                    return DataEnumType.MemberList;
                case "OptionList":
                    return DataEnumType.OptionList;
                case "SequenceList":
                    return DataEnumType.SequenceList;
                case "boolean":
                    return DataEnumType.Boolean;
                case "dateTime":
                    return DataEnumType.DateTime;
                case "decimal":
                    return DataEnumType.Decimal;
                case "integer":
                    return DataEnumType.Integer;
                case "string":
                    return DataEnumType.String;
            }
            throw new Exception("Cannot unmarshal type DataEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DataEnumType)untypedValue;
            switch (value)
            {
                case DataEnumType.MemberList:
                    serializer.Serialize(writer, "MemberList");
                    return;
                case DataEnumType.OptionList:
                    serializer.Serialize(writer, "OptionList");
                    return;
                case DataEnumType.SequenceList:
                    serializer.Serialize(writer, "SequenceList");
                    return;
                case DataEnumType.Boolean:
                    serializer.Serialize(writer, "boolean");
                    return;
                case DataEnumType.DateTime:
                    serializer.Serialize(writer, "dateTime");
                    return;
                case DataEnumType.Decimal:
                    serializer.Serialize(writer, "decimal");
                    return;
                case DataEnumType.Integer:
                    serializer.Serialize(writer, "integer");
                    return;
                case DataEnumType.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type DataEnumType");
        }

        public static readonly DataEnumTypeConverter Singleton = new DataEnumTypeConverter();
    }

    internal class StickyMinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length <= 16)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 16)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly StickyMinMaxLengthCheckConverter Singleton = new StickyMinMaxLengthCheckConverter();
    }

    internal class IndigoMinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length <= 1000)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 1000)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly IndigoMinMaxLengthCheckConverter Singleton = new IndigoMinMaxLengthCheckConverter();
    }
}
