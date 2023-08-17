using System.Text.Json.Serialization;

namespace FieldAdv.ServiceChannel.Webhooks.Models;

public partial class CheckList : WebhookRoot<CheckListObject>
{
  [JsonPropertyName("Object")]
  public override CheckListObject Object { get; set; } = null!;

  public override void Process()
  {
    throw new NotImplementedException();
  }
}

public partial class CheckListObject
{
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Id")]
  public long? Id { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Name")]
  public string? Name { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("IsActive")]
  public bool? IsActive { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CreatedDate")]
  public DateTime? CreatedDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("UpdatedDate")]
  public DateTime? UpdatedDate { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CreatedBy")]
  public long? CreatedBy { get; set; }

  [JsonPropertyName("UpdatedBy")]
  public long UpdatedBy { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Locations")]
  public List<long> Locations { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Trades")]
  public List<long> Trades { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Categories")]
  public List<long> Categories { get; set; } = new();

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("Questions")]
  public List<Question> Questions { get; set; } = new();

  [JsonPropertyName("SubscriberId")]
  public long SubscriberId { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CheckListResponse")]
  public CheckListResponse? CheckListResponse { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("CheckListResponsePicture")]
  public CheckListResponsePicture? CheckListResponsePicture { get; set; }
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

  // Answer to a checklist question. Checklist question type defines the response type:
  // Acknowledgement. A choice answer. Possible values: on, off, 1, 0, true, false, yes, no.
  // Text Entry. A text answer. The maximum length is 500 characters.
  // Numeric Input. A numeric answer.
  [JsonPropertyName("Answer")]
  public long Answer { get; set; }

  [JsonPropertyName("EntityId")]
  public long EntityId { get; set; }

  [JsonPropertyName("EntityTypeId")]
  public long EntityTypeId { get; set; }

  [JsonPropertyName("Attempt")]
  public long Attempt { get; set; }

  [JsonPropertyName("UpdatedDate")]
  public DateTime UpdatedDate { get; set; }

  [JsonPropertyName("UpdatedDateDto")]
  public DateTime UpdatedDateDto { get; set; }
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

  // Checklist question that a technician is prompted to answer when working on a service request.
  [JsonPropertyName("Question")]
  public string? QuestionText { get; set; }

  [JsonPropertyName("AnswerRequired")]
  public bool AnswerRequired { get; set; }

  [JsonPropertyName("PictureFlag")]
  public long PictureFlag { get; set; }

  [JsonPropertyName("Sequence")]
  public long Sequence { get; set; }

  [JsonPropertyName("QuestionType")]
  public long QuestionType { get; set; }

  [JsonPropertyName("CheckListQuestionOptions")]
  public List<CheckListQuestionOption> CheckListQuestionOptions { get; set; } = new();

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
  public string? Answer { get; set; }

  [JsonPropertyName("IsConditionalFollowUp")]
  public bool IsConditionalFollowUp { get; set; }
}