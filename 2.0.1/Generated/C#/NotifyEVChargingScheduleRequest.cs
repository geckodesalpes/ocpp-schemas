// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Ocpp._201.Generated.Models.NotifyEVChargingScheduleRequest;
//
//    var notifyEvChargingScheduleRequest = NotifyEvChargingScheduleRequest.FromJson(jsonString);

namespace Ocpp._201.Generated.Models.NotifyEVChargingScheduleRequest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NotifyEvChargingScheduleRequest
    {
        [JsonProperty("chargingSchedule")]
        public virtual ChargingScheduleType ChargingSchedule { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// The charging schedule contained in this notification applies to an EVSE. EvseId must be
        /// &gt; 0.
        /// </summary>
        [JsonProperty("evseId")]
        public virtual long EvseId { get; set; }

        /// <summary>
        /// Periods contained in the charging profile are relative to this point in time.
        /// </summary>
        [JsonProperty("timeBase")]
        public virtual DateTimeOffset TimeBase { get; set; }
    }

    /// <summary>
    /// Charging_ Schedule
    /// urn:x-oca:ocpp:uid:2:233256
    /// Charging schedule structure defines a list of charging periods, as used in:
    /// GetCompositeSchedule.conf and ChargingProfile.
    /// </summary>
    public partial class ChargingScheduleType
    {
        [JsonProperty("chargingRateUnit")]
        public virtual ChargingRateUnitEnumType ChargingRateUnit { get; set; }

        [JsonProperty("chargingSchedulePeriod")]
        public virtual System.Collections.Generic.List<ChargingSchedulePeriodType> ChargingSchedulePeriod { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Charging_ Schedule. Duration. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569236
        /// Duration of the charging schedule in seconds. If the duration is left empty, the last
        /// period will continue indefinitely or until end of the transaction if
        /// chargingProfilePurpose = TxProfile.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? Duration { get; set; }

        /// <summary>
        /// Identifies the ChargingSchedule.
        /// </summary>
        [JsonProperty("id")]
        public virtual long Id { get; set; }

        /// <summary>
        /// Charging_ Schedule. Min_ Charging_ Rate. Numeric
        /// urn:x-oca:ocpp:uid:1:569239
        /// Minimum charging rate supported by the EV. The unit of measure is defined by the
        /// chargingRateUnit. This parameter is intended to be used by a local smart charging
        /// algorithm to optimize the power allocation for in the case a charging process is
        /// inefficient at lower charging rates. Accepts at most one digit fraction (e.g. 8.1)
        /// </summary>
        [JsonProperty("minChargingRate", NullValueHandling = NullValueHandling.Ignore)]
        public virtual double? MinChargingRate { get; set; }

        [JsonProperty("salesTariff", NullValueHandling = NullValueHandling.Ignore)]
        public virtual SalesTariffType SalesTariff { get; set; }

        /// <summary>
        /// Charging_ Schedule. Start_ Schedule. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569237
        /// Starting point of an absolute schedule. If absent the schedule will be relative to start
        /// of charging.
        /// </summary>
        [JsonProperty("startSchedule", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTimeOffset? StartSchedule { get; set; }
    }

    /// <summary>
    /// Charging_ Schedule_ Period
    /// urn:x-oca:ocpp:uid:2:233257
    /// Charging schedule period structure defines a time period in a charging schedule.
    /// </summary>
    public partial class ChargingSchedulePeriodType
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Charging_ Schedule_ Period. Limit. Measure
        /// urn:x-oca:ocpp:uid:1:569241
        /// Charging rate limit during the schedule period, in the applicable chargingRateUnit, for
        /// example in Amperes (A) or Watts (W). Accepts at most one digit fraction (e.g. 8.1).
        /// </summary>
        [JsonProperty("limit")]
        public virtual double Limit { get; set; }

        /// <summary>
        /// Charging_ Schedule_ Period. Number_ Phases. Counter
        /// urn:x-oca:ocpp:uid:1:569242
        /// The number of phases that can be used for charging. If a number of phases is needed,
        /// numberPhases=3 will be assumed unless another number is given.
        /// </summary>
        [JsonProperty("numberPhases", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? NumberPhases { get; set; }

        /// <summary>
        /// Values: 1..3, Used if numberPhases=1 and if the EVSE is capable of switching the phase
        /// connected to the EV, i.e. ACPhaseSwitchingSupported is defined and true. It’s not allowed
        /// unless both conditions above are true. If both conditions are true, and phaseToUse is
        /// omitted, the Charging Station / EVSE will make the selection on its own.
        /// </summary>
        [JsonProperty("phaseToUse", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? PhaseToUse { get; set; }

        /// <summary>
        /// Charging_ Schedule_ Period. Start_ Period. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569240
        /// Start of the period, in seconds from the start of schedule. The value of StartPeriod also
        /// defines the stop time of the previous period.
        /// </summary>
        [JsonProperty("startPeriod")]
        public virtual long StartPeriod { get; set; }
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
    /// Sales_ Tariff
    /// urn:x-oca:ocpp:uid:2:233272
    /// NOTE: This dataType is based on dataTypes from &lt;&lt;ref-ISOIEC15118-2,ISO
    /// 15118-2&gt;&gt;.
    /// </summary>
    public partial class SalesTariffType
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// SalesTariff identifier used to identify one sales tariff. An SAID remains a unique
        /// identifier for one schedule throughout a charging session.
        /// </summary>
        [JsonProperty("id")]
        public virtual long Id { get; set; }

        /// <summary>
        /// Sales_ Tariff. Num_ E_ Price_ Levels. Counter
        /// urn:x-oca:ocpp:uid:1:569284
        /// Defines the overall number of distinct price levels used across all provided SalesTariff
        /// elements.
        /// </summary>
        [JsonProperty("numEPriceLevels", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? NumEPriceLevels { get; set; }

        /// <summary>
        /// Sales_ Tariff. Sales. Tariff_ Description
        /// urn:x-oca:ocpp:uid:1:569283
        /// A human readable title/short description of the sales tariff e.g. for HMI display
        /// purposes.
        /// </summary>
        [JsonProperty("salesTariffDescription", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyMinMaxLengthCheckConverter))]
        public virtual string SalesTariffDescription { get; set; }

        [JsonProperty("salesTariffEntry")]
        public virtual System.Collections.Generic.List<SalesTariffEntryType> SalesTariffEntry { get; set; }
    }

    /// <summary>
    /// Sales_ Tariff_ Entry
    /// urn:x-oca:ocpp:uid:2:233271
    /// </summary>
    public partial class SalesTariffEntryType
    {
        [JsonProperty("consumptionCost", NullValueHandling = NullValueHandling.Ignore)]
        public virtual System.Collections.Generic.List<ConsumptionCostType> ConsumptionCost { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Sales_ Tariff_ Entry. E_ Price_ Level. Unsigned_ Integer
        /// urn:x-oca:ocpp:uid:1:569281
        /// Defines the price level of this SalesTariffEntry (referring to NumEPriceLevels). Small
        /// values for the EPriceLevel represent a cheaper TariffEntry. Large values for the
        /// EPriceLevel represent a more expensive TariffEntry.
        /// </summary>
        [JsonProperty("ePriceLevel", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? EPriceLevel { get; set; }

        [JsonProperty("relativeTimeInterval")]
        public virtual RelativeTimeIntervalType RelativeTimeInterval { get; set; }
    }

    /// <summary>
    /// Consumption_ Cost
    /// urn:x-oca:ocpp:uid:2:233259
    /// </summary>
    public partial class ConsumptionCostType
    {
        [JsonProperty("cost")]
        public virtual System.Collections.Generic.List<CostType> Cost { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Consumption_ Cost. Start_ Value. Numeric
        /// urn:x-oca:ocpp:uid:1:569246
        /// The lowest level of consumption that defines the starting point of this consumption
        /// block. The block interval extends to the start of the next interval.
        /// </summary>
        [JsonProperty("startValue")]
        public virtual double StartValue { get; set; }
    }

    /// <summary>
    /// Cost
    /// urn:x-oca:ocpp:uid:2:233258
    /// </summary>
    public partial class CostType
    {
        /// <summary>
        /// Cost. Amount. Amount
        /// urn:x-oca:ocpp:uid:1:569244
        /// The estimated or actual cost per kWh
        /// </summary>
        [JsonProperty("amount")]
        public virtual long Amount { get; set; }

        /// <summary>
        /// Cost. Amount_ Multiplier. Integer
        /// urn:x-oca:ocpp:uid:1:569245
        /// Values: -3..3, The amountMultiplier defines the exponent to base 10 (dec). The final
        /// value is determined by: amount * 10 ^ amountMultiplier
        /// </summary>
        [JsonProperty("amountMultiplier", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? AmountMultiplier { get; set; }

        [JsonProperty("costKind")]
        public virtual CostKindEnumType CostKind { get; set; }

        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }
    }

    /// <summary>
    /// Relative_ Timer_ Interval
    /// urn:x-oca:ocpp:uid:2:233270
    /// </summary>
    public partial class RelativeTimeIntervalType
    {
        [JsonProperty("customData", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CustomDataType CustomData { get; set; }

        /// <summary>
        /// Relative_ Timer_ Interval. Duration. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569280
        /// Duration of the interval, in seconds.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? Duration { get; set; }

        /// <summary>
        /// Relative_ Timer_ Interval. Start. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569279
        /// Start of the interval, in seconds from NOW.
        /// </summary>
        [JsonProperty("start")]
        public virtual long Start { get; set; }
    }

    /// <summary>
    /// Charging_ Schedule. Charging_ Rate_ Unit. Charging_ Rate_ Unit_ Code
    /// urn:x-oca:ocpp:uid:1:569238
    /// The unit of measure Limit is expressed in.
    /// </summary>
    public enum ChargingRateUnitEnumType { A, W };

    /// <summary>
    /// Cost. Cost_ Kind. Cost_ Kind_ Code
    /// urn:x-oca:ocpp:uid:1:569243
    /// The kind of cost referred to in the message element amount
    /// </summary>
    public enum CostKindEnumType { CarbonDioxideEmission, RelativePricePercentage, RenewableGenerationPercentage };

    public partial class NotifyEvChargingScheduleRequest
    {
        public static NotifyEvChargingScheduleRequest FromJson(string json) => JsonConvert.DeserializeObject<NotifyEvChargingScheduleRequest>(json, Ocpp._201.Generated.Models.NotifyEVChargingScheduleRequest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this NotifyEvChargingScheduleRequest self) => JsonConvert.SerializeObject(self, Ocpp._201.Generated.Models.NotifyEVChargingScheduleRequest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ChargingRateUnitEnumTypeConverter.Singleton,
                CostKindEnumTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ChargingRateUnitEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ChargingRateUnitEnumType) || t == typeof(ChargingRateUnitEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "A":
                    return ChargingRateUnitEnumType.A;
                case "W":
                    return ChargingRateUnitEnumType.W;
            }
            throw new Exception("Cannot unmarshal type ChargingRateUnitEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ChargingRateUnitEnumType)untypedValue;
            switch (value)
            {
                case ChargingRateUnitEnumType.A:
                    serializer.Serialize(writer, "A");
                    return;
                case ChargingRateUnitEnumType.W:
                    serializer.Serialize(writer, "W");
                    return;
            }
            throw new Exception("Cannot marshal type ChargingRateUnitEnumType");
        }

        public static readonly ChargingRateUnitEnumTypeConverter Singleton = new ChargingRateUnitEnumTypeConverter();
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
            if (value.Length <= 32)
            {
                return value;
            }
            throw new Exception("Cannot unmarshal type string");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (string)untypedValue;
            if (value.Length <= 32)
            {
                serializer.Serialize(writer, value);
                return;
            }
            throw new Exception("Cannot marshal type string");
        }

        public static readonly FluffyMinMaxLengthCheckConverter Singleton = new FluffyMinMaxLengthCheckConverter();
    }

    internal class CostKindEnumTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CostKindEnumType) || t == typeof(CostKindEnumType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CarbonDioxideEmission":
                    return CostKindEnumType.CarbonDioxideEmission;
                case "RelativePricePercentage":
                    return CostKindEnumType.RelativePricePercentage;
                case "RenewableGenerationPercentage":
                    return CostKindEnumType.RenewableGenerationPercentage;
            }
            throw new Exception("Cannot unmarshal type CostKindEnumType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CostKindEnumType)untypedValue;
            switch (value)
            {
                case CostKindEnumType.CarbonDioxideEmission:
                    serializer.Serialize(writer, "CarbonDioxideEmission");
                    return;
                case CostKindEnumType.RelativePricePercentage:
                    serializer.Serialize(writer, "RelativePricePercentage");
                    return;
                case CostKindEnumType.RenewableGenerationPercentage:
                    serializer.Serialize(writer, "RenewableGenerationPercentage");
                    return;
            }
            throw new Exception("Cannot marshal type CostKindEnumType");
        }

        public static readonly CostKindEnumTypeConverter Singleton = new CostKindEnumTypeConverter();
    }
}
