using System;
using System.ComponentModel.DataAnnotations;

namespace QuizApp.Core.Entities {

  public class Option : BaseEntity {

    public required Question Question { get; set; }

    public required int QuestionId { get; set; }

    [Required(ErrorMessage = "A text is required for each option")]
    public required string Text { get; set; }

    public string? FeedbackText { get; set; }

  }
}