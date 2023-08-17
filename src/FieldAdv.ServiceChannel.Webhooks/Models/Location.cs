using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;

public partial class Location : WebhookRoot<LocationObject>
{
  [JsonPropertyName("Object")]
  public override LocationObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class LocationObject
{
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("StoreId")]
  public string? StoreId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Id")]
  public long? Id { get; set; }

  [JsonPropertyName("SubscriberId")]
  public long SubscriberId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ShortName")]
  public string? ShortName { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("FullName")]
  public string? FullName { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Address2")]
  public string? Address2 { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("City")]
  public string? City { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("State")]
  public string? State { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Country")]
  public string? Country { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Zip")]
  public string? Zip { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("NotesCount")]
  public long? NotesCount { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Latitude")]
  public double? Latitude { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Longitude")]
  public double? Longitude { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("UpdatedUserName")]
  public string? UpdatedUserName { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("UpdatedDate")]
  public DateTimeOffset? UpdatedDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Address1")]
  public string? Address1 { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("StoreOpen")]
  public DateTimeOffset? StoreOpen { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("TimeZoneId")]
  public string? TimeZoneId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Name")]
  public string? Name { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("SearchType")]
  public string? SearchType { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Access")]
  public string? Access { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("User")]
  public WebhookUser? User { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("LocationId")]
  public long? LocationId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ChangedValues")]
  public List<ChangedValue> ChangedValues { get; set; } = new();
}

public partial class ChangedValue
{
  [JsonPropertyName("Name")]
  public string? Name { get; set; }

  [JsonPropertyName("Value")]
  public string? Value { get; set; }
}