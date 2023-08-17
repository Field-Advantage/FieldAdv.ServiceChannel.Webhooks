using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;
public partial class CheckInAndOut : WebhookRoot<CheckInAndOutObject>
{
  [JsonPropertyName("Object")]
  public override CheckInAndOutObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class CheckInAndOutObject
{
  [JsonPropertyName("CheckInNotes")]
  public CheckInNotes? CheckInNotes { get; set; }

  [JsonPropertyName("SubscriberId")]
  public long SubscriberId { get; set; }

  [JsonPropertyName("ProviderId")]
  public long ProviderId { get; set; }

  [JsonPropertyName("LocationId")]
  public long LocationId { get; set; }

  [JsonPropertyName("CheckinAction")]
  public long CheckinAction { get; set; }

  [JsonPropertyName("WorkOrderId")]
  public long WorkOrderId { get; set; }

  [JsonPropertyName("Date")]
  public DateTime Date { get; set; }

  [JsonPropertyName("DateDTO")]
  public DateTime DateDto { get; set; }

  [JsonPropertyName("User")]
  public WebhookUser? User { get; set; }

  [JsonPropertyName("CallerId")]
  public string? CallerId { get; set; }

  [JsonPropertyName("Action")]
  public string? Action { get; set; }

  [JsonPropertyName("WorkType")]
  public string? WorkType { get; set; }

  [JsonPropertyName("WorkorderStatus")]
  public Status? WorkorderStatus { get; set; }

  [JsonPropertyName("ProviderName")]
  public string? ProviderName { get; set; }

  [JsonPropertyName("Trade")]
  public string? Trade { get; set; }

  [JsonPropertyName("Category")]
  public Category Category { get; set; }

  [JsonPropertyName("Source")]
  public string? Source { get; set; }

  [JsonPropertyName("TradeId")]
  public long TradeId { get; set; }

  [JsonPropertyName("TechsCount")]
  public long TechsCount { get; set; }
}

public partial class CheckInNotes
{
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("AllTechniciansCheckedOut")]
  public string? AllTechniciansCheckedOut { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("OutsideOperationalHours")]
  public string? OutsideOperationalHours { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("OutsideAcceptableTimeframe")]
  public string? OutsideAcceptableTimeframe { get; set; }
}