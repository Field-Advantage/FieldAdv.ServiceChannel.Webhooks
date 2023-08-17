using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;

public partial class Subscriber : WebhookRoot<SubscriberObject>
{
  [JsonPropertyName("Object")]
  public override SubscriberObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class SubscriberObject
{
  // Unique numeric identifier of the trade.
  [JsonPropertyName("Id")]
  public long Id { get; set; }

  // Unique numeric identifier of the subscriber.
  [JsonPropertyName("SubscriberId")]
  public long SubscriberId { get; set; }

  // Trade name
  [JsonPropertyName("Name")]
  public string? Name { get; set; }

  // Primary trade name.
  [JsonPropertyName("NamePrimary")]
  public string? NamePrimary { get; set; }
}