using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;

public partial class ServiceProviderContract : WebhookRoot<ServiceProviderContractObject>
{
  [JsonPropertyName("Object")]
  public override ServiceProviderContractObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class ServiceProviderContractObject
{
  [JsonPropertyName("ProviderId")]
  public long ProviderId { get; set; }

  [JsonPropertyName("TradedId")]
  public long TradedId { get; set; }

  [JsonPropertyName("SubscriberId")]
  public long SubscriberId { get; set; }

  [JsonPropertyName("LocationIds")]
  public List<long> LocationIds { get; set; } = new();

  [JsonPropertyName("UpdatedBy")]
  public WebhookUser? UpdatedBy { get; set; }
}
