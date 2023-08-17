using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;

public partial class IssueList : WebhookRoot<IssueListObject>
{
  [JsonPropertyName("Object")]
  public override IssueListObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class IssueListObject
{
  [JsonPropertyName("SubscriberId")]
  public long SubscriberId { get; set; }

  [JsonPropertyName("SetupId")]
  public long SetupId { get; set; }
}