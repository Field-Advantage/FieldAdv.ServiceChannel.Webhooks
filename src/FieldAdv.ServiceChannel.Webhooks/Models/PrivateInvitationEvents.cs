using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;

public partial class PrivateInvitationEvents : WebhookRoot<PrivateInvitationEventsObject>
{
  [JsonPropertyName("Object")]
  public override PrivateInvitationEventsObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class PrivateInvitationEventsObject
{
  [JsonPropertyName("ClientId")]
  public long ClientId { get; set; }

  [JsonPropertyName("ContractorId")]
  public long ContractorId { get; set; }

  [JsonPropertyName("ScProviderId")]
  public long ScProviderId { get; set; }

  [JsonPropertyName("ScSubscriberId")]
  public long ScSubscriberId { get; set; }

  [JsonPropertyName("Status")]
  public string? Status { get; set; }
}