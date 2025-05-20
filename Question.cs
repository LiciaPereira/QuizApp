using System;
using System.Collections.Generic;

namespace QuizApp.Core.Entities {

  public enum Difficulty { Easy, Medium, Hard }

  public class Question : BaseEntity {

    public required Quiz Quiz { get; set; }

    public required int QuizId { get; set; }

    [Required(ErrorMessage = "A question is required")]
    [StringLength(100, MinimumLength = 10, ErrorMessage = "Question should be between {2} and {1} characters")]
    public required string QuestionText { get; set; }

    public required ICollection<Option> Options { get; set; } = new List<Option>();

    public required int CorrectAnswerId { get; set; }

    public required Difficulty Difficulty { get; set; }

  }
}