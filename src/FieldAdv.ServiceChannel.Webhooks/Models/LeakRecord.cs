using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;


public partial class LeakRecord : WebhookRoot<LeakRecordObject>
{
  [JsonPropertyName("Object")]
  public override LeakRecordObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class LeakRecordObject
{
  [JsonPropertyName("Id")]
  public long Id { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Note")]
  public string? Note { get; set; }

  [JsonPropertyName("InitialMethod")]
  public string? InitialMethod { get; set; }

  [JsonPropertyName("FollowUpMethod")]
  public string? FollowUpMethod { get; set; }

  [JsonPropertyName("WorkOrderId")]
  public long WorkOrderId { get; set; }

  [JsonPropertyName("SubscriberId")]
  public long SubscriberId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("RepairDate")]
  public DateTime? RepairDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("InitialDate")]
  public DateTime? InitialDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("FollowUpDate")]
  public DateTime? FollowUpDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("LocationId")]
  public long? LocationId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("FaultCodeId")]
  public long? FaultCodeId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ActionCodeId")]
  public long? ActionCodeId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("AreaId")]
  public long? AreaId { get; set; }
}