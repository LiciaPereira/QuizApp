using System;

namespace QuizApp.Core.Entities

public class Option : BaseEntity
{

  public required Question Question { get; set; }

  public required int QuestionId { get; set; }

  public required string Text { get; set; }

  public string? FeedbackText { get; set; }

}
