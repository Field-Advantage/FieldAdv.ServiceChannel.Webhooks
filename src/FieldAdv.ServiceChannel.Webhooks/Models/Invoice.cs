using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;

public partial class Invoice : WebhookRoot<InvoiceObject>
{
  [JsonPropertyName("Object")]
  public override InvoiceObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class InvoiceObject
{
  [JsonPropertyName("Id")]
  public long Id { get; set; }

  [JsonPropertyName("Number")]
  public string? Number { get; set; }

  [JsonPropertyName("BatchNumber")]
  public string? BatchNumber { get; set; }

  [JsonPropertyName("InvoiceTax")]
  public double InvoiceTax { get; set; }

  [JsonPropertyName("PostedTaxRate")]
  public long? PostedTaxRate { get; set; }

  [JsonPropertyName("VendorPayeeId")]
  public long VendorPayeeId { get; set; }

  [JsonPropertyName("InvoiceTotal")]
  public double InvoiceTotal { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CurrencyAlphabeticalCode")]
  public string? CurrencyAlphabeticalCode { get; set; }

  [JsonPropertyName("ApprovedDateDTO")]
  public DateTime? ApprovedDateDto { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ApprovalCode")]
  public string? ApprovalCode { get; set; }

  [JsonPropertyName("PostedDateDTO")]
  public DateTime PostedDateDto { get; set; }

  [JsonPropertyName("Subtotal")]
  public long Subtotal { get; set; }

  [JsonPropertyName("Status")]
  public string? Status { get; set; }

  [JsonPropertyName("Trade")]
  public string? Trade { get; set; }

  [JsonPropertyName("StarredBy")]
  public string? StarredBy { get; set; }

  [JsonPropertyName("IsStarred")]
  public bool IsStarred { get; set; }

  [JsonPropertyName("StarredDate")]
  public DateTime StarredDate { get; set; }

  [JsonPropertyName("Description")]
  public string? Description { get; set; }

  [JsonPropertyName("InvoiceDateDTO")]
  public DateTime InvoiceDateDto { get; set; }

  [JsonPropertyName("LaborTaxIncluded")]
  public bool LaborTaxIncluded { get; set; }

  [JsonPropertyName("TravelTaxIncluded")]
  public bool TravelTaxIncluded { get; set; }

  [JsonPropertyName("MaterialsTaxIncluded")]
  public bool MaterialsTaxIncluded { get; set; }

  [JsonPropertyName("FreightTaxIncluded")]
  public bool FreightTaxIncluded { get; set; }

  [JsonPropertyName("OtherTaxIncluded")]
  public bool OtherTaxIncluded { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("StatusChangeDate")]
  public DateTime? StatusChangeDate { get; set; }

  [JsonPropertyName("StatusChangeUser")]
  //The username or full name of the person who updated the invoice status.
  public string? StatusChangeUser { get; set; }

  [JsonPropertyName("StatusChangeUserid")]
  //The user ID of the person who updated the invoice status.
  public string? StatusChangeUserid { get; set; }

  [JsonPropertyName("WoTrackingNumber")]
  public long WoTrackingNumber { get; set; }

  [JsonPropertyName("Terms")]
  //The source that created the invoice. Empty when created manually or InvoiceAgent when created by the background process.
  public string? Terms { get; set; }

  [JsonPropertyName("Comments")]
  public string? Comments { get; set; }

  [JsonPropertyName("PaidDateDTO")]
  //The date and time when the invoice was paid indicated with the UTC offset.
  public DateTime PaidDateDto { get; set; }

  [JsonPropertyName("TransferredDate")]
  //The invoice transferred date and time.
  public DateTime TransferredDate { get; set; }

  [JsonPropertyName("LastActionDateDTO")]
  //The date and time of the last action performed on the invoice indicated with the UTC offset.
  public DateTime? LastActionDateDto { get; set; }

  [JsonPropertyName("UpdatedDateDTO")]
  //The date and time of the last invoice update indicated with the UTC offset.
  public DateTime UpdatedDateDto { get; set; }

  [JsonPropertyName("ProviderId")]
  public long ProviderId { get; set; }

  [JsonPropertyName("SubscriberId")]
  public long SubscriberId { get; set; }

  [JsonPropertyName("LocationId")]
  public long LocationId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ProviderName")]
  public string? ProviderName { get; set; }

  [JsonPropertyName("Labors")]
  public List<Labor> Labors { get; set; } = new();

  [JsonPropertyName("Materials")]
  public List<Material> Materials { get; set; } = new();

  // The overall classification of the WO, for example, MAINTENANCE or REPAIR.
  [JsonPropertyName("Category")]
  public string? Category { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ChangedBy")]
  public ChangedBy? ChangedBy { get; set; }
}

public partial class ChangedBy
{
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Id")]
  public long? Id { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("AuthUserId")]
  public long? AuthUserId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("UserName")]
  public string? UserName { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("FullName")]
  public string? FullName { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Email")]
  public string? Email { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("SubscriberId")]
  public long? SubscriberId { get; set; }

  [JsonPropertyName("LoginType")]
  public long? LoginType { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("ProviderId")]
  public long? ProviderId { get; set; }
}

public partial class Labor
{
  [JsonPropertyName("SkillLevel")]
  // The skill level of a worker.
  // Possible values: 1 — Supervisor; 2 — Technician; 3 — Helper.
  public long SkillLevel { get; set; }

  [JsonPropertyName("LaborType")]
  // The type of the pay rate.
  // Possible values: 1 — Regular; 2 — Overtime; 3 — Double time.
  public long LaborType { get; set; }

  [JsonPropertyName("NumOfTech")]
  public long NumOfTech { get; set; }

  [JsonPropertyName("HourlyRate")]
  public long HourlyRate { get; set; }

  [JsonPropertyName("Hours")]
  public long Hours { get; set; }

  [JsonPropertyName("Amount")]
  public long Amount { get; set; }
}

public partial class Material
{
  [JsonPropertyName("Description")]
  public string? Description { get; set; }

  [JsonPropertyName("PartNum")]
  public string? PartNum { get; set; }

  // A unit of measurement.
  // Possible values: 1 — Each; 2 — Box; 3 — Feet; 4 — Sqft; 5 — Lbs; 6 — Gal; 7 — Oz.
  [JsonPropertyName("UnitType")]
  public long UnitType { get; set; }

  [JsonPropertyName("UnitPrice")]
  public long UnitPrice { get; set; }

  [JsonPropertyName("Quantity")]
  public long Quantity { get; set; }

  [JsonPropertyName("Amount")]
  public long Amount { get; set; }
}