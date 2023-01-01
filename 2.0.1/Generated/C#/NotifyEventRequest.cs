// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.NotifyEventRequest;
//
//    var notifyEventRequest = NotifyEventRequest.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.NotifyEventRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NotifyEventRequest
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        [JsonProperty("eventData")]
        public virtual System.Collections.Generic.List<EventDataType> EventData { get; set; }

        /// <summary>
        /// Timestamp of the moment this message was generated at the Charging Station.
        /// </summary>
        [JsonProperty("generatedAt")]
        public virtual DateTimeOffset GeneratedAt { get; set; }

        /// <summary>
        /// Sequence number of this message. First message starts at 0.
        /// </summary>
        [JsonProperty("seqNo")]
        public virtual long SeqNo { get; set; }

        /// <summary>
        /// “to be continued” indicator. Indicates whether another part of the report follows in an
        /// upcoming notifyEventRequest message. Default value when omitted is false.
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
    /// Class to report an event notification for a component-variable.
    /// </summary>
    public partial class EventDataType
    {
        /// <summary>
        /// Actual value (_attributeType_ Actual) of the variable.
        ///
        /// The Configuration Variable
        /// &lt;&lt;configkey-reporting-value-size,ReportingValueSize&gt;&gt; can be used to limit
        /// GetVariableResult.attributeValue, VariableAttribute.value and EventData.actualValue. The
        /// max size of these values will always remain equal.
        /// </summary>
        [JsonProperty("actualValue")]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string ActualValue { get; set; }

        /// <summary>
        /// Refers to the Id of an event that is considered to be the cause for this event.
        /// </summary>
        [JsonProperty("cause", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? Cause { get; set; }

        /// <summary>
        /// _Cleared_ is set to true to report the clearing of a monitored situation, i.e. a 'return
        /// to normal'.
        /// </summary>
        [JsonProperty("cleared", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? Cleared { get; set; }

        [JsonProperty("component")]
        public virtual ComponentType Component { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Identifies the event. This field can be referred to as a cause by other events.
        /// </summary>
        [JsonProperty("eventId")]
        public virtual long EventId { get; set; }

        [JsonProperty("eventNotificationType")]
        public virtual EventNotificationEnumType EventNotificationType { get; set; }

        /// <summary>
        /// Technical (error) code as reported by component.
        /// </summary>
        [JsonProperty("techCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(TentacledMinMaxLengthCheckConverter))]
        public virtual string TechCode { get; set; }

        /// <summary>
        /// Technical detail information as reported by component.
        /// </summary>
        [JsonProperty("techInfo", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StickyMinMaxLengthCheckConverter))]
        public virtual string TechInfo { get; set; }

        /// <summary>
        /// Timestamp of the moment the report was generated.
        /// </summary>
        [JsonProperty("timestamp")]
        public virtual DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// If an event notification is linked to a specific transaction, this field can be used to
        /// specify its transactionId.
        /// </summary>
        [JsonProperty("transactionId", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(IndigoMinMaxLengthCheckConverter))]
        public virtual string TransactionId { get; set; }

        [JsonProperty("trigger")]
        public virtual EventTriggerEnumType Trigger { get; set; }

        [JsonProperty("variable")]
        public virtual VariableType Variable { get; set; }

        /// <summary>
        /// Identifies the VariableMonitoring which triggered the event.
        /// </summary>
        [JsonProperty("variableMonitoringId", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? VariableMonitoringId { get; set; }
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
        [JsonConverter(typeof(TentacledMinMaxLengthCheckConverter))]
        public virtual string Instance { get; set; }

        /// <summary>
        /// Name of the component. Name should be taken from the list of standardized component names
        /// whenever possible. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        [JsonProperty("name")]
        [JsonConverter(typeof(TentacledMinMaxLengthCheckConverter))]
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
        [JsonConverter(typeof(TentacledMinMaxLengthCheckConverter))]
        public virtual string Instance { get; set; }

        /// <summary>
        /// Name of the variable. Name should be taken from the list of standardized variable names
        /// whenever possible. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        [JsonProperty("name")]
        [JsonConverter(typeof(TentacledMinMaxLengthCheckConverter))]
        public virtual string Name { get; set; }
    }

    /// <summary>
    /// Specifies the event notification type of the message.
    /// </summary>
    public enum EventNotificationEnumType { CustomMonitor, HardWiredMonitor, HardWiredNotification, PreconfiguredMonitor };

    /// <summary>
    /// Type of monitor that triggered this event, e.g. exceeding a threshold value.
    /// </summary>
    public enum EventTriggerEnumType { Alerting, Delta, Periodic };

    public partial class NotifyEventRequest
    {
        public static NotifyEventRequest FromJson(string json) => JsonConvert.DeserializeObject<NotifyEventRequest>(json, Ocpp._201.Generated.Models.NotifyEventRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this NotifyEventRequest self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.NotifyEventRequest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                EventNotificationEnumTypeConverter.Singleton,
                EventTriggerEnumTypeConverter.Singleton,
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

        public static readonly FluffyMinMaxLengthCheckConverter Singleton = new FluffyMinMaxLengthCheckConverter();
    }

    internal class TentacledMinMaxLengthCheckConverter : JsonConverter
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

        public static readonly TentacledMinMaxLengthCheckConverter Singleton = new TentacledMinMaxLengthCheckConverter();
    }

    internal class EventNotificationEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EventNotificationEnumType) || t == typeof(EventNotificationEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CustomMonitor":
                    return EventNotificationEnumType.CustomMonitor;
                case "HardWiredMonitor":
                    return EventNotificationEnumType.HardWiredMonitor;
                case "HardWiredNotification":
                    return EventNotificationEnumType.HardWiredNotification;
                case "PreconfiguredMonitor":
                    return EventNotificationEnumType.PreconfiguredMonitor;
            }
            throw new Exception("Cannot unmarshal type EventNotificationEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EventNotificationEnumType)untypedValue;
            switch (value)
            {
                case EventNotificationEnumType.CustomMonitor:
                    serializer.Serialize(writer, "CustomMonitor");
                    return;
                case EventNotificationEnumType.HardWiredMonitor:
                    serializer.Serialize(writer, "HardWiredMonitor");
                    return;
                case EventNotificationEnumType.HardWiredNotification:
                    serializer.Serialize(writer, "HardWiredNotification");
                    return;
                case EventNotificationEnumType.PreconfiguredMonitor:
                    serializer.Serialize(writer, "PreconfiguredMonitor");
                    return;
            }
            throw new Exception("Cannot marshal type EventNotificationEnumType");
        }

        public static readonly EventNotificationEnumTypeConverter Singleton = new EventNotificationEnumTypeConverter();
    }

    internal class StickyMinMaxLengthCheckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);
            if (value.Length <= 500)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 500)
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

        public static readonly IndigoMinMaxLengthCheckConverter Singleton = new IndigoMinMaxLengthCheckConverter();
    }

    internal class EventTriggerEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EventTriggerEnumType) || t == typeof(EventTriggerEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Alerting":
                    return EventTriggerEnumType.Alerting;
                case "Delta":
                    return EventTriggerEnumType.Delta;
                case "Periodic":
                    return EventTriggerEnumType.Periodic;
            }
            throw new Exception("Cannot unmarshal type EventTriggerEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EventTriggerEnumType)untypedValue;
            switch (value)
            {
                case EventTriggerEnumType.Alerting:
                    serializer.Serialize(writer, "Alerting");
                    return;
                case EventTriggerEnumType.Delta:
                    serializer.Serialize(writer, "Delta");
                    return;
                case EventTriggerEnumType.Periodic:
                    serializer.Serialize(writer, "Periodic");
                    return;
            }
            throw new Exception("Cannot marshal type EventTriggerEnumType");
        }

        public static readonly EventTriggerEnumTypeConverter Singleton = new EventTriggerEnumTypeConverter();
    }
}
