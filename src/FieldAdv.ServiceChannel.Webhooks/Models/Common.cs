using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;

public enum Action { Delete, New, Update };

public enum Category { PartsOrder, Repair };

public enum TypeEnum { GenericRootNotification, WoRootNotification };

public abstract class WebhookRoot
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EventType")]
    public string? EventType { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Type")]
    public TypeEnum? Type { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Action")]
    public Action? Action { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Version")]
    public long? Version { get; set; }

    public abstract void Process();
}

public abstract class WebhookRoot<T> : WebhookRoot
{
    [JsonPropertyName("Object")]
    public abstract T Object { get; set; }
}

public partial class WebhookUser
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
    [JsonPropertyName("LoginType")]
    public long? LoginType { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SubscriberId")]
    public long? SubscriberId { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProviderId")]
    public long? ProviderId { get; set; }
}

public partial class Label
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Id")]
    public long Id { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Text")]
    public string? Text { get; set; }
}

public partial class Attachment
{
    [JsonPropertyName("Id")]
    public long Id { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Date")]
    public DateTime? Date { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Uri")]
    public Uri? Uri { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Type")]
    public long Type { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CreatedBy")]
    public WebhookUser? CreatedBy { get; set; }
}


/** Orginal code generated via app.quicktype.io

namespace FieldAdv
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

    public partial class LeakRecord
    {
        [JsonPropertyName("Object")]
        public LeakRecordObject Object { get; set; }

        [JsonPropertyName("Type")]
        public TypeEnum Type { get; set; }

        [JsonPropertyName("Action")]
        public Action Action { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }

        [JsonPropertyName("Version")]
        public long Version { get; set; }
    }

    public partial class LeakRecordObject
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Note")]
        public string Note { get; set; }

        [JsonPropertyName("InitialMethod")]
        public string InitialMethod { get; set; }

        [JsonPropertyName("FollowUpMethod")]
        public string FollowUpMethod { get; set; }

        [JsonPropertyName("WorkOrderId")]
        public long WorkOrderId { get; set; }

        [JsonPropertyName("SubscriberId")]
        public long SubscriberId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("RepairDate")]
        public DateTimeOffset? RepairDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("InitialDate")]
        public DateTimeOffset? InitialDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FollowUpDate")]
        public DateTimeOffset? FollowUpDate { get; set; }

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

    public partial class Asset
    {
        [JsonPropertyName("Object")]
        public AssetObject Object { get; set; }

        [JsonPropertyName("Type")]
        public TypeEnum Type { get; set; }

        [JsonPropertyName("Action")]
        public Action Action { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }

        [JsonPropertyName("Version")]
        public long Version { get; set; }
    }

    public partial class AssetObject
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("Tag")]
        public string Tag { get; set; }

        [JsonPropertyName("AssetTypeId")]
        public long AssetTypeId { get; set; }

        [JsonPropertyName("TradeId")]
        public long TradeId { get; set; }

        [JsonPropertyName("BrandId")]
        public long BrandId { get; set; }

        [JsonPropertyName("Active")]
        public bool Active { get; set; }

        [JsonPropertyName("AssetTag")]
        public string AssetTag { get; set; }

        [JsonPropertyName("AssetStatus")]
        public long AssetStatus { get; set; }

        [JsonPropertyName("LocationId")]
        public long LocationId { get; set; }
    }

    public partial class IssueList
    {
        [JsonPropertyName("Object")]
        public IssueListObject Object { get; set; }

        [JsonPropertyName("Type")]
        public TypeEnum Type { get; set; }

        [JsonPropertyName("Action")]
        public Action Action { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }

        [JsonPropertyName("Version")]
        public long Version { get; set; }
    }

    public partial class IssueListObject
    {
        [JsonPropertyName("SubscriberId")]
        public long SubscriberId { get; set; }

        [JsonPropertyName("SetupId")]
        public long SetupId { get; set; }
    }

    public partial class CheckList
    {
        [JsonPropertyName("Object")]
        public CheckListObject Object { get; set; }

        [JsonPropertyName("Type")]
        public TypeEnum Type { get; set; }

        [JsonPropertyName("Action")]
        public Action Action { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }

        [JsonPropertyName("Version")]
        public long Version { get; set; }
    }

    public partial class CheckListObject
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Id")]
        public long? Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CreatedDate")]
        public DateTimeOffset? CreatedDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("UpdatedDate")]
        public DateTimeOffset? UpdatedDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CreatedBy")]
        public long? CreatedBy { get; set; }

        [JsonPropertyName("UpdatedBy")]
        public UpdatedByUnion UpdatedBy { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Locations")]
        public List<long> Locations { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Trades")]
        public List<long> Trades { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Categories")]
        public List<long> Categories { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Questions")]
        public List<Question> Questions { get; set; }

        [JsonPropertyName("SubscriberId")]
        public long SubscriberId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CheckListResponse")]
        public CheckListResponse CheckListResponse { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CheckListResponsePicture")]
        public CheckListResponsePicture CheckListResponsePicture { get; set; }
    }

    public partial class CheckListResponse
    {
        [JsonPropertyName("CheckListQuestionId")]
        public long CheckListQuestionId { get; set; }

        [JsonPropertyName("ProviderId")]
        public long ProviderId { get; set; }

        [JsonPropertyName("TechnicianId")]
        public long TechnicianId { get; set; }

        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("Answer")]
        public string Answer { get; set; }

        [JsonPropertyName("EntityId")]
        public long EntityId { get; set; }

        [JsonPropertyName("EntityTypeId")]
        public long EntityTypeId { get; set; }

        [JsonPropertyName("Attempt")]
        public long Attempt { get; set; }

        [JsonPropertyName("UpdatedDate")]
        public DateTimeOffset UpdatedDate { get; set; }

        [JsonPropertyName("UpdatedDateDto")]
        public DateTimeOffset UpdatedDateDto { get; set; }
    }

    public partial class CheckListResponsePicture
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("CheckListResponseId")]
        public long CheckListResponseId { get; set; }

        [JsonPropertyName("UpdatedBy")]
        public long UpdatedBy { get; set; }
    }

    public partial class Question
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("CheckListId")]
        public long CheckListId { get; set; }

        [JsonPropertyName("Question")]
        public string QuestionQuestion { get; set; }

        [JsonPropertyName("AnswerRequired")]
        public bool AnswerRequired { get; set; }

        [JsonPropertyName("PictureFlag")]
        public long PictureFlag { get; set; }

        [JsonPropertyName("Sequence")]
        public long Sequence { get; set; }

        [JsonPropertyName("QuestionType")]
        public long QuestionType { get; set; }

        [JsonPropertyName("CheckListQuestionOptions")]
        public List<CheckListQuestionOption> CheckListQuestionOptions { get; set; }

        [JsonPropertyName("AnswerCanPersist")]
        public bool AnswerCanPersist { get; set; }

        [JsonPropertyName("CheckListTimingType")]
        public long CheckListTimingType { get; set; }
    }

    public partial class CheckListQuestionOption
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("Answer")]
        public string Answer { get; set; }

        [JsonPropertyName("IsConditionalFollowUp")]
        public bool IsConditionalFollowUp { get; set; }
    }

    public partial class UpdatedBy
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Id")]
        public long? Id { get; set; }

        [JsonPropertyName("AuthUserId")]
        public long? AuthUserId { get; set; }

        [JsonPropertyName("UserName")]
        public UserName? UserName { get; set; }

        [JsonPropertyName("FullName")]
        public Caller? FullName { get; set; }

        [JsonPropertyName("Email")]
        public Email? Email { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ProviderId")]
        public long? ProviderId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SubscriberId")]
        public long? SubscriberId { get; set; }

        [JsonPropertyName("LoginType")]
        public long? LoginType { get; set; }
    }

    public partial class ServiceProviderContract
    {
        [JsonPropertyName("Object")]
        public ServiceProviderContractObject Object { get; set; }

        [JsonPropertyName("Type")]
        public TypeEnum Type { get; set; }

        [JsonPropertyName("Action")]
        public Action Action { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }

        [JsonPropertyName("Version")]
        public long Version { get; set; }
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
        public List<long> LocationIds { get; set; }

        [JsonPropertyName("UpdatedBy")]
        public UpdatedBy UpdatedBy { get; set; }
    }

    public partial class Subscriber
    {
        [JsonPropertyName("Object")]
        public SubscriberObject Object { get; set; }

        [JsonPropertyName("Type")]
        public TypeEnum Type { get; set; }

        [JsonPropertyName("Action")]
        public Action Action { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }

        [JsonPropertyName("Version")]
        public long Version { get; set; }
    }

    public partial class SubscriberObject
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("SubscriberId")]
        public long SubscriberId { get; set; }

        [JsonPropertyName("Name")]
        public Name Name { get; set; }

        [JsonPropertyName("NamePrimary")]
        public string NamePrimary { get; set; }
    }

    public partial class Location
    {
        [JsonPropertyName("Object")]
        public LocationObject Object { get; set; }

        [JsonPropertyName("Type")]
        public TypeEnum Type { get; set; }

        [JsonPropertyName("Action")]
        public Action Action { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }

        [JsonPropertyName("Version")]
        public long Version { get; set; }
    }

    public partial class LocationObject
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StoreId")]
        public string StoreId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Id")]
        public long? Id { get; set; }

        [JsonPropertyName("SubscriberId")]
        public long SubscriberId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ShortName")]
        public string ShortName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("FullName")]
        public string FullName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Address2")]
        public string Address2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("City")]
        public string City { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("State")]
        public string State { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Country")]
        public string Country { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Zip")]
        public string Zip { get; set; }

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
        public UserName? UpdatedUserName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("UpdatedDate")]
        public DateTimeOffset? UpdatedDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Address1")]
        public string Address1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("StoreOpen")]
        public DateTimeOffset? StoreOpen { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("TimeZoneId")]
        public string TimeZoneId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SearchType")]
        public string SearchType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Access")]
        public string Access { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("User")]
        public UpdatedBy User { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("LocationId")]
        public long? LocationId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ChangedValues")]
        public List<ChangedValue> ChangedValues { get; set; }
    }

    public partial class ChangedValue
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; }
    }

    public partial class PrivateInvitationEvents
    {
        [JsonPropertyName("Object")]
        public PrivateInvitationEventsObject Object { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }
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
        public string Status { get; set; }
    }

    public partial class Proposal
    {
        [JsonPropertyName("Object")]
        public ProposalObject Object { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }
    }

    public partial class ProposalObject
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Number")]
        public string Number { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Comments")]
        public string Comments { get; set; }

        [JsonPropertyName("Trade")]
        public Name Trade { get; set; }

        [JsonPropertyName("LocationId")]
        public long LocationId { get; set; }

        [JsonPropertyName("SubscriberId")]
        public long SubscriberId { get; set; }

        [JsonPropertyName("ProviderId")]
        public long ProviderId { get; set; }

        [JsonPropertyName("WorkOrderId")]
        public long? WorkOrderId { get; set; }

        [JsonPropertyName("WorkOrderNumber")]
        public object WorkOrderNumber { get; set; }

        [JsonPropertyName("RfpId")]
        public object RfpId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CurrencyAlphabeticalCode")]
        public string CurrencyAlphabeticalCode { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CreatedBy")]
        public UpdatedBy CreatedBy { get; set; }

        [JsonPropertyName("UpdatedBy")]
        public AssignedTo UpdatedBy { get; set; }

        [JsonPropertyName("AssignedTo")]
        public AssignedTo AssignedTo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("RequestedBy")]
        public string RequestedBy { get; set; }

        [JsonPropertyName("ScheduledDate")]
        public DateTimeOffset? ScheduledDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Status")]
        public string Status { get; set; }

        [JsonPropertyName("Attachments")]
        public List<Attachment> Attachments { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Amount")]
        public long? Amount { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AmountCategories")]
        public List<AmountCategory> AmountCategories { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Asset")]
        public List<AssetElement> Asset { get; set; }

        [JsonPropertyName("Category")]
        public PurpleCategory? Category { get; set; }
    }

    public partial class AmountCategory
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("TotalCost")]
        public double TotalCost { get; set; }
    }

    public partial class AssetElement
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Action")]
        public string Action { get; set; }

        [JsonPropertyName("Area")]
        public string Area { get; set; }

        [JsonPropertyName("BrandId")]
        public string BrandId { get; set; }

        [JsonPropertyName("TypeId")]
        public string TypeId { get; set; }

        [JsonPropertyName("IsNew")]
        public bool IsNew { get; set; }

        [JsonPropertyName("Attributes")]
        public List<ChangedValue> Attributes { get; set; }
    }

    public partial class AssignedTo
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("UserName")]
        public string UserName { get; set; }

        [JsonPropertyName("FullName")]
        public string FullName { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }
    }

    public partial class Attachment
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Date")]
        public DateTimeOffset? Date { get; set; }

        [JsonPropertyName("Uri")]
        public Uri Uri { get; set; }

        [JsonPropertyName("Type")]
        public long Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CreatedBy")]
        public UpdatedBy CreatedBy { get; set; }
    }

    public partial class Invoice
    {
        [JsonPropertyName("Object")]
        public InvoiceObject Object { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }
    }

    public partial class InvoiceObject
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("Number")]
        public string Number { get; set; }

        [JsonPropertyName("BatchNumber")]
        public string BatchNumber { get; set; }

        [JsonPropertyName("InvoiceTax")]
        public double InvoiceTax { get; set; }

        [JsonPropertyName("PostedTaxRate")]
        public object PostedTaxRate { get; set; }

        [JsonPropertyName("VendorPayeeId")]
        public long VendorPayeeId { get; set; }

        [JsonPropertyName("InvoiceTotal")]
        public double InvoiceTotal { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CurrencyAlphabeticalCode")]
        public string CurrencyAlphabeticalCode { get; set; }

        [JsonPropertyName("ApprovedDateDTO")]
        public DateTimeOffset? ApprovedDateDto { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ApprovalCode")]
        public ApprovalCode? ApprovalCode { get; set; }

        [JsonPropertyName("PostedDateDTO")]
        public DateTimeOffset PostedDateDto { get; set; }

        [JsonPropertyName("Subtotal")]
        public long Subtotal { get; set; }

        [JsonPropertyName("Status")]
        public string Status { get; set; }

        [JsonPropertyName("Trade")]
        public Name Trade { get; set; }

        [JsonPropertyName("StarredBy")]
        public string StarredBy { get; set; }

        [JsonPropertyName("IsStarred")]
        public bool IsStarred { get; set; }

        [JsonPropertyName("StarredDate")]
        public DateTimeOffset StarredDate { get; set; }

        [JsonPropertyName("Description")]
        public Description Description { get; set; }

        [JsonPropertyName("InvoiceDateDTO")]
        public DateTimeOffset InvoiceDateDto { get; set; }

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
        public DateTimeOffset? StatusChangeDate { get; set; }

        [JsonPropertyName("StatusChangeUser")]
        public StatusChangeUser StatusChangeUser { get; set; }

        [JsonPropertyName("StatusChangeUserid")]
        public string StatusChangeUserid { get; set; }

        [JsonPropertyName("WoTrackingNumber")]
        public long WoTrackingNumber { get; set; }

        [JsonPropertyName("Terms")]
        public object Terms { get; set; }

        [JsonPropertyName("Comments")]
        public string Comments { get; set; }

        [JsonPropertyName("PaidDateDTO")]
        public object PaidDateDto { get; set; }

        [JsonPropertyName("TransferredDate")]
        public object TransferredDate { get; set; }

        [JsonPropertyName("LastActionDateDTO")]
        public string LastActionDateDto { get; set; }

        [JsonPropertyName("UpdatedDateDTO")]
        public DateTimeOffset UpdatedDateDto { get; set; }

        [JsonPropertyName("ProviderId")]
        public long ProviderId { get; set; }

        [JsonPropertyName("SubscriberId")]
        public long SubscriberId { get; set; }

        [JsonPropertyName("LocationId")]
        public long LocationId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ProviderName")]
        public string ProviderName { get; set; }

        [JsonPropertyName("Labors")]
        public List<Labor> Labors { get; set; }

        [JsonPropertyName("Materials")]
        public List<Material> Materials { get; set; }

        [JsonPropertyName("Category")]
        public PurpleCategory Category { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ChangedBy")]
        public UpdatedBy ChangedBy { get; set; }
    }

    public partial class Labor
    {
        [JsonPropertyName("SkillLevel")]
        public long SkillLevel { get; set; }

        [JsonPropertyName("LaborType")]
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
        public string Description { get; set; }

        [JsonPropertyName("PartNum")]
        public string PartNum { get; set; }

        [JsonPropertyName("UnitType")]
        public long UnitType { get; set; }

        [JsonPropertyName("UnitPrice")]
        public long UnitPrice { get; set; }

        [JsonPropertyName("Quantity")]
        public long Quantity { get; set; }

        [JsonPropertyName("Amount")]
        public long Amount { get; set; }
    }

    public partial class CheckInAndOut
    {
        [JsonPropertyName("Object")]
        public CheckInAndOutObject Object { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }
    }

    public partial class CheckInAndOutObject
    {
        [JsonPropertyName("CheckInNotes")]
        public CheckInNotes CheckInNotes { get; set; }

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
        public DateTimeOffset Date { get; set; }

        [JsonPropertyName("DateDTO")]
        public DateTimeOffset DateDto { get; set; }

        [JsonPropertyName("User")]
        public UpdatedBy User { get; set; }

        [JsonPropertyName("CallerId")]
        public string CallerId { get; set; }

        [JsonPropertyName("Action")]
        public string Action { get; set; }

        [JsonPropertyName("WorkType")]
        public string WorkType { get; set; }

        [JsonPropertyName("WorkorderStatus")]
        public Status WorkorderStatus { get; set; }

        [JsonPropertyName("ProviderName")]
        public string ProviderName { get; set; }

        [JsonPropertyName("Trade")]
        public string Trade { get; set; }

        [JsonPropertyName("Category")]
        public PurpleCategory Category { get; set; }

        [JsonPropertyName("Source")]
        public string Source { get; set; }

        [JsonPropertyName("TradeId")]
        public long TradeId { get; set; }

        [JsonPropertyName("TechsCount")]
        public long TechsCount { get; set; }
    }

    public partial class CheckInNotes
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AllTechniciansCheckedOut")]
        public string AllTechniciansCheckedOut { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OutsideOperationalHours")]
        public string OutsideOperationalHours { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("OutsideAcceptableTimeframe")]
        public string OutsideAcceptableTimeframe { get; set; }
    }

    public partial class Status
    {
        [JsonPropertyName("Primary")]
        public string Primary { get; set; }

        [JsonPropertyName("Extended")]
        public string Extended { get; set; }
    }

    public partial class WorkOrder
    {
        [JsonPropertyName("Object")]
        public WorkOrderObject Object { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Type")]
        public TypeEnum? Type { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Action")]
        public Action? Action { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Version")]
        public long? Version { get; set; }
    }

    public partial class WorkOrderObject
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("LinkedWorOrderIds")]
        public List<object> LinkedWorOrderIds { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Id")]
        public long? Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Number")]
        public string Number { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("PurchaseNumber")]
        public string PurchaseNumber { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("SubscriberId")]
        public long? SubscriberId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ProviderId")]
        public long? ProviderId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ProviderName")]
        public string ProviderName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("LocationId")]
        public long? LocationId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("LocationName")]
        public string LocationName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("LocationStoreId")]
        public string LocationStoreId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Status")]
        public Status Status { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Caller")]
        public Caller? Caller { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CreatedBy")]
        public Caller? CreatedBy { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("UpdatedBy")]
        public UpdatedBy UpdatedBy { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CallDate")]
        public DateTimeOffset? CallDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Priority")]
        public string Priority { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Trade")]
        public string Trade { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ScheduledDate")]
        public DateTimeOffset? ScheduledDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AreaId")]
        public long? AreaId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AssetType")]
        public string AssetType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ProblemType")]
        public string ProblemType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ScheduledDate_DTO")]
        public DateTimeOffset? ScheduledDateDto { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ExpirationDate")]
        public DateTimeOffset? ExpirationDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category")]
        public FluffyCategory? Category { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Nte")]
        public long? Nte { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CurrencyAlphabeticalCode")]
        public string CurrencyAlphabeticalCode { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ProblemCode")]
        public string ProblemCode { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AssetId")]
        public long? AssetId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Source")]
        public string Source { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Attachments")]
        public List<Attachment> Attachments { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("UpdatedDate")]
        public DateTimeOffset? UpdatedDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("CompletedDate")]
        public DateTimeOffset? CompletedDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Notes")]
        public List<Note> Notes { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("UpdatedDate_DTO")]
        public DateTimeOffset? UpdatedDateDto { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Technician")]
        public Technician Technician { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("WorkOrderId")]
        public long? WorkOrderId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("LinkedWorkOrdersIds")]
        public List<long> LinkedWorkOrdersIds { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("UnlinkLinkedWorkOrders")]
        public bool? UnlinkLinkedWorkOrders { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("User")]
        public UpdatedBy User { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Labels")]
        public List<Label> Labels { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ResolutionCodes")]
        public List<ResolutionCode> ResolutionCodes { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("RootCauses")]
        public List<ResolutionCode> RootCauses { get; set; }
    }

    public partial class Label
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("Text")]
        public string Text { get; set; }
    }

    public partial class Note
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("Number")]
        public long Number { get; set; }

        [JsonPropertyName("NoteData")]
        public string NoteData { get; set; }

        [JsonPropertyName("DateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonPropertyName("ScheduledDate")]
        public DateTimeOffset ScheduledDate { get; set; }

        [JsonPropertyName("ActionRequired")]
        public bool ActionRequired { get; set; }

        [JsonPropertyName("CreatedBy")]
        public Caller CreatedBy { get; set; }

        [JsonPropertyName("CreatedByUser")]
        public CreatedByUser CreatedByUser { get; set; }
    }

    public partial class CreatedByUser
    {
        [JsonPropertyName("UserName")]
        public UserName UserName { get; set; }

        [JsonPropertyName("ProviderId")]
        public long ProviderId { get; set; }
    }

    public partial class ResolutionCode
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }
    }

    public partial class Technician
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }

        [JsonPropertyName("AuthUserId")]
        public long AuthUserId { get; set; }
    }

    public enum Action { Delete, New, Update };

    public enum TypeEnum { GenericRootNotification, WoRootNotification };

    public enum Email { CajunsoulrestaurantGmailCom, Empty, GBTechnicianGmailCom, IfixxservicesGmailCom };

    public enum Caller { Empty, GeorgeJosephByron, ScDev1, SharonMoore, TestApi, XavierBrown };

    public enum UserName { GBTechnicianGmailCom, IfixxservicesGmailCom, ScDev1, ScSmoore, TestApi1 };

    public enum Name { Doors, Electrical, Glass, Hvac };

    public enum PurpleCategory { Capex, Maintenance, Repair };

    public enum Description { CutGrassClearedWeedsInFlowerBedAndTrimmedShrubs, Empty, Test };

    public enum StatusChangeUser { ScDev1, TestUsername };

    public enum FluffyCategory { PartsOrder, Repair };

    public partial struct UpdatedByUnion
    {
        public long? Integer;
        public UpdatedBy UpdatedBy;

        public static implicit operator UpdatedByUnion(long Integer) => new UpdatedByUnion { Integer = Integer };
        public static implicit operator UpdatedByUnion(UpdatedBy UpdatedBy) => new UpdatedByUnion { UpdatedBy = UpdatedBy };
    }

    public partial struct ApprovalCode
    {
        public long? Integer;
        public string String;

        public static implicit operator ApprovalCode(long Integer) => new ApprovalCode { Integer = Integer };
        public static implicit operator ApprovalCode(string String) => new ApprovalCode { String = String };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                ActionConverter.Singleton,
                TypeEnumConverter.Singleton,
                UpdatedByUnionConverter.Singleton,
                EmailConverter.Singleton,
                CallerConverter.Singleton,
                UserNameConverter.Singleton,
                NameConverter.Singleton,
                PurpleCategoryConverter.Singleton,
                ApprovalCodeConverter.Singleton,
                DescriptionConverter.Singleton,
                StatusChangeUserConverter.Singleton,
                FluffyCategoryConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }

    internal class ActionConverter : JsonConverter<Action>
    {
        public override bool CanConvert(Type t) => t == typeof(Action);

        public override Action Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "DELETE":
                    return Action.Delete;
                case "NEW":
                    return Action.New;
                case "UPDATE":
                    return Action.Update;
            }
            throw new Exception("Cannot unmarshal type Action");
        }

        public override void Write(Utf8JsonWriter writer, Action value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Action.Delete:
                    JsonSerializer.Serialize(writer, "DELETE", options);
                    return;
                case Action.New:
                    JsonSerializer.Serialize(writer, "NEW", options);
                    return;
                case Action.Update:
                    JsonSerializer.Serialize(writer, "UPDATE", options);
                    return;
            }
            throw new Exception("Cannot marshal type Action");
        }

        public static readonly ActionConverter Singleton = new ActionConverter();
    }

    internal class TypeEnumConverter : JsonConverter<TypeEnum>
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum);

        public override TypeEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "GenericRootNotification":
                    return TypeEnum.GenericRootNotification;
                case "WoRootNotification":
                    return TypeEnum.WoRootNotification;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void Write(Utf8JsonWriter writer, TypeEnum value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case TypeEnum.GenericRootNotification:
                    JsonSerializer.Serialize(writer, "GenericRootNotification", options);
                    return;
                case TypeEnum.WoRootNotification:
                    JsonSerializer.Serialize(writer, "WoRootNotification", options);
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class UpdatedByUnionConverter : JsonConverter<UpdatedByUnion>
    {
        public override bool CanConvert(Type t) => t == typeof(UpdatedByUnion);

        public override UpdatedByUnion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.Number:
                    var integerValue = reader.GetInt64();
                    return new UpdatedByUnion { Integer = integerValue };
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<UpdatedBy>(ref reader, options);
                    return new UpdatedByUnion { UpdatedBy = objectValue };
            }
            throw new Exception("Cannot unmarshal type UpdatedByUnion");
        }

        public override void Write(Utf8JsonWriter writer, UpdatedByUnion value, JsonSerializerOptions options)
        {
            if (value.Integer != null)
            {
                JsonSerializer.Serialize(writer, value.Integer.Value, options);
                return;
            }
            if (value.UpdatedBy != null)
            {
                JsonSerializer.Serialize(writer, value.UpdatedBy, options);
                return;
            }
            throw new Exception("Cannot marshal type UpdatedByUnion");
        }

        public static readonly UpdatedByUnionConverter Singleton = new UpdatedByUnionConverter();
    }

    internal class EmailConverter : JsonConverter<Email>
    {
        public override bool CanConvert(Type t) => t == typeof(Email);

        public override Email Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "":
                    return Email.Empty;
                case "cajunsoulrestaurant@gmail.com":
                    return Email.CajunsoulrestaurantGmailCom;
                case "g.b.technician@gmail.com":
                    return Email.GBTechnicianGmailCom;
                case "ifixxservices@gmail.com":
                    return Email.IfixxservicesGmailCom;
            }
            throw new Exception("Cannot unmarshal type Email");
        }

        public override void Write(Utf8JsonWriter writer, Email value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Email.Empty:
                    JsonSerializer.Serialize(writer, "", options);
                    return;
                case Email.CajunsoulrestaurantGmailCom:
                    JsonSerializer.Serialize(writer, "cajunsoulrestaurant@gmail.com", options);
                    return;
                case Email.GBTechnicianGmailCom:
                    JsonSerializer.Serialize(writer, "g.b.technician@gmail.com", options);
                    return;
                case Email.IfixxservicesGmailCom:
                    JsonSerializer.Serialize(writer, "ifixxservices@gmail.com", options);
                    return;
            }
            throw new Exception("Cannot marshal type Email");
        }

        public static readonly EmailConverter Singleton = new EmailConverter();
    }

    internal class CallerConverter : JsonConverter<Caller>
    {
        public override bool CanConvert(Type t) => t == typeof(Caller);

        public override Caller Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "":
                    return Caller.Empty;
                case "George Joseph Byron":
                    return Caller.GeorgeJosephByron;
                case "SC-Dev1":
                    return Caller.ScDev1;
                case "Sharon Moore":
                    return Caller.SharonMoore;
                case "TestApi":
                    return Caller.TestApi;
                case "Xavier Brown":
                    return Caller.XavierBrown;
            }
            throw new Exception("Cannot unmarshal type Caller");
        }

        public override void Write(Utf8JsonWriter writer, Caller value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Caller.Empty:
                    JsonSerializer.Serialize(writer, "", options);
                    return;
                case Caller.GeorgeJosephByron:
                    JsonSerializer.Serialize(writer, "George Joseph Byron", options);
                    return;
                case Caller.ScDev1:
                    JsonSerializer.Serialize(writer, "SC-Dev1", options);
                    return;
                case Caller.SharonMoore:
                    JsonSerializer.Serialize(writer, "Sharon Moore", options);
                    return;
                case Caller.TestApi:
                    JsonSerializer.Serialize(writer, "TestApi", options);
                    return;
                case Caller.XavierBrown:
                    JsonSerializer.Serialize(writer, "Xavier Brown", options);
                    return;
            }
            throw new Exception("Cannot marshal type Caller");
        }

        public static readonly CallerConverter Singleton = new CallerConverter();
    }

    internal class UserNameConverter : JsonConverter<UserName>
    {
        public override bool CanConvert(Type t) => t == typeof(UserName);

        public override UserName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "SC-Dev1":
                    return UserName.ScDev1;
                case "TestApi1":
                    return UserName.TestApi1;
                case "g.b.technician@gmail.com":
                    return UserName.GBTechnicianGmailCom;
                case "ifixxservices@gmail.com":
                    return UserName.IfixxservicesGmailCom;
                case "sc-smoore":
                    return UserName.ScSmoore;
            }
            throw new Exception("Cannot unmarshal type UserName");
        }

        public override void Write(Utf8JsonWriter writer, UserName value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case UserName.ScDev1:
                    JsonSerializer.Serialize(writer, "SC-Dev1", options);
                    return;
                case UserName.TestApi1:
                    JsonSerializer.Serialize(writer, "TestApi1", options);
                    return;
                case UserName.GBTechnicianGmailCom:
                    JsonSerializer.Serialize(writer, "g.b.technician@gmail.com", options);
                    return;
                case UserName.IfixxservicesGmailCom:
                    JsonSerializer.Serialize(writer, "ifixxservices@gmail.com", options);
                    return;
                case UserName.ScSmoore:
                    JsonSerializer.Serialize(writer, "sc-smoore", options);
                    return;
            }
            throw new Exception("Cannot marshal type UserName");
        }

        public static readonly UserNameConverter Singleton = new UserNameConverter();
    }

    internal class NameConverter : JsonConverter<Name>
    {
        public override bool CanConvert(Type t) => t == typeof(Name);

        public override Name Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "DOORS":
                    return Name.Doors;
                case "ELECTRICAL":
                    return Name.Electrical;
                case "GLASS":
                    return Name.Glass;
                case "HVAC":
                    return Name.Hvac;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void Write(Utf8JsonWriter writer, Name value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Name.Doors:
                    JsonSerializer.Serialize(writer, "DOORS", options);
                    return;
                case Name.Electrical:
                    JsonSerializer.Serialize(writer, "ELECTRICAL", options);
                    return;
                case Name.Glass:
                    JsonSerializer.Serialize(writer, "GLASS", options);
                    return;
                case Name.Hvac:
                    JsonSerializer.Serialize(writer, "HVAC", options);
                    return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }

    internal class PurpleCategoryConverter : JsonConverter<PurpleCategory>
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleCategory);

        public override PurpleCategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "CAPEX":
                    return PurpleCategory.Capex;
                case "MAINTENANCE":
                    return PurpleCategory.Maintenance;
                case "REPAIR":
                    return PurpleCategory.Repair;
            }
            throw new Exception("Cannot unmarshal type PurpleCategory");
        }

        public override void Write(Utf8JsonWriter writer, PurpleCategory value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case PurpleCategory.Capex:
                    JsonSerializer.Serialize(writer, "CAPEX", options);
                    return;
                case PurpleCategory.Maintenance:
                    JsonSerializer.Serialize(writer, "MAINTENANCE", options);
                    return;
                case PurpleCategory.Repair:
                    JsonSerializer.Serialize(writer, "REPAIR", options);
                    return;
            }
            throw new Exception("Cannot marshal type PurpleCategory");
        }

        public static readonly PurpleCategoryConverter Singleton = new PurpleCategoryConverter();
    }

    internal class ApprovalCodeConverter : JsonConverter<ApprovalCode>
    {
        public override bool CanConvert(Type t) => t == typeof(ApprovalCode);

        public override ApprovalCode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.Number:
                    var integerValue = reader.GetInt64();
                    return new ApprovalCode { Integer = integerValue };
                case JsonTokenType.String:
                    var stringValue = reader.GetString();
                    return new ApprovalCode { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type ApprovalCode");
        }

        public override void Write(Utf8JsonWriter writer, ApprovalCode value, JsonSerializerOptions options)
        {
            if (value.Integer != null)
            {
                JsonSerializer.Serialize(writer, value.Integer.Value, options);
                return;
            }
            if (value.String != null)
            {
                JsonSerializer.Serialize(writer, value.String, options);
                return;
            }
            throw new Exception("Cannot marshal type ApprovalCode");
        }

        public static readonly ApprovalCodeConverter Singleton = new ApprovalCodeConverter();
    }

    internal class DescriptionConverter : JsonConverter<Description>
    {
        public override bool CanConvert(Type t) => t == typeof(Description);

        public override Description Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "":
                    return Description.Empty;
                case "Cut grass, cleared weeds in flower bed and trimmed shrubs":
                    return Description.CutGrassClearedWeedsInFlowerBedAndTrimmedShrubs;
                case "test":
                    return Description.Test;
            }
            throw new Exception("Cannot unmarshal type Description");
        }

        public override void Write(Utf8JsonWriter writer, Description value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Description.Empty:
                    JsonSerializer.Serialize(writer, "", options);
                    return;
                case Description.CutGrassClearedWeedsInFlowerBedAndTrimmedShrubs:
                    JsonSerializer.Serialize(writer, "Cut grass, cleared weeds in flower bed and trimmed shrubs", options);
                    return;
                case Description.Test:
                    JsonSerializer.Serialize(writer, "test", options);
                    return;
            }
            throw new Exception("Cannot marshal type Description");
        }

        public static readonly DescriptionConverter Singleton = new DescriptionConverter();
    }

    internal class StatusChangeUserConverter : JsonConverter<StatusChangeUser>
    {
        public override bool CanConvert(Type t) => t == typeof(StatusChangeUser);

        public override StatusChangeUser Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "SC-Dev1":
                    return StatusChangeUser.ScDev1;
                case "test-username":
                    return StatusChangeUser.TestUsername;
            }
            throw new Exception("Cannot unmarshal type StatusChangeUser");
        }

        public override void Write(Utf8JsonWriter writer, StatusChangeUser value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case StatusChangeUser.ScDev1:
                    JsonSerializer.Serialize(writer, "SC-Dev1", options);
                    return;
                case StatusChangeUser.TestUsername:
                    JsonSerializer.Serialize(writer, "test-username", options);
                    return;
            }
            throw new Exception("Cannot marshal type StatusChangeUser");
        }

        public static readonly StatusChangeUserConverter Singleton = new StatusChangeUserConverter();
    }

    internal class FluffyCategoryConverter : JsonConverter<FluffyCategory>
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyCategory);

        public override FluffyCategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "PARTS ORDER":
                    return FluffyCategory.PartsOrder;
                case "REPAIR":
                    return FluffyCategory.Repair;
            }
            throw new Exception("Cannot unmarshal type FluffyCategory");
        }

        public override void Write(Utf8JsonWriter writer, FluffyCategory value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case FluffyCategory.PartsOrder:
                    JsonSerializer.Serialize(writer, "PARTS ORDER", options);
                    return;
                case FluffyCategory.Repair:
                    JsonSerializer.Serialize(writer, "REPAIR", options);
                    return;
            }
            throw new Exception("Cannot marshal type FluffyCategory");
        }

        public static readonly FluffyCategoryConverter Singleton = new FluffyCategoryConverter();
    }
    
    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        private readonly string serializationFormat;
        public DateOnlyConverter() : this(null) { }

        public DateOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
        }

        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return DateOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    public class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        private readonly string serializationFormat;

        public TimeOnlyConverter() : this(null) { }

        public TimeOnlyConverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "HH:mm:ss.fff";
        }

        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return TimeOnly.Parse(value!);
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString(serializationFormat));
    }

    internal class IsoDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
        private string? _dateTimeFormat;
        private CultureInfo? _culture;

        public DateTimeStyles DateTimeStyles
        {
            get => _dateTimeStyles;
            set => _dateTimeStyles = value;
        }

        public string? DateTimeFormat
        {
            get => _dateTimeFormat ?? string.Empty;
            set => _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value;
        }

        public CultureInfo Culture
        {
            get => _culture ?? CultureInfo.CurrentCulture;
            set => _culture = value;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            string text;


            if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
            {
                value = value.ToUniversalTime();
            }

            text = value.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);

            writer.WriteStringValue(text);
        }

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? dateText = reader.GetString();

            if (string.IsNullOrEmpty(dateText) == false)
            {
                if (!string.IsNullOrEmpty(_dateTimeFormat))
                {
                    return DateTimeOffset.ParseExact(dateText, _dateTimeFormat, Culture, _dateTimeStyles);
                }
                else
                {
                    return DateTimeOffset.Parse(dateText, Culture, _dateTimeStyles);
                }
            }
            else
            {
                return default(DateTimeOffset);
            }
        }


        public static readonly IsoDateTimeOffsetConverter Singleton = new IsoDateTimeOffsetConverter();
    }
}
*/