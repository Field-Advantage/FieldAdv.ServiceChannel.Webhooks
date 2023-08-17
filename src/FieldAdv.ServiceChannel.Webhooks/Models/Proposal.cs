using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;

public partial class Proposal : WebhookRoot<ProposalObject>
{
  [JsonPropertyName("Object")]
  public override ProposalObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class ProposalObject
{
  [JsonPropertyName("Id")]
  public long Id { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Number")]
  public string? Number { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Description")]
  public string? Description { get; set; }

  [JsonPropertyName("Comments")]
  public string? Comments { get; set; }

  // The type of work a provider performs, for example, CARPENTRY or PLUMBING.
  [JsonPropertyName("Trade")]
  public string? Trade { get; set; }

  [JsonPropertyName("LocationId")]
  public long LocationId { get; set; }

  [JsonPropertyName("SubscriberId")]
  public long SubscriberId { get; set; }

  [JsonPropertyName("ProviderId")]
  public long ProviderId { get; set; }

  [JsonPropertyName("WorkOrderId")]
  public long? WorkOrderId { get; set; }

  // The number of the work order connected to the proposal.
  [JsonPropertyName("WorkOrderNumber")]
  public string? WorkOrderNumber { get; set; }

  // The unique ID of the request for proposal (RFP) associated with the proposal.
  [JsonPropertyName("RfpId")]
  public long RfpId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CurrencyAlphabeticalCode")]
  public string? CurrencyAlphabeticalCode { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CreatedBy")]
  public WebhookUser? CreatedBy { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("UpdatedBy")]
  public WebhookUser? UpdatedBy { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("AssignedTo")]
  public WebhookUser? AssignedTo { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("RequestedBy")]
  public string? RequestedBy { get; set; }

  [JsonPropertyName("ScheduledDate")]
  public DateTime? ScheduledDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Status")]
  public string? Status { get; set; }

  [JsonPropertyName("Attachments")]
  public List<Attachment> Attachments { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Amount")]
  public long? Amount { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("AmountCategories")]
  public List<AmountCategory> AmountCategories { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Asset")]
  public List<ProposalAsset> Asset { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Category")]
  public string? Category { get; set; }
}

public partial class AmountCategory
{
  [JsonPropertyName("Id")]
  public long Id { get; set; }

  [JsonPropertyName("Name")]
  public string? Name { get; set; }

  [JsonPropertyName("TotalCost")]
  public double TotalCost { get; set; }
}

public partial class ProposalAsset
{
  [JsonPropertyName("Id")]
  public string? Id { get; set; }

  // The recommendation for action a provider needs to perform on the asset.
  // Possible values: REPAIR, REPLACE, NEW, REMOVE.
  [JsonPropertyName("Action")]
  public string? Action { get; set; }

  [JsonPropertyName("Area")]
  public string? Area { get; set; }

  [JsonPropertyName("BrandId")]
  public string? BrandId { get; set; }

  [JsonPropertyName("TypeId")]
  public string? TypeId { get; set; }

  [JsonPropertyName("IsNew")]
  public bool IsNew { get; set; }

  [JsonPropertyName("Attributes")]
  public List<Attribute> Attributes { get; set; } = new();
}

public partial class Attribute
{
  [JsonPropertyName("Name")]
  public string? Name { get; set; }

  [JsonPropertyName("Value")]
  public string? Value { get; set; }
}

public partial class AssignedTo
{
  [JsonPropertyName("Id")]
  public long Id { get; set; }

  [JsonPropertyName("UserName")]
  public string? UserName { get; set; }

  [JsonPropertyName("FullName")]
  public string? FullName { get; set; }

  [JsonPropertyName("Email")]
  public string? Email { get; set; }
}



