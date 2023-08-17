using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;

public partial class Asset : WebhookRoot<AssetObject>
{
  [JsonPropertyName("Object")]
  public override AssetObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class AssetObject
{
  [JsonPropertyName("Id")]
  public long Id { get; set; }

  [JsonPropertyName("Tag")]
  public string? Tag { get; set; }

  [JsonPropertyName("AssetTypeId")]
  public long AssetTypeId { get; set; }

  [JsonPropertyName("TradeId")]
  public long TradeId { get; set; }

  [JsonPropertyName("BrandId")]
  public long BrandId { get; set; }

  [JsonPropertyName("Active")]
  public bool Active { get; set; }

  [JsonPropertyName("AssetTag")]
  public string? AssetTag { get; set; }

  [JsonPropertyName("AssetStatus")]
  public long AssetStatus { get; set; }

  [JsonPropertyName("LocationId")]
  public long LocationId { get; set; }
}
