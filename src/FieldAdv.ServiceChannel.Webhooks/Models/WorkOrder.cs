using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;
using System.Collections.Generic;

namespace FieldAdv.ServiceChannel.Webhooks.Models;


public partial class WorkOrder : WebhookRoot<WorkOrderObject>
{
  [JsonPropertyName("Object")]
  public override WorkOrderObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class WorkOrderObject
{
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("LinkedWorkOrderIds")]
  public List<long> LinkedWorkOrderIds { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Id")]
  public long? Id { get; set; }

  // Work order number
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Number")]
  public string? Number { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("PurchaseNumber")]
  public string? PurchaseNumber { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("SubscriberId")]
  public long? SubscriberId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ProviderId")]
  public long? ProviderId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ProviderName")]
  public string? ProviderName { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("LocationId")]
  public long? LocationId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("LocationName")]
  public string? LocationName { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("LocationStoreId")]
  public string? LocationStoreId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Status")]
  public Status? Status { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Caller")]
  public string? Caller { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CreatedBy")]
  public string? CreatedBy { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("UpdatedBy")]
  public WebhookUser? UpdatedBy { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CallDate")]
  public DateTime? CallDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Priority")]
  public string? Priority { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Trade")]
  public string? Trade { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ScheduledDate")]
  public DateTime? ScheduledDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("AreaId")]
  public long? AreaId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("AssetType")]
  public string? AssetType { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ProblemType")]
  public string? ProblemType { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ScheduledDate_DTO")]
  public DateTime? ScheduledDateDto { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ExpirationDate")]
  public DateTime? ExpirationDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Description")]
  public string? Description { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Category")]
  public string? Category { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Nte")]
  public long? Nte { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CurrencyAlphabeticalCode")]
  public string? CurrencyAlphabeticalCode { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ProblemCode")]
  public string? ProblemCode { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("AssetId")]
  public long? AssetId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Source")]
  public string? Source { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Attachments")]
  public List<Attachment> Attachments { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("UpdatedDate")]
  public DateTime? UpdatedDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CompletedDate")]
  public DateTime? CompletedDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Notes")]
  public List<Note> Notes { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("UpdatedDate_DTO")]
  public DateTime? UpdatedDateDto { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Technician")]
  public WebhookUser? Technician { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("WorkOrderId")]
  public long? WorkOrderId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("LinkedWorkOrdersIds")]
  public List<long> LinkedWorkOrdersIds { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("UnlinkLinkedWorkOrders")]
  public bool? UnlinkLinkedWorkOrders { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("User")]
  public WebhookUser? User { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Labels")]
  public List<Label> Labels { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ResolutionCodes")]
  public List<ResolutionCode> ResolutionCodes { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("RootCauses")]
  public List<ResolutionCode> RootCauses { get; set; } = new();
}

public partial class Note
{
  [JsonPropertyName("Id")]
  public long Id { get; set; }

  [JsonPropertyName("Number")]
  public long Number { get; set; }

  [JsonPropertyName("NoteData")]
  public string? NoteData { get; set; }

  [JsonPropertyName("DateCreated")]
  public DateTime? DateCreated { get; set; }

  [JsonPropertyName("ScheduledDate")]
  public DateTime? ScheduledDate { get; set; }

  [JsonPropertyName("ActionRequired")]
  public bool ActionRequired { get; set; }

  [JsonPropertyName("CreatedBy")]
  public string? CreatedBy { get; set; }

  [JsonPropertyName("CreatedByUser")]
  public WebhookUser? CreatedByUser { get; set; }
}

public partial class ResolutionCode
{
  [JsonPropertyName("Id")]
  public long Id { get; set; }
}

public partial class Status
{
  [JsonPropertyName("Primary")]
  public string? Primary { get; set; }

  [JsonPropertyName("Extended")]
  public string? Extended { get; set; }
}


internal static class Converter
{
  public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
  {
    Converters =
            {
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeConverter.Singleton
            },
  };
}

public class DateOnlyConverter : JsonConverter<DateOnly>
{
  private readonly string serializationFormat;
  public DateOnlyConverter() : this(null) { }

  public DateOnlyConverter(string? serializationFormat)
  {
    this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
  }

  public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    var value = reader.GetString();
    return DateOnly.Parse(value!);
  }

  public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
      => writer.WriteStringValue(value.ToString(serializationFormat));
}

public class TimeOnlyConverter : JsonConverter<TimeOnly>
{
  private readonly string serializationFormat;

  public TimeOnlyConverter() : this(null) { }

  public TimeOnlyConverter(string? serializationFormat)
  {
    this.serializationFormat = serializationFormat ?? "HH:mm:ss.fff";
  }

  public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    var value = reader.GetString();
    return TimeOnly.Parse(value!);
  }

  public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
      => writer.WriteStringValue(value.ToString(serializationFormat));
}

internal class IsoDateTimeConverter : JsonConverter<DateTime>
{
  public override bool CanConvert(Type t) => t == typeof(DateTime);

  private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

  private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
  private string? _dateTimeFormat;
  private CultureInfo? _culture;

  public DateTimeStyles DateTimeStyles
  {
    get => _dateTimeStyles;
    set => _dateTimeStyles = value;
  }

  public string? DateTimeFormat
  {
    get => _dateTimeFormat ?? string.Empty;
    set => _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value;
  }

  public CultureInfo Culture
  {
    get => _culture ?? CultureInfo.CurrentCulture;
    set => _culture = value;
  }

  public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
  {
    string text;


    if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
        || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
    {
      value = value.ToUniversalTime();
    }

    text = value.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);

    writer.WriteStringValue(text);
  }

  public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    string? dateText = reader.GetString();

    if (string.IsNullOrEmpty(dateText) == false)
    {
      if (!string.IsNullOrEmpty(_dateTimeFormat))
      {
        return DateTime.ParseExact(dateText, _dateTimeFormat, Culture, _dateTimeStyles);
      }
      else
      {
        return DateTime.Parse(dateText, Culture, _dateTimeStyles);
      }
    }
    else
    {
      return default(DateTime);
    }
  }


  public static readonly IsoDateTimeConverter Singleton = new IsoDateTimeConverter();
}
